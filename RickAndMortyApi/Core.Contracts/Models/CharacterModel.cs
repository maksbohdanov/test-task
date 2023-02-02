﻿namespace Core.Contracts.Models
{
    public class CharacterModel
    {
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public LocationModel? Origin { get; set; }
    }
}
