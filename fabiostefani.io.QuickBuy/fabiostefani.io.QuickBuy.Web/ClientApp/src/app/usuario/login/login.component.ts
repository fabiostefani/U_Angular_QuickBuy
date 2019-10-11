import { Component } from '@angular/core'
import { Usuario } from 'src/app/modelo/usuario';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})

export class LoginComponent {
    public usuario: Usuario;
    public usuarioAutenticado: boolean;

    constructor() {
        this.usuario = new Usuario();
    }

    entrar() {
        if (this.usuario.email == "fabio@teste.com" && this.usuario.senha == "123654") {
            this.usuarioAutenticado = true;
        }
    }
}