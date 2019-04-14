import { Component, OnInit } from '@angular/core';
import { Gear } from '../Gear';

@Component({
  selector: 'app-gear',
  templateUrl: './gear.component.html',
  styleUrls: ['./gear.component.css']
})
export class GearComponent implements OnInit {

  gear: Gear = {
    id: 1,
    name: 'Backpack',
    weblink: 'google.com',
    description: 'good shit mate'
};

  constructor() { }

  ngOnInit() {
  }

}
