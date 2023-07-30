using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundScheduleGen.Application.BL.DTO
{
    public class PersonHermanoDTO
    {
        #region Constructors
        public PersonHermanoDTO()
        {

        }
        #endregion

        #region Fields
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Congregacion { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool esBautizado { get; set; }
        public bool esVideo { get; set; }
        public bool esSonido { get; set; }
        public bool esPlataforma { get; set; }
        public bool esAcomVideo { get; set; }
        public bool esMicro { get; set; }
        #endregion
    }
}
