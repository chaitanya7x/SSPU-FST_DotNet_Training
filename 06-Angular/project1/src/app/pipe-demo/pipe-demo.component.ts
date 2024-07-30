import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { SquareRootPipePipe } from '../square-root-pipe.pipe';
import { RevStringPipePipe } from '../rev-string-pipe.pipe';
import { CubePipePipe } from '../cube-pipe.pipe';
import { PalindromePipe } from '../palindrome.pipe';

@Component({
  selector: 'app-pipe-demo',
  standalone: true,
  imports: [CommonModule,FormsModule,SquareRootPipePipe,RevStringPipePipe,CubePipePipe,PalindromePipe],
  templateUrl: './pipe-demo.component.html',
  styleUrl: './pipe-demo.component.css'
})
export class PipeDemoComponent {
today:Date = new Date();
months=['Jan','Feb','Mar','Apr','May','Jun','Jul','Aug','Sep','oct','Nov','Dec'];
Celsius:number = 0;
myName:string ='ChaitanyA';
numberInput:number = 0;
inputString='';
}
