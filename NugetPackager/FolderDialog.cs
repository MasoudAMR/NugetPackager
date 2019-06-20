using System;
using System.Windows.Forms;

namespace NugetPackager
{
    public partial class FolderDialog : UserControl
    {
        public string Label { get => lblDesc.Text; set => lblDesc.Text = value; }
        public string Path { get => txtPath.Text; set => txtPath.Text = value; }
        public FolderDialog()
        {
            InitializeComponent();
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                }
            }
        }
        private void TxtPath_TextChanged(object sender, System.EventArgs e)
        {
            OnSelectFolder?.Invoke(sender);
        }
        public delegate void OnSelectFolderHandler(object sender);
        public event OnSelectFolderHandler OnSelectFolder;
    }
}
