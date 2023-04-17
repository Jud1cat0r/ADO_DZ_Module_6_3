using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DZ_Module_6_3
{
    public class GameContext : DbContext
    {
        public GameContext() : base("DbConnect")
        {
        }
        public DbSet<Game> Games { get; set;}
        public DbSet<GameStudio> GameStudios { get; set;}
        public DbSet<GameMode> GameModes { get; set;}
        public DbSet<GameStyle> GameStyles { get; set;}
        public DbSet<City> Cities { get; set;}
        public DbSet<Country> Countries { get; set;}
    }
}
