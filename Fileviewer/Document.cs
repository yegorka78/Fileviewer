using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fileviewer
{
    public class Document
    {
        private String path;
        private String name;
        private String content;
        private String type;

        public Document(String path, String name, String content, String type)
        {
            this.path = path;
            this.name = name;
            this.content = content;
            this.type = type;
        }

        public String getPath()
        {
            return this.path;
        }

        public void setPath(String path)
        {
            this.path = path;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getContent()
        {
            return this.content;
        }

        public void setContent(String content)
        {
            this.content = content;
        }

        public String getType()
        {
            return this.type;
        }

        public void setType(String type)
        {
            this.type = type;
        }
    }
}