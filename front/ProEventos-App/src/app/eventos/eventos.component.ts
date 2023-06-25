import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent {

  Eventos: any = [];
  EventosFiltrados: any = [];
  renderImage: boolean = false
  private _filtroLista:  string = '';

  public get filtroLista(){


    return this._filtroLista;
  }

  public set filtroLista(value: string){
    this._filtroLista = value;
    this.EventosFiltrados = this._filtroLista ? this.filtrarEventos(this.filtroLista) : this.Eventos
  }


  filtrarEventos(filtraPor: string ): any{
    filtraPor  = filtraPor.toLocaleLowerCase();
    return this.Eventos.filter(
      (evento: any) => evento.tema.toLocaleLowerCase().indexOf(filtraPor) !== -1
    )
  }
  constructor(private http: HttpClient){}

  ngOnInit(): void{
    this.getEventos();
    this.renderImageFunction();
  }

  public getEventos(): void{
    this.http.get('https://localhost:5001/Evento').subscribe(
      response => {
        this.Eventos = response,
        this.EventosFiltrados = response
      },
      error => console.log(error)
    )

  }

  public renderImageFunction(): void{
    this.renderImage = !this.renderImage;
  }
}
