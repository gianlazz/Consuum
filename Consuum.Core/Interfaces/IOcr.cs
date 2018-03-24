using Consuum.Core.Models;

namespace Consuum.Core
{
    public interface IOcrService
    {
        TextAnnotation Parse(Image image);
    }
}