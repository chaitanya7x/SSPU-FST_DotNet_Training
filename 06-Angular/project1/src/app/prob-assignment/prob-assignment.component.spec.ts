import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProbAssignmentComponent } from './prob-assignment.component';

describe('ProbAssignmentComponent', () => {
  let component: ProbAssignmentComponent;
  let fixture: ComponentFixture<ProbAssignmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProbAssignmentComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProbAssignmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
