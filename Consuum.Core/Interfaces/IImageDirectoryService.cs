using Consuum.Core.Models;

namespace Consuum.Core.Interfaces
{
    public interface IImageDirectoryService
    {
        Image CreateFromDirectory(string imageDirectory);
    }
}