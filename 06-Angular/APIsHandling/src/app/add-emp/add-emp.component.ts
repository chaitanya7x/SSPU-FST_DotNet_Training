import { Component } from '@angular/core';
import { RestService } from '../rest.service';
import { CommonModule } from '@angular/common';
import { Employee } from '../employee';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-emp',
  standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './add-emp.component.html',
  styleUrl: './add-emp.component.css'
})
export class AddEmployeeComponent {
  employee: Employee = new Employee();

  constructor(public restApi: RestService) {}

  addEmployee() {
    this.restApi.addEmployee(this.employee).subscribe({
      next: (data: Employee) => {
        console.log('Employee added successfully!', data);
        this.employee = new Employee(); // Reset the form
      },
      error: (error) => {
        console.error('Error adding employee!', error);
      }
    });
  }
}
