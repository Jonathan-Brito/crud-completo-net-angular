import {Component} from '@angular/core';
import {Usuario} from "../../../models/Usuario";
import {UsuarioService} from "../../../services/usuario.service";

@Component({
  selector: 'app-listar-usuario',
  templateUrl: './listar-usuario.component.html',
  styleUrls: ['./listar-usuario.component.css']
})
export class ListarUsuarioComponent {

  usuarios: Usuario[]=[];

  constructor(private service: UsuarioService){}

  ngOnInit(): void {
    this.findAll();
  }

  findAll(): void {
    this.service.findAll().subscribe((usuarios) => {
      this.usuarios = usuarios;
    });
  }
}
