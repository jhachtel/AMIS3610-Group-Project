import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GearRowComponent } from './gear-row.component';

describe('GearRowComponent', () => {
  let component: GearRowComponent;
  let fixture: ComponentFixture<GearRowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GearRowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GearRowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
