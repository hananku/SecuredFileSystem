using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureFileSystemServer
{
    class FileShown
    {
        private string _filename;
        private string _user;
        private DateTime _created;
        private DateTime _modified;

        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }

        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        public DateTime Created
        {
            get { return _created; }
            set { _created = value; }
        }

        public DateTime Modified
        {
            get { return _modified; }
            set { _modified = value; }
        }
    }
}
