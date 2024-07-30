import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserinputComponent } from './userinput.component';

describe('UserinputComponent', () => {
  let component: UserinputComponent;
  let fixture: ComponentFixture<UserinputComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [UserinputComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UserinputComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
