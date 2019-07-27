using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentListAPI.DataBase.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
    }
}
