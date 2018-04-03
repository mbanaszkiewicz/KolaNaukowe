import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AppRoutingModule } from './/app-routing.module';
import { AdvancedSearchComponent } from './advanced-search/advanced-search.component';
import { ModalLoginComponent } from './modal-login/modal-login.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AdvancedSearchComponent,
    ModalLoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
