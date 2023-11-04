using SolutionStrips.DATA.Context;
using SolutionStrips.DOMAIN.Services.AuteurService;
using SolutionStrips.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionStrips.DOMAIN.Interfaces;

namespace SolutionStrips.DATA.Repositories
{
    public class AuteurRepository : IAuteurRepository
    {
        private readonly SolutionStripsContext _context;

        public AuteurRepository(SolutionStripsContext context) 
        {
            _context = context;
        }

        public void VoegAuteurToe(Auteur auteur)
        {
            _context.Auteurs.Add(auteur);
            _context.SaveChanges();
        }

    }
}
