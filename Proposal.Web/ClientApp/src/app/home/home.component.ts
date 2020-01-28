import { Component } from '@angular/core';
import { Usuario } from '../models/usuario';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  

  public usuario = new Usuario();

  constructor() {
    this.usuario = new Usuario();
  }

  entrar() {
    
    if(this.usuario.email == "admin@blendit.com.br" && this.usuario.senha == "$blendit@7436") {
      
    }
  }
}
