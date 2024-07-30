import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  FormBuilder,
  ReactiveFormsModule,
  FormGroup,
  Validators,
} from '@angular/forms';

@Component({
  selector: 'app-reactive-form',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './reactive-form.component.html',
  styleUrl: './reactive-form.component.css',
})
export class ReactiveFormComponent {
  myForm!: FormGroup;

  constructor(private formBuilder: FormBuilder) {
    this.CreateForm();
  }
  CreateForm() {
    this.myForm = this.formBuilder.group({
      fname: this.formBuilder.control<String>('', [
        Validators.required,
        Validators.minLength(4),
      ]),
      lname: this.formBuilder.control<String>('', [Validators.required]),
      age: this.formBuilder.control<number>(0, [Validators.required]),
    });
  }
}
