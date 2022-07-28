using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Playstore.Data;
using Playstore.Models;

namespace Playstore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleGamesController : ControllerBase
    {
        private readonly GameContext _context;

        public SaleGamesController(GameContext context)
        {
            _context = context;
        }

        // GET: api/SaleGames
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SaleGame>>> GetSaleGames()
        {
          if (_context.SaleGames == null)
          {
              return NotFound();
          }
            return await _context.SaleGames.ToListAsync();
        }

        // GET: api/SaleGames/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SaleGame>> GetSaleGame(int id)
        {
          if (_context.SaleGames == null)
          {
              return NotFound();
          }
            var saleGame = await _context.SaleGames.FindAsync(id);

            if (saleGame == null)
            {
                return NotFound();
            }

            return saleGame;
        }

        // PUT: api/SaleGames/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSaleGame(int id, SaleGame saleGame)
        {
            if (id != saleGame.ID)
            {
                return BadRequest();
            }

            _context.Entry(saleGame).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaleGameExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SaleGames
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SaleGame>> PostSaleGame(SaleGame saleGame)
        {
          if (_context.SaleGames == null)
          {
              return Problem("Entity set 'GameContext.SaleGames'  is null.");
          }
            _context.SaleGames.Add(saleGame);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSaleGame", new { id = saleGame.ID }, saleGame);
        }

        // DELETE: api/SaleGames/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSaleGame(int id)
        {
            if (_context.SaleGames == null)
            {
                return NotFound();
            }
            var saleGame = await _context.SaleGames.FindAsync(id);
            if (saleGame == null)
            {
                return NotFound();
            }

            _context.SaleGames.Remove(saleGame);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SaleGameExists(int id)
        {
            return (_context.SaleGames?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
