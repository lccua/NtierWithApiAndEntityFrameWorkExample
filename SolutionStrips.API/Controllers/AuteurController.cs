using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SolutionStrips.DOMAIN.Models;
using SolutionStrips.DOMAIN.Services;
using SolutionStrips.DOMAIN.Services.AuteurService;

namespace SolutionStrips.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuteurController : ControllerBase
    {
        private readonly IAuteurService _auteurService;

        public AuteurController(IAuteurService auteurService)
        {
            _auteurService = auteurService;
        }

        [HttpPost]
        public ActionResult VoegAuteurToe([FromBody] Auteur auteur)
        {
           
              _auteurService.VoegAuteurToe(auteur);
              return CreatedAtAction(nameof(VoegAuteurToe), auteur);
        }
    }
}
