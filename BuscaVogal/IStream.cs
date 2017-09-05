using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaVogal
{
    public interface IStream
    {
        char getNext();
        Boolean hasNext();

        char[] getRepetead();
        void setRepetead(char[] value);
        Boolean repetead(char item);

        string getMock();
        void setMock(string value);
    }
}
