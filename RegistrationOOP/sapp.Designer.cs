namespace RegistrationOOP
{
    partial class sapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sapp));
            this.sss = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.dname = new System.Windows.Forms.Label();
            this.spec = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.upname = new System.Windows.Forms.TextBox();
            this.phoneno = new System.Windows.Forms.TextBox();
            this.specia = new System.Windows.Forms.TextBox();
            this.dayup = new System.Windows.Forms.TextBox();
            this.doctorname = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sss
            // 
            this.sss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sss.Location = new System.Drawing.Point(354, 117);
            this.sss.Margin = new System.Windows.Forms.Padding(2);
            this.sss.Name = "sss";
            this.sss.Size = new System.Drawing.Size(318, 28);
            this.sss.TabIndex = 0;
            this.sss.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.sss.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sss_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Invoice";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(229, 242);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(24, 22);
            this.name.TabIndex = 2;
            this.name.Text = "--";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.BackColor = System.Drawing.Color.Transparent;
            this.phone.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(229, 279);
            this.phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(24, 22);
            this.phone.TabIndex = 2;
            this.phone.Text = "--";
            this.phone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dname
            // 
            this.dname.AutoSize = true;
            this.dname.BackColor = System.Drawing.Color.Transparent;
            this.dname.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dname.Location = new System.Drawing.Point(229, 313);
            this.dname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(24, 22);
            this.dname.TabIndex = 2;
            this.dname.Text = "--";
            this.dname.Click += new System.EventHandler(this.Label4_Click);
            // 
            // spec
            // 
            this.spec.AutoSize = true;
            this.spec.BackColor = System.Drawing.Color.Transparent;
            this.spec.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spec.Location = new System.Drawing.Point(229, 346);
            this.spec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(24, 22);
            this.spec.TabIndex = 2;
            this.spec.Text = "--";
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.BackColor = System.Drawing.Color.Transparent;
            this.day.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.Location = new System.Drawing.Point(229, 379);
            this.day.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(24, 22);
            this.day.TabIndex = 2;
            this.day.Text = "--";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(229, 415);
            this.time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(24, 22);
            this.time.TabIndex = 2;
            this.time.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 242);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 346);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "speciality";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 279);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "PhoneNO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 313);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 22);
            this.label11.TabIndex = 4;
            this.label11.Text = "DoctorName";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 379);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 22);
            this.label12.TabIndex = 4;
            this.label12.Text = "Day";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(44, 415);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 22);
            this.label13.TabIndex = 4;
            this.label13.Text = "Time";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // upname
            // 
            this.upname.Location = new System.Drawing.Point(452, 245);
            this.upname.Name = "upname";
            this.upname.Size = new System.Drawing.Size(145, 20);
            this.upname.TabIndex = 6;
            // 
            // phoneno
            // 
            this.phoneno.Location = new System.Drawing.Point(452, 282);
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(145, 20);
            this.phoneno.TabIndex = 6;
            // 
            // specia
            // 
            this.specia.Location = new System.Drawing.Point(452, 349);
            this.specia.Name = "specia";
            this.specia.Size = new System.Drawing.Size(145, 20);
            this.specia.TabIndex = 6;
            // 
            // dayup
            // 
            this.dayup.Location = new System.Drawing.Point(452, 382);
            this.dayup.Name = "dayup";
            this.dayup.Size = new System.Drawing.Size(145, 20);
            this.dayup.TabIndex = 6;
            // 
            // doctorname
            // 
            this.doctorname.Location = new System.Drawing.Point(452, 316);
            this.doctorname.Name = "doctorname";
            this.doctorname.Size = new System.Drawing.Size(145, 20);
            this.doctorname.TabIndex = 6;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(452, 448);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(124, 31);
            this.update.TabIndex = 7;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "get";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // sapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 497);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.doctorname);
            this.Controls.Add(this.dayup);
            this.Controls.Add(this.specia);
            this.Controls.Add(this.phoneno);
            this.Controls.Add(this.upname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.time);
            this.Controls.Add(this.day);
            this.Controls.Add(this.spec);
            this.Controls.Add(this.dname);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sss);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "sapp";
            this.Text = "Search Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label dname;
        private System.Windows.Forms.Label spec;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox upname;
        private System.Windows.Forms.TextBox phoneno;
        private System.Windows.Forms.TextBox specia;
        private System.Windows.Forms.TextBox dayup;
        private System.Windows.Forms.TextBox doctorname;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button2;
    }
}