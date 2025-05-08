import { Routes } from '@angular/router';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { CustomersComponent } from './pages/customers/customers.component';
import { LoginComponent } from './pages/login/login.component';

export const routes: Routes = [
    {path: '',redirectTo: '/dashboard',pathMatch:'full'},
    {path: 'dashboard',component:DashboardComponent},
    {path: 'customers',component:CustomersComponent},
    {path: 'login',component:LoginComponent},
       
];
