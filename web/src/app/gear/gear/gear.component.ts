import { Component, OnInit } from '@angular/core';
import { Gear } from '../../gear/gear';

@Component({
  selector: 'app-gear',
  templateUrl: './gear.component.html',
  styleUrls: ['./gear.component.css']
})
export class GearComponent implements OnInit {

  gear: Gear[] = [
    {
    id: 8888888888,
    name: 'Sample Gear Name 1',
    brand: 'Sample Brand A',
    type: 'Some Random Type',
    description: 'A cool piece of gear'
    },
    {
    id: 9999999999,
    name: 'Sample Gear Name 2',
    brand: 'Sample Brand B',
    type: 'Some Other Random Type',
    description: 'Another cool piece of gear'
    }
  ];
  
  constructor() { }

  ngOnInit() {
  }

}
