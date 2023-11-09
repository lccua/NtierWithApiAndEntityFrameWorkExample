using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionStrips.DOMAIN.Models
{
    public class Strip
    {
       
        public int Id { get; set; }
        public string Naam { get; set; }
        public Auteur Auteur { get; set; }
        public int AuteurId { get; set; }
    }
}
