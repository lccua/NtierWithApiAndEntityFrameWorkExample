using SolutionStrips.DOMAIN.Interfaces;
using SolutionStrips.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionStrips.DOMAIN.Services.StripService
{
    public class StripService
    {
        private IStripRepository _stripRepo;

        public StripService(IStripRepository stripRepo)
        {
            _stripRepo = stripRepo;
        }

        public void VoegStripToe(Strip strip)
        {
            _stripRepo.VoegStripToe(strip);
        }

    }
}
