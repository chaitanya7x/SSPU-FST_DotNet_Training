import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'palindrome',
  standalone: true
})
export class PalindromePipe implements PipeTransform {

  // transform(value: unknown, ...args: unknown[]): unknown {
  //   return null;
  // }

  transform(value: string): string {

    value = value.toLowerCase();

    let start = 0;
    let end = value.length - 1;

    while (start < end) {
      if (value[start] !== value[end]) {
        return 'It is not a palindrome';
      }
      start++;
      end--;
    }

    return 'It is a palindrome';
  }
}
