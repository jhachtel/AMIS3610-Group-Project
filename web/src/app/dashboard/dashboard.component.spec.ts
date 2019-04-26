import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DashboardComponent } from './dashboard.component';
import { ItemSearchComponent } from '../Item-search/Item-search.component';
import { of } from 'rxjs';
import { Item } from '../item';
import { RouterTestingModule } from '@angular/router/testing';

describe('DashboardComponent', () => {
  let component: DashboardComponent;
  let fixture: ComponentFixture<DashboardComponent>;
  let ItemService;
  let getItemsSpy;

  beforeEach(async(() => {
    ItemService = jasmine.createSpyObj('ItemService', ['getItems']);
    getItemsSpy = ItemService.getItems.and.returnValue( of(Item) );
    TestBed.configureTestingModule({
      declarations: 
      [ DashboardComponent,
        ItemSearchComponent
      ],
      imports: [
        RouterTestingModule.withRoutes([])
      ],
      providers: [
        { provide: ItemService, useValue: ItemService }
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
  it('should display "Top Items" as headline', () => {
    expect(fixture.nativeElement.querySelector('h3').textContent).toEqual('Top Items');
  });

  it('should call ItemService', async(() => {
    expect(getItemsSpy.calls.any()).toBe(true);
    }));

  it('should display 4 links', async(() => {
    expect(fixture.nativeElement.querySelectorAll('a').length).toEqual(4);
  }));
});
