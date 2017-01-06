using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Fileviewer
{
    public class EditorModel
    {
        private List<IView> views;
        private List<Document> files;
        private List<String> availableFileTypes;

        public EditorModel()
        {
            views = new List<IView>();
            files = new List<Document>();
            availableFileTypes = new List<string>();
            initAvailableFileTypes();
        }

        #region observer
        public void addView(IView view)
        {
            views.Add(view);
            view.update();
        }

        public void removeView(IView view)
        {
            views.Remove(view);
            view.update();
        }

        public void updateAllViews()
        {
            foreach (IView view in views)
            {
                view.update();
            }
        }
        #endregion

        public List<Document> getFiles()
        {
            return files;
        }

        private void initAvailableFileTypes()
        {
            availableFileTypes.Add("plain text");
            availableFileTypes.Add("xml");
            availableFileTypes.Add("ansi-x12");
            availableFileTypes.Add("edifact");
            availableFileTypes.Add("vda");
        }

        public List<String> getAvailableFileTypes()
        {
            return availableFileTypes;
        }
        
        public void addFile(Document file)
        {
            files.Add(file);
            updateAllViews();
        }

        public void removeFile(Document file)
        {
            files.Remove(file);
            updateAllViews();
        }

        public void updateFile(Document oldFile, Document newFile)
        {
            int i = files.IndexOf(oldFile);
            files[i] = newFile;
            updateAllViews();
        }

        public void saveFile(Document file)
        {
            System.IO.StreamWriter targetFile = new System.IO.StreamWriter(file.getPath());
            targetFile.WriteLine(file.getContent());
            targetFile.Close();
        }

        public Document readFile(Document file)
        {
            if (File.Exists(file.getPath()))
            {
                file.setName(Path.GetFileName(file.getPath()));
                file.setContent(File.ReadAllText(file.getPath()));
            }
            file = analyzeFileType(file);
            return file;
        }

        public void formatFile(Document file)
        {
            Document tmpFile = new Document(file.getPath(), file.getName(), file.getContent(), file.getType());
            switch (file.getType())
            {
                case "xml":
                    tmpFile = formatXML(tmpFile);
                    break;
                case "ansi-x12":
                    tmpFile = formatAnsix12(tmpFile);
                    break;
                case "edifact":
                    tmpFile = formatEdifact(tmpFile);
                    break;
                case "vda":
                    tmpFile = formatVda(tmpFile);
                    break;
                default: break;
            }
            updateFile(file, tmpFile);
            updateAllViews();
        }

        private Document formatXML(Document file)
        {
            MemoryStream mStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(mStream, Encoding.Unicode);
            XmlDocument document = new XmlDocument();
            document.Load(file.getPath());
            writer.Formatting = Formatting.Indented;
            document.WriteContentTo(writer);
            writer.Flush();
            mStream.Flush();
            mStream.Position = 0;
            StreamReader sReader = new StreamReader(mStream);
            String FormattedXML = sReader.ReadToEnd();
            file.setContent(FormattedXML);
            mStream.Close();
            writer.Close();
            return file;
        }

        private Document formatAnsix12(Document file)
        {
            Char separator = getSeparatorOfAnsix12(file.getContent());
            if (separator != 13)
            {
                StringBuilder builder = new StringBuilder();
                foreach (Char c in file.getContent())
                {
                    builder.Append(c);
                    if (c == separator)
                    {
                        builder.Append((char)13);
                    }
                }
                file.setContent(builder.ToString());
            }
            return file;
        }

        private Document formatEdifact(Document file)
        {
            StringBuilder builder = new StringBuilder();
            Char[] content = file.getContent().ToCharArray();
            for (int i = 0; i < file.getContent().Length; i ++)
            {
                builder.Append(content[i]);
                if (content[i] == '\'')
                {
                    if (content[i - 1] != '?')
                    {
                        builder.Append((char)13);
                    }
                }
            }
            file.setContent(builder.ToString());
            return file;
        }

        private Document formatVda(Document file)
        {
            StringBuilder builder = new StringBuilder();
            Char[] content = file.getContent().ToCharArray();
            for (int i = 0; i < content.Length; i++)
            {
                if (i % 128 == 0 && i != 0)
                {
                    builder.Append((char)13);
                }
                builder.Append(content[i]);
            }
            file.setContent(builder.ToString());
            return file;
        }

        private Char getSeparatorOfAnsix12(String str)
        {
            return str.ToCharArray()[105];
        }

        public void unformatFile(Document file)
        {
            Document tmpFile = new Document(file.getPath(), file.getName(), file.getContent(), file.getType());
            tmpFile = readFile(tmpFile);
            updateFile(file, tmpFile);
            updateAllViews();
        }

        public Document analyzeFileType(Document file)
        {
            if (file.getContent() != String.Empty)
            {
                if (isXML(file))
                {
                    file.setType("xml");
                } else if (isAnsiX12(file))
                {
                    file.setType("ansi-x12");
                } else if (isEdifact(file))
                {
                    file.setType("edifact");
                } else if (isVda(file))
                {
                    file.setType("vda");
                } else
                {
                    file.setType("plain text");
                }
            }
            return file;
        }

        private bool isXML(Document file)
        {
            if (file.getContent().Contains("<") && file.getContent().Contains("</") && file.getContent().Contains(">"))
            {
                return true;
            }
            return false;
        }

        private bool isAnsiX12(Document file)
        {
            if (file.getContent().Contains("ISA"))
            {
                return true;
            }
            return false;
        }

        private bool isEdifact(Document file)
        {
            if (file.getContent().Contains("UNB") || file.getContent().Contains("UNA"))
            {
                return true;
            }
            return false;
        }

        private bool isVda(Document file)
        {
            if (file.getContent().Length%128 == 0)
            {
                return true;
            }
            return false;
        }

    }
}
