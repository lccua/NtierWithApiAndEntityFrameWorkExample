﻿using System;
using System.ComponentModel.DataAnnotations;


namespace SolutionStrips.DOMAIN.Models
{
    public class Auteur
    {
        

        public int Id { get; set; }

        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public string Achtergrond { get; set; }
    }
}