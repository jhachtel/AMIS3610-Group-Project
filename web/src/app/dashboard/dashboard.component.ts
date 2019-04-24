import { Component, OnInit } from '@angular/core';
import { Item } from '../item';
import { ItemService } from '../item.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: [ './dashboard.component.css' ]
})
export class DashboardComponent implements OnInit {
  items: Item[] = [];

  constructor(private ItemService: ItemService) { }

  ngOnInit() {
    this.getItem();
  }

  getItem(): void {
    this.ItemService.getItems()
      .subscribe(item => this.items = item.slice(1, 5));
  }
}
