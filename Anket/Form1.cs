using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anket
{
    public partial class Form1 : Form
    {

        public class Human
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string BirthDay { get; set; }
            public string Email { get; set; }
            public string Gender { get; set; }
            public string Phone { get; set; }
            public string City { get; set; }
        }


        public class FileHelper
        {
            public static void WriteJsonHuman(Human human)
            {
                var serializer = new JsonSerializer();
                using (var sw = new StreamWriter($"{human.Name}.json"))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                        serializer.Serialize(jw, human);
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public bool check { get; set; } = false;

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
                check = true;
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (check)
            {
                string gender = "";
                if (ManBtn.Checked)
                {
                    gender = ManBtn.Text;
                }
                else if (womanBtn.Checked)
                {
                    gender = womanBtn.Text;
                }

                this.BackColor = Color.SlateBlue;
                Human human = new Human()
                {
                    Name = NameTxtb.Text,
                    Surname = SurnameTxtb.Text,
                    City = cityTxtb.Text,
                    Email = emailTxtb.Text,
                    BirthDay = birthDayTxtb.Text,
                    Phone = phoneTxtb.Text,
                    Gender = gender
                };

                MessageBox.Show("Succesfuly", "Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FileHelper.WriteJsonHuman(human);
                Application.Exit();
            }
            else
            {
                this.BackColor = Color.DarkRed;
            }

        }

        private void NameTxtb_TextChanged(object sender, EventArgs e)
        {
            if (NameTxtb.Text.Length <= 0)
            {
                infoNameLbl.Text = "This must be filled!";
                infoNameLbl.ForeColor = Color.Red;
            }
            else
            {
                infoNameLbl.Text = "";
                check = true;
            }
        }


        private void surnameInfoLbl_TextChanged(object sender, EventArgs e)
        {
            if (SurnameTxtb.Text.Length <= 0)
            {
                surnameInfoLbl.Text= "This must be filled!";
                surnameInfoLbl.ForeColor = Color.Red;
            }
            else
            {
                surnameInfoLbl.Text = "";
                check = true;
            }
        }
    }
}
