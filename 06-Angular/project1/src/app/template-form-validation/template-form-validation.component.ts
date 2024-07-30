import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, NgForm } from '@angular/forms';

@Component({
  selector: 'app-template-form-validation',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './template-form-validation.component.html',
  styleUrl: './template-form-validation.component.css',
})
export class TemplateFormValidationComponent {
  formEmail: string = '';
  formPass: string = '';

  onSubmit(form: NgForm) {
    alert('Information is submitted');
  }
}
