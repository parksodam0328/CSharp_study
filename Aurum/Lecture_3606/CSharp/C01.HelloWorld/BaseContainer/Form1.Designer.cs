namespace BaseContainer
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.파일NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.새창NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.종료FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.창WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.계단식배열ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.가로배열ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.세로배열ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일NToolStripMenuItem,
            this.창WToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(337, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 파일NToolStripMenuItem
			// 
			this.파일NToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새창NToolStripMenuItem,
            this.toolStripSeparator1,
            this.종료FToolStripMenuItem});
			this.파일NToolStripMenuItem.Name = "파일NToolStripMenuItem";
			this.파일NToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.파일NToolStripMenuItem.Text = "파일(&F)";
			this.파일NToolStripMenuItem.Click += new System.EventHandler(this.파일NToolStripMenuItem_Click);
			// 
			// 새창NToolStripMenuItem
			// 
			this.새창NToolStripMenuItem.Name = "새창NToolStripMenuItem";
			this.새창NToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.새창NToolStripMenuItem.Text = "새 창(&N)";
			this.새창NToolStripMenuItem.Click += new System.EventHandler(this.새창NToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(116, 6);
			// 
			// 종료FToolStripMenuItem
			// 
			this.종료FToolStripMenuItem.Name = "종료FToolStripMenuItem";
			this.종료FToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.종료FToolStripMenuItem.Text = "종료(&F)";
			// 
			// 창WToolStripMenuItem
			// 
			this.창WToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.계단식배열ToolStripMenuItem,
            this.가로배열ToolStripMenuItem,
            this.세로배열ToolStripMenuItem});
			this.창WToolStripMenuItem.Name = "창WToolStripMenuItem";
			this.창WToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.창WToolStripMenuItem.Text = "창(&W)";
			this.창WToolStripMenuItem.Click += new System.EventHandler(this.창ToolStripMenuItem_Click);
			// 
			// 계단식배열ToolStripMenuItem
			// 
			this.계단식배열ToolStripMenuItem.Name = "계단식배열ToolStripMenuItem";
			this.계단식배열ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.계단식배열ToolStripMenuItem.Text = "계단식 배열";
			this.계단식배열ToolStripMenuItem.Click += new System.EventHandler(this.계단식배열ToolStripMenuItem_Click);
			// 
			// 가로배열ToolStripMenuItem
			// 
			this.가로배열ToolStripMenuItem.Name = "가로배열ToolStripMenuItem";
			this.가로배열ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.가로배열ToolStripMenuItem.Text = "가로 배열";
			this.가로배열ToolStripMenuItem.Click += new System.EventHandler(this.가로배열ToolStripMenuItem_Click);
			// 
			// 세로배열ToolStripMenuItem
			// 
			this.세로배열ToolStripMenuItem.Name = "세로배열ToolStripMenuItem";
			this.세로배열ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.세로배열ToolStripMenuItem.Text = "세로 배열";
			this.세로배열ToolStripMenuItem.Click += new System.EventHandler(this.세로배열ToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(337, 296);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 파일NToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 새창NToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem 종료FToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 창WToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 계단식배열ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 가로배열ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 세로배열ToolStripMenuItem;
	}
}