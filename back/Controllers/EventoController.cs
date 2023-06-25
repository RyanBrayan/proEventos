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
    
    [HttpPost]
    public IActionResult Post(Evento evento){
        var eventoA = new Evento();
        eventoA.DataEvento = evento.DataEvento;
        eventoA.ImageUrl = evento.ImageUrl;
        eventoA.Local = evento.Local;
        eventoA.QtdPessoas = evento.QtdPessoas;
        eventoA.Tema = evento.Tema;
        _context.eventos.Add(eventoA);
        _context.SaveChanges();
        
        return Ok();
    }
}
