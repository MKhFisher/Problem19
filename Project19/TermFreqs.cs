using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19
{
    public interface ITermFreqs
    {
        List<Frequency> PrintTop25(List<string> words);
    }
}
