using back.Data;
using back.models;
using Microsoft.AspNetCore.Mvc;

namespace back.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoController : ControllerBase
{


    private readonly DataContext _context;
    public EventoController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.eventos;
    }


    [HttpGet("{id}")]
    public Evento GetById(int id)
    {

        return _context.eventos.FirstOrDefault(evento => evento.EventoId == id);
    }
}
