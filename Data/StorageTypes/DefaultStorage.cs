using Microsoft.AspNetCore.Components.Forms;

namespace Robotics_File_Storage.Data.StorageTypes
{
    public class DefaultStorage : StorageInterface
    {

        public async void loadFile(IBrowserFile file, string path)
        {

            Directory.CreateDirectory(path);

            Console.WriteLine("Path: " + path);

            await using FileStream fs = new(path + file.Name, FileMode.Create);
            await file.OpenReadStream().CopyToAsync(fs);
            
            Console.WriteLine("uploading file" + file.Name);

        }

        public List<String> getFiles(string path)
        {

            string[] files = Directory.GetFiles(path);

            return files.ToArray().ToList();

        }

        public Stream getFile(string path, string name)
        {

            string[] files = Directory.GetFiles(path);

            Console.WriteLine("thing: " + path + " | " + name);

            Console.WriteLine("files: " + files);
                return File.OpenRead(path + name);

        }

    }
}
