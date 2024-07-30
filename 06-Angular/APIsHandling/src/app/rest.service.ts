// rest.service.ts
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, Observable, retry, throwError } from 'rxjs';
import { Employee } from './employee';

@Injectable({
  providedIn: 'root'
})
export class RestService {
  apiURL = 'http://localhost:3000';

  constructor(private http: HttpClient) {}

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  };

  getEmployees(): Observable<Employee[]> {
    return this.http.get<Employee[]>(`${this.apiURL}/employees`)
      .pipe(
        retry(1),
        catchError(this.handleError)
      );
  }

  addEmployee(employee: Employee): Observable<Employee> {
    return this.http.post<Employee>(`${this.apiURL}/employees`, JSON.stringify(employee), this.httpOptions)
      .pipe(
        retry(1),
        catchError(this.handleError)
      );
  }

  handleError(error: any) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      errorMessage = error.error.message;
    } else {
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    window.alert(errorMessage);
    return throwError(errorMessage);
  }
}
