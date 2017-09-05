using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaVogal
{
    public class Stream : IStream
    {
        public Stream()
        {            
            _repeated = new char[5];
        }

        #region Atributos

        private String _mock;
        private Char[] _array;
        private Char[] _repeated;
        private int index = -1;

        #endregion

        #region Metodos Publicos

        public char getNext()
        {
            index++;
            return _array[index];
        }

        public bool hasNext()
        {
            return index < _array.Length - 1;
        }

        public bool repetead(char item)
        {
            return _repeated.Contains(item);
        }

        public char[] getRepetead()
        {
            return _repeated;
        }

        public void setRepetead(char[] value)
        {
            _repeated = value;            
        }

        public string getMock()
        {
            return _mock;            
        }

        public void setMock(string value)
        {
            _mock = value;
            _array = value.ToCharArray();
        }

        #endregion
    }
}
