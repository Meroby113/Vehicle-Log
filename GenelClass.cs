using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject
{
    internal class GenelClass
    {
        public void ClearInputs(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is TextBoxBase || c is ComboBox)
                {
                    c.Text = String.Empty;
                }
                else
                {
                    ClearInputs(c.Controls);
                }
            }
        }

        public void justNumericAllowded(object sender, KeyPressEventArgs e)
        {
            
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                ;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
               
            }
            
        }
        public String checkCombobox(String text)
        {
            if (text == null)
                return "null";
            return text;
        }
       
    }
}
