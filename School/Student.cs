using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Student
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Point { get; set; }

        public override string ToString()
        {
            return this.Name.ToUpper()+" "+this.Surname.ToUpper();
        }
    }
}
