using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool checkPass { get; set; } = false;

        private void emailTxtb_TextChanged(object sender, EventArgs e)
        {
            if (!emailTxtb.Text.Contains('@'))
            {
                infoEmailLbl.Text = "Email is not entered correctly!";
                infoEmailLbl.ForeColor = Color.Red;
            }
            else
            {
                infoEmailLbl.Text = "";
                checkPass = true;
            }
        }
    }
}
