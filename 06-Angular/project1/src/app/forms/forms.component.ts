import { Component,NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, NgForm } from '@angular/forms';

@Component({
  selector: 'app-forms',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './forms.component.html',
  styleUrls: ['./forms.component.css']
})
export class FormsComponent {
  contact = {
    fname: '',
    lname: '',
    email: '',
    phone: '',
    gender: '',
    country: '',
    message: '',
    address: {
      street: '',
      city: '',
      state: ''
    }
  };
  a: any=null;
  // formData: any = {};
  // submitted = false;

  // onSubmit(form: NgForm) {
  //   this.formData = form.value;
  //   this.submitted = true;
  //   console.log('Form Data:', this.formData);
  // }

  countryList = [
    { id: 'us', name: 'United States' },
    { id: 'ca', name: 'Canada' },
    { id: 'uk', name: 'United Kingdom' },
  ];

  onSubmit(form: any): void {
    if (form.valid) {
      // Store form data
      this.a = form.value;
      // You can also perform additional operations here like sending data to a server
      console.log('Form Submitted!', this.a);
    } else {
      console.log('Form is not valid');
    }
  }
}
