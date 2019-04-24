import { NgModule }           from '@angular/core';
import { TripsComponent } from './trips/trips.component';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
    imports: [
        AppRoutingModule
    ],
    exports: [TripsComponent],
    declarations: [TripsComponent],
    providers: [],
 })
 
 export class TripModule {
 }