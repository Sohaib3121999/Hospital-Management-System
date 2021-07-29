namespace RegistrationOOP
{
    partial class appointform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appointform));
            this.Grido = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LBL = new System.Windows.Forms.Label();
            this.lbldoc = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.did = new System.Windows.Forms.TextBox();
            this.spec = new System.Windows.Forms.TextBox();
            this.dname = new System.Windows.Forms.TextBox();
            this.patientname = new System.Windows.Forms.TextBox();
            this.phoneno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.invoice = new System.Windows.Forms.Label();
            this.fee = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.page = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grido)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grido
            // 
            this.Grido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grido.Location = new System.Drawing.Point(4, 302);
            this.Grido.Margin = new System.Windows.Forms.Padding(2);
            this.Grido.Name = "Grido";
            this.Grido.RowTemplate.Height = 24;
            this.Grido.Size = new System.Drawing.Size(996, 156);
            this.Grido.TabIndex = 3;
            this.Grido.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grido_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(880, 463);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Make Appointment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 463);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Register patient";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(808, 463);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "print";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL.Location = new System.Drawing.Point(4, 172);
            this.LBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(177, 25);
            this.LBL.TabIndex = 1;
            this.LBL.Text = "Search Doctors ID";
            // 
            // lbldoc
            // 
            this.lbldoc.AutoSize = true;
            this.lbldoc.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoc.Location = new System.Drawing.Point(4, 207);
            this.lbldoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldoc.Name = "lbldoc";
            this.lbldoc.Size = new System.Drawing.Size(135, 25);
            this.lbldoc.TabIndex = 1;
            this.lbldoc.Text = "Doctor Name";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpec.Location = new System.Drawing.Point(4, 243);
            this.lblSpec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(99, 25);
            this.lblSpec.TabIndex = 1;
            this.lblSpec.Text = "Speciality";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 21);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(378, 32);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // did
            // 
            this.did.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.did.Location = new System.Drawing.Point(267, 170);
            this.did.Margin = new System.Windows.Forms.Padding(2);
            this.did.Name = "did";
            this.did.Size = new System.Drawing.Size(119, 32);
            this.did.TabIndex = 2;
            this.did.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.did.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyDown);
            // 
            // spec
            // 
            this.spec.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spec.Location = new System.Drawing.Point(117, 243);
            this.spec.Margin = new System.Windows.Forms.Padding(2);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(269, 32);
            this.spec.TabIndex = 6;
            // 
            // dname
            // 
            this.dname.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dname.Location = new System.Drawing.Point(134, 205);
            this.dname.Margin = new System.Windows.Forms.Padding(2);
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(252, 32);
            this.dname.TabIndex = 7;
            // 
            // patientname
            // 
            this.patientname.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientname.Location = new System.Drawing.Point(145, 57);
            this.patientname.Margin = new System.Windows.Forms.Padding(2);
            this.patientname.Name = "patientname";
            this.patientname.Size = new System.Drawing.Size(241, 32);
            this.patientname.TabIndex = 8;
            this.patientname.TextChanged += new System.EventHandler(this.patientname_TextChanged);
            this.patientname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.patientname_KeyDown);
            // 
            // phoneno
            // 
            this.phoneno.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneno.Location = new System.Drawing.Point(117, 129);
            this.phoneno.Margin = new System.Windows.Forms.Padding(2);
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(269, 32);
            this.phoneno.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Patient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phone No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(778, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Invoice";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // invoice
            // 
            this.invoice.AutoSize = true;
            this.invoice.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice.Location = new System.Drawing.Point(872, 21);
            this.invoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(87, 22);
            this.invoice.TabIndex = 11;
            this.invoice.Text = "0000000";
            this.invoice.Click += new System.EventHandler(this.Invoice_Click);
            // 
            // fee
            // 
            this.fee.AutoSize = true;
            this.fee.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fee.Location = new System.Drawing.Point(904, 249);
            this.fee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(62, 21);
            this.fee.TabIndex = 12;
            this.fee.Text = "0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(814, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fees :";
            // 
            // page
            // 
            this.page.Location = new System.Drawing.Point(134, 94);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(100, 28);
            this.page.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.page);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.fee);
            this.groupBox1.Controls.Add(this.invoice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.phoneno);
            this.groupBox1.Controls.Add(this.patientname);
            this.groupBox1.Controls.Add(this.dname);
            this.groupBox1.Controls.Add(this.spec);
            this.groupBox1.Controls.Add(this.did);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblSpec);
            this.groupBox1.Controls.Add(this.lbldoc);
            this.groupBox1.Controls.Add(this.LBL);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(996, 294);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Information";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // appointform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1004, 501);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grido);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "appointform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "appointform";
            this.Load += new System.EventHandler(this.appointform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Grido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LBL;
        private System.Windows.Forms.Label lbldoc;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox did;
        private System.Windows.Forms.TextBox spec;
        private System.Windows.Forms.TextBox dname;
        private System.Windows.Forms.TextBox patientname;
        private System.Windows.Forms.TextBox phoneno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label invoice;
        private System.Windows.Forms.Label fee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox page;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}