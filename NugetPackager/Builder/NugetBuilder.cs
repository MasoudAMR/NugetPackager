using System;
using System.Diagnostics;
using System.Linq;

namespace NugetPackager.Builder
{
    public class NugetBuilder
    {
        private readonly NuspecBuilder _nuspecBuilder;
        private readonly string _destPath;
        private readonly string _assemblyVersion;
        public NugetBuilder(NuspecBuilder nuspecBuilder, string destPath, string assemblyVersion)
        {
            _nuspecBuilder = nuspecBuilder;
            _destPath = destPath;
            _assemblyVersion = assemblyVersion;
        }

        public void Build()
        {
            var nuspec = _nuspecBuilder.Build();
            var fileName = nuspec.Split('\\').LastOrDefault();

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = MainInfo.NugetAppPath,
                Arguments = $@"pack {MainInfo.NuspecOutputPath}\{fileName} -version {_assemblyVersion} -OutputDirectory {_destPath}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process processTemp = new Process
            {
                StartInfo = startInfo,
                EnableRaisingEvents = true
            };
            try
            {
                processTemp.Start();
            }
            catch (Exception exception)
            {
                throw exception;
            }

            
        }
    }
}
