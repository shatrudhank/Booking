import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { DashboardComponent } from './admin/dashboard/dashboard.component';
import { CountryMasterComponent } from './admin/country-master/country-master.component';
import { Country } from './admin/models/country';
import { CountryComponent } from './admin/country/country.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'admin-dashboard', component: DashboardComponent,children:[
    {path:"admin-country",component:CountryMasterComponent},
    {path:"country",component:CountryComponent}
  ]},
  { path: '', redirectTo: 'home', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
