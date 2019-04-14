import { Component, OnInit } from '@angular/core';
import { Gear } from '../gear';
import { GearService } from '../gear.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: [ './dashboard.component.css' ]
})
export class DashboardComponent implements OnInit {
  gear: Gear[] = [];

  constructor(private gearService: GearService) { }

  ngOnInit() {
    this.getGear();
  }

  getGear(): void {
    this.gearService.getAllGear()
      .subscribe(gear => this.gear = gear.slice(1, 5));
  }
}
