import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { EmpListComponent } from './emp-list/emp-list.component';
import { AddEmployeeComponent } from './add-emp/add-emp.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,EmpListComponent,AddEmployeeComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'APIsHandling';
}
