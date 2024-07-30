// import { Component } from '@angular/core';
// import { FormBuilder, FormGroup, Validators } from '@angular/forms';
// import { AbstractControl, ValidationErrors } from '@angular/forms';
// import { CommonModule } from '@angular/common';

// @Component({
//   selector: 'app-prob-assignment',
//   standalone: true,
//   imports: [CommonModule],
//   templateUrl: './prob-assignment.component.html',
//   styleUrl: './prob-assignment.component.css'
// })
// export class ProbAssignmentComponent {
//   form: FormGroup;
//   age: number | null = null;

//   constructor(private fb: FormBuilder) {
//     this.form = this.fb.group({
//       username: ['', [Validators.required, Validators.minLength(6)]],
//       password: ['', [Validators.required]],
//       confirmPassword: ['', [Validators.required]],
//       phone: ['', [Validators.required, Validators.maxLength(10), Validators.pattern('^[0-9]*$')]],
//       dob: ['', [Validators.required, this.ageValidator]]
//     }, { validators: this.passwordMatchValidator });
//   }

//   passwordMatchValidator(form: AbstractControl): ValidationErrors | null {
//     const password = form.get('password')?.value;
//     const confirmPassword = form.get('confirmPassword')?.value;
//     if (password !== confirmPassword) {
//       return { passwordMismatch: true };
//     }
//     return null;
//   }

//   ageValidator(control: AbstractControl): ValidationErrors | null {
//     const dob = new Date(control.value);
//     const age = this.calculateAge(dob);
//     if (age < 18 || age > 100) {
//       return { invalidAge: true };
//     }
//     return null;
//   }

//   calculateAge(dob: Date): number {
//     const diff = Date.now() - dob.getTime();
//     const ageDt = new Date(diff);
//     return Math.abs(ageDt.getUTCFullYear() - 1970);
//   }

//   onSubmit() {
//     if (this.form.valid) {
//       const dob = new Date(this.form.value.dob);
//       this.age = this.calculateAge(dob);
//       alert(`Form submitted successfully. Your age is ${this.age}`);
//     } else {
//       alert('Form is not valid');
//     }
//   }
// }
