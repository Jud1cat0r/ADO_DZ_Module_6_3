﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DZ_Module_6_3
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public ICollection<GameStudio> GameStudios { get; set; }
    }
}
