import { NgModule }           from '@angular/core';
import { PlacesComponent } from './places/places.component';
import { AppRoutingModule } from './app-routing.module';

import { PlaceService } from './place.service';

@NgModule({
    imports: [
        AppRoutingModule
    ],
    exports: [PlacesComponent],
    declarations: [PlacesComponent],
    providers: [PlaceService],
 })
 
 export class PlaceModule {
 }