using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public struct StructFun
    {
        public String firstName;
        public String lastName;

        public String GetName()//结构函数
        {
            return firstName + ":" + lastName;
        }
    }
}
