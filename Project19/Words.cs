using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19
{
    public interface IWords
    {
        List<string> ExtractWords(string file);
    }
}
