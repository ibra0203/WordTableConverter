using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
namespace WordTableConverter
{
    class DocumentManager
    {
        public static Document SourceDocument, TargetDocument, DestinationDocument;

        static public int srcCols, destCols;
        static List<List<String>> sourceData;
        static List<Object[]> styles;
        public static Font cellFont;
        public static List<int> FillingInstructions;
        public static ParagraphFormat paragraphFormat;
        static ParagraphFormat tableParagraphFormat;
        static dynamic tableStyle;
        static object tableHeight;
        static int _dataDone = 0;
        static int DataDone
        {
            set
            {
                alertProgressChange();
                _dataDone = value;
            }
            get
            {
                return _dataDone;
            }
        }
        
        public static int ProgressAmount
        {
            get
            {
                if (DataDone > 0 && sourceData.Count > 0)
                {
                    return (int) (((float)DataDone / (float)sourceData.Count)*100);
                }
                else
                    return 0;
            }
        }

        public delegate void DataChanged();
        public static event DataChanged EProgressChanged;
        protected static void alertProgressChange()
        {
            EProgressChanged();
        }

        public static void Init()
        {
            SourceDocument = new Document();
            TargetDocument = new Document();
            DestinationDocument = new Document();
            sourceData = new List<List<string>>();
            FillingInstructions = new List<int>();
            

        }

        public static void SetColumnsNumber(int _src, int _dest)
        {
            srcCols = _src;
            destCols = _dest;
        }
        static void CopyTemplate()
        {
            object start = 0, end = 0;
            end = TargetDocument.Tables[1].Range.End;
            start = TargetDocument.Content.Start;
            Range range = TargetDocument.Tables[1].Range;
            range.Copy();

            if (tableParagraphFormat == null)
                tableParagraphFormat = range.ParagraphFormat;

            if (tableStyle == null)
                tableStyle = TargetDocument.Tables[1].get_Style();
        }
        [STAThread]
        static void AddEmptyTable(Range tableRange)
        {
            
            object missing = System.Reflection.Missing.Value;
            object start = 0;
            object end = tableRange.Start;
            Range rn = TargetDocument.Range(ref start, ref end);
            if (rn.Text != null)
            {

                rn.Copy();
                rn.SetRange(TargetDocument.Content.End + 1, TargetDocument.Content.End + 1);
                rn.Select();

                rn.Paste();
                rn = tableRange;
                rn.Copy();
                rn.SetRange(TargetDocument.Content.End + 1, TargetDocument.Content.End + 1);
                Table newTable = TargetDocument.Tables.Add(rn, 1, 1, ref missing, ref missing);
                newTable.Range.Paste();
                Clipboard.Clear();
            }
            

        }
        [STAThread]
        static void FillDocument()
        {
            Table Tbl = TargetDocument.Tables[1];
            Table srcTbl = SourceDocument.Tables[1];
            object start = Tbl.Range.End;
            object end = TargetDocument.Content.End;
            tableHeight = Tbl.Range.End - Tbl.Range.Start;
            Range rn = TargetDocument.Range(ref start, ref end);
            rn.Cut();
            Clipboard.Clear();
            start = 0;
            end = Tbl.Range.Start/2;
            rn = TargetDocument.Range(ref start, ref end);
            Paragraphs par = rn.Paragraphs;
            foreach(Paragraph p in par)
            {
                if(p.Range.Text.Trim() == string.Empty)
                {
                    p.Range.Select();
                    WordManager.app.Selection.Delete();
                }
            }
            int rowsPerTable = Tbl.Rows.Count-1;
            int srcDataRows = sourceData.Count;
            for (int rows=0; rows<srcDataRows; rows+=rowsPerTable)
            {
                AddEmptyTable(Tbl.Range);
                
            }
            if (Tbl.Rows.Count-1 >= srcDataRows+2)
            {
                Range dltRange = TargetDocument.Range(Tbl.Rows[srcDataRows+2].Range.Start, TargetDocument.Content.End);
                dltRange.Select();
                WordManager.app.Selection.Delete();
                Clipboard.Clear();
            }


        }

        static void FillTables()
        {
            int d = 0;
            int dCount = 0;
            while(d<sourceData.Count)
            {
                foreach(Table table in TargetDocument.Tables)
                {
                    Rows rows = table.Rows;
                    for (int r = 1; r < rows.Count; r++)
                    {
                        try
                        {
                            Row row = rows[r+1];
                            bool inputOccured = false;
                            if (row.Cells.Count == destCols)
                            {
                                if (d >= sourceData.Count)
                                    break;
                                List<String> _data = sourceData[d];
                                for (int c=0; c< destCols; c++)
                                {
                                    int txtIndex = FillingInstructions[c]-1;
                                    if (txtIndex != -1)
                                    {
                                        row.Cells[c + 1].Range.Text = _data[txtIndex];
                                        row.Cells[c + 1].Range.ParagraphFormat = paragraphFormat;
                                        row.Cells[c + 1].Range.Font = cellFont;

                                        inputOccured = true;
                                        
                                    }
                                  
                                }
                                if (!inputOccured) r--;
                                d++;
                                dCount++;
                                if(dCount>=3)
                                {
                                    DataDone = d;
                                    dCount = 0;
                                }
                            }
                        }
                        catch
                        {

                        }
                    }
                    
                    if (d >= sourceData.Count)
                        break;
                }
            }
        }
        static void FixTablesAlignment()
        {
            WdStatistic stat = WdStatistic.wdStatisticPages;
            object missing = System.Reflection.Missing.Value;
            int numOfPages = TargetDocument.ComputeStatistics(stat, ref missing);
            int pageLength = (TargetDocument.Content.End - TargetDocument.Content.Start) / numOfPages;
            Tables tables = TargetDocument.Tables;
            for(int i=0; i<tables.Count; i++)
            {
                Table t = tables[i+1];
                if(t.Columns.Count == destCols)
                {
                    Range rStart = TargetDocument.Range(t.Range.Start-1, t.Range.Start);
                    Range rEnd = TargetDocument.Range(t.Range.End-1, t.Range.End);

                    rStart.Select();
                    int startPage = WordManager.app.Selection.Information[WdInformation.wdActiveEndPageNumber];
                    rEnd.Select();
                    int endPage = WordManager.app.Selection.Information[WdInformation.wdActiveEndPageNumber];
                    
                    if(startPage != endPage)
                    {
                        rStart.Select();
                        int startLine = WordManager.app.Selection.Information[WdInformation.wdFirstCharacterLineNumber];
                        if (startLine > 20)
                        {
                            if (i != 0)
                            {
                                Table pT = tables[i];
                                Range r = TargetDocument.Range(pT.Range.End, pT.Range.End );
                                r.Select();
                            }
                            object pageBreak = WdBreakType.wdPageBreak;
                            WordManager.app.Selection.InsertBreak(ref pageBreak);
                        }
                       
                    }
                    
                }
            }
        }
        delegate void deleg();
        public static void PrepareSaveFile()
        {
            FillDocument();
        }
        public static void SaveFile(ref object fileName)
        {

            try
            {
                FillTables();
               // FixTablesAlignment();
                object missing = System.Reflection.Missing.Value;

                TargetDocument.SaveAs2(ref fileName,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing);

                TargetDocument.Close();
                DataDone = 0;
            }
            catch(Exception exp)
            {

                Console.WriteLine(exp.Message);
                MessageBox.Show(exp.Message);
                WordManager.Close();
                WindowManager.Close();
               
            }
        }

        static Font getMostCommonTableStyle(ref Document doc)
        {
            styles = new List<object[]>();
            Font result = null;
            int tableCount = doc.Tables.Count;

            if (tableCount > 4) tableCount = 4;
            Tables tables = doc.Tables;
            for (int t = 0; t < tableCount; t++)
            {
                if (tables[t + 1].Rows.Count > 0)
                {
                    Rows rows = tables[t + 1].Rows;
                    for (int r = 0; r < rows.Count; r++)
                    {
                        Row row = rows[r + 1];
                        if (row.Cells.Count == srcCols)
                        {
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                try
                                {
                                    Font d = row.Cells[i + 1].Range.Font;
                                    bool found = false;
                                    foreach(object[] obj in styles)
                                    {
                                        if(Helpers.isSameFont((Font)obj[0], d))
                                        {
                                            found = true;
                                            obj[1] = (int)obj[1]+1;
                                            break;
                                        }
                                        
                                    }
                                    if(!found)
                                    styles.Add((new object[] { d, 1 }));



                                }
                                catch
                                {

                                }
                            }
                        }
                    }    
                }
            }

            int maxCount = 0;
            foreach(object[] obj in styles)
            {
                Font s = (Font)obj[0];
                int count = (int)obj[1];

                if(count>maxCount)
                {
                    result = s;
                    maxCount = count;
                }
            }
            
            return result;
        }
                        
       public static void CopyDataFromSource()
        {
            Font cellStyle = getMostCommonTableStyle(ref SourceDocument);
            cellFont = cellStyle;
            int tableCount = SourceDocument.Tables.Count;
            Tables tables = SourceDocument.Tables;
            for(int t=0; t< tableCount; t++)
            {
                if (tables[t+1].Rows.Count > 0)
                {
                    Rows rows = tables[t+1].Rows;
                    for (int r=0; r<rows.Count; r++)
                    {
                        try
                        {
                            Row row = rows[r + 1];
                            if (row.Cells.Count == srcCols)
                            {
                                int styleCount = 0;
                                List<String> newData = new List<string>();
                                for (int i = 0; i < row.Cells.Count; i++)
                                {
                                    String s = row.Cells[i + 1].Range.Text;
                                    if (Helpers.isSameFont(row.Cells[i + 1].Range.Font, cellStyle))
                                    {
                                        if (paragraphFormat == null)
                                            paragraphFormat = row.Cells[i + 1].Range.ParagraphFormat;
                                        styleCount++;
                                    }
                                    newData.Add(s);
                                }
                                if(styleCount>srcCols/2)
                                sourceData.Add(newData);

                            }
                        }
                        catch { 
}
                    }
                }
            }
        }
    }
}
