import {CommonModule, CurrencyPipe} from '@angular/common';
import {HTTP_INTERCEPTORS, HttpClientModule} from '@angular/common/http';
import {NgModule} from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import {BrowserModule} from '@angular/platform-browser';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {TooltipModule} from 'ngx-bootstrap/tooltip';
import {NgxMaskDirective, NgxMaskPipe, provideNgxMask} from 'ngx-mask';
import {ToastrModule} from 'ngx-toastr';

import {AppRoutingModule} from './app-routing.module';
import {AppComponent} from './app.component';
import {
  AdicionarCategoriasComponent
} from './components/categorias/adicionar-categorias/adicionar-categorias.component';
import {EditarCategoriaComponent} from './components/categorias/editar-categoria/editar-categoria.component';
import {ExcluirCategoriaComponent} from './components/categorias/excluir-categoria/excluir-categoria.component';
import {ListarCategoriasComponent} from './components/categorias/listar-categorias/listar-categorias.component';
import {FooterComponent} from './components/footer/footer.component';
import {HomeComponent} from './components/home/home.component';
import {LoginComponent} from './components/login/login.component';
import {NavbarComponent} from './components/navbar/navbar.component';
import {SidebarComponent} from './components/sidebar/sidebar.component';
import {AdicionarUsuarioComponent} from './components/usuario/adicionar-usuario/adicionar-usuario.component';
import {JwtInterceptor} from './security/jwt.interceptor';
import {CpfcnpjMaskDirective} from './shared/directives/cpfcnpj-mask.directive';
import {TelefoneMaskDirective} from './shared/directives/telefone-mask.directive';
import {CpfCnpjPipe} from './shared/pipe/cpf-cnpj.pipe';
import {PhonePipe} from './shared/pipe/phone.pipe';
import {NgxViacepModule} from '@brunoc/ngx-viacep';
import { ListarUsuarioComponent } from './components/usuario/listar-usuario/listar-usuario.component';
import { EditarUsuarioComponent } from './components/usuario/editar-usuario/editar-usuario.component';
import { ExcluirUsuarioComponent } from './components/usuario/excluir-usuario/excluir-usuario.component';


@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FooterComponent,
    ListarCategoriasComponent,
    AdicionarCategoriasComponent,
    ExcluirCategoriaComponent,
    EditarCategoriaComponent,
    LoginComponent,
    HomeComponent,
    AdicionarUsuarioComponent,
    CpfCnpjPipe,
    PhonePipe,
    TelefoneMaskDirective,
    CpfcnpjMaskDirective,
    SidebarComponent,
    ListarUsuarioComponent,
    EditarUsuarioComponent,
    ExcluirUsuarioComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    CommonModule,
    NgxMaskDirective,
    NgxMaskPipe,
    CurrencyPipe,
    NgxViacepModule,
    TooltipModule.forRoot(),
    ToastrModule.forRoot({
      timeOut: 4000,
      closeButton: true,
      progressBar: true
    }),
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    provideNgxMask(),
    CurrencyPipe
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
