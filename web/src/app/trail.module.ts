import { NgModule }           from '@angular/core';
import { TrailsComponent } from './trails/trails.component';
import { AppRoutingModule } from './app-routing.module';

import { TrailService } from './trail.service';

@NgModule({
    imports: [
        AppRoutingModule
    ],
    exports: [TrailsComponent],
    declarations: [TrailsComponent],
    providers: [TrailService],
 })
 
 export class TrailModule {
 }