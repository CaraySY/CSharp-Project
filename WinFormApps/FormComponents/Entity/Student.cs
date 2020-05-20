using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormComponents.Entity
{
    public class Student
    {
        private string code;
        private string name;
        private string sex;
        private DateTime birth;

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime Birth { get => birth; set => birth = value; }

        public override string ToString()
        {
            return $"code={code},name={name},sex={sex},birth={birth}";
        }
    }
}
