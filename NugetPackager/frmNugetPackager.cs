using NugetPackager.Builder;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace NugetPackager
{
    public partial class FrmNugetPackager : Form
    {
        public FrmNugetPackager()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            var dllPath = fldDllPath.Path;
            var nugetPath = fldNugetPath.Path;

            foreach (var fileName in clbDll.CheckedItems)
            {
                var file = $@"{dllPath}\{fileName}";

                byte[] b = File.ReadAllBytes(file);
                byte[] fb = new byte[b.Length];
                b.CopyTo(fb, 0);
                var assembly = Assembly.Load(fb);
                var version = assembly.GetName().Version;

                try
                {
                    var nuspecBuilder = new NuspecBuilder(file, version.ToString());

                    var nugetBuilder = new NugetBuilder(nuspecBuilder, nugetPath, $"{version}");
                    nugetBuilder.Build();

                    sb.AppendLine($@"create package '{fileName}' successfuly");
                }
                catch (Exception ex)
                {
                    string getMessage(Exception exception)
                    {
                        if (exception == null)
                            return "";
                        return $@"{exception.Message} -> {getMessage(exception.InnerException)}";
                    }
                    sb.AppendLine($"create package '{fileName}' failed -> {getMessage(ex)}");
                }
                
                txtLog.Text = sb.ToString();
                txtLog.Refresh();
            }

            sb.AppendLine("Finish...");
            txtLog.Text = sb.ToString();
        }

        public void FldDllPath_OnSelectFolder(object sender)
        {
            clbDll.Items.Clear();
            if (!Directory.Exists(fldDllPath.Path)) return;
            var files = Directory.GetFiles(fldDllPath.Path, "*.dll");
            clbDll.Items.AddRange(files.Select(x => x.Split('\\').LastOrDefault()).ToArray());
        }

    }
}
