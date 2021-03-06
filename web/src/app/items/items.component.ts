import { Component, OnInit } from '@angular/core';

import { Item } from '../item';
import { ItemService } from '../item.service';

@Component({
  selector: 'app-items',
  templateUrl: './items.component.html',
  styleUrls: ['./items.component.css']
})
export class ItemsComponent implements OnInit {
  items: Item[];

  constructor(private ItemService: ItemService) { }

  ngOnInit() {
    this.getItems();
  }

  getItems(): void {
    this.ItemService.getItems()
    .subscribe(items => this.items = items);
  }

  add(name: string): void {
    name = name.trim();
    if (!name) { return; }
    this.ItemService.addItem({ name } as Item)
      .subscribe(item => {
        this.items.push(item);
      });
  }

  delete(item: Item): void {
    this.items = this.items.filter(i => i !== item);
    this.ItemService.deleteItem(item).subscribe();
  }

}