namespace ETUI_TRIGGERS
{
    partial class TriggerEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriggerEditor));
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.cmbobxTriggerType = new System.Windows.Forms.ComboBox();
            this.trkbarWidth = new System.Windows.Forms.TrackBar();
            this.trkbarHeight = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxXposition = new System.Windows.Forms.TextBox();
            this.txtbxYposition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCreateTrigger = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trkbarPositionX = new System.Windows.Forms.TrackBar();
            this.trkbarPositionY = new System.Windows.Forms.TrackBar();
            this.labelTimeDelay = new System.Windows.Forms.Label();
            this.txtBxTimeDelay = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelectOperation = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkbarWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbarHeight)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkbarPositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbarPositionY)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Location = new System.Drawing.Point(15, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblType.Location = new System.Drawing.Point(15, 51);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(15, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operation";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(74, 15);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(121, 20);
            this.txtbxName.TabIndex = 3;
            // 
            // cmbobxTriggerType
            // 
            this.cmbobxTriggerType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbobxTriggerType.FormattingEnabled = true;
            this.cmbobxTriggerType.Location = new System.Drawing.Point(74, 48);
            this.cmbobxTriggerType.Name = "cmbobxTriggerType";
            this.cmbobxTriggerType.Size = new System.Drawing.Size(121, 21);
            this.cmbobxTriggerType.TabIndex = 4;
            this.cmbobxTriggerType.SelectedIndexChanged += new System.EventHandler(this.cmbobxTriggerType_SelectedIndexChanged);
            // 
            // trkbarWidth
            // 
            this.trkbarWidth.Location = new System.Drawing.Point(53, 121);
            this.trkbarWidth.Maximum = 1000;
            this.trkbarWidth.Minimum = 10;
            this.trkbarWidth.Name = "trkbarWidth";
            this.trkbarWidth.Size = new System.Drawing.Size(150, 45);
            this.trkbarWidth.TabIndex = 6;
            this.trkbarWidth.Value = 300;
            this.trkbarWidth.Scroll += new System.EventHandler(this.trkbarWidth_Scroll);
            // 
            // trkbarHeight
            // 
            this.trkbarHeight.Location = new System.Drawing.Point(53, 158);
            this.trkbarHeight.Maximum = 1000;
            this.trkbarHeight.Minimum = 10;
            this.trkbarHeight.Name = "trkbarHeight";
            this.trkbarHeight.Size = new System.Drawing.Size(150, 45);
            this.trkbarHeight.TabIndex = 7;
            this.trkbarHeight.Value = 200;
            this.trkbarHeight.Scroll += new System.EventHandler(this.trkbarHeight_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(219, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Position:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(270, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(321, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Y:";
            // 
            // txtbxXposition
            // 
            this.txtbxXposition.Enabled = false;
            this.txtbxXposition.Location = new System.Drawing.Point(286, 16);
            this.txtbxXposition.Name = "txtbxXposition";
            this.txtbxXposition.Size = new System.Drawing.Size(24, 20);
            this.txtbxXposition.TabIndex = 13;
            // 
            // txtbxYposition
            // 
            this.txtbxYposition.Enabled = false;
            this.txtbxYposition.Location = new System.Drawing.Point(338, 16);
            this.txtbxYposition.Name = "txtbxYposition";
            this.txtbxYposition.Size = new System.Drawing.Size(24, 20);
            this.txtbxYposition.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(275, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Anchors";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(221, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 93);
            this.panel1.TabIndex = 16;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Highlight;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(4, 62);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 25);
            this.button7.TabIndex = 24;
            this.button7.Text = "BL";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Highlight;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.Control;
            this.button8.Location = new System.Drawing.Point(53, 62);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(44, 25);
            this.button8.TabIndex = 23;
            this.button8.Text = "BC";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Highlight;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.Control;
            this.button9.Location = new System.Drawing.Point(103, 62);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(44, 25);
            this.button9.TabIndex = 22;
            this.button9.Text = "BR";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(4, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 25);
            this.button1.TabIndex = 21;
            this.button1.Text = "CL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(53, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 25);
            this.button2.TabIndex = 20;
            this.button2.Text = "CC";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Highlight;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(103, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 25);
            this.button6.TabIndex = 19;
            this.button6.Text = "CR";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Highlight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 25);
            this.button5.TabIndex = 18;
            this.button5.Text = "TL";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(53, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 25);
            this.button4.TabIndex = 17;
            this.button4.Text = "TC";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(103, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "TR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCreateTrigger
            // 
            this.btnCreateTrigger.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreateTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTrigger.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTrigger.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateTrigger.Location = new System.Drawing.Point(19, 324);
            this.btnCreateTrigger.Name = "btnCreateTrigger";
            this.btnCreateTrigger.Size = new System.Drawing.Size(250, 38);
            this.btnCreateTrigger.TabIndex = 17;
            this.btnCreateTrigger.Text = "Create Trigger";
            this.btnCreateTrigger.UseVisualStyleBackColor = false;
            this.btnCreateTrigger.Click += new System.EventHandler(this.btnCreateTrigger_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(38, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Screen Location:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(14, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "X Axis";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(14, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Y Axis";
            // 
            // trkbarPositionX
            // 
            this.trkbarPositionX.Location = new System.Drawing.Point(53, 235);
            this.trkbarPositionX.Maximum = 1000;
            this.trkbarPositionX.Name = "trkbarPositionX";
            this.trkbarPositionX.Size = new System.Drawing.Size(318, 45);
            this.trkbarPositionX.TabIndex = 21;
            this.trkbarPositionX.Value = 300;
            this.trkbarPositionX.Scroll += new System.EventHandler(this.trkbarPositionX_Scroll);
            // 
            // trkbarPositionY
            // 
            this.trkbarPositionY.Location = new System.Drawing.Point(53, 278);
            this.trkbarPositionY.Maximum = 1000;
            this.trkbarPositionY.Name = "trkbarPositionY";
            this.trkbarPositionY.Size = new System.Drawing.Size(319, 45);
            this.trkbarPositionY.TabIndex = 22;
            this.trkbarPositionY.Value = 300;
            this.trkbarPositionY.Scroll += new System.EventHandler(this.trkbarPositionY_Scroll);
            // 
            // labelTimeDelay
            // 
            this.labelTimeDelay.AutoSize = true;
            this.labelTimeDelay.Location = new System.Drawing.Point(201, 52);
            this.labelTimeDelay.Name = "labelTimeDelay";
            this.labelTimeDelay.Size = new System.Drawing.Size(93, 13);
            this.labelTimeDelay.TabIndex = 23;
            this.labelTimeDelay.Text = "Delay in Seconds:";
            // 
            // txtBxTimeDelay
            // 
            this.txtBxTimeDelay.Location = new System.Drawing.Point(297, 48);
            this.txtBxTimeDelay.Name = "txtBxTimeDelay";
            this.txtBxTimeDelay.Size = new System.Drawing.Size(65, 20);
            this.txtBxTimeDelay.TabIndex = 24;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Location = new System.Drawing.Point(132, 204);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Draggable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.Draggable);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(274, 324);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 38);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.closeBtn);
            // 
            // btnSelectOperation
            // 
            this.btnSelectOperation.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSelectOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectOperation.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSelectOperation.Location = new System.Drawing.Point(74, 83);
            this.btnSelectOperation.Name = "btnSelectOperation";
            this.btnSelectOperation.Size = new System.Drawing.Size(101, 25);
            this.btnSelectOperation.TabIndex = 25;
            this.btnSelectOperation.Text = "Select Operation";
            this.btnSelectOperation.UseVisualStyleBackColor = false;
            this.btnSelectOperation.Click += new System.EventHandler(this.btnSelectOperation_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "No operation selected!";
            // 
            // TriggerEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 378);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSelectOperation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtBxTimeDelay);
            this.Controls.Add(this.labelTimeDelay);
            this.Controls.Add(this.trkbarPositionY);
            this.Controls.Add(this.trkbarPositionX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCreateTrigger);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbxYposition);
            this.Controls.Add(this.txtbxXposition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trkbarHeight);
            this.Controls.Add(this.trkbarWidth);
            this.Controls.Add(this.cmbobxTriggerType);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TriggerEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Trigger [Trigger Editor]";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.trkbarWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbarHeight)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trkbarPositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbarPositionY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.ComboBox cmbobxTriggerType;
        private System.Windows.Forms.TrackBar trkbarWidth;
        private System.Windows.Forms.TrackBar trkbarHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbxXposition;
        private System.Windows.Forms.TextBox txtbxYposition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCreateTrigger;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trkbarPositionX;
        private System.Windows.Forms.TrackBar trkbarPositionY;
        private System.Windows.Forms.Label labelTimeDelay;
        private System.Windows.Forms.TextBox txtBxTimeDelay;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelectOperation;
        private System.Windows.Forms.Label label11;
    }
}

