import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';

import { HomeComponent } from './home/home.component';
import { AdvancedSearchComponent } from './advanced-search/advanced-search.component';

const routes: Routes = [
  // { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'advancedSearch', component: AdvancedSearchComponent, pathMatch: 'full' }
];
@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [
    RouterModule
  ],
  declarations: []
})

export class AppRoutingModule { }
