using Consuum.Core.Models;

namespace Consuum.Core.Interfaces
{
    public interface IOcrService
    {
        TextAnnotation Parse(Image image);
    }
}