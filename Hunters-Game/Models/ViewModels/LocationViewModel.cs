﻿using Hunters_Game.Models.Academies;
using Hunters_Game.Models.Location;

namespace Hunters_Game.Models.ViewModels
{
    public class LocationViewModel
    {
        public IEnumerable<Region> Regions { get; set; }
        public IEnumerable<Territory> Territories { get; set; }
        public IEnumerable<Area> Areas { get; set; }
        public IEnumerable<City> Cities { get; set; }
        public IEnumerable<District> Districts { get; set; }
    }
}