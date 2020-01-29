namespace ETUI_TRIGGERS
{
    partial class Dock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dock));
            this.btnCreateTrigger = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnEditTrigger = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBacktoMain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBxTriggerActive = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.systemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateTrigger
            // 
            this.btnCreateTrigger.BackColor = System.Drawing.Color.Black;
            this.btnCreateTrigger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnCreateTrigger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnCreateTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTrigger.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTrigger.ForeColor = System.Drawing.Color.White;
            this.btnCreateTrigger.Location = new System.Drawing.Point(160, 3);
            this.btnCreateTrigger.Name = "btnCreateTrigger";
            this.btnCreateTrigger.Size = new System.Drawing.Size(149, 50);
            this.btnCreateTrigger.TabIndex = 1;
            this.btnCreateTrigger.Text = "Create Trigger";
            this.btnCreateTrigger.UseVisualStyleBackColor = false;
            this.btnCreateTrigger.Click += new System.EventHandler(this.btnCreateTrigger_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(560, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 105);
            this.button2.TabIndex = 2;
            this.button2.Text = "Activate ETUI";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(832, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 33);
            this.button6.TabIndex = 6;
            this.button6.Text = "Save Configuration";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnEditTrigger
            // 
            this.btnEditTrigger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditTrigger.BackColor = System.Drawing.Color.Black;
            this.btnEditTrigger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnEditTrigger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnEditTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTrigger.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTrigger.ForeColor = System.Drawing.Color.White;
            this.btnEditTrigger.Location = new System.Drawing.Point(160, 58);
            this.btnEditTrigger.Name = "btnEditTrigger";
            this.btnEditTrigger.Size = new System.Drawing.Size(149, 50);
            this.btnEditTrigger.TabIndex = 11;
            this.btnEditTrigger.Text = "Edit Trigger";
            this.btnEditTrigger.UseVisualStyleBackColor = false;
            this.btnEditTrigger.Click += new System.EventHandler(this.EditTrigger);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(313, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 50);
            this.button4.TabIndex = 12;
            this.button4.Text = "Reset All Trigges";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ResetAllTriggers);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(313, 58);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(149, 50);
            this.button8.TabIndex = 13;
            this.button8.Text = "Delete All Triggers";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.DeleteAllTriggers);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(832, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "Hide Control Panel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBacktoMain
            // 
            this.btnBacktoMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBacktoMain.BackColor = System.Drawing.Color.Black;
            this.btnBacktoMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnBacktoMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnBacktoMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBacktoMain.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoMain.ForeColor = System.Drawing.Color.White;
            this.btnBacktoMain.Location = new System.Drawing.Point(832, 75);
            this.btnBacktoMain.Name = "btnBacktoMain";
            this.btnBacktoMain.Size = new System.Drawing.Size(161, 34);
            this.btnBacktoMain.TabIndex = 15;
            this.btnBacktoMain.Text = "Back to Main Menu";
            this.btnBacktoMain.UseVisualStyleBackColor = false;
            this.btnBacktoMain.Click += new System.EventHandler(this.btnBacktoMain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DraggingOff);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DraggingOn);
            // 
            // txtBxTriggerActive
            // 
            this.txtBxTriggerActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxTriggerActive.BackColor = System.Drawing.Color.Black;
            this.txtBxTriggerActive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTriggerActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBxTriggerActive.Location = new System.Drawing.Point(476, 39);
            this.txtBxTriggerActive.Name = "txtBxTriggerActive";
            this.txtBxTriggerActive.ReadOnly = true;
            this.txtBxTriggerActive.Size = new System.Drawing.Size(72, 27);
            this.txtBxTriggerActive.TabIndex = 16;
            this.txtBxTriggerActive.Text = "Triggers Active: 0";
            this.txtBxTriggerActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxTriggerActive.MouseEnter += new System.EventHandler(this.TextbxActiveTrigger_MouseEnter);
            this.txtBxTriggerActive.MouseLeave += new System.EventHandler(this.TextbxActiveTrigger_MouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // systemTrayIcon
            // 
            this.systemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTrayIcon.Icon")));
            this.systemTrayIcon.Text = "ETUI Control Panel";
            this.systemTrayIcon.Visible = true;
            this.systemTrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MaximizeMethod);
            // 
            // Dock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 113);
            this.Controls.Add(this.txtBxTriggerActive);
            this.Controls.Add(this.btnBacktoMain);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEditTrigger);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreateTrigger);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(5000, 150);
            this.MinimumSize = new System.Drawing.Size(1000, 100);
            this.Name = "Dock";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Control Panel | ETUI © 2020";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Dock_Load);
            this.SizeChanged += new System.EventHandler(this.MinimizeMethod);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCreateTrigger;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnEditTrigger;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBacktoMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox txtBxTriggerActive;
        public System.Windows.Forms.NotifyIcon systemTrayIcon;
    }
}