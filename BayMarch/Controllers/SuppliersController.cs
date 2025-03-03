﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BayMarch.Models;
using BayMarch.Dto.Filter;
using BayMarch.Services;

namespace BayMarch.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly ISupplierService _supplierService;

        public SuppliersController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }


        // GET: api/suppliers
        //[HttpGet]
        //[Route("GetAll")]
        //public IActionResult GetAll()
        //{
        //    return Ok(_supplierService.GetAll());
        //}

        // GET: api/suppliers
        [HttpGet]
        [Route("GetDefault")]
        public IActionResult GetDefault()
        {
            return Ok(_supplierService.GetDefault());
        }

        // GET: api/suppliers
        [HttpGet]
        [Route("GetPage")]
        public IActionResult GetPage([FromQuery] DefaultFilter defaultFilter)
        {
            return Ok(_supplierService.GetPage(defaultFilter));
        }

        // GET: api/suppliers/5
        [HttpGet("{id}")]
        [Route("Get/{id}")]
        public IActionResult GetSupplier(long id)
        {
            var supplier = _supplierService.Get(id);

            if (supplier == null)
            {
                return NotFound();
            }

            return Ok(supplier);
        }

        // PUT: api/suppliers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Route("Update/{id}")]
        public IActionResult PutSupplier(long id, Supplier supplier)
        {
            if (id != supplier.SupplierId)
            {
                return BadRequest();
            }

            if (_supplierService.Update(supplier))
            {
                return Ok(supplier);
            }
            else
            {
                return NotFound();
            }

        }

        // POST: api/suppliers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("Create")]
        public IActionResult PostSupplier(Supplier supplier)
        {
            if (_supplierService.Create(supplier))
            {
                return CreatedAtAction("GetSupplier", new { id = supplier.SupplierId }, supplier);
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE: api/suppliers/5
        [HttpDelete("{id}")]
        [Route("Delete")]
        public IActionResult DeleteSupplier(long id)
        {
            if (_supplierService.Delete(id))
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

    }
}


/*

        // GET: api/Suppliers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Supplier>>> GetSupplier()
        {
            return await _context.Supplier.ToListAsync();
        }

        // GET: api/Suppliers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Supplier>> GetSupplier(long id)
        {
            var supplier = await _context.Supplier.FindAsync(id);

            if (supplier == null)
            {
                return NotFound();
            }

            return supplier;
        }

        // PUT: api/Suppliers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplier(long id, Supplier supplier)
        {
            if (id != supplier.SupplierId)
            {
                return BadRequest();
            }

            _context.Entry(supplier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierExists(id))
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

        // POST: api/Suppliers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Supplier>> PostSupplier(Supplier supplier)
        {
            _context.Supplier.Add(supplier);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSupplier", new { id = supplier.SupplierId }, supplier);
        }

        // DELETE: api/Suppliers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplier(long id)
        {
            var supplier = await _context.Supplier.FindAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }

            _context.Supplier.Remove(supplier);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupplierExists(long id)
        {
            return _context.Supplier.Any(e => e.SupplierId == id);
        }
    }
}

*/

