import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ArrayPrintComponent } from './array-print.component';

describe('ArrayPrintComponent', () => {
  let component: ArrayPrintComponent;
  let fixture: ComponentFixture<ArrayPrintComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ArrayPrintComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ArrayPrintComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
