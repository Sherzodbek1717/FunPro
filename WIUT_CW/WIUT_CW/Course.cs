using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIUT_CW
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Course()
        {
            Name = "BIS";

        }

        public override bool Equals(object? obj)
        {
            return obj is Course course &&
                   Name == course.Name;
        }
    }
}
