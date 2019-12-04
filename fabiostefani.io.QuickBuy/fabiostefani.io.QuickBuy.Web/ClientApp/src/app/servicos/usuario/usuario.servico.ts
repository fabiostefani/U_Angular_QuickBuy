import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Usuario } from "src/app/modelo/usuario";

@Injectable({
    providedIn: "root"
})

export class UsuarioServico {

    private baseUrl: string;
    private _usuario: Usuario;

    get hearders(): HttpHeaders {
        return new HttpHeaders().set('content-type', 'application/json');
    }

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl
    }

    set usuario(usuario: Usuario) {
        sessionStorage.setItem("usuario-autenticado", JSON.stringify(usuario));
        this._usuario = usuario;
    }

    get usuario(): Usuario {
        let usuario_json = sessionStorage.getItem("usuario-autenticado");
        this._usuario = JSON.parse(usuario_json);
        return this._usuario;
    }

    public usuarioAutenticado(): boolean {
        return this._usuario != null && this._usuario.email != "" && this._usuario.senha != "";
    }

    public limparSessao() {
        sessionStorage.setItem("usuario-autenticado", "");
        this._usuario = null;
    }



    public verificarUsuario(usuario: Usuario): Observable<Usuario> {

        var body = {
            email: usuario.email,
            senha: usuario.senha
        }

        return this.http.post<Usuario>(this.baseUrl + "api/usuario/validar", body, { headers: this.hearders });
    }

    public cadastrarUsuario(usuario: Usuario): Observable<Usuario> {

        return this.http.post<Usuario>(this.baseUrl + "api/usuario", JSON.stringify(usuario), { headers: this.hearders });
    }
}
