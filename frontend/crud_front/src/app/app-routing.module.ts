import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';

import {
  AdicionarCategoriasComponent
} from './components/categorias/adicionar-categorias/adicionar-categorias.component';
import {EditarCategoriaComponent} from './components/categorias/editar-categoria/editar-categoria.component';
import {ExcluirCategoriaComponent} from './components/categorias/excluir-categoria/excluir-categoria.component';
import {ListarCategoriasComponent} from './components/categorias/listar-categorias/listar-categorias.component';
import {HomeComponent} from './components/home/home.component';
import {LoginComponent} from './components/login/login.component';
import {SidebarComponent} from './components/sidebar/sidebar.component';
import {AdicionarUsuarioComponent} from './components/usuario/adicionar-usuario/adicionar-usuario.component';
import {authGuard} from './security/auth.guard';
import {ListarUsuarioComponent} from "./components/usuario/listar-usuario/listar-usuario.component";
import {EditarUsuarioComponent} from "./components/usuario/editar-usuario/editar-usuario.component";
import {ExcluirUsuarioComponent} from "./components/usuario/excluir-usuario/excluir-usuario.component";

const routes: Routes = [

  // { path: '', redirectTo: 'login', pathMatch: 'full'},
  { path: 'login', component: LoginComponent },
  { path: 'adicionarusuario', component: AdicionarUsuarioComponent },


  { path: '', component: SidebarComponent, canActivate:[authGuard], children:[
    { path: 'home', component: HomeComponent },

    { path: 'categorias', component: ListarCategoriasComponent, canActivate:[authGuard]},
    { path: 'categorias/create', component: AdicionarCategoriasComponent, canActivate:[authGuard] },
    { path: 'categorias/update/:id', component: EditarCategoriaComponent, canActivate:[authGuard] },
    { path: 'categorias/delete/:id', component: ExcluirCategoriaComponent, canActivate:[authGuard] },

    { path: 'usuarios', component: ListarUsuarioComponent, canActivate:[authGuard] },
    { path: 'usuarios/update/:id', component: EditarUsuarioComponent, canActivate:[authGuard] },
    { path: 'usarios/delete/:id', component: ExcluirUsuarioComponent, canActivate:[authGuard] },



    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
