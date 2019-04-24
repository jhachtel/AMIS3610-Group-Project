import { NgModule }           from '@angular/core';
import { PlacesComponent } from './places/places.component';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
    imports: [
        AppRoutingModule
    ],
    exports: [PlacesComponent],
    declarations: [PlacesComponent],
    providers: [],
 })
 
 export class PlaceModule {
 }