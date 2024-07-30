import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Student } from '../student';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-array-print',
  standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './array-print.component.html',
  styleUrl: './array-print.component.css'
})
export class ArrayPrintComponent {

  fruits: string[] = ['apple', 'orange', 'banana'];
  numArray: number[] = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

  StudentList: Student[] = [
    { name: "Student1", rollNo: 1, age: 20 },
    { name: "Student2", rollNo: 2, age: 30 },
    { name: "Student3", rollNo: 3, age: 40 }
  ];

  cities:string[] = ['Pune','Nashik','Mumbai','Los Angeles'];
  selectedCity: string = '';
}
