using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    internal class Teacher
    {
        private string id;
        private string name;
        private int age;

        public Teacher(string id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public string TeacherID { get; internal set; }
        public string Name { get; internal set; }
        public int Age { get; internal set; }

        internal void PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
