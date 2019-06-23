using System.Collections.Generic;  
using System.IO;
using SyncFileFolder.Model; 

namespace SyncFileFolder.Adapter
{
    public class Core
    {
        public static List<Images> GetListFile(string path)
        {
            var lstFile = new List<Images>();
            if (Directory.Exists(path))
            {
                var files = new DirectoryInfo(path).GetFiles();
                foreach (var item in files)
                {
                    lstFile.Add(new Images()
                    {
                        FileName = item.Name,
                        Path = item.FullName
                    });
                }  
            }
            return lstFile;
        }
        
    }  
}
