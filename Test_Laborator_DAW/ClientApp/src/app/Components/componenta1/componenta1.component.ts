import { Component } from '@angular/core';
import { UtilizatorServiceService } from '../../services/utilizator-service.service';
import { ComandaProdusServiceService } from '../../services/comanda-produs-service.service';
import { ComandaServiceService } from '../../services/comanda-service.service';
import { ProdusServiceService } from '../../services/produs-service.service';
import { FormBuilder,FormGroup } from '@angular/forms';

@Component({
  selector: 'app-componenta1',
  templateUrl: './componenta1.component.html',
  styleUrl: './componenta1.component.css'
})
export class Componenta1Component {
  addProdus!:FormGroup;
  addComanda!:FormGroup;
  addComandaProdus!:FormGroup;
  getProdus!:FormGroup;
  getComanda!:FormGroup;
  getComandaProdus!:FormGroup;
  produse:any[]=[];
  constructor(private fb:FormBuilder,private comandaService:ComandaServiceService,private produsService:ProdusServiceService,private comandaProdusService:ComandaProdusServiceService){}
  ngOnInit(){
    this.addProdus=this.fb.group({
      Nume:'',
      Pret:''
    });
    this.addComanda=this.fb.group({
      Adresa:''
    });
    this.addComandaProdus=this.fb.group({
      Id_Comanda:'',
      Id_Produs:''
    });
    
    this.produsService.getProdus().subscribe(data => {
      this.produse = data;
    },
    (error)=>{
      console.error('Error',error);
    }
    );
  }
  addNewComandaProdus():void{
    let idc=this.addComandaProdus.get("Id_Comanda")?.value;
    let idp=this.addComandaProdus.get("Id_Produs")?.value;
    this.comandaProdusService.addComandaProdus(idc,idp).subscribe(
      (data:string)=>{
        console.log(data);
        
      },
      (error)=>{
        console.error;
      }
    )
  }
  addNewComanda():void{
    const comanda={
      adresa:this.addComanda.get("Adresa")?.value,
      
    }
    
    this.comandaService.addComanda(comanda).subscribe(
      (data:string)=>{
        console.log(data);
        
      },
      (error)=>{
        console.error;
      }
    )
  }
  addNewProdus():void{
    
    const produs={
      nume:this.addProdus.get("Nume")?.value,
      pret:this.addProdus.get("Pret")?.value
    }
    
    this.produsService.addProdus(produs).subscribe(
      (data:string)=>{
        console.log(data);
        
      },
      (error)=>{
        console.error;
      }
    )
  }
}
