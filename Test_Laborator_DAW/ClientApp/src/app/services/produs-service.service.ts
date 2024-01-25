import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProdusServiceService {
  private apiUrl= 'http://localhost:5000/api/Produs';

  constructor(private http: HttpClient) { }

  getProdus(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}`);
  }

  addProdus(produs: any): Observable<string> {
    return this.http.post(`${this.apiUrl}`, produs, { responseType: 'text' });
  }

  
}
