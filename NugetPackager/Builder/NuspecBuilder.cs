using System.IO;
using System.Linq;
using System.Xml;

namespace NugetPackager.Builder
{
    public class NuspecBuilder
    {
        private string _dllPath;
        private string _version;
        private string _fileName;
        private string _fileNameWithOutExtention;
        private XmlDocument _document;
        public NuspecBuilder(string dllPath, string version)
        {
            _dllPath = dllPath;
            _fileName = _dllPath.Split('\\').LastOrDefault();
            _fileNameWithOutExtention = _fileName.TrimEnd(".dll".ToCharArray());
            _version = version;
            _document = new XmlDocument();
        }
        public string Build()
        {

            var nuspecPath = $@"{ MainInfo.NuspecOutputPath }\{ _fileNameWithOutExtention}.nuspec";
            var nuspecPathWithOutExtention = $@"{ MainInfo.NuspecOutputPath }\{ _fileNameWithOutExtention}";
            if (!Directory.Exists(MainInfo.NuspecOutputPath))
                Directory.CreateDirectory(MainInfo.NuspecOutputPath);
            _document.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\"?><package> </package>");
            AddPackage();
            _document.Save(nuspecPath);

            return nuspecPath;
        }

        private void AddPackage()
        {
            var package = _document.DocumentElement;
            AddMetaData(package);
            AddFiles(package);
            _document.AppendChild(package);
        }

        private void AddMetaData(XmlElement parent)
        {
            var metaDataTag = _document.CreateElement("metadata");
            parent.AppendChild(metaDataTag);

            SetId(metaDataTag);
            SetDescription(metaDataTag);
            SetVersion(metaDataTag);
            SetAuthor(metaDataTag);
            SetCopyRight(metaDataTag);
            SetTags(metaDataTag);

        }

        private void SetDescription(XmlElement parent)
        {
            var descriptionTag = _document.CreateElement("description");
            descriptionTag.InnerText = "Nuget package";
            parent.AppendChild(descriptionTag);
        }

        private void SetTags(XmlNode package)
        {
        }

        private void SetCopyRight(XmlNode parent)
        {
            var copyrightTag = _document.CreateElement("copyright");
            copyrightTag.InnerText = MainInfo.CopyRight;
            parent.AppendChild(copyrightTag);
        }

        private void SetVersion(XmlNode parent)
        {
            var idTag = _document.CreateElement("version");
            idTag.InnerText = _version;
            parent.AppendChild(idTag);
        }

        private void SetId(XmlNode parent)
        {
            var idTag = _document.CreateElement("id");
            idTag.InnerText = _fileNameWithOutExtention;
            parent.AppendChild(idTag);
        }
        private void SetAuthor(XmlNode parent)
        {
            var authorTag = _document.CreateElement("authors");
            authorTag.InnerText = MainInfo.Author;
            parent.AppendChild(authorTag);
        }

        private void AddFiles(XmlNode parent)
        {
            var fileTag = _document.CreateElement("file");
            fileTag.SetAttribute("src", _dllPath);
            fileTag.SetAttribute("target", $@"{MainInfo.TargetPath}\{_fileNameWithOutExtention}");

            var filesTag = _document.CreateElement("files");
            filesTag.AppendChild(fileTag);
            parent.AppendChild(filesTag);
        }
    }
}
