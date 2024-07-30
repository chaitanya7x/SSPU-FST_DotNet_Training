import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'cubePipe',
  standalone: true,
})
export class CubePipePipe implements PipeTransform {
  // transform(value: unknown, ...args: unknown[]): unknown {
  //   return null;
  // }

  transform(value: number): number {
      return Math.pow(value, 3);
  }
}
