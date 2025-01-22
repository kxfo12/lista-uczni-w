using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listOfStudents
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Boolean IsIdiot { get; set; }
        public string ParentsJob { get; set; }

        public Student(string name, int age, bool isIdiot, string parentsJob)
        {
            Name = name;
            Age = age;
            IsIdiot = isIdiot;
            ParentsJob = parentsJob;
        }
    }
}
