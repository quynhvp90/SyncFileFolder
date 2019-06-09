using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncFileFolder.Model
{
    public class Images
    {
        public string Id = new Guid().ToString();
        public string FileName { get; set; }
        public string Path { set; get; }
    }
}
