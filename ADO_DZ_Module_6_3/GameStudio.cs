using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DZ_Module_6_3
{
    public class GameStudio
    {
        public int Id { get; set; }
        public string GameStudioName { get; set; }
        public ICollection<Game> Games { get; set; }
        public ICollection<City> Cities { get; set; }
        public ICollection<Country> Countries { get; set; }
    }
}
