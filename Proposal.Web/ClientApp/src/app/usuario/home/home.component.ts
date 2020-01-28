import { Component } from "@angular/core";
import {Usuario} from "../../models/usuario";


export class HomeComponent {
    public usuarioAutenticado: boolean;
    public usuario;
    public email;

    public senha;
    constructor() {
        this.usuario = new Usuario();
    }

    entrar() {
        if(this.usuario.email == "lester.cerioli@blendit.com.br" && this.usuario.senha == "Consultoria@7359") {
            this.usuarioAutenticado = true;
        }
    }
    
}