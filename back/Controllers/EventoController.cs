using back.models;
using Microsoft.AspNetCore.Mvc;

namespace back.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoController : ControllerBase
{

    public IEnumerable<Evento> _evento = new Evento []{
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11",
                Local =  "Sao  paulo",
                Lote ="1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString()
            },
            new Evento(){
                EventoId = 2,
                Tema = "Angular 123",
                Local =  "Osascp",
                Lote ="3º Lote",
                QtdPessoas = 200,
                DataEvento = DateTime.Now.AddDays(2).ToString()
            }
        };


    public EventoController()
    {
        
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    
    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        
        return _evento.Where(evento => evento.EventoId == id);
    }
}
