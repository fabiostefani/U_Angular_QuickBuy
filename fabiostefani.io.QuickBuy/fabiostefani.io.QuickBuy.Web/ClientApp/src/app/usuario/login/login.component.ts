import { Component, OnInit } from '@angular/core'
import { Usuario } from 'src/app/modelo/usuario';
import { Router, ActivatedRoute } from '@angular/router';
import { UsuarioServico } from 'src/app/servicos/usuario/usuario.servico';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {
    public usuario: Usuario;
    public returnUrl: string;
    public mensagem: string;
    private ativarSpinner: boolean;

    constructor(private router: Router, private activatedRouter: ActivatedRoute,
        private usuarioServico: UsuarioServico) {

    }

    ngOnInit(): void {
        this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
        this.usuario = new Usuario();
    }

    entrar() {
        this.ativarSpinner = true;
        this.usuarioServico.verificarUsuario(this.usuario)
            .subscribe(
                usuario_json => {
                    // var usuarioRetorno: Usuario;
                    // usuarioRetorno = data;

                    // sessionStorage.setItem("usuario-autenticado", "1");
                    // sessionStorage.setItem("email-usuario", usuarioRetorno.email);
                    this.usuarioServico.usuario = usuario_json;

                    if (this.returnUrl == null) {
                        this.router.navigate(['/']);
                    } else {
                        this.router.navigate([this.returnUrl]);
                    }
                },
                err => {
                    console.log(err.error);
                    this.mensagem = err.error;
                    this.ativarSpinner = false;
                }
            );
        // this.ativarSpinner = false;
        // if (this.usuario.email == "fabio@teste.com" && this.usuario.senha == "123654") {
        //     sessionStorage.setItem("usuario-autenticado", "1");
        //     
        // }
    }
}