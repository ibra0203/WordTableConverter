using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
namespace WordTableConverter
{
    class WordManager
    {
        public static Application app { get; private set; }
        static List<Document> docs;
        public static void Init()
        {
            app = new Application();
            app.Visible = false;
            docs = new List<Document>();
        }
        public static bool Load(object fileName, ref Document document)
        {
           
            try
            {
                object missing = System.Reflection.Missing.Value;
                object vis = false;
                document = app.Documents.Open(ref fileName, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, 
                    ref vis, ref missing, ref missing, ref missing, ref missing);
                docs.Add(document);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static void Close()
        {

            for (int i = 0; i < docs.Count; i++)
            {
                try
                {
                    if (docs[i] != null)
                        docs[i].Close(WdSaveOptions.wdDoNotSaveChanges);
                    docs[i] = null;
                }
                catch
                {

                }
            }
               
            try
            {
                if (app != null)
                    app.Quit();
                app = null;
                GC.Collect();
            }
            catch
            {

            }
        }
    }
}
