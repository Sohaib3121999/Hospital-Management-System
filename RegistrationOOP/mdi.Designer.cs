namespace RegistrationOOP
{
    partial class mdi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.allpatients = new System.Windows.Forms.Button();
            this.alldocs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(63, 494);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.newAppointmentToolStripMenuItem,
            this.searchAppointmentToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newAccountToolStripMenuItem.Text = "new Account";
            this.newAccountToolStripMenuItem.Click += new System.EventHandler(this.newAccountToolStripMenuItem_Click);
            // 
            // newAppointmentToolStripMenuItem
            // 
            this.newAppointmentToolStripMenuItem.Name = "newAppointmentToolStripMenuItem";
            this.newAppointmentToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newAppointmentToolStripMenuItem.Text = "New Appointment";
            this.newAppointmentToolStripMenuItem.Click += new System.EventHandler(this.newAppointmentToolStripMenuItem_Click);
            // 
            // searchAppointmentToolStripMenuItem
            // 
            this.searchAppointmentToolStripMenuItem.Name = "searchAppointmentToolStripMenuItem";
            this.searchAppointmentToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.searchAppointmentToolStripMenuItem.Text = "Search Appointment";
            this.searchAppointmentToolStripMenuItem.Click += new System.EventHandler(this.searchAppointmentToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(63, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 106);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(307, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(63, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1323, 100);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(493, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Copyright ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(493, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Aga Khan University Hospitals";
            // 
            // allpatients
            // 
            this.allpatients.Location = new System.Drawing.Point(2, 37);
            this.allpatients.Name = "allpatients";
            this.allpatients.Size = new System.Drawing.Size(61, 69);
            this.allpatients.TabIndex = 5;
            this.allpatients.Text = "show Appointment Data";
            this.allpatients.UseVisualStyleBackColor = true;
            this.allpatients.Click += new System.EventHandler(this.Allpatients_Click);
            // 
            // alldocs
            // 
            this.alldocs.Location = new System.Drawing.Point(0, 112);
            this.alldocs.Name = "alldocs";
            this.alldocs.Size = new System.Drawing.Size(61, 74);
            this.alldocs.TabIndex = 5;
            this.alldocs.Text = "show all Doctors";
            this.alldocs.UseVisualStyleBackColor = true;
            this.alldocs.Click += new System.EventHandler(this.Alldocs_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 176);
            this.dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 84);
            this.button1.TabIndex = 7;
            this.button1.Text = "show all Patient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.alldocs);
            this.Controls.Add(this.allpatients);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mdi";
            this.Text = "AGA KHAN HOSPITAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mdi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button allpatients;
        private System.Windows.Forms.Button alldocs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}