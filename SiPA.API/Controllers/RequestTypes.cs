using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiPA.API.Data;
using SiPA.API.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiPA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestTypes : ControllerBase
    {
        private readonly DataContext _context;

        public RequestTypes(DataContext context)
        {
            _context = context;
        }

        //Get api/request
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RequestType>>> GetRequestType()
        {
            return await _context.RequestTypes.ToListAsync();
        }

        //Get api/request/id
        [HttpGet("{id}")]
        public async Task<ActionResult<RequestType>> GetRequestType(int id)
        {
            var requestType = await _context.RequestTypes.FindAsync(id);

            if (requestType == null)
            {
                return NotFound();
            }

            return requestType;
        }

        //POST api/requestType
        [HttpPost("{id}")]
        public async Task<IActionResult> PostRequestType(RequestType requestType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var request = new RequestType
            {
                Id = requestType.Id,
                RequestName = requestType.RequestName
            };

            _context.RequestTypes.Add(request);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRequestType), new { id = requestType.Id }, requestType);
        }
      

        //private bool RequestTypeExists(int id)
        //{
        //    return _context.RequestTypes.Any(e => e.Id == id);
        //}

    }
}
