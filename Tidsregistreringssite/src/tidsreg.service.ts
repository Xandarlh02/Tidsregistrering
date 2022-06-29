import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Tidsreg } from 'src/classes/tidsreg';

@Injectable({
  providedIn: 'root'
})
export class TidsregService {
  url = 'https://localhost:44387/api/Tidsreg';
  constructor(private http: HttpClient) { }
  getAllTidsregs(): Observable<Tidsreg[]> {
    return this.http.get<Tidsreg[]>(this.url + '/GetReg');
  }

  createTidsreg(tidsreg: any): Observable<Tidsreg> {
    console.log("Test")
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'}) };
    return this.http.post<any>(this.url + '/PostReg',
    tidsreg, httpOptions);
  }
}
