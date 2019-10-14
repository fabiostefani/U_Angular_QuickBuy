import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {

  constructor(private router: Router) {

  }

  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  public usuarioLogado(): boolean {
    var autenticado = sessionStorage.getItem("usuario-autenticado");
    return autenticado == "1";
  }

  sair() {
    sessionStorage.setItem("usuario-autenticado", "0");
    this.router.navigate(['/']);
  }
}
