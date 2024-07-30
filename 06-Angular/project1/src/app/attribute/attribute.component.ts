import { Component } from '@angular/core';
import {FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-attribute',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './attribute.component.html',
  styleUrl: './attribute.component.css'
})
export class AttributeComponent {
uname: string='';
pid: string='';
num=10;
alpha='u';
a=-5;
}
