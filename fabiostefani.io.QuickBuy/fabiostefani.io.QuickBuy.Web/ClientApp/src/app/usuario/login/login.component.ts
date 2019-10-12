import { Component } from '@angular/core'
import { Usuario } from 'src/app/modelo/usuario';
import { Router } from '@angular/router';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})

export class LoginComponent {
    public usuario: Usuario;
    public usuarioAutenticado: boolean;

    constructor(private router: Router) {
        this.usuario = new Usuario();
    }

    entrar() {
        if (this.usuario.email == "fabio@teste.com" && this.usuario.senha == "123654") {
            localStorage.setItem("usuario-autenticado", "1");
            //this.router.navigate(['/']);
        }
    }
}