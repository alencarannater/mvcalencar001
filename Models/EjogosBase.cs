using System.IO;

namespace E_jogos.Models
{
    public class EjogosBase
    {
        public void CreateFolderAndFile (string path) 
        {
            string folder = path.Split('/')[0];
            string file = path.Split('/')[1];

            if(!Directory.Exists(folder))
            Directory.CreateDirectory(folder);

            if (!File.Exists(file))
                File.Create(path);

        }
    }
}
