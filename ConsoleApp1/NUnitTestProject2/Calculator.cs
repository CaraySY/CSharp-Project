using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject2
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        private static readonly object objSync = new object();
        private static Calculator instance = null;

        public static Calculator GetInstance()
        {
            if (instance == null)
            {
                lock (objSync)
                {
                    if (instance == null)
                    {
                        instance = new Calculator();
                    }
                }
            }
            return instance;
        }
    }
}
