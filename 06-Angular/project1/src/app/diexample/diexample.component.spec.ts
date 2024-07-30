import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DIExampleComponent } from './diexample.component';

describe('DIExampleComponent', () => {
  let component: DIExampleComponent;
  let fixture: ComponentFixture<DIExampleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DIExampleComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DIExampleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
