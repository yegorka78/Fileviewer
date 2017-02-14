using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Fileviewer
{
    public class XMLConfiguration
    {
        private string path;
        private XDocument configFile;
        private IDictionary<String, String> attributes;

        public XMLConfiguration(string path, string fileName)
        {
            this.path = path;
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                this.path = this.path + "\\" + fileName;
                if (!File.Exists(this.path))
                {
                    initialize();
                    reload();
                } else
                {
                    reload();
                }
            } catch(Exception e)
            {
                MessageBox.Show("Cannot load or initialize settings file!");
            }
        }

        public void reload()
        {
            configFile = XDocument.Parse(File.ReadAllText(path));
            attributes = new Dictionary<String, String>();
            foreach (XElement config in configFile.Root.Nodes())
            {
                attributes[config.Name.ToString()] = config.Value.ToString();
            }
        }

        private void initialize()
        {
            try
            {
                configFile = new XDocument();
                configFile.AddFirst(new XElement("configs"));

                XElement columnStartsWith = new XElement("columnStartsWith");
                columnStartsWith.Value = "1";
                configFile.Root.Add(columnStartsWith);

                XElement rowStartsWith = new XElement("rowStartsWith");
                rowStartsWith.Value = "1";
                configFile.Root.Add(rowStartsWith);

                XElement defaultFont = new XElement("defaultFont");
                defaultFont.Value = "Courier New; 8.25pt";
                configFile.Root.Add(defaultFont);

                XElement defaultFontColor = new XElement("defaultFontColor");
                defaultFontColor.Value = "#000000";
                configFile.Root.Add(defaultFontColor);

                XElement backgroundColor = new XElement("backgroundColor");
                backgroundColor.Value = "#FFFFFF";
                configFile.Root.Add(backgroundColor);

                XElement matchColor = new XElement("matchColor");
                matchColor.Value = "#FFFF00";
                configFile.Root.Add(matchColor);

                XElement base64Header = new XElement("base64Header");
                base64Header.Value = "---===***SFS-BASE64-ENCODED***===---";
                configFile.Root.Add(base64Header);

                FileStream fileStream = new FileStream(path, FileMode.CreateNew);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                configFile.Save(streamWriter);
                streamWriter.Close();
                fileStream.Close();
            } catch(Exception e)
            {
                MessageBox.Show("Error while initializing settings file!");
            }
        }

        public string get(string key)
        {
            try
            {
                return attributes[key];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void set(string key, string val)
        {
            try
            {
                XDocument newConfigFile = new XDocument();
                newConfigFile.AddFirst(new XElement("configs"));
                foreach (XElement config in configFile.Root.Nodes())
                {
                    if (key == config.Name.ToString())
                    {
                        config.Value = val;
                    }
                    newConfigFile.Root.Add(config);
                }
                FileStream fileStream = new FileStream(path, FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                newConfigFile.Save(streamWriter);
                streamWriter.Close();
                fileStream.Close();
                reload();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
