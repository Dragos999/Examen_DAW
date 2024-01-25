import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UtilizatorServiceService{
  private apiUrl= 'http://localhost:5000/api/Utilizator';

  constructor(private http: HttpClient) { }

  getUtilizator(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}`);
  }

  addUtilizator(utilizator: any): Observable<string> {
    return this.http.post(`${this.apiUrl}`, utilizator, { responseType: 'text' });
  }

  
}
