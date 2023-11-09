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

        public Auteur VraagAuteurOp(int id)
        {
            // Assuming that "Auteurs" is a DbSet in your DbContext for authors
            return _context.Auteurs.FirstOrDefault(a => a.Id == id);
        }

        public void UpdateAuteur(int id, Auteur updatedAuteur)
        {
            // Find the existing entity with the given ID
            var existingAuteur = _context.Auteurs.Find(id);

            if (existingAuteur == null)
            {
                // Handle the case where the entity with the given ID is not found
                // You can throw an exception, log an error, or take appropriate action
                // based on your application's requirements.
                throw new Exception($"Auteur with ID {id} not found");
            }

            // Update each property of the existing entity with the values from the updated entity
            existingAuteur.Id = id;
            existingAuteur.Naam = updatedAuteur.Naam;
            existingAuteur.Leeftijd = updatedAuteur.Leeftijd;
            existingAuteur.Achtergrond = updatedAuteur.Achtergrond;

            // Repeat for other properties excluding the 'id'

            // Save the changes to the database
            _context.SaveChanges();
        }

        public void VerwijderAuteur(int id)
        {
            var auteur = _context.Auteurs.Find(id); // Find the author by ID

            if (auteur != null)
            {
                _context.Auteurs.Remove(auteur); // Mark the author for deletion
                _context.SaveChanges(); // Commit the changes to the database
            }
        }

        public IEnumerable<Auteur> VraagAlleAuteursOp()
        {
            return _context.Auteurs.ToList();
        }
    }
}
