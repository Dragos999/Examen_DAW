import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Componenta1Component } from './Components/componenta1/componenta1.component';

const routes: Routes = [
  {path:'',component:Componenta1Component}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
  