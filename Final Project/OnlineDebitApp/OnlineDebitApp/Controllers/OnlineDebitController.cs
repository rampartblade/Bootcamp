using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineDebitApp.Data;
using OnlineDebitApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineDebitApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class OnlineDebitController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public OnlineDebitController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var items = await _context.CreditCardDetails.ToListAsync();
            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem (ItemData data)
        {
            if (ModelState.IsValid)
            {
                await _context.CreditCardDetails.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new { data.paymentDetailId }, data);
            }
            return new JsonResult("Something Went Wrong") { StatusCode = 500 };
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _context.CreditCardDetails.FirstOrDefaultAsync(x => x.paymentDetailId == id);

            if(item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, ItemData item)
        {
            if(id != item.paymentDetailId)
            {
                return BadRequest();
            }

            var existItem = await _context.CreditCardDetails.FirstOrDefaultAsync(x => x.paymentDetailId == id);

            if(existItem == null)
            {
                return NotFound();
            }
            existItem.cardOwnerName = item.cardOwnerName;
            existItem.cardNumber = item.cardNumber;
            existItem.expirationDate = item.expirationDate;
            existItem.securityCode = item.securityCode;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _context.CreditCardDetails.FirstOrDefaultAsync(x => x.paymentDetailId == id);

            if(existItem == null)
            {
                return NotFound();
            }

            _context.CreditCardDetails.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok(existItem);
        }
    }
}
