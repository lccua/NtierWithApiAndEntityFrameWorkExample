
using SolutionStrips.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionStrips.DOMAIN.Interfaces;

namespace SolutionStrips.DOMAIN.Services.AuteurService
{
    public class AuteurService : IAuteurService
    {
        private IAuteurRepository _auteurRepo;

        public AuteurService(IAuteurRepository auteurRepo)
        {
            _auteurRepo = auteurRepo;
        }

        public void VoegAuteurToe(Auteur auteur)
        {
            _auteurRepo.VoegAuteurToe(auteur);
        }
    }
}
