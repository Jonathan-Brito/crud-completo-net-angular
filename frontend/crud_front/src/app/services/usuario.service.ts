import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Usuario } from '../models/Usuario';
import { Observable } from 'rxjs';
import {Categoria} from "../models/Categoria";

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  private readonly API = 'http://localhost:8080/lynxprocess/usuarios'

  constructor(
    private http: HttpClient
  ) { }

  create(usuario: Usuario): Observable<Usuario>{
    return this.http.post<Usuario>(this.API, usuario);
  }

  findAll(): Observable<Usuario[]>{
    return this.http.get<Usuario[]>(this.API);
  }

  findById(id: number): Observable<Usuario> {
    const url = `${this.API}/${id}`
    return this.http.get<Usuario>(url)
  }

  update(usuario: Usuario): Observable<Usuario> {
    const url = `${this.API}/${usuario.id}`;
    return this.http.put<Usuario>(url, usuario);
  }

  delete(id: number): Observable<Usuario> {
    const url = `${this.API}/${id}`;
    return this.http.delete<Usuario>(url);
  }
}
