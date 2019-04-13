import { Component, OnInit, Input } from '@angular/core';
import { Gear } from '../gear';

@Component({
  selector: 'app-gear-row',
  templateUrl: './gear-row.component.html',
  styleUrls: ['./gear-row.component.css']
})
export class GearRowComponent implements OnInit {
  @Input() gear: any;

  ngOnInit() {
  }

}
