using NugetPackager.Builder;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

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
            var files = Directory.GetFiles(dllPath, "*.dll");
            foreach (var file in files)
            {
                var fileName = file.Split('\\').LastOrDefault();
                var assembly = Assembly.LoadFrom(file);
                var version = assembly.GetName().Version;

                var nuspecBuilder = new NuspecBuilder(file, version.ToString());

                var nugetBuilder = new NugetBuilder(nuspecBuilder, nugetPath, $"{version}");
                nugetBuilder.Build();

                sb.AppendLine($@"create package '{fileName}' successfuly");

                txtLog.Text = sb.ToString();
                txtLog.Refresh();
            }
        }

    }
}
