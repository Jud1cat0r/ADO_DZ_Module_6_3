using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DZ_Module_6_3
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string DateRelease { get; set; }
        public int SoldGame { get; set; }
        public int GameStudioId { get; set; }
        public GameStudio GameStudio { get; set; }
        public ICollection<GameStyle> GameStyles { get; set; }
        public ICollection<GameMode> GameMods { get; set; }
    }
}
