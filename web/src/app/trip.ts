import { Person } from '../app/person';
import { Item } from '../app/item';
import { Place } from '../app/place';
import { Trail } from '../app/trail';

export class Trip {
    id: number;
    name: string;
    description: string;

    companions: Person[];
    itemList: Item[];
    places: Place[];
    trails: Trail[];
}
