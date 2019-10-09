import { Component } from "@angular/core"

@Component({
    selector: "app-produto",
    //template: "<html><body>{{ obterNome() }}</body></html>"
    templateUrl: './produto.component.html'
})
export class ProdutoComponent {
    public nome: string;
    public liberadoParaVenda: boolean;

    public obterNome(): string {
        return "Fabio";
    }
}