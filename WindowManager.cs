using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace WordTableConverter
{
    public enum FORMS { LOADFILE, COLUMNSETTINGS, FONTSETTINGS}
    class WindowManager
    {
        static FormWindow mainForm;
        static Form currentForm;
        public static void SwitchForm(FORMS formType)
        {
            Form _oldForm = currentForm;

            if (formType == FORMS.LOADFILE)
                currentForm = new FormLoadFiles();
            else if (formType == FORMS.COLUMNSETTINGS)
                currentForm = new FormSettings();
            else if (formType == FORMS.FONTSETTINGS)
                currentForm = new FormFont();

           if(mainForm.SwitchToForm(currentForm))
            {
                if(_oldForm !=null)
                _oldForm.Close();
            }
        }

        public static void SetMainForm(FormWindow _mainForm)
        {
            mainForm = _mainForm;
        }
        public static FormWindow GetMainForm()
        {
            return mainForm;
        }

    }
}
