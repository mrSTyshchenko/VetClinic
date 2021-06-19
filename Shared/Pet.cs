using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Shared
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Kind { get; set; }
        public int OvnerId { get; set; }
    }
}
