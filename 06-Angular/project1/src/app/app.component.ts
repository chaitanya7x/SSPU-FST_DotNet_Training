import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AttributeComponent } from './attribute/attribute.component';
import { UserinputComponent } from './userinput/userinput.component';
import { ArrayPrintComponent } from './array-print/array-print.component';
import { StyleComponent } from './style/style.component';
import { PipeDemoComponent } from './pipe-demo/pipe-demo.component';
import { FormsComponent } from './forms/forms.component';
import { TemplateFormValidationComponent } from './template-form-validation/template-form-validation.component';
import { ReactiveFormComponent } from './reactive-form/reactive-form.component';
import { CustomReactiveFormComponent } from './custom-reactive-form/custom-reactive-form.component';
// import{prob}
import { DIExampleComponent } from './diexample/diexample.component';
import { ServiceExampleComponent } from './service-example/service-example.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,AttributeComponent,UserinputComponent,ArrayPrintComponent,StyleComponent,PipeDemoComponent,FormsComponent,TemplateFormValidationComponent,ReactiveFormComponent,CustomReactiveFormComponent,DIExampleComponent,ServiceExampleComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'project1';
}
