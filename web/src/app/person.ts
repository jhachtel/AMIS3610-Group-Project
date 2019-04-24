import { Place } from '../app/place';
import { Item } from '../app/item';
import { Trail } from '../app/trail';
import { Trip } from '../app/trip';

export class Person {
    id: number;
    name: string;
    email: string;
    bio: string;

    places: Place[];
    items: Item[];
    friends: Person[];
    trails: Trail[];
    trips: Trip[];
}
