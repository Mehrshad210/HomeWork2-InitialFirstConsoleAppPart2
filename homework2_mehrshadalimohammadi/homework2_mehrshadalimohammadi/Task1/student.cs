using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_mehrshadalimohammadi.Task1
{
    public class student
    {
        public student(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }


        public int Age { get; set; }

        public string Name { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hello , my name is {Name} and I am {Age} years old");
        }
    }
}
