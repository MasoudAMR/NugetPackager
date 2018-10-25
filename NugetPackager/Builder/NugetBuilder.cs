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
            Process.Start(MainInfo.NugetAppPath, $@"pack {MainInfo.NuspecOutputPath}\{fileName} -version {_assemblyVersion} -OutputDirectory {_destPath}").WaitForExit();
        }
    }
}
