using System;
using System.Collections.Generic;
using System.Text;

namespace ComposicaoExercicio1.Entities
{
    internal class Department
    {
        // AutoProps
        public string Name { get; set; }

        // Construtores
        public Department() { }
        public Department(string name)
        {
            Name = name;
        }
    }
}
