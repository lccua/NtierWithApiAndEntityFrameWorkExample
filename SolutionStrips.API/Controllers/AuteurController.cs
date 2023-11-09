using AutoMapper;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SolutionStrips.API.Models.Input;
using SolutionStrips.API.Models.Output;
using SolutionStrips.DOMAIN.Models;
using SolutionStrips.DOMAIN.Services;
using SolutionStrips.DOMAIN.Services.AuteurService;
using SolutionStrips.DOMAIN.Services.StripService;


namespace SolutionStrips.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuteurController : ControllerBase
    {
        private readonly AuteurService _auteurService;
        private readonly StripService _stripService;

        private readonly IMapper _mapper;

        public AuteurController(AuteurService auteurService, StripService stripService, IMapper mapper)
        {
            _auteurService = auteurService;
            _stripService = stripService;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult VoegAuteurToe([FromBody] AuteurRestInputDTO inputDto)
        {
            // Use AutoMapper to map the input DTO to your internal model
            Auteur auteur = _mapper.Map<Auteur>(inputDto);

            _auteurService.VoegAuteurToe(auteur);

            // Use AutoMapper to map the Auteur to the output DTO
            AuteurRestOutputDTO outputDto = _mapper.Map<AuteurRestOutputDTO>(auteur);

            // Return the output DTO
            return CreatedAtAction(nameof(VoegAuteurToe), outputDto);
        }

        [HttpPost]
        [Route("{auteurId}/strip/")]
        public ActionResult VoegStripToe(int auteurId, [FromBody] StripRestInputDTO inputDto)
        {
            if (inputDto.AuteurId != auteurId) return BadRequest("ID klopt niet");

            // Use AutoMapper to map the input DTO to your internal model
            Strip strip = _mapper.Map<Strip>(inputDto);

            _stripService.VoegStripToe(strip);

            // Use AutoMapper to map the Auteur to the output DTO
            StripRestOutputDTO outputDto = _mapper.Map<StripRestOutputDTO>(strip);

            // Return the output DTO
            return CreatedAtAction(nameof(VoegStripToe), outputDto);
        }



        [HttpGet("{id}")]
        public ActionResult VraagAuteurOp(int id)
        {
            var auteur = _auteurService.VraagAuteurOp(id);

            // Use AutoMapper to map the Auteur to the output DTO
            AuteurRestOutputDTO outputDto = _mapper.Map<AuteurRestOutputDTO>(auteur);

            return Ok(outputDto);
        }

        [HttpGet("All")]
        public ActionResult GetAllAuteurs()
        {
            IEnumerable<Auteur> auteurs = _auteurService.VraagAlleAuteursOp();

            // Use AutoMapper to map the list of Auteurs to a list of output DTOs
            List<AuteurRestOutputDTO> outputDtos = _mapper.Map<List<AuteurRestOutputDTO>>(auteurs);

            return Ok(outputDtos);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult UpdateAuteur(int id, [FromBody] AuteurRestInputDTO inputDto)
        {
            // Use AutoMapper to map the input DTO to your internal model
            Auteur auteur = _mapper.Map<Auteur>(inputDto);


            _auteurService.UpdateAuteur(id,auteur);

            // Use AutoMapper to map the Auteur to the output DTO
            AuteurRestOutputDTO outputDto = _mapper.Map<AuteurRestOutputDTO>(auteur);
            // Set the id in the output DTO
            outputDto.Id = id;


            return Ok(outputDto);
        }

        [HttpDelete("{id}")]
        public ActionResult VerwijderAuteur(int id)
        {
            _auteurService.VerwijderAuteur(id);
            return NoContent();
        }
    }



}
