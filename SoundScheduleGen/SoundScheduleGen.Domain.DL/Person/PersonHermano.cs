using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundScheduleGen.Domain.DL.Person
{
    public class PersonHermano
    {
        public PersonHermano()
        {
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Congregacion { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime FechaCreado { get; set; }
        public bool esBautizado { get; set; }
        public bool esVideo { get; set; }
        public bool esSonido { get; set; }
        public bool esPlataforma { get; set; }
        public bool esAcomVideo { get; set; }
        public bool esMicro { get; set; }

    }
}
