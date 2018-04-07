using System.Collections.Generic;
using System.Numerics;
using System;

namespace KnockKnock.Models
{
    public class FibonacciSequence
    {
        private List<BigInteger> _values = new List<BigInteger>();

        public FibonacciSequence()
        {
            _values.Add(0);
            _values.Add(1);
        }

        public BigInteger this[int i]
        {
            get
            {
                if(_values.Count < (i + 1))
                {
                    GenerateValuesTo(i);
                }
                return _values[i];
            }
        }

        private void GenerateValuesTo(int i)
        {
            while(_values.Count < (i + 1))
            {
                _values.Add(_values[_values.Count - 1] + _values[_values.Count - 2]);
            }
        }
    }
}