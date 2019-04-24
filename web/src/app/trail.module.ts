import { NgModule }           from '@angular/core';
import { TrailsComponent } from './trails/trails.component';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
    imports: [
        AppRoutingModule
    ],
    exports: [TrailsComponent],
    declarations: [TrailsComponent],
    providers: [],
 })
 
 export class TrailModule {
 }