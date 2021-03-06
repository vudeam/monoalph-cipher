﻿using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Monoalphabet
{
	public class StartForm : Form
	{
		private System.ComponentModel.Container components = null;
		public String strOrigAlphabet;
		public String strCiphAlphabet;
		public String strToEncrypt;
		public Dictionary<Char, Char> dictionary;
		public Dictionary<Char, Char> decryptionary;
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
		private PictureBox lockDecryptImage;
		public Regex englishLetters;

		public StartForm()
		{
			this.InitializeComponent();

			this.strOrigAlphabet = "abcdefghijklmnopqrstuvwxyz";
			this.strCiphAlphabet = "spokycareltnbdfghijmquvwxz";
			this.strToEncrypt = String.Empty;
			this.toEncryptTextbox.ReadOnly = true;
			this.dictionary = new Dictionary<Char, Char>(26);
			this.decryptionary = new Dictionary<Char, Char>(26);
			this.makeDictionary();

			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(this.ciphAlphabetTextbox, "Cipher alphabet input field");
			toolTip.SetToolTip(this.toEncryptTextbox, "Input text to encrypt here");
			toolTip.SetToolTip(this.encryptedTextTextbox, "Copy the encrypted text from here");
			toolTip.SetToolTip(this.lockEncryptImage, "Click to encrypt text from the left textbox");
			toolTip.SetToolTip(this.lockDecryptImage, "Click to decrypt text in the right textbox");
			
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
			this.lockDecryptImage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.keyImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.openLockImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closedLockImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lockEncryptImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lockDecryptImage)).BeginInit();
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
			this.toEncryptTextbox.MaxLength = 1000;
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
			this.encryptedTextTextbox.MaxLength = 1000;
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
			// lockDecryptImage
			// 
			this.lockDecryptImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lockDecryptImage.Image = ((System.Drawing.Image)(resources.GetObject("lockDecryptImage.Image")));
			this.lockDecryptImage.Location = new System.Drawing.Point(466, 328);
			this.lockDecryptImage.Name = "lockDecryptImage";
			this.lockDecryptImage.Size = new System.Drawing.Size(80, 80);
			this.lockDecryptImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.lockDecryptImage.TabIndex = 10;
			this.lockDecryptImage.TabStop = false;
			this.lockDecryptImage.Click += new System.EventHandler(this.lockDecryptImage_Click);
			// 
			// StartForm
			// 
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(1008, 537);
			this.Controls.Add(this.lockDecryptImage);
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
			this.Text = "Monoalphabetic Cipher Implementation";
			((System.ComponentModel.ISupportInitialize)(this.keyImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.openLockImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closedLockImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lockEncryptImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lockDecryptImage)).EndInit();
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

	private Boolean validateCipherAlphabet(String candidate)
		{
			Boolean isValid = true;
			Console.Clear();

			foreach (Char c in candidate)
			{
				if (!Char.IsWhiteSpace(Char.ToLower(c)) && (Char.IsLetterOrDigit(Char.ToLower(c)) || Char.IsSymbol(Char.ToLower(c))))
				{
					isValid &= true;

					Console.WriteLine("Symbol '{0}' is correct", c);
				}
				else
				{
					isValid &= false;

					Console.WriteLine("Symbol '{0}' is not correct", c);
				}
			}

			isValid &= candidate.Equals(new String(candidate.Distinct().ToArray()));

			Console.WriteLine("candidate.Equals(new String(candidate.Distinct().ToArray())) = {0}", candidate.Equals(new String(candidate.Distinct().ToArray())));

			return isValid;

		}

		private void ciphAlphabetTextbox_TextChanged(object sender, EventArgs e)
		{
			if (this.ciphAlphabetTextbox.TextLength == 26)
			{
				if (validateCipherAlphabet(this.ciphAlphabetTextbox.Text))
				{
					this.incorrectCipherAlphabetLabel.Visible = false;
					this.correctCipherAlphabetLabel.Visible = true;

					makeDictionary();

					this.toEncryptTextbox.ReadOnly = false;
					this.toEncryptTextbox.Focus();
				}
				else
				{
					this.incorrectCipherAlphabetLabel.Visible = true;
					this.correctCipherAlphabetLabel.Visible = false;
					this.toEncryptTextbox.ReadOnly = true;
				}
			}
			else
			{
				this.toEncryptTextbox.Clear();
				this.toEncryptTextbox.ReadOnly = true;
			}

			return;
		}

		private void toEncryptTextbox_Click(object sender, EventArgs e)
		{
			if (this.toEncryptTextbox.ReadOnly)
			{
				MessageBox.Show("Invalid cipher alphabet length!\nIt must be 26 distinct English letters.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.ciphAlphabetTextbox.Focus();
			}

			return;
		}

		private void lockEncryptImage_Click(object sender, EventArgs e)
		{
			this.encryptedTextTextbox.Text = String.Empty;

			if (!String.IsNullOrEmpty(toEncryptTextbox.Text))
			{
				foreach(Char nextSymbol in this.toEncryptTextbox.Text)
				{
					if(Char.IsLetter(nextSymbol) && this.englishLetters.IsMatch(nextSymbol.ToString()))
					{
						this.encryptedTextTextbox.Text += this.dictionary[Char.ToLower(nextSymbol)];
					}
					else
					{
						this.encryptedTextTextbox.Text += nextSymbol;
					}
				}
			}
			else
			{
				this.toEncryptTextbox.Focus();
			}

			return;
		}

		private void lockDecryptImage_Click(object sender, EventArgs e)
		{
			String encText = this.encryptedTextTextbox.Text;
			if (String.IsNullOrEmpty(this.encryptedTextTextbox.Text)) return;
			if ((this.ciphAlphabetTextbox.TextLength == 26) && validateCipherAlphabet(this.ciphAlphabetTextbox.Text))
			{
				this.encryptedTextTextbox.Clear();
				for (Int32 i = 0; i < 26; i++) this.decryptionary[this.ciphAlphabetTextbox.Text[i]] = this.strOrigAlphabet[i];
				foreach (Char c in encText)
				{
					if (Char.IsLetter(c) && this.englishLetters.IsMatch(c.ToString()))
					{
						this.encryptedTextTextbox.Text += this.decryptionary[Char.ToLower(c)];
					}
					else
					{
						this.encryptedTextTextbox.Text += c;
					}
				}
			}
			else
			{
				MessageBox.Show("Invalid cipher alphabet! It must be 26 distinct English letters.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			return;
		}
	}
}