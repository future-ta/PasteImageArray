using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Drawing.Imaging;

namespace PasteImageArray
{
	public partial class MainForm : Form
	{

		private Bitmap m_bmp = null;
		public MainForm()
		{
			InitializeComponent();
		}

		private void pasteImage()
		{
			//	イメージがある？
			if (Clipboard.ContainsImage() == false)
			{
				return;
			}

			Image img = Clipboard.GetImage();
			if (img == null)
			{
				return;
			}

			//	初期状態？
			if (m_bmp == null)
			{
				m_bmp = new Bitmap(img, img.Width, img.Height);

				//	単純に貼り付ける
				picPaste.Image = m_bmp;
				return;
			}

			//	新規にビットマップを生成
			Bitmap bmp = new Bitmap(m_bmp.Width + img.Width, Math.Max(m_bmp.Height, img.Height));

			//	イメージを描画
			Graphics gr = Graphics.FromImage(bmp);
			gr.DrawImage(m_bmp, new Point(0, 0));
			gr.DrawImage(img, new Point(m_bmp.Width, 0));
			m_bmp = bmp;
			picPaste.Image = bmp;
		}

		private void copyImage()
		{
			if (m_bmp == null)
			{
				return;
			}
			Clipboard.SetImage(m_bmp);
		}

		private void newImage()
		{
			m_bmp = null;
			picPaste.Image = null;
		}
		private void saveImage()
		{
			if (m_bmp == null)
			{
				return;
			}

			FileDialog dlg = new SaveFileDialog();
			dlg.FileName = "新規ファイル.bmp";
			dlg.Filter = "ビットマップ(*.bmp)|*.bmp|PNGファイル(*.png)|*.png|JPEGファイル(*.jpg)|*.jpg";
			dlg.RestoreDirectory = true;
			if (dlg.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			//	拡張子で判定
			string strExt = System.IO.Path.GetExtension(dlg.FileName);
			ImageFormat fmt = null;
			if (String.Compare(strExt, ".bmp", true) == 0)
			{
				fmt = ImageFormat.Bmp;
			}
			else if (String.Compare(strExt, ".png", true) == 0)
			{
				fmt = ImageFormat.Png;
			}
			else if (String.Compare(strExt, ".jpg", true) == 0)
			{
				fmt = ImageFormat.Jpeg;
			}
			m_bmp.Save(dlg.FileName, fmt);
		}

		private void toolStripCopy_Click(object sender, EventArgs e)
		{
			copyImage();
		}

		private void toolStripNew_Click(object sender, EventArgs e)
		{
			newImage();
		}

		private void toolStripSave_Click(object sender, EventArgs e)
		{
			saveImage();
		}

		private void menuMainFileQuit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void menuMainFileSave_Click(object sender, EventArgs e)
		{
			saveImage();
		}

		private void menuMainEditPaste_Click(object sender, EventArgs e)
		{
			pasteImage();
		}

		private void menuMainEditCopy_Click(object sender, EventArgs e)
		{
			copyImage();
		}

		private void menuMainFileNew_Click(object sender, EventArgs e)
		{
			newImage();
		}
	}
}
