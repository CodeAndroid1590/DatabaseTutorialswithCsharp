namespace DatabaseTutorialswithCsharp
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fname_textbox = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.colse_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.isSkilleInCsharp = new System.Windows.Forms.CheckBox();
            this.isSkilledInjava = new System.Windows.Forms.CheckBox();
            this.isSkilledInpython = new System.Windows.Forms.CheckBox();
            this.gender_btn = new System.Windows.Forms.Label();
            this.male_btn = new System.Windows.Forms.RadioButton();
            this.fmale_btn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.admTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.districtComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.browseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(256, 35);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(190, 20);
            this.name_textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "FName";
            // 
            // fname_textbox
            // 
            this.fname_textbox.Location = new System.Drawing.Point(256, 61);
            this.fname_textbox.Name = "fname_textbox";
            this.fname_textbox.Size = new System.Drawing.Size(190, 20);
            this.fname_textbox.TabIndex = 1;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(192, 270);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // colse_btn
            // 
            this.colse_btn.Location = new System.Drawing.Point(412, 270);
            this.colse_btn.Name = "colse_btn";
            this.colse_btn.Size = new System.Drawing.Size(75, 23);
            this.colse_btn.TabIndex = 2;
            this.colse_btn.Text = "Close";
            this.colse_btn.UseVisualStyleBackColor = true;
            this.colse_btn.Click += new System.EventHandler(this.colse_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Skilled In";
            // 
            // isSkilleInCsharp
            // 
            this.isSkilleInCsharp.AutoSize = true;
            this.isSkilleInCsharp.Location = new System.Drawing.Point(277, 96);
            this.isSkilleInCsharp.Name = "isSkilleInCsharp";
            this.isSkilleInCsharp.Size = new System.Drawing.Size(40, 17);
            this.isSkilleInCsharp.TabIndex = 3;
            this.isSkilleInCsharp.Text = "C#";
            this.isSkilleInCsharp.UseVisualStyleBackColor = true;
            // 
            // isSkilledInjava
            // 
            this.isSkilledInjava.AutoSize = true;
            this.isSkilledInjava.Location = new System.Drawing.Point(341, 95);
            this.isSkilledInjava.Name = "isSkilledInjava";
            this.isSkilledInjava.Size = new System.Drawing.Size(49, 17);
            this.isSkilledInjava.TabIndex = 3;
            this.isSkilledInjava.Text = "Java";
            this.isSkilledInjava.UseVisualStyleBackColor = true;
            // 
            // isSkilledInpython
            // 
            this.isSkilledInpython.AutoSize = true;
            this.isSkilledInpython.Location = new System.Drawing.Point(419, 95);
            this.isSkilledInpython.Name = "isSkilledInpython";
            this.isSkilledInpython.Size = new System.Drawing.Size(59, 17);
            this.isSkilledInpython.TabIndex = 3;
            this.isSkilledInpython.Text = "Python";
            this.isSkilledInpython.UseVisualStyleBackColor = true;
            // 
            // gender_btn
            // 
            this.gender_btn.AutoSize = true;
            this.gender_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_btn.Location = new System.Drawing.Point(189, 124);
            this.gender_btn.Name = "gender_btn";
            this.gender_btn.Size = new System.Drawing.Size(48, 13);
            this.gender_btn.TabIndex = 0;
            this.gender_btn.Text = "Gender";
            // 
            // male_btn
            // 
            this.male_btn.AutoSize = true;
            this.male_btn.Checked = true;
            this.male_btn.Location = new System.Drawing.Point(277, 124);
            this.male_btn.Name = "male_btn";
            this.male_btn.Size = new System.Drawing.Size(48, 17);
            this.male_btn.TabIndex = 4;
            this.male_btn.TabStop = true;
            this.male_btn.Text = "Male";
            this.male_btn.UseVisualStyleBackColor = true;
            // 
            // fmale_btn
            // 
            this.fmale_btn.AutoSize = true;
            this.fmale_btn.Location = new System.Drawing.Point(342, 124);
            this.fmale_btn.Name = "fmale_btn";
            this.fmale_btn.Size = new System.Drawing.Size(59, 17);
            this.fmale_btn.TabIndex = 4;
            this.fmale_btn.TabStop = true;
            this.fmale_btn.Text = "Female";
            this.fmale_btn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "D.O.B";
            // 
            // dobPicker
            // 
            this.dobPicker.CustomFormat = " ";
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobPicker.Location = new System.Drawing.Point(256, 151);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(200, 20);
            this.dobPicker.TabIndex = 5;
            this.dobPicker.ValueChanged += new System.EventHandler(this.dobPicker_ValueChanged);
            this.dobPicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dobPicker_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "AdmTime";
            // 
            // admTimePicker
            // 
            this.admTimePicker.CustomFormat = " ";
            this.admTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.admTimePicker.Location = new System.Drawing.Point(256, 194);
            this.admTimePicker.Name = "admTimePicker";
            this.admTimePicker.ShowUpDown = true;
            this.admTimePicker.Size = new System.Drawing.Size(200, 20);
            this.admTimePicker.TabIndex = 6;
            this.admTimePicker.ValueChanged += new System.EventHandler(this.Time_ValueChanged);
            this.admTimePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.admTimePicker_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Districts";
            // 
            // districtComboBox
            // 
            this.districtComboBox.FormattingEnabled = true;
            this.districtComboBox.Location = new System.Drawing.Point(256, 229);
            this.districtComboBox.Name = "districtComboBox";
            this.districtComboBox.Size = new System.Drawing.Size(200, 21);
            this.districtComboBox.TabIndex = 7;
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStudent.Image")));
            this.pictureBoxStudent.Location = new System.Drawing.Point(12, 35);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(119, 121);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudent.TabIndex = 8;
            this.pictureBoxStudent.TabStop = false;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(26, 162);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 9;
            this.browseBtn.Text = "browseBtn";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 305);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pictureBoxStudent);
            this.Controls.Add(this.districtComboBox);
            this.Controls.Add(this.admTimePicker);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.fmale_btn);
            this.Controls.Add(this.male_btn);
            this.Controls.Add(this.isSkilledInpython);
            this.Controls.Add(this.isSkilledInjava);
            this.Controls.Add(this.isSkilleInCsharp);
            this.Controls.Add(this.colse_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.fname_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gender_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fname_textbox;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button colse_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isSkilleInCsharp;
        private System.Windows.Forms.CheckBox isSkilledInjava;
        private System.Windows.Forms.CheckBox isSkilledInpython;
        private System.Windows.Forms.Label gender_btn;
        private System.Windows.Forms.RadioButton male_btn;
        private System.Windows.Forms.RadioButton fmale_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker admTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox districtComboBox;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.Button browseBtn;
    }
}