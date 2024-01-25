import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ComandaProdusServiceService {
  private apiUrl= 'http://localhost:5000/api/ComandaProdus';

  constructor(private http: HttpClient) { }

  getComandaProdus(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}`);
  }

  addComandaProdus(comId:string,prodId:string): Observable<string> {
    return this.http.post(`${this.apiUrl}?id_com=${comId}&id_prod=${prodId}`, null, { responseType: 'text' });
  }

  
}
