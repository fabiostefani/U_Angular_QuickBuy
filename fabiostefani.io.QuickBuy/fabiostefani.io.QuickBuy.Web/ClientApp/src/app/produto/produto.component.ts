import { Component, OnInit } from "@angular/core"
import { ProdutoServico } from "../servicos/produto/produto.servico";
import { Produto } from "../modelo/produto";

@Component({
    selector: "app-produto",
    //template: "<html><body>{{ obterNome() }}</body></html>"
    templateUrl: "./produto.component.html",
    styleUrls: ["./produto.component.css"]
})
export class ProdutoComponent implements OnInit {
    public produto: Produto;

    constructor(private produtoServico: ProdutoServico) {

    }

    ngOnInit(): void {
        this.produto = new Produto();
    }

    public obterNome(): string {
        return "Fabio";
    }

    public cadastrar() {
        this.produtoServico.cadastrar(this.produto)
            .subscribe(
                produto => {
                    console.log(produto);
                },
                erro => {
                    console.log(erro.error);
                }
            )
    }
}