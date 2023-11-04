using System;
using System.ComponentModel.DataAnnotations;


namespace SolutionStrips.DOMAIN.Models
{
    public class Auteur
    {
        public Auteur(string naam)
        {
            Naam = naam;
        }

        public int Id { get; set; }
        public string Naam { get; set; }
    }
}