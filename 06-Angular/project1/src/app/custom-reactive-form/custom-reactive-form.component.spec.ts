import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomReactiveFormComponent } from './custom-reactive-form.component';

describe('CustomReactiveFormComponent', () => {
  let component: CustomReactiveFormComponent;
  let fixture: ComponentFixture<CustomReactiveFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CustomReactiveFormComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CustomReactiveFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
