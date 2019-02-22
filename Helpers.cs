using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace WordTableConverter
{
    class Helpers
    {
        public static bool isInt(string s)
        {
            try
            {
                if (int.Parse(s.ToString()).GetType().Equals(typeof(int)))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool isFloat(string s)
        {
            try
            {
                if (float.Parse(s.ToString()).GetType().Equals(typeof(float)))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool isSameFont(Word.Font f1,  Word.Font f2)
        {
            if (f1.Bold != f2.Bold || f1.Color != f2.Color || f1.Size != f2.Size|| f1.Name != f2.Name)
                return false;

            return true;
        }
    }
}
