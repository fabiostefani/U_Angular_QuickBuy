import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Produto } from "../../modelo/produto";

@Injectable({
    providedIn: "root"
})

export class ProdutoServico implements OnInit {
    private baseUrl: string;
    public produtos: Produto[];

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl
    }

    ngOnInit(): void {
        this.produtos = [];
    }

    get hearders(): HttpHeaders {
        return new HttpHeaders().set('content-type', 'application/json');
    }

    public cadastrar(produto: Produto): Observable<Produto> {
        return this.http.post<Produto>(this.baseUrl + "api/Produto", JSON.stringify(produto), { headers: this.hearders });
    }

    public salvar(produto: Produto): Observable<Produto> {
        return this.http.put<Produto>(this.baseUrl + "api/Produto", JSON.stringify(produto), { headers: this.hearders });
    }

    public deletar(produto: Produto): Observable<Produto> {
        return this.http.post<Produto>(this.baseUrl + "api/Produto", JSON.stringify(produto), { headers: this.hearders });
    }

    public obterTodosProdutos(): Observable<Produto[]> {
        return this.http.get<Produto[]>(this.baseUrl + "api/Produto");
    }

    public obterProduto(produtoId: number): Observable<Produto> {
        return this.http.get<Produto>(this.baseUrl + "api/Produto");
    }
}