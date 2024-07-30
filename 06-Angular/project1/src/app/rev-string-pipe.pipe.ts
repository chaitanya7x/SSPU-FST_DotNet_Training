import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'revStringPipe',
  standalone: true
})
export class RevStringPipePipe implements PipeTransform {

  // transform(value: unknown, ...args: unknown[]): unknown {
  //   return null;
  // }

  transform(value: string):string {
    let newStr:string ="";
    for(let i=value.length-1; i>=0; i--){
      newStr += value[i];
    }
    return newStr;

  }

}
