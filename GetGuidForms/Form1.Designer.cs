namespace GetGuidForms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getGuidNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.GetGuidMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GetGuidExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GetGuidMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // getGuidNotifyIcon
            // 
            this.getGuidNotifyIcon.ContextMenuStrip = this.GetGuidMenuStrip;
            this.getGuidNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("getGuidNotifyIcon.Icon")));
            this.getGuidNotifyIcon.Text = "Get Guid";
            this.getGuidNotifyIcon.Visible = true;
            this.getGuidNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.getGuidNotifyIcon_MouseDoubleClick);
            // 
            // GetGuidMenuStrip
            // 
            this.GetGuidMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GetGuidExit});
            this.GetGuidMenuStrip.Name = "GetGuidMenuStrip";
            this.GetGuidMenuStrip.Size = new System.Drawing.Size(93, 26);
            // 
            // GetGuidExit
            // 
            this.GetGuidExit.Name = "GetGuidExit";
            this.GetGuidExit.Size = new System.Drawing.Size(92, 22);
            this.GetGuidExit.Text = "Exit";
            this.GetGuidExit.Click += new System.EventHandler(this.GetGuidExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "You can get a new Guid by clicking the\nbelow button or double clicking the\ntray i" +
    "con.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Guid";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(4, 95);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(275, 163);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 100000);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Guid Generator";
            this.GetGuidMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon getGuidNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip GetGuidMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem GetGuidExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

