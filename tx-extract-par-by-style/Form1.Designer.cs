namespace tx_extract_par_by_style
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
			this.textControl1 = new TXTextControl.TextControl();
			this.ribbon1 = new TXTextControl.Windows.Forms.Ribbon.Ribbon();
			this.ribbonFormattingTab1 = new TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab();
			this.rulerBar1 = new TXTextControl.RulerBar();
			this.statusBar1 = new TXTextControl.StatusBar();
			this.rulerBar2 = new TXTextControl.RulerBar();
			this.button3 = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.sidebar1 = new TXTextControl.Windows.Forms.Sidebar();
			this.ribbon1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textControl1
			// 
			this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textControl1.Font = new System.Drawing.Font("Arial", 10F);
			this.textControl1.FormattingPrinter = "Standard";
			this.textControl1.Location = new System.Drawing.Point(25, 25);
			this.textControl1.Name = "textControl1";
			this.textControl1.Ribbon = this.ribbon1;
			this.textControl1.RulerBar = this.rulerBar1;
			this.textControl1.Size = new System.Drawing.Size(632, 409);
			this.textControl1.StatusBar = this.statusBar1;
			this.textControl1.TabIndex = 0;
			this.textControl1.Text = "textControl1";
			this.textControl1.UserNames = null;
			this.textControl1.VerticalRulerBar = this.rulerBar2;
			// 
			// ribbon1
			// 
			this.ribbon1.Controls.Add(this.ribbonFormattingTab1);
			this.ribbon1.Dock = System.Windows.Forms.DockStyle.Top;
			this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ribbon1.HotTrack = true;
			this.ribbon1.Location = new System.Drawing.Point(0, 0);
			this.ribbon1.Name = "ribbon1";
			this.ribbon1.SelectedIndex = 1;
			this.ribbon1.Size = new System.Drawing.Size(1106, 118);
			this.ribbon1.TabIndex = 3;
			this.ribbon1.Text = "ribbon1";
			// 
			// ribbonFormattingTab1
			// 
			this.ribbonFormattingTab1.Location = new System.Drawing.Point(4, 24);
			this.ribbonFormattingTab1.Name = "ribbonFormattingTab1";
			this.ribbonFormattingTab1.Size = new System.Drawing.Size(1098, 90);
			this.ribbonFormattingTab1.TabIndex = 1;
			// 
			// rulerBar1
			// 
			this.rulerBar1.Dock = System.Windows.Forms.DockStyle.Top;
			this.rulerBar1.Location = new System.Drawing.Point(0, 0);
			this.rulerBar1.Name = "rulerBar1";
			this.rulerBar1.Size = new System.Drawing.Size(657, 25);
			this.rulerBar1.TabIndex = 1;
			this.rulerBar1.Text = "rulerBar1";
			// 
			// statusBar1
			// 
			this.statusBar1.BackColor = System.Drawing.SystemColors.Control;
			this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.statusBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusBar1.Location = new System.Drawing.Point(0, 434);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(883, 22);
			this.statusBar1.TabIndex = 3;
			// 
			// rulerBar2
			// 
			this.rulerBar2.Alignment = TXTextControl.RulerBarAlignment.Left;
			this.rulerBar2.Dock = System.Windows.Forms.DockStyle.Left;
			this.rulerBar2.Location = new System.Drawing.Point(0, 25);
			this.rulerBar2.Name = "rulerBar2";
			this.rulerBar2.Size = new System.Drawing.Size(25, 409);
			this.rulerBar2.TabIndex = 2;
			this.rulerBar2.Text = "rulerBar2";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 13);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(122, 39);
			this.button3.TabIndex = 5;
			this.button3.Text = "Convert to styles";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 118);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.button3);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.textControl1);
			this.splitContainer1.Panel2.Controls.Add(this.rulerBar2);
			this.splitContainer1.Panel2.Controls.Add(this.rulerBar1);
			this.splitContainer1.Panel2.Controls.Add(this.sidebar1);
			this.splitContainer1.Panel2.Controls.Add(this.statusBar1);
			this.splitContainer1.Size = new System.Drawing.Size(1106, 456);
			this.splitContainer1.SplitterDistance = 219;
			this.splitContainer1.TabIndex = 6;
			// 
			// sidebar1
			// 
			this.sidebar1.ContentLayout = TXTextControl.Windows.Forms.Sidebar.SidebarContentLayout.Styles;
			this.sidebar1.Dock = System.Windows.Forms.DockStyle.Right;
			this.sidebar1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.sidebar1.Location = new System.Drawing.Point(657, 0);
			this.sidebar1.Name = "sidebar1";
			this.sidebar1.Size = new System.Drawing.Size(226, 434);
			this.sidebar1.TabIndex = 4;
			this.sidebar1.TextControl = this.textControl1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1106, 574);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.ribbon1);
			this.Name = "Form1";
			this.Text = "Style Manager";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ribbon1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private TXTextControl.TextControl textControl1;
        private TXTextControl.Windows.Forms.Ribbon.Ribbon ribbon1;
        private TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab ribbonFormattingTab1;
		private System.Windows.Forms.Button button3;
		private TXTextControl.RulerBar rulerBar2;
		private TXTextControl.StatusBar statusBar1;
		private TXTextControl.RulerBar rulerBar1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private TXTextControl.Windows.Forms.Sidebar sidebar1;
	}
}

