﻿using Hunters_Game.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Hunters_Game.Models.Ranks
{
    public class Level
    {
        [Key]
        public int LevelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public LevelType LevelType { get; set; }
    }
}
