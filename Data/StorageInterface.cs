using Microsoft.AspNetCore.Components.Forms;

namespace Robotics_File_Storage.Data
{
    public interface StorageInterface
    {

        public void loadFile(IBrowserFile file, string path);

        public List<String> getFiles(string path);

        public Stream getFile(string path, string name);

    }
}
