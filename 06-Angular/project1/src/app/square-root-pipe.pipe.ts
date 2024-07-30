import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'squareRootPipe',
  standalone: true
})
export class SquareRootPipePipe implements PipeTransform {

  // transform(value: unknown, ...args: unknown[]): unknown {
  //   return null;
  // }

  transform(value:number):number {
    return Math.sqrt(value);
  }

}
