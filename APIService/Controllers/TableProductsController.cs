using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIService.Models;

namespace APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableProductsController : ControllerBase
    {
        private readonly DBApiProductContext _context;

        public TableProductsController(DBApiProductContext context)
        {
            _context = context;
        }

        // GET: api/TableProducts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TableProduct>>> GetTableProduct()
        {
            return await _context.TableProduct.ToListAsync();
        }

        // GET: api/TableProducts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TableProduct>> GetTableProduct(int id)
        {
            var tableProduct = await _context.TableProduct.FindAsync(id);

            if (tableProduct == null)
            {
                return NotFound();
            }

            return tableProduct;
        }

        // PUT: api/TableProducts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTableProduct(int id, TableProduct tableProduct)
        {
            if (id != tableProduct.Id)
            {
                return BadRequest();
            }

            _context.Entry(tableProduct).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TableProductExists(id))
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

        // POST: api/TableProducts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TableProduct>> PostTableProduct(TableProduct tableProduct)
        {
            _context.TableProduct.Add(tableProduct);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTableProduct", new { id = tableProduct.Id }, tableProduct);
        }

        // DELETE: api/TableProducts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TableProduct>> DeleteTableProduct(int id)
        {
            var tableProduct = await _context.TableProduct.FindAsync(id);
            if (tableProduct == null)
            {
                return NotFound();
            }

            _context.TableProduct.Remove(tableProduct);
            await _context.SaveChangesAsync();

            return tableProduct;
        }

        private bool TableProductExists(int id)
        {
            return _context.TableProduct.Any(e => e.Id == id);
        }
    }
}
