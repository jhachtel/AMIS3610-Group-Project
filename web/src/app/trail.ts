import { Place } from '../app/place';

export class Trail {
    id: number;
    name: string;
    description: string;
    link: string;

    places: Place[];
}
