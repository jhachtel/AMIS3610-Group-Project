import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GearComponent }      from './gear/gear.component';
import { DashboardComponent }   from './dashboard/dashboard.component';
import { GearDetailComponent }  from './gear-detail/gear-detail.component';

const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'gear', component: GearComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'detail/:id', component: GearDetailComponent }
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
