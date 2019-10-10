import { Component } from '@angular/core'

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})

export class LoginComponent {
    public email = "fabio@teste.com";
    public senha = "1254";

    entrar() {
        alert(this.email + this.senha);
    }
}