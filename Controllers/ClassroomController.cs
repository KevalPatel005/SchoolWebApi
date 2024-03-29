using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        private readonly SchoolContext _context;

        public ClassroomController(SchoolContext context)
        {
            _context = context;
        }

        // GET: api/Classroom
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Classroom>>> GetClassrrom()
        {
            return await _context.Classrrom.ToListAsync();
        }

        // GET: api/Classroom/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Classroom>> GetClassroom(int id)
        {
            var classroom = await _context.Classrrom.FindAsync(id);

            if (classroom == null)
            {
                return NotFound();
            }

            return classroom;
        }

        // PUT: api/Classroom/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClassroom(int id, Classroom classroom)
        {
            if (id != classroom.ClassroomId)
            {
                return BadRequest();
            }

            _context.Entry(classroom).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassroomExists(id))
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

        // POST: api/Classroom
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Classroom>> PostClassroom(Classroom classroom)
        {
            _context.Classrrom.Add(classroom);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClassroom", new { id = classroom.ClassroomId }, classroom);
        }

        // DELETE: api/Classroom/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClassroom(int id)
        {
            var classroom = await _context.Classrrom.FindAsync(id);
            if (classroom == null)
            {
                return NotFound();
            }

            _context.Classrrom.Remove(classroom);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClassroomExists(int id)
        {
            return _context.Classrrom.Any(e => e.ClassroomId == id);
        }
    }
}
