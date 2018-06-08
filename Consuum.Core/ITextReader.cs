using System.Collections.Generic;
using Consuum.Core.Models;

namespace Consuum.Core
{
    public interface ITextReader
    {
        List<string> GetLines();
    }
}