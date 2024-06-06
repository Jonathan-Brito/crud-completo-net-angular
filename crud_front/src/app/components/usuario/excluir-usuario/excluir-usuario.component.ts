import { Component } from '@angular/core';
import {Categoria} from "../../../models/Categoria";
import {CategoriaService} from "../../../services/categoria.service";
import {ActivatedRoute, Router} from "@angular/router";
import {ToastrService} from "ngx-toastr";
import {Usuario} from "../../../models/Usuario";
import {UsuarioService} from "../../../services/usuario.service";

@Component({
  selector: 'app-excluir-usuario',
  templateUrl: './excluir-usuario.component.html',
  styleUrls: ['./excluir-usuario.component.css']
})
export class ExcluirUsuarioComponent {

  usuario: Usuario = {
    nome:'',
    sobrenome:'',
    email:'',
    senha:'',
  }

  constructor(
    private usuarioService: UsuarioService,
    private route: ActivatedRoute,
    private router: Router,
    private toastService: ToastrService,
  ){}

  ngOnInit(): void {
    this.usuario.id = this.route.snapshot.paramMap.get('id');
    this.findById();
  }

  findById(): void {
    this.usuarioService.findById(this.usuario.id).subscribe(resposta => {
      this.usuario = resposta;
    }, ex => {
      this.toastService.error(ex.error.error);
    })
  }

  delete(): void {
    this.usuarioService.delete(this.usuario.id).subscribe(() => {
      this.toastService.success('Usuario deletado com sucesso', 'Deletar');
      this.router.navigate(['usuarios'])
    }, ex => {
      if(ex.error.errors) {
        ex.error.errors.forEach((element: { message: string | undefined; }) => {
          this.toastService.error(element.message);
        });
      } else {
        this.toastService.error(ex.error.message);
      }
    })
  }

  cancelar(){
    this.router.navigate(['/usuarios']);
  }
}
