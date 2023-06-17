import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent {

  constructor(private http: HttpClient){}

  public Eventos: any;

  ngOnInit(): void{
    this.getEventos();
  }

  public getEventos(): void{
    this.http.get('https://localhost:5001/Evento').subscribe(
      response => this.Eventos = response,
      error => console.log(error)
    )

  }
}
