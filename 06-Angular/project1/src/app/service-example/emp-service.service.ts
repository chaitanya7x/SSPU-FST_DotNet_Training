import { Injectable } from '@angular/core';
import { Emp } from './emp';

@Injectable({
  providedIn: 'root'
})

export class EmpServiceService {
  employees: Emp[] = [{
    id: 1,
    name: 'John Doe',
    location: 'New York'
  },
  {
    id: 2,
    name: 'Jane Smith',
    location: 'Los Angeles'
  },
  {
    id: 3,
    name: 'Michael Johnson',
    location: 'Chicago'
  }];
  constructor() { }
}
