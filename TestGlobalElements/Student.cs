using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGlobalElements
{
    public class Student
    {
        public int StudID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public IList Subjects { get; set; }

        
    }
}
