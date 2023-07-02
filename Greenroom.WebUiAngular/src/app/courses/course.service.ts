import { Observable } from 'rxjs';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { baseUrl } from '../shared/app-constants';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  path = "/Courses"
  constructor(private http: HttpClient) { }

  getCourseById(id: number): Observable<Course> {
    return this.http.get(`${baseUrl}/${this.path}`, {params: new HttpParams().set('id', id)}) as Observable<Course>;
  }

  getCoursesByUserId(userId: number): Observable<Course[]> {
    return this.http.get(`${baseUrl}/${this.path}`, {params: new HttpParams().set('userId', userId)}) as Observable<Course[]>;
  }
}

export interface Course {
  id: number;
  title: string;
  description?: string;
  userCourseId: number;
}
