
namespace PasteImageArray
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripCopy = new System.Windows.Forms.ToolStripButton();
			this.toolStripNew = new System.Windows.Forms.ToolStripButton();
			this.toolStripSave = new System.Windows.Forms.ToolStripButton();
			this.picPaste = new System.Windows.Forms.PictureBox();
			this.menuMain = new System.Windows.Forms.MenuStrip();
			this.menuMainFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuMainFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.menuMainSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.menuMainFileQuit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuMainEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuMainEditPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.menuMainEditCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.menuMainFileNew = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPaste)).BeginInit();
			this.menuMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCopy,
            this.toolStripNew,
            this.toolStripSave});
			this.toolStrip.Location = new System.Drawing.Point(0, 28);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(494, 27);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip";
			// 
			// toolStripCopy
			// 
			this.toolStripCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripCopy.Image = global::PasteImageArray.Properties.Resources.Copy_16x;
			this.toolStripCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripCopy.Name = "toolStripCopy";
			this.toolStripCopy.Size = new System.Drawing.Size(29, 24);
			this.toolStripCopy.Text = "toolStripButton1";
			this.toolStripCopy.Click += new System.EventHandler(this.toolStripCopy_Click);
			// 
			// toolStripNew
			// 
			this.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripNew.Image = global::PasteImageArray.Properties.Resources.Document_16x;
			this.toolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripNew.Name = "toolStripNew";
			this.toolStripNew.Size = new System.Drawing.Size(29, 24);
			this.toolStripNew.Text = "toolStripButton3";
			this.toolStripNew.Click += new System.EventHandler(this.toolStripNew_Click);
			// 
			// toolStripSave
			// 
			this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSave.Image = global::PasteImageArray.Properties.Resources.SaveAs_16x;
			this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSave.Name = "toolStripSave";
			this.toolStripSave.Size = new System.Drawing.Size(29, 24);
			this.toolStripSave.Text = "toolStripButton2";
			this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
			// 
			// picPaste
			// 
			this.picPaste.Location = new System.Drawing.Point(0, 30);
			this.picPaste.Name = "picPaste";
			this.picPaste.Size = new System.Drawing.Size(16, 16);
			this.picPaste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picPaste.TabIndex = 1;
			this.picPaste.TabStop = false;
			// 
			// menuMain
			// 
			this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainFile,
            this.menuMainEdit});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new System.Drawing.Size(494, 28);
			this.menuMain.TabIndex = 2;
			this.menuMain.Text = "menuStrip1";
			// 
			// menuMainFile
			// 
			this.menuMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainFileNew,
            this.menuMainFileSave,
            this.menuMainSeparator,
            this.menuMainFileQuit});
			this.menuMainFile.Name = "menuMainFile";
			this.menuMainFile.Size = new System.Drawing.Size(82, 24);
			this.menuMainFile.Text = "ファイル(&F)";
			// 
			// menuMainFileSave
			// 
			this.menuMainFileSave.Name = "menuMainFileSave";
			this.menuMainFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.menuMainFileSave.Size = new System.Drawing.Size(224, 26);
			this.menuMainFileSave.Text = "保存(&S)";
			this.menuMainFileSave.Click += new System.EventHandler(this.menuMainFileSave_Click);
			// 
			// menuMainSeparator
			// 
			this.menuMainSeparator.Name = "menuMainSeparator";
			this.menuMainSeparator.Size = new System.Drawing.Size(221, 6);
			// 
			// menuMainFileQuit
			// 
			this.menuMainFileQuit.Name = "menuMainFileQuit";
			this.menuMainFileQuit.Size = new System.Drawing.Size(224, 26);
			this.menuMainFileQuit.Text = "終了(&Q)";
			this.menuMainFileQuit.Click += new System.EventHandler(this.menuMainFileQuit_Click);
			// 
			// menuMainEdit
			// 
			this.menuMainEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainEditPaste,
            this.menuMainEditCopy});
			this.menuMainEdit.Name = "menuMainEdit";
			this.menuMainEdit.Size = new System.Drawing.Size(71, 24);
			this.menuMainEdit.Text = "編集(&E)";
			// 
			// menuMainEditPaste
			// 
			this.menuMainEditPaste.Name = "menuMainEditPaste";
			this.menuMainEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.menuMainEditPaste.Size = new System.Drawing.Size(224, 26);
			this.menuMainEditPaste.Text = "ペースト(&P)";
			this.menuMainEditPaste.Click += new System.EventHandler(this.menuMainEditPaste_Click);
			// 
			// menuMainEditCopy
			// 
			this.menuMainEditCopy.Name = "menuMainEditCopy";
			this.menuMainEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.menuMainEditCopy.Size = new System.Drawing.Size(224, 26);
			this.menuMainEditCopy.Text = "コピー(&C)";
			this.menuMainEditCopy.Click += new System.EventHandler(this.menuMainEditCopy_Click);
			// 
			// menuMainFileNew
			// 
			this.menuMainFileNew.Name = "menuMainFileNew";
			this.menuMainFileNew.Size = new System.Drawing.Size(224, 26);
			this.menuMainFileNew.Text = "新規作成(&N)";
			this.menuMainFileNew.Click += new System.EventHandler(this.menuMainFileNew_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(494, 465);
			this.Controls.Add(this.picPaste);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.menuMain);
			this.MainMenuStrip = this.menuMain;
			this.MinimumSize = new System.Drawing.Size(512, 512);
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "クリップボード画像配置";
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPaste)).EndInit();
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton toolStripCopy;
		private System.Windows.Forms.ToolStripButton toolStripSave;
		private System.Windows.Forms.PictureBox picPaste;
		private System.Windows.Forms.ToolStripButton toolStripNew;
		private System.Windows.Forms.MenuStrip menuMain;
		private System.Windows.Forms.ToolStripMenuItem menuMainFile;
		private System.Windows.Forms.ToolStripMenuItem menuMainFileSave;
		private System.Windows.Forms.ToolStripSeparator menuMainSeparator;
		private System.Windows.Forms.ToolStripMenuItem menuMainFileQuit;
		private System.Windows.Forms.ToolStripMenuItem menuMainEdit;
		private System.Windows.Forms.ToolStripMenuItem menuMainEditPaste;
		private System.Windows.Forms.ToolStripMenuItem menuMainEditCopy;
		private System.Windows.Forms.ToolStripMenuItem menuMainFileNew;
	}
}

