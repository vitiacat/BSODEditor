
using System.Windows.Forms;

namespace BugCheckHackUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

		private Label label1;

		private TextBox emoticonTextBox;

		private TextBox stringOneTextBox;

		private Label label2;

		private TextBox websiteTextBox;

		private Label label3;

		private TextBox stringTwoTextBox;

		private Label label4;

		private Button Apply;

		private TextBox possibleFixesTextBox;

		private Label label5;

		private TextBox calledSupportTextBox;

		private Label label6;

		private Button enableTestSigning;

		private Button disableTestSigning;

		private Button deleteService;

		private Button createService;

		private Button stopService;

		private Button startService;

		private OpenFileDialog driverOpenFileDialog;

		private Label label7;

		private TextBox colorTextBox;

		private Button selectColor;

		private ColorDialog colorDialog;

		private Button aboutButton;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && components != null)
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
			label1 = new System.Windows.Forms.Label();
			emoticonTextBox = new System.Windows.Forms.TextBox();
			stringOneTextBox = new System.Windows.Forms.TextBox();
			label2 = new System.Windows.Forms.Label();
			websiteTextBox = new System.Windows.Forms.TextBox();
			label3 = new System.Windows.Forms.Label();
			stringTwoTextBox = new System.Windows.Forms.TextBox();
			label4 = new System.Windows.Forms.Label();
			Apply = new System.Windows.Forms.Button();
			possibleFixesTextBox = new System.Windows.Forms.TextBox();
			label5 = new System.Windows.Forms.Label();
			calledSupportTextBox = new System.Windows.Forms.TextBox();
			label6 = new System.Windows.Forms.Label();
			enableTestSigning = new System.Windows.Forms.Button();
			disableTestSigning = new System.Windows.Forms.Button();
			deleteService = new System.Windows.Forms.Button();
			createService = new System.Windows.Forms.Button();
			stopService = new System.Windows.Forms.Button();
			startService = new System.Windows.Forms.Button();
			driverOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			label7 = new System.Windows.Forms.Label();
			colorTextBox = new System.Windows.Forms.TextBox();
			selectColor = new System.Windows.Forms.Button();
			colorDialog = new System.Windows.Forms.ColorDialog();
			aboutButton = new System.Windows.Forms.Button();
			SuspendLayout();
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(4, 12);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(54, 13);
			label1.TabIndex = 0;
			label1.Text = "Emoticon:";
			emoticonTextBox.Location = new System.Drawing.Point(60, 10);
			emoticonTextBox.Name = "emoticonTextBox";
			emoticonTextBox.Size = new System.Drawing.Size(294, 20);
			emoticonTextBox.TabIndex = 1;
			emoticonTextBox.Text = ":C";
			stringOneTextBox.Location = new System.Drawing.Point(64, 36);
			stringOneTextBox.Name = "stringOneTextBox";
			stringOneTextBox.Size = new System.Drawing.Size(290, 20);
			stringOneTextBox.TabIndex = 3;
			stringOneTextBox.Text = "Haha!";
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(4, 38);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(58, 13);
			label2.TabIndex = 2;
			label2.Text = "String one:";
			websiteTextBox.Location = new System.Drawing.Point(76, 87);
			websiteTextBox.Name = "websiteTextBox";
			websiteTextBox.Size = new System.Drawing.Size(278, 20);
			websiteTextBox.TabIndex = 7;
			websiteTextBox.Text = "https://example.com";
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(4, 89);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(74, 13);
			label3.TabIndex = 6;
			label3.Text = "Website URL:";
			stringTwoTextBox.Location = new System.Drawing.Point(62, 61);
			stringTwoTextBox.Name = "stringTwoTextBox";
			stringTwoTextBox.Size = new System.Drawing.Size(292, 20);
			stringTwoTextBox.TabIndex = 5;
			stringTwoTextBox.Text = "Bruh.";
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(4, 63);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(58, 13);
			label4.TabIndex = 4;
			label4.Text = "StringTwo:";
			Apply.Location = new System.Drawing.Point(287, 248);
			Apply.Name = "Apply";
			Apply.Size = new System.Drawing.Size(75, 23);
			Apply.TabIndex = 8;
			Apply.Text = "Apply";
			Apply.UseVisualStyleBackColor = true;
			Apply.Click += new System.EventHandler(Apply_Click);
			possibleFixesTextBox.Location = new System.Drawing.Point(79, 141);
			possibleFixesTextBox.Name = "possibleFixesTextBox";
			possibleFixesTextBox.Size = new System.Drawing.Size(278, 20);
			possibleFixesTextBox.TabIndex = 12;
			possibleFixesTextBox.Text = "fix me";
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(4, 143);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(73, 13);
			label5.TabIndex = 11;
			label5.Text = "PossibleFixes:";
			calledSupportTextBox.Location = new System.Drawing.Point(78, 115);
			calledSupportTextBox.Name = "calledSupportTextBox";
			calledSupportTextBox.Size = new System.Drawing.Size(277, 20);
			calledSupportTextBox.TabIndex = 10;
			calledSupportTextBox.Text = "880553535";
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(4, 117);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(76, 13);
			label6.TabIndex = 9;
			label6.Text = "CalledSupport:";
			enableTestSigning.Location = new System.Drawing.Point(5, 193);
			enableTestSigning.Name = "enableTestSigning";
			enableTestSigning.Size = new System.Drawing.Size(111, 23);
			enableTestSigning.TabIndex = 13;
			enableTestSigning.Text = "Enable TestSigning";
			enableTestSigning.UseVisualStyleBackColor = true;
			enableTestSigning.Click += new System.EventHandler(enableTestSigning_Click);
			disableTestSigning.Location = new System.Drawing.Point(5, 220);
			disableTestSigning.Name = "disableTestSigning";
			disableTestSigning.Size = new System.Drawing.Size(111, 23);
			disableTestSigning.TabIndex = 14;
			disableTestSigning.Text = "Disable TestSigning";
			disableTestSigning.UseVisualStyleBackColor = true;
			disableTestSigning.Click += new System.EventHandler(disableTestSigning_Click);
			deleteService.Location = new System.Drawing.Point(122, 220);
			deleteService.Name = "deleteService";
			deleteService.Size = new System.Drawing.Size(111, 23);
			deleteService.TabIndex = 16;
			deleteService.Text = "Delete Service";
			deleteService.UseVisualStyleBackColor = true;
			deleteService.Click += new System.EventHandler(deleteService_Click);
			createService.Location = new System.Drawing.Point(122, 193);
			createService.Name = "createService";
			createService.Size = new System.Drawing.Size(111, 23);
			createService.TabIndex = 15;
			createService.Text = "Create Service";
			createService.UseVisualStyleBackColor = true;
			createService.Click += new System.EventHandler(createService_Click);
			stopService.Location = new System.Drawing.Point(239, 220);
			stopService.Name = "stopService";
			stopService.Size = new System.Drawing.Size(111, 23);
			stopService.TabIndex = 18;
			stopService.Text = "Stop Service";
			stopService.UseVisualStyleBackColor = true;
			stopService.Click += new System.EventHandler(stopService_Click);
			startService.Location = new System.Drawing.Point(239, 193);
			startService.Name = "startService";
			startService.Size = new System.Drawing.Size(111, 23);
			startService.TabIndex = 17;
			startService.Text = "Start Service";
			startService.UseVisualStyleBackColor = true;
			startService.Click += new System.EventHandler(startService_Click);
			driverOpenFileDialog.FileName = "BugCheckHack.sys";
			driverOpenFileDialog.Filter = "Drivers files|*.sys";
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(5, 164);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(34, 13);
			label7.TabIndex = 19;
			label7.Text = "Color:";
			colorTextBox.Location = new System.Drawing.Point(41, 163);
			colorTextBox.Name = "colorTextBox";
			colorTextBox.Size = new System.Drawing.Size(282, 20);
			colorTextBox.TabIndex = 20;
			colorTextBox.Text = "FFFFFF";
			colorTextBox.TextChanged += new System.EventHandler(colorTextBox_TextChanged);
			selectColor.BackColor = System.Drawing.Color.White;
			selectColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			selectColor.Location = new System.Drawing.Point(329, 162);
			selectColor.Name = "selectColor";
			selectColor.Size = new System.Drawing.Size(28, 23);
			selectColor.TabIndex = 21;
			selectColor.UseVisualStyleBackColor = false;
			selectColor.Click += new System.EventHandler(selectColor_Click);
			colorDialog.Color = System.Drawing.Color.White;
			colorDialog.FullOpen = true;
			aboutButton.Location = new System.Drawing.Point(206, 248);
			aboutButton.Name = "aboutButton";
			aboutButton.Size = new System.Drawing.Size(75, 23);
			aboutButton.TabIndex = 22;
			aboutButton.Text = "About";
			aboutButton.UseVisualStyleBackColor = true;
			aboutButton.Click += new System.EventHandler(aboutButton_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(366, 272);
			base.Controls.Add(aboutButton);
			base.Controls.Add(selectColor);
			base.Controls.Add(colorTextBox);
			base.Controls.Add(label7);
			base.Controls.Add(stopService);
			base.Controls.Add(startService);
			base.Controls.Add(deleteService);
			base.Controls.Add(createService);
			base.Controls.Add(disableTestSigning);
			base.Controls.Add(enableTestSigning);
			base.Controls.Add(possibleFixesTextBox);
			base.Controls.Add(label5);
			base.Controls.Add(calledSupportTextBox);
			base.Controls.Add(label6);
			base.Controls.Add(Apply);
			base.Controls.Add(websiteTextBox);
			base.Controls.Add(label3);
			base.Controls.Add(stringTwoTextBox);
			base.Controls.Add(label4);
			base.Controls.Add(stringOneTextBox);
			base.Controls.Add(label2);
			base.Controls.Add(emoticonTextBox);
			base.Controls.Add(label1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Form1";
			Text = "BSOD Editor (BugCheckHack UI)";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
	}
}