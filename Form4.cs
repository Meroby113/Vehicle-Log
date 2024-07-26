using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject
{
    public partial class MessageBoxForm : Form
    {
        public MessageBoxForm(String message)
        {
            InitializeComponent();
            MessageL.Text = message;
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkeyB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
