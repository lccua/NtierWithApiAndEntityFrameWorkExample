using SolutionStrips.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionStrips.DOMAIN.Services.AuteurService
{
    public interface IAuteurService
    {
        void VoegAuteurToe(Auteur auteur);
    }
}
