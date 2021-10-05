
using System.Windows.Forms;

namespace BugCheckHackUI
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label label1;

        private Label label2;

        private LinkLabel linkLabel1;

        private LinkLabel linkLabel2;

        private Label label3;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
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
			label2 = new System.Windows.Forms.Label();
			linkLabel1 = new System.Windows.Forms.LinkLabel();
			linkLabel2 = new System.Windows.Forms.LinkLabel();
			label3 = new System.Windows.Forms.Label();
			SuspendLayout();
			label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25f);
			label1.Location = new System.Drawing.Point(8, 8);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(423, 58);
			label1.TabIndex = 0;
			label1.Text = "BSOD Editor - интерфейс для работы с программой-службой BugCheckHack, которая позволяет сделать BSOD в своём стиле.";
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25f);
			label2.Location = new System.Drawing.Point(11, 70);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(204, 16);
			label2.TabIndex = 1;
			label2.Text = "Автор BugCheckHack: NSG650 ";
			linkLabel1.AutoSize = true;
			linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25f);
			linkLabel1.Location = new System.Drawing.Point(212, 70);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new System.Drawing.Size(49, 16);
			linkLabel1.TabIndex = 2;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "GitHub";
			linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
			linkLabel2.AutoSize = true;
			linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25f);
			linkLabel2.Location = new System.Drawing.Point(285, 100);
			linkLabel2.Name = "linkLabel2";
			linkLabel2.Size = new System.Drawing.Size(49, 16);
			linkLabel2.TabIndex = 4;
			linkLabel2.TabStop = true;
			linkLabel2.Text = "GitHub";
			linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked);
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25f);
			label3.Location = new System.Drawing.Point(12, 99);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(272, 16);
			label3.TabIndex = 3;
			label3.Text = "Автор данной программы: VitiaCatDragon";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(425, 133);
			base.Controls.Add(linkLabel2);
			base.Controls.Add(label3);
			base.Controls.Add(linkLabel1);
			base.Controls.Add(label2);
			base.Controls.Add(label1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AboutBox";
			base.Padding = new System.Windows.Forms.Padding(9);
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "BSOD Editor: О программе";
			ResumeLayout(false);
			PerformLayout();
		}
	}

	#endregion
}