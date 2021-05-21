using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeatherAPIProject.Models;

namespace WeatherAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class weathersController : ControllerBase
    {
        private readonly WeatherContext _context;

        public weathersController(WeatherContext context)
        {
            _context = context;
        }

        // GET: api/weathers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<weather>>> Getw()
        {
            return await _context.w.ToListAsync();
        }

        // GET: api/weathers/5
        [HttpGet("{City}")]
        public async Task<ActionResult<weather>> Getweather(string City)
        {
            var weather = await _context.w.FindAsync(City);

            if (weather == null)
            {
                return NotFound();
            }

            return weather;
        }

        // PUT: api/weathers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{City}")]
        public async Task<IActionResult> Putweather(string City, weather weather)
        {
            if (City != weather.City)
            {
                return BadRequest();
            }

            _context.Entry(weather).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!weatherExists(City))
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

        // POST: api/weathers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<weather>> Postweather(weather weather)
        {
            _context.w.Add(weather);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (weatherExists(weather.City))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("Getweather", new { id = weather.City }, weather);
        }

        // DELETE: api/weathers/5
        [HttpDelete("{City}")]
        public async Task<IActionResult> Deleteweather(string City)
        {
            var weather = await _context.w.FindAsync(City);
            if (weather == null)
            {
                return NotFound();
            }

            _context.w.Remove(weather);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool weatherExists(string City)
        {
            return _context.w.Any(e => e.City == City);
        }
    }
}
