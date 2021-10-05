using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BugCheckHackUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
		private void Apply_Click(object sender, EventArgs e)
		{
            RegistryKey softwareKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            RegistryKey bugCheckHack = softwareKey.GetSubKeyNames().Contains("BugCheckHack") ? softwareKey.OpenSubKey("SOFTWARE\\BugCheckHack", RegistryKeyPermissionCheck.ReadWriteSubTree) : softwareKey.CreateSubKey("SOFTWARE\\BugCheckHack", writable: true);
            bugCheckHack.SetValue("Emoticon", emoticonTextBox.Text);
			bugCheckHack.SetValue("StringOne", stringOneTextBox.Text);
			bugCheckHack.SetValue("StringTwo", stringTwoTextBox.Text);
			bugCheckHack.SetValue("WebsiteUrl", websiteTextBox.Text);
			bugCheckHack.SetValue("CalledSupport", calledSupportTextBox.Text);
			bugCheckHack.SetValue("PossibleFixes", possibleFixesTextBox.Text);
			if(uint.TryParse(colorTextBox.Text, out var color))
			{
				bugCheckHack.SetValue("Color", color, RegistryValueKind.DWord);
			}
			bugCheckHack.Close();
			softwareKey.Close();
		}

		private void enableTestSigning_Click(object sender, EventArgs e)
		{
			Process.Start(new ProcessStartInfo("bcdedit.exe", "/set testsigning on")
			{
				Verb = "runas"
			});
		}

		private void disableTestSigning_Click(object sender, EventArgs e)
		{
			Process.Start(new ProcessStartInfo("bcdedit.exe", "/set testsigning off")
			{
				Verb = "runas"
			});
		}

		private void createService_Click(object sender, EventArgs e)
		{
			if(DialogResult.OK == driverOpenFileDialog.ShowDialog())
			{
				Process p = Process.Start(new ProcessStartInfo("sc", "create BugCheckHack binPath=" + driverOpenFileDialog.FileName + " type=kernel start=auto")
				{
					UseShellExecute = false,
					Verb = "runas",
					RedirectStandardOutput = true,
					RedirectStandardError = true
				});
				MessageBox.Show(p.StandardOutput.ReadToEnd() + "\n" + p.StandardError.ReadToEnd());
			}
		}

		private void deleteService_Click(object sender, EventArgs e)
		{
			Process p = Process.Start(new ProcessStartInfo("sc", "delete BugCheckHack")
			{
				UseShellExecute = false,
				Verb = "runas",
				RedirectStandardOutput = true,
				RedirectStandardError = true
			});
			MessageBox.Show(p.StandardOutput.ReadToEnd() + "\n" + p.StandardError.ReadToEnd());
		}

		private void startService_Click(object sender, EventArgs e)
		{
			Process p = Process.Start(new ProcessStartInfo("sc", "start BugCheckHack")
			{
				UseShellExecute = false,
				Verb = "runas",
				RedirectStandardOutput = true,
				RedirectStandardError = true
			});
			MessageBox.Show(p.StandardOutput.ReadToEnd() + "\n" + p.StandardError.ReadToEnd());
		}

		private void stopService_Click(object sender, EventArgs e)
		{
			Process p = Process.Start(new ProcessStartInfo("sc", "stop BugCheckHack")
			{
				UseShellExecute = false,
				Verb = "runas",
				RedirectStandardOutput = true,
				RedirectStandardError = true
			});
			MessageBox.Show(p.StandardOutput.ReadToEnd() + "\n" + p.StandardError.ReadToEnd());
		}

		private void selectColor_Click(object sender, EventArgs e)
		{
			if(DialogResult.OK == colorDialog.ShowDialog())
			{
				selectColor.BackColor = colorDialog.Color;
				colorTextBox.Text = HexConverter(colorDialog.Color);
			}
		}

		private void colorTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				selectColor.BackColor = (Color)new ColorConverter().ConvertFromString("#" + colorTextBox.Text);
			}
			catch(Exception)
			{
				MessageBox.Show("Invalid HEX color", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private static string HexConverter(Color c)
		{
			return c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
		}

		private void aboutButton_Click(object sender, EventArgs e)
		{
			new AboutBox().ShowDialog();
		}
	}
}
