import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmpServiceService } from './emp-service.service';
import { Emp } from './emp';

@Component({
  selector: 'app-service-example',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './service-example.component.html',
  styleUrl: './service-example.component.css'
})
export class ServiceExampleComponent {

  employees: Emp[];

  constructor(empService: EmpServiceService) {
    this.employees = empService.employees;
  }
}
