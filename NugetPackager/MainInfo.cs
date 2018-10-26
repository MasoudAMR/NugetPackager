using System;

namespace NugetPackager
{
    public static class MainInfo
    {
        public static string NugetAppDirectory => $@"{AppDomain.CurrentDomain.BaseDirectory}\Resources";
        public static string NugetAppPath => $@"{NugetAppDirectory}\nuget.exe";
        public static string NuspecOutputPath => $@"{AppDomain.CurrentDomain.BaseDirectory}\Output";
        public static string Author => $@"Masoud Hosseini";
        public static string CopyRight => $@"Copyright ©  2018";
        public static object TargetPath => $@"lib\monoandroid81";
    }
}
