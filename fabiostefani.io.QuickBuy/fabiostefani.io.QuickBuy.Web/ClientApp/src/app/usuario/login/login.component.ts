import { Component, OnInit } from '@angular/core'
import { Usuario } from 'src/app/modelo/usuario';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {
    public usuario: Usuario;
    // public usuarioAutenticado: boolean;
    public returnUrl: string;

    constructor(private router: Router, private activatedRouter: ActivatedRoute) {

    }

    ngOnInit(): void {
        this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
        this.usuario = new Usuario();
    }

    entrar() {
        if (this.usuario.email == "fabio@teste.com" && this.usuario.senha == "123654") {
            sessionStorage.setItem("usuario-autenticado", "1");
            this.router.navigate([this.returnUrl]);
        }
    }
}