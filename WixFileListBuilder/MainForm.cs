using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WixFileListBuilder
{
    public partial class MainForm : Form
    {
        private string path = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
                lPath.Text = path;
            }
        }

        private void bGenerate_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            var masks = tbMask.Text.Split(new[] {'|'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var mask in masks)
            {
                string[] files = Directory.GetFiles(path, mask, SearchOption.TopDirectoryOnly);
                foreach (var file in files)
                {
                    string name = Path.GetFileName(file);
                    if (name != null)
                    {
                        result.AppendLine("<File Id=\"" + name.ToUpper() + "\" Name=\"" + name + "\"/>");
                    }
                }
            }
            

            tbResult.Text = result.ToString();
        }
    }
}
