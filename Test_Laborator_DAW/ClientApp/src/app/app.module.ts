import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProdusServiceService } from './services/produs-service.service';
import { ComandaProdusServiceService } from './services/comanda-produs-service.service';
import { ComandaServiceService } from './services/comanda-service.service';
import { UtilizatorServiceService } from './services/utilizator-service.service';
import { Componenta1Component } from './Components/componenta1/componenta1.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
@NgModule({
  declarations: [
    AppComponent,
    Componenta1Component
  ],
  imports: [
    FormsModule,
    ReactiveFormsModule,
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [
    ComandaProdusServiceService,
    ComandaServiceService,
    UtilizatorServiceService,
    
    ProdusServiceService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
