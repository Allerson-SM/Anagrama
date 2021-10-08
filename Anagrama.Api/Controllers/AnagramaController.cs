using Anagrama.Api.Data;
using Anagrama.Api.Service;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Anagrama.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnagramaController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;
        private AnagramaService _service;

        public AnagramaController(AppDbContext context, IMapper mapper, AnagramaService service)
        {
            _context = context;
            _mapper = mapper;
            _service = service;
        }

        [HttpGet("{palavra}")]
        public IActionResult RetornaPalavra(string palavra)
        {
            var lista = _service.ProcurarPalavra(palavra);

            if (lista != null)
            {
                return Ok(lista);
            }
            else
            {
                return NotFound();
            }
        }
    }
}