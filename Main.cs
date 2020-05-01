using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Monoalphabet
{
	public class StartForm : Form
	{
		private System.ComponentModel.Container components = null;
		public String strOrigAlphabet;
		public String strCiphAlphabet;
		public String strToEncrypt;
		public Dictionary<Char, Char> dictionary;
		private TextBox ciphAlphabetTextbox;
		private PictureBox keyImage;
		private TextBox toEncryptTextbox;
		private TextBox encryptedTextTextbox;
		private PictureBox openLockImage;
		private PictureBox closedLockImage;
		private Label incorrectCipherAlphabetLabel;
		private Label correctCipherAlphabetLabel;
		private PictureBox lockEncryptImage;
		private Label copyrightLabel;
		public Regex englishLetters;

		public StartForm()
		{
			this.InitializeComponent();

			this.strOrigAlphabet = "abcdefghijklmnopqrstuvwxyz";
			this.strCiphAlphabet = "spokycareltnbdfghijmquvwxz";
			this.strToEncrypt = String.Empty;
			this.toEncryptTextbox.ReadOnly = true;
			this.dictionary = new Dictionary<char, char>(26);
			this.makeDictionary();

			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip((Control)this.ciphAlphabetTextbox, "Cipher alphabet input field");
			toolTip.SetToolTip((Control)this.toEncryptTextbox, "Input (or drop a .txt file) text to encrypt here");
			toolTip.SetToolTip((Control)this.encryptedTextTextbox, "Copy the encrypted text from here");
			toolTip.SetToolTip((Control)this.lockEncryptImage, "Click to encrypt text from the left textbox");
			
			this.englishLetters = new Regex("[a-zA-Z]", RegexOptions.Compiled);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
			this.ciphAlphabetTextbox = new System.Windows.Forms.TextBox();
			this.keyImage = new System.Windows.Forms.PictureBox();
			this.toEncryptTextbox = new System.Windows.Forms.TextBox();
			this.encryptedTextTextbox = new System.Windows.Forms.TextBox();
			this.openLockImage = new System.Windows.Forms.PictureBox();
			this.closedLockImage = new System.Windows.Forms.PictureBox();
			this.incorrectCipherAlphabetLabel = new System.Windows.Forms.Label();
			this.correctCipherAlphabetLabel = new System.Windows.Forms.Label();
			this.lockEncryptImage = new System.Windows.Forms.PictureBox();
			this.copyrightLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.keyImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.openLockImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closedLockImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lockEncryptImage)).BeginInit();
			this.SuspendLayout();
			// 
			// ciphAlphabetTextbox
			// 
			this.ciphAlphabetTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ciphAlphabetTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.ciphAlphabetTextbox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ciphAlphabetTextbox.Location = new System.Drawing.Point(360, 30);
			this.ciphAlphabetTextbox.MaxLength = 26;
			this.ciphAlphabetTextbox.Name = "ciphAlphabetTextbox";
			this.ciphAlphabetTextbox.Size = new System.Drawing.Size(286, 31);
			this.ciphAlphabetTextbox.TabIndex = 0;
			this.ciphAlphabetTextbox.TextChanged += new System.EventHandler(this.ciphAlphabetTextbox_TextChanged);
			// 
			// keyImage
			// 
			this.keyImage.Image = global::Monoalphabet.Properties.Resources.Key2;
			this.keyImage.Location = new System.Drawing.Point(229, 0);
			this.keyImage.Name = "keyImage";
			this.keyImage.Size = new System.Drawing.Size(116, 85);
			this.keyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.keyImage.TabIndex = 1;
			this.keyImage.TabStop = false;
			// 
			// toEncryptTextbox
			// 
			this.toEncryptTextbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toEncryptTextbox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.toEncryptTextbox.Location = new System.Drawing.Point(12, 80);
			this.toEncryptTextbox.Multiline = true;
			this.toEncryptTextbox.Name = "toEncryptTextbox";
			this.toEncryptTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.toEncryptTextbox.Size = new System.Drawing.Size(420, 360);
			this.toEncryptTextbox.TabIndex = 1;
			this.toEncryptTextbox.Click += new System.EventHandler(this.toEncryptTextbox_Click);
			// 
			// encryptedTextTextbox
			// 
			this.encryptedTextTextbox.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.encryptedTextTextbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.encryptedTextTextbox.Location = new System.Drawing.Point(576, 80);
			this.encryptedTextTextbox.Multiline = true;
			this.encryptedTextTextbox.Name = "encryptedTextTextbox";
			this.encryptedTextTextbox.ReadOnly = true;
			this.encryptedTextTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.encryptedTextTextbox.Size = new System.Drawing.Size(420, 360);
			this.encryptedTextTextbox.TabIndex = 3;
			// 
			// openLockImage
			// 
			this.openLockImage.Image = global::Monoalphabet.Properties.Resources.openLock2;
			this.openLockImage.Location = new System.Drawing.Point(152, 445);
			this.openLockImage.Name = "openLockImage";
			this.openLockImage.Size = new System.Drawing.Size(92, 92);
			this.openLockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.openLockImage.TabIndex = 4;
			this.openLockImage.TabStop = false;
			// 
			// closedLockImage
			// 
			this.closedLockImage.Image = global::Monoalphabet.Properties.Resources.closedLock2;
			this.closedLockImage.Location = new System.Drawing.Point(752, 445);
			this.closedLockImage.Name = "closedLockImage";
			this.closedLockImage.Size = new System.Drawing.Size(92, 92);
			this.closedLockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.closedLockImage.TabIndex = 5;
			this.closedLockImage.TabStop = false;
			// 
			// incorrectCipherAlphabetLabel
			// 
			this.incorrectCipherAlphabetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.incorrectCipherAlphabetLabel.ForeColor = System.Drawing.Color.Red;
			this.incorrectCipherAlphabetLabel.Location = new System.Drawing.Point(652, 30);
			this.incorrectCipherAlphabetLabel.Name = "incorrectCipherAlphabetLabel";
			this.incorrectCipherAlphabetLabel.Size = new System.Drawing.Size(307, 37);
			this.incorrectCipherAlphabetLabel.TabIndex = 6;
			this.incorrectCipherAlphabetLabel.Text = "The cpher alphabet must contain exactly 26 disticnts visible characters!";
			this.incorrectCipherAlphabetLabel.Visible = false;
			// 
			// correctCipherAlphabetLabel
			// 
			this.correctCipherAlphabetLabel.AutoSize = true;
			this.correctCipherAlphabetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.correctCipherAlphabetLabel.ForeColor = System.Drawing.Color.Green;
			this.correctCipherAlphabetLabel.Location = new System.Drawing.Point(652, 30);
			this.correctCipherAlphabetLabel.Name = "correctCipherAlphabetLabel";
			this.correctCipherAlphabetLabel.Size = new System.Drawing.Size(215, 16);
			this.correctCipherAlphabetLabel.TabIndex = 7;
			this.correctCipherAlphabetLabel.Text = "The cipher alphabet is correct";
			this.correctCipherAlphabetLabel.Visible = false;
			// 
			// lockEncryptImage
			// 
			this.lockEncryptImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lockEncryptImage.Image = global::Monoalphabet.Properties.Resources.Lock2;
			this.lockEncryptImage.Location = new System.Drawing.Point(440, 190);
			this.lockEncryptImage.Name = "lockEncryptImage";
			this.lockEncryptImage.Size = new System.Drawing.Size(132, 132);
			this.lockEncryptImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.lockEncryptImage.TabIndex = 8;
			this.lockEncryptImage.TabStop = false;
			this.lockEncryptImage.Click += new System.EventHandler(this.lockEncryptImage_Click);
			// 
			// copyrightLabel
			// 
			this.copyrightLabel.AutoSize = true;
			this.copyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.copyrightLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.copyrightLabel.Location = new System.Drawing.Point(885, 515);
			this.copyrightLabel.Name = "copyrightLabel";
			this.copyrightLabel.Size = new System.Drawing.Size(110, 13);
			this.copyrightLabel.TabIndex = 9;
			this.copyrightLabel.Text = "(Artwork)© Beta, 2020";
			// 
			// StartForm
			// 
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(1008, 537);
			this.Controls.Add(this.copyrightLabel);
			this.Controls.Add(this.lockEncryptImage);
			this.Controls.Add(this.correctCipherAlphabetLabel);
			this.Controls.Add(this.incorrectCipherAlphabetLabel);
			this.Controls.Add(this.closedLockImage);
			this.Controls.Add(this.openLockImage);
			this.Controls.Add(this.encryptedTextTextbox);
			this.Controls.Add(this.toEncryptTextbox);
			this.Controls.Add(this.keyImage);
			this.Controls.Add(this.ciphAlphabetTextbox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "StartForm";
			this.Text = "Monoalphabet Cipher Implementation";
			((System.ComponentModel.ISupportInitialize)(this.keyImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.openLockImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closedLockImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lockEncryptImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new StartForm());

			return;
		}

		private void makeDictionary()
		{
			this.strCiphAlphabet = this.ciphAlphabetTextbox.Text;
			
			for (Int32 i = 0; i < this.strCiphAlphabet.Length; i++)
			{
				this.dictionary[this.strOrigAlphabet[i]] = this.strCiphAlphabet[i];
			}
			return;
		}

		private void ciphAlphabetTextbox_TextChanged(object sender, EventArgs e)
		{

		}

		private void toEncryptTextbox_Click(object sender, EventArgs e)
		{

		}

		private void lockEncryptImage_Click(object sender, EventArgs e)
		{

		}
	}
}