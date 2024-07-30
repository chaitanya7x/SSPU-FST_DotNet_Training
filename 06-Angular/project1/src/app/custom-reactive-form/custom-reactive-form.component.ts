import { Component } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, FormGroup, Validators, AbstractControl, ValidationErrors } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { CustomDirectiveDirective } from '../custom-directive.directive';

@Component({
  selector: 'app-custom-reactive-form',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule,CustomDirectiveDirective],
  templateUrl: './custom-reactive-form.component.html',
  styleUrls: ['./custom-reactive-form.component.css']
})

export class CustomReactiveFormComponent {

  fb: FormBuilder = new FormBuilder;
validatorForm=this.fb.group({
  txtAge:['',[Validators.required, AgeValidator]],
})
get txtAge(){
  return this.validatorForm.get('txtAge');
}

  onSubmit():any {
    if (!this.validatorForm.valid) {
      alert('Please enter your Age');
      return false
    } else {
      alert(JSON.stringify(this.validatorForm.value));
      //alert(this.validatorForm.value);
    }
  }
}
export function AgeValidator(control: AbstractControl):
{[key:string]:Boolean} | null{
  if(control.value > 18) {
    return { 'age': true };
  }
  return null;
}
