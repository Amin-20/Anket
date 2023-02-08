namespace Anket
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SurnameTxtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTxtb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.infoEmailLbl = new System.Windows.Forms.Label();
            this.birthDayTxtb = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneTxtb = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cityTxtb = new System.Windows.Forms.TextBox();
            this.CityLbl = new System.Windows.Forms.Label();
            this.SendBtn = new System.Windows.Forms.Button();
            this.FormNameLbl = new System.Windows.Forms.Label();
            this.infoNameLbl = new System.Windows.Forms.Label();
            this.surnameInfoLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ManBtn = new System.Windows.Forms.RadioButton();
            this.womanBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 80);
            this.label1.TabIndex = 0;
            // 
            // NameTxtb
            // 
            this.NameTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTxtb.Location = new System.Drawing.Point(6, 136);
            this.NameTxtb.Margin = new System.Windows.Forms.Padding(2);
            this.NameTxtb.Multiline = true;
            this.NameTxtb.Name = "NameTxtb";
            this.NameTxtb.Size = new System.Drawing.Size(133, 27);
            this.NameTxtb.TabIndex = 1;
            this.NameTxtb.TextChanged += new System.EventHandler(this.NameTxtb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname";
            // 
            // SurnameTxtb
            // 
            this.SurnameTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTxtb.Location = new System.Drawing.Point(184, 136);
            this.SurnameTxtb.Margin = new System.Windows.Forms.Padding(2);
            this.SurnameTxtb.Multiline = true;
            this.SurnameTxtb.Name = "SurnameTxtb";
            this.SurnameTxtb.Size = new System.Drawing.Size(116, 27);
            this.SurnameTxtb.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "E-mail";
            // 
            // emailTxtb
            // 
            this.emailTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTxtb.Location = new System.Drawing.Point(359, 136);
            this.emailTxtb.Margin = new System.Windows.Forms.Padding(2);
            this.emailTxtb.Multiline = true;
            this.emailTxtb.Name = "emailTxtb";
            this.emailTxtb.Size = new System.Drawing.Size(116, 27);
            this.emailTxtb.TabIndex = 8;
            this.emailTxtb.TextChanged += new System.EventHandler(this.emailTxtb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gender";
            // 
            // infoEmailLbl
            // 
            this.infoEmailLbl.AutoSize = true;
            this.infoEmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoEmailLbl.Location = new System.Drawing.Point(346, 167);
            this.infoEmailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoEmailLbl.Name = "infoEmailLbl";
            this.infoEmailLbl.Size = new System.Drawing.Size(0, 17);
            this.infoEmailLbl.TabIndex = 13;
            // 
            // birthDayTxtb
            // 
            this.birthDayTxtb.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDayTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDayTxtb.Location = new System.Drawing.Point(6, 217);
            this.birthDayTxtb.Margin = new System.Windows.Forms.Padding(2);
            this.birthDayTxtb.Name = "birthDayTxtb";
            this.birthDayTxtb.Size = new System.Drawing.Size(121, 22);
            this.birthDayTxtb.TabIndex = 14;
            this.birthDayTxtb.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birthday";
            // 
            // phoneTxtb
            // 
            this.phoneTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTxtb.Location = new System.Drawing.Point(12, 312);
            this.phoneTxtb.Mask = "(994) 00-000-0000";
            this.phoneTxtb.Name = "phoneTxtb";
            this.phoneTxtb.Size = new System.Drawing.Size(100, 22);
            this.phoneTxtb.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 286);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone";
            // 
            // cityTxtb
            // 
            this.cityTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityTxtb.Location = new System.Drawing.Point(349, 235);
            this.cityTxtb.Margin = new System.Windows.Forms.Padding(2);
            this.cityTxtb.Multiline = true;
            this.cityTxtb.Name = "cityTxtb";
            this.cityTxtb.Size = new System.Drawing.Size(116, 27);
            this.cityTxtb.TabIndex = 8;
            this.cityTxtb.TextChanged += new System.EventHandler(this.emailTxtb_TextChanged);
            // 
            // CityLbl
            // 
            this.CityLbl.AutoSize = true;
            this.CityLbl.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLbl.Location = new System.Drawing.Point(346, 209);
            this.CityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CityLbl.Name = "CityLbl";
            this.CityLbl.Size = new System.Drawing.Size(40, 23);
            this.CityLbl.TabIndex = 9;
            this.CityLbl.Text = "City";
            // 
            // SendBtn
            // 
            this.SendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendBtn.Location = new System.Drawing.Point(189, 326);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(157, 52);
            this.SendBtn.TabIndex = 16;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // FormNameLbl
            // 
            this.FormNameLbl.AutoSize = true;
            this.FormNameLbl.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.FormNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormNameLbl.Location = new System.Drawing.Point(13, 13);
            this.FormNameLbl.Name = "FormNameLbl";
            this.FormNameLbl.Size = new System.Drawing.Size(136, 55);
            this.FormNameLbl.TabIndex = 17;
            this.FormNameLbl.Text = "Form";
            // 
            // infoNameLbl
            // 
            this.infoNameLbl.AutoSize = true;
            this.infoNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoNameLbl.Location = new System.Drawing.Point(9, 165);
            this.infoNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoNameLbl.Name = "infoNameLbl";
            this.infoNameLbl.Size = new System.Drawing.Size(0, 17);
            this.infoNameLbl.TabIndex = 13;
            // 
            // surnameInfoLbl
            // 
            this.surnameInfoLbl.AutoSize = true;
            this.surnameInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameInfoLbl.Location = new System.Drawing.Point(181, 165);
            this.surnameInfoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surnameInfoLbl.Name = "surnameInfoLbl";
            this.surnameInfoLbl.Size = new System.Drawing.Size(0, 17);
            this.surnameInfoLbl.TabIndex = 13;
            this.surnameInfoLbl.TextChanged += new System.EventHandler(this.surnameInfoLbl_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(347, 266);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 13;
            this.label9.TextChanged += new System.EventHandler(this.emailTxtb_TextChanged);
            // 
            // ManBtn
            // 
            this.ManBtn.AutoSize = true;
            this.ManBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManBtn.Location = new System.Drawing.Point(184, 233);
            this.ManBtn.Name = "ManBtn";
            this.ManBtn.Size = new System.Drawing.Size(55, 22);
            this.ManBtn.TabIndex = 18;
            this.ManBtn.TabStop = true;
            this.ManBtn.Text = "Man";
            this.ManBtn.UseVisualStyleBackColor = true;
            // 
            // womanBtn
            // 
            this.womanBtn.AutoSize = true;
            this.womanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.womanBtn.Location = new System.Drawing.Point(184, 261);
            this.womanBtn.Name = "womanBtn";
            this.womanBtn.Size = new System.Drawing.Size(79, 22);
            this.womanBtn.TabIndex = 18;
            this.womanBtn.TabStop = true;
            this.womanBtn.Text = "Woman";
            this.womanBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(540, 436);
            this.Controls.Add(this.womanBtn);
            this.Controls.Add(this.ManBtn);
            this.Controls.Add(this.FormNameLbl);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.phoneTxtb);
            this.Controls.Add(this.birthDayTxtb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.surnameInfoLbl);
            this.Controls.Add(this.infoNameLbl);
            this.Controls.Add(this.infoEmailLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CityLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cityTxtb);
            this.Controls.Add(this.emailTxtb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SurnameTxtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTxtb);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1000, 669);
            this.Name = "Form1";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTxtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SurnameTxtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailTxtb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label infoEmailLbl;
        private System.Windows.Forms.DateTimePicker birthDayTxtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox phoneTxtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cityTxtb;
        private System.Windows.Forms.Label CityLbl;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Label FormNameLbl;
        private System.Windows.Forms.Label infoNameLbl;
        private System.Windows.Forms.Label surnameInfoLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton ManBtn;
        private System.Windows.Forms.RadioButton womanBtn;
    }
}

