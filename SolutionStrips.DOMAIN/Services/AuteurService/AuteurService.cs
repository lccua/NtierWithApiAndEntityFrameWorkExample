
using SolutionStrips.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionStrips.DOMAIN.Interfaces;

namespace SolutionStrips.DOMAIN.Services.AuteurService
{
    public class AuteurService
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

        public Auteur VraagAuteurOp(int id)
        {
            return _auteurRepo.VraagAuteurOp(id);
        }

        public void UpdateAuteur(int id, Auteur auteur)
        {
            _auteurRepo.UpdateAuteur(id,auteur);
        }

        public void VerwijderAuteur(int id)
        {
            _auteurRepo.VerwijderAuteur(id);
        }

        public IEnumerable<Auteur> VraagAlleAuteursOp()
        {
            return _auteurRepo.VraagAlleAuteursOp();
        }
            

    }
}
