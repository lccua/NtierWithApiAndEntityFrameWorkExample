using SolutionStrips.DATA.Context;
using SolutionStrips.DOMAIN.Interfaces;
using SolutionStrips.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionStrips.DATA.Repositories
{
    public class StripRepository : IStripRepository
    {
        private readonly SolutionStripsContext _context;

        public StripRepository(SolutionStripsContext context)
        {
            _context = context;
        }

        public void VoegStripToe(Strip strip)
        {
            _context.Strips.Add(strip);
            _context.SaveChanges();
        }
    }
}
