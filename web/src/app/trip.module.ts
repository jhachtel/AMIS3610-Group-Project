import { NgModule }           from '@angular/core';
import { TripsComponent } from './trips/trips.component';
import { AppRoutingModule } from './app-routing.module';

import { TripService } from './trip.service';

@NgModule({
    imports: [
        AppRoutingModule
    ],
    exports: [TripsComponent],
    declarations: [TripsComponent],
    providers: [TripService],
 })
 
 export class TripModule {
 }