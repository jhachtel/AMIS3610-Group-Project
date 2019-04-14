import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GearSearchComponent } from './gear-search.component';

describe('GearSearchComponent', () => {
  let component: GearSearchComponent;
  let fixture: ComponentFixture<GearSearchComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GearSearchComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GearSearchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
