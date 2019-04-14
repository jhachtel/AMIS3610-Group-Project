import { Place } from '../places/Place';
import { Gear } from '../gear/Gear';
import { People } from '../people/People';
import { BlockingProxy } from 'blocking-proxy';

export class Trip{
    id: number;
    name: string;
    place: Place;
    gear: Gear;
    people: People;
    blog: string;
}