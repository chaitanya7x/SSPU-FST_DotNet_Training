import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-userinput',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './userinput.component.html',
  styleUrl: './userinput.component.css'
})
export class UserinputComponent {
num: number=0;
result: string="";
charInput: string = "";
charResult: string = "";
// check(): void {
//   if (this.num > 0) {
//     alert('Positive Number: ' + this.num);
//     this.result = "Positive";
//   } else {
//     alert('Negative Number: ' + this.num);
//     this.result = "Negative";
//   }
// }

checkType(): void {
    const char = this.charInput[0];
    if (char >= '0' && char <= '9') {
      this.charResult = "Number";
    } else if ((char >= 'a' && char <= 'z') || (char >= 'A' && char <= 'Z')) {
      this.charResult = "Character";
    } else {
      this.charResult = "Special Symbol";
    }
}
}

