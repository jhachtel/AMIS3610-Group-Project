import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { Gear }         from '../gear';
import { GearService }  from '../gear.service';

@Component({
  selector: 'app-gear-detail',
  templateUrl: './gear-detail.component.html',
  styleUrls: [ './gear-detail.component.css' ]
})
export class GearDetailComponent implements OnInit {
  @Input() gear: Gear;

  constructor(
    private route: ActivatedRoute,
    private heroService: GearService,
    private location: Location
  ) {}

  ngOnInit(): void {
    this.getGear();
  }

  getGear(): void {
    const id = +this.route.snapshot.paramMap.get('id');
    this.gearService.getGear(id)
      .subscribe(gear => this.gear = gear);
  }

  goBack(): void {
    this.location.back();
  }

 save(): void {
    this.gearService.updateGear(this.gear)
      .subscribe(() => this.goBack());
  }
}