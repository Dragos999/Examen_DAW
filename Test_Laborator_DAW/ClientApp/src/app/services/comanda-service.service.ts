import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ComandaServiceService {
  private apiUrl= 'http://localhost:5000/api/Comanda';

  constructor(private http: HttpClient) { }

  getComanda(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}`);
  }

  addComanda(comanda: any): Observable<string> {
    
    return this.http.post(`${this.apiUrl}`, comanda, { responseType: 'text' });
  }

  
}
