using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PdfGenerateService;
using PdfGenerateService.Models;

namespace PdfGenerateService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormDataItemsController : ControllerBase
    {
        private readonly FormContext _context;

        public FormDataItemsController(FormContext context)
        {
            _context = context;
        }

        // GET: api/FormDataItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FormDataItems>>> GetFormDataItems()
        {
            return await _context.FormDataItems.ToListAsync();
        }

        // GET: api/FormDataItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FormDataItems>> GetFormDataItems(string id)
        {
            var formDataItems = await _context.FormDataItems.FindAsync(id);

            if (formDataItems == null)
            {
                return NotFound();
            }

            return formDataItems;
        }

        // PUT: api/FormDataItems/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFormDataItems(string id, FormDataItems formDataItems)
        {
            if (id != formDataItems.user_id)
            {
                return BadRequest();
            }

            _context.Entry(formDataItems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FormDataItemsExists(id))
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

        // POST: api/FormDataItems
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<FormDataItems>> PostFormDataItems(FormDataItems formDataItems)
        {
            _context.FormDataItems.Add(formDataItems);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FormDataItemsExists(formDataItems.user_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFormDataItems", new { id = formDataItems.user_id }, formDataItems);
        }

        // DELETE: api/FormDataItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FormDataItems>> DeleteFormDataItems(string id)
        {
            var formDataItems = await _context.FormDataItems.FindAsync(id);
            if (formDataItems == null)
            {
                return NotFound();
            }

            _context.FormDataItems.Remove(formDataItems);
            await _context.SaveChangesAsync();

            return formDataItems;
        }

        private bool FormDataItemsExists(string id)
        {
            return _context.FormDataItems.Any(e => e.user_id == id);
        }
    }
}
