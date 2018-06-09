using System.Collections.Generic;
using Consuum.Domain.Models;

namespace Consuum.Domain
{
    public interface ITextReader
    {
        List<string> GetLines();
    }
}