using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlindMusic
{
    class Music
    {

        public Music()
        {
                
        }

        public Music(FileInfo fi)
        {
            this.Info = fi;
        }

        public Music(string fileName)
        {
            this.FileName = fileName;
        }

        private string m_path;

        private FileInfo m_info;
        private string fileName;

        public FileInfo Info
        {
            get
            {
                return m_info;
            }

            set
            {
                m_info = value;
            }
        }

        public string Path
        {
            get
            {
                return Info.FullName;
            }
        }

        public string FileName
        {
            get
            {
                return fileName;
            }

            set
            {
                fileName = value;
            }
        }
    }
}
