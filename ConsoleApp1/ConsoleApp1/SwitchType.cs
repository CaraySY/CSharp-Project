using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1
{
    public class SwitchType
    {
        public bool IsValid(int opt)
        {
            if (opt > 100)
            {
                return true;
            }
            return false;
        }

        public int AddData(int a,int b)
        {
            return a + b;
        }
    }
}
