using SolutionStrips.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionStrips.DOMAIN.Interfaces
{
    public interface IStripRepository
    {
        void VoegStripToe(Strip strip);
    }
}
