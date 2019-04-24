import { NgModule }           from '@angular/core';
import { ItemsComponent } from './items/items.component';
import { AppRoutingModule } from './app-routing.module';

import { ItemService } from './item.service';

@NgModule({
    imports: [
        AppRoutingModule
    ],
    exports: [ItemsComponent],
    declarations: [ItemsComponent],
    providers: [ ItemService ],
 })
 
 export class ItemModule {
 }