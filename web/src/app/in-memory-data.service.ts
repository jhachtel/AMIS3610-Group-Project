import { InMemoryDbService } from 'angular-in-memory-web-api';
import { Item } from './item';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class InMemoryDataService implements InMemoryDbService {
  createDb() {
    const items = [
      { id: 11, name: 'Item 11' },
      { id: 12, name: 'Item 12' },
      { id: 13, name: 'Item 13' },
      { id: 14, name: 'Item 14' },
      { id: 15, name: 'Item 15' },
      { id: 16, name: 'Item 16' },
      { id: 17, name: 'Item 17' },
      { id: 18, name: 'Item 18' },
      { id: 19, name: 'Item 19' },
      { id: 20, name: 'Item 20' }
    ];
    return {items: items};
  }

  // Overrides the genId method to ensure that an item always has an id.
  // If the items array is empty,
  // the method below returns the initial number (11).
  // if the items array is not empty, the method below returns the highest
  // item id + 1.
  genId(items: Item[]): number {
    return items.length > 0 ? Math.max(...items.map(item => item.id)) + 1 : 11;
  }
}
