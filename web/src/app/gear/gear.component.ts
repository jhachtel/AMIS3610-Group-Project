import { Component, OnInit } from '@angular/core';

import { Gear } from '../gear';
import { GearService } from '../gear.service';

@Component({
  selector: 'app-gear',
  templateUrl: './gear.component.html',
  styleUrls: ['./gear.component.css']
})
export class gearComponent implements OnInit {
  gear: Gear[];

  constructor(private gearService: GearService) { }

  ngOnInit() {
    this.getGear();
  }

  getGear(): void {
    this.gearService.getGear()
    .subscribe(gear => this.gear = gear);
  }

  add(name: string): void {
    name = name.trim();
    if (!name) { return; }
    this.gearService.addGear({ name } as Gear)
      .subscribe(gear => {
        this.gear.push(gear);
      });
  }

  delete(gear: Gear): void {
    this.gear = this.gear.filter(g => g !== gear);
    this.gearService.deleteGear(Gear).subscribe();
  }

}
