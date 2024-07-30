import { Component, OnInit } from '@angular/core';
import { RestService } from '../rest.service';
import { CommonModule } from '@angular/common';
import { Employee } from '../employee';
import { HttpClientJsonpModule } from '@angular/common/http';

@Component({
  selector: 'app-emp-list',
  standalone: true,
  imports: [CommonModule,HttpClientJsonpModule],
  templateUrl: './emp-list.component.html',
  styleUrls: ['./emp-list.component.css'],
})
export class EmpListComponent implements OnInit {
  employees: Employee[] = [];

  constructor(public restApi: RestService) {}

  ngOnInit() {
    this.loadEmployees();
  }

  loadEmployees() {
    this.restApi.getEmployees().subscribe((data: Employee[]) => {
      this.employees = data;
    });
  }
}
