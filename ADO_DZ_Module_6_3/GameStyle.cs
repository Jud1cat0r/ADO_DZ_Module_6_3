using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DZ_Module_6_3
{
    public class GameStyle
    {
        public int Id { get; set; }
        public string GameStyleName { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
