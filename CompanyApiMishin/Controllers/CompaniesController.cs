using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CompanyApiMishin.Models;

namespace CompanyApiMishin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly Context _context;

        public CompaniesController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Company>> GetAll()
        {
            return await _context.Companies.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompanyById(int id)
        {
            var company = await _context.Companies.FindAsync(id);

            if (company == null)
            {
                return NotFound();
            }

            return company;
        }

        [HttpGet("/Name")]
        public async Task<IEnumerable<Company>> GetName(string name)
        {
            return await _context.Companies.Where(n  => n.Name.Contains(name)).ToListAsync();
        }

        [HttpGet("/Description")]
        public async Task<IEnumerable<Company>> GetDescription(string description)
        {
            return await _context.Companies.Where(o => o.Description.StartsWith(description)).ToListAsync();
        }

        [HttpGet("/Motherland")]
        public async Task<IEnumerable<Company>> GetMotherland(string motherland)
        {
            return await _context.Companies.Where(m => m.Motherland.Contains(motherland)).ToListAsync();
        }

        [HttpGet("/FoundationDate")]
        public async Task<IEnumerable<Company>> GetFoundationDate(int year)
        {
            return await _context.Companies.Where(d => d.FoundationDate.Year == year).ToListAsync();
        }

    }
}
