import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-style',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './style.component.html',
  styleUrl: './style.component.css',
})
export class StyleComponent {
  showColor: boolean = false;
  public changeColor(): void {
    this.showColor = !this.showColor;
  }
  constructor() {}
  isValid = true;
  ids = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

  studentList: Array<any> = new Array<any>();
  ngOnInit(): void {
    this.studentList = [
      { rollNo: 1, name: 'Alice', age: 16, grade: 'A', course: 'MCA' },
      { rollNo: 2, name: 'John', age: 18, grade: 'A', course: 'MCA' },
      { rollNo: 3, name: 'Jane', age: 17, grade: 'B', course: 'MCA' },
      { rollNo: 4, name: 'Mike', age: 19, grade: 'C', course: 'MCA' },
    ];
  }
}
