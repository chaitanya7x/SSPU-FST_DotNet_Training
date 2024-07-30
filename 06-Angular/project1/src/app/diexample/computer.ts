import { Cpu } from './cpu';
import { Keyboard } from './keyboard';
import { Monitor } from './monitor';

export class Computer {
  public monitor: Monitor;
  public cpu: Cpu;
  public keyboard: Keyboard;
  public myString: string = 'myComputer';

  constructor() {
    this.monitor = new Monitor();
    this.cpu = new Cpu();
    this.keyboard = new Keyboard();
  }

  public complete() {
    return `${this.myString} has ${this.monitor.monitorNo} Monitors, ${this.cpu.cpuNo} CPUs and ${this.keyboard.keyboardNo} Keyboards`;
  }
}
