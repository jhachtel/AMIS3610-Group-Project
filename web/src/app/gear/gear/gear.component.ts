import { Component, OnInit } from '@angular/core';
import { Gear } from '../Gear';
import { GearService } from '../gear.service';

@Component({
  selector: 'app-gear',
  templateUrl: './gear.component.html',
  styleUrls: ['./gear.component.css']
})
export class GearComponent implements OnInit {

  gear: Gear[];

  constructor(private gearService: GearService) { }

  ngOnInit() {
    this.getGear();
  }

  getGear(): void {
    this.gearService.getGear()
    .subscribe(gear => this.gear = gear);
  }

}
