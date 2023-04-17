using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DZ_Module_6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (GameContext filling = new GameContext())
            {
                GameStudio gameStudio1 = new GameStudio
                {
                    GameStudioName = "Bethesda"
                };
                GameStudio gameStudio2 = new GameStudio
                {
                    GameStudioName = "CD Project"
                };
                GameStudio gameStudio3 = new GameStudio
                {
                    GameStudioName = "NCSoft"
                };
                GameStudio gameStudio4 = new GameStudio
                {
                    GameStudioName = "Valve"
                };
                GameStudio gameStudio5 = new GameStudio
                {
                    GameStudioName = "Piranha Bytes"
                };
                GameStudio gameStudio6 = new GameStudio
                {
                    GameStudioName = "Sowftware"
                };
                filling.GameStudios.AddRange(new List<GameStudio> { gameStudio1, gameStudio2, gameStudio3, gameStudio4, gameStudio5, gameStudio6 });
                filling.SaveChanges();
                Game game1 = new Game
                {
                    GameName = "Gothic 2",
                    DateRelease = "03.03.03",
                    SoldGame = 12345,
                    GameStudioId = 5
                };
                Game game2 = new Game
                {
                    GameName = "Doom 3",
                    DateRelease = "04.04.04",
                    SoldGame = 34523,
                    GameStudioId = 6
                };
                Game game3 = new Game
                {
                    GameName = "Gothic",
                    DateRelease = "01.01.01",
                    SoldGame = 12455,
                    GameStudioId = 5
                };
                Game game4 = new Game
                {
                    GameName = "Fallout 2",
                    DateRelease = "03.03.98",
                    SoldGame = 6578,
                    GameStudioId = 1
                };
                Game game5 = new Game
                {
                    GameName = "Dota 2",
                    DateRelease = "11.11.11",
                    SoldGame = 876543,
                    GameStudioId = 4
                };
                Game game6 = new Game
                {
                    GameName = "Linage 2",
                    DateRelease = "06.06.06",
                    SoldGame = 756722,
                    GameStudioId = 3
                };
                Game game7 = new Game
                {
                    GameName = "The Witcher",
                    DateRelease = "07.07.07",
                    SoldGame = 56413,
                    GameStudioId = 2
                };
                filling.Games.AddRange(new List<Game> { game1, game2, game3, game4, game5, game6, game7 });
                GameMode gameMode1 = new GameMode
                {
                    GameModeName = "Singleplayer"
                };
                GameMode gameMode2 = new GameMode
                {
                    GameModeName = "Multiplayer"
                };
                filling.GameModes.AddRange(new List<GameMode> { gameMode1, gameMode2 });
                GameStyle gameStyle1 = new GameStyle
                {
                    GameStyleName = "RPG"
                };
                GameStyle gameStyle2 = new GameStyle
                {
                    GameStyleName = "Action"
                };
                GameStyle gameStyle3 = new GameStyle
                {
                    GameStyleName = "MOBA"
                };
                GameStyle gameStyle4 = new GameStyle
                {
                    GameStyleName = "Strategy"
                };
                GameStyle gameStyle5 = new GameStyle
                {
                    GameStyleName = "Simulation"
                };
                GameStyle gameStyle6 = new GameStyle
                {
                    GameStyleName = "MMO"
                };
                GameStyle gameStyle7 = new GameStyle
                {
                    GameStyleName = "Quest"
                };
                filling.GameStyles.AddRange(new List<GameStyle> { gameStyle1, gameStyle2, gameStyle3, gameStyle4, gameStyle5, gameStyle6, gameStyle7 });
                City city1 = new City
                {
                    CityName = "Moscow"
                };
                City city2 = new City
                {
                    CityName = "California"
                };
                City city3 = new City
                {
                    CityName = "Berlin"
                };
                City city4 = new City
                {
                    CityName = "London"
                };
                City city5 = new City
                {
                    CityName = "Rostov-On-Don"
                };
                City city6 = new City
                {
                    CityName = "Washington"
                };
                City city7 = new City
                {
                    CityName = "Manchester"
                };
                City city8 = new City
                {
                    CityName = "Bayern"
                };
                City city9 = new City
                {
                    CityName = "Madrid"
                };
                City city10 = new City
                {
                    CityName = "Krasnodar"
                };
                filling.Cities.AddRange(new List<City> { city1, city2, city3, city4, city5, city6, city7, city8, city9, city10 });
                Country country1 = new Country
                {
                    CountryName = "Russia"
                };
                Country country2 = new Country
                {
                    CountryName = "Germany"
                };
                Country country3 = new Country
                {
                    CountryName = "USA"
                };
                Country country4 = new Country
                {
                    CountryName = "England"
                };
                Country country5 = new Country
                {
                    CountryName = "Spain"
                };
                filling.Countries.AddRange(new List<Country> { country1, country2, country3, country4, country5 });
                filling.SaveChanges();
            }

        }
    }
}
