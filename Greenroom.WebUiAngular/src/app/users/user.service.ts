import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { baseUrl } from '../shared/app-constants';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  getById(id: number): Observable<User> {
    return this.http.get(`${baseUrl}/Users`, {params: new HttpParams().set('id', id)}) as Observable<User>;
  }
}

export interface User {
  id: number;
  firstName: string;
  lastName: string;
  email: string;
  password: string;
}
