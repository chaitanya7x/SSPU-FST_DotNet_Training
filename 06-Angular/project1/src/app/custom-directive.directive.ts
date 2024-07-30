import { Directive, Input, TemplateRef, ViewContainerRef } from '@angular/core';

@Directive({
  selector: '[appCustomDirective]',
  standalone: true
})
export class CustomDirectiveDirective {
  constructor(
    private templateRef: TemplateRef<any>,
    private viewContainerRef: ViewContainerRef
  ) {}

  @Input('appCustomDirective') set loop(num: number) {
    for (var i = 0; i < num; i++) {
      this.viewContainerRef.createEmbeddedView(this.templateRef);
    }
  }
}
