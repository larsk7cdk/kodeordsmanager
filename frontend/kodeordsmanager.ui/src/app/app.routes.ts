import {Routes} from '@angular/router';
import {Manager} from './features/manager/manager';
import {authGuard} from './core/auth/guards/auth-guard';
import Login from './core/auth/components/login/login';
import {Home} from './features/home/home';

export const routes: Routes = [
  {
    path: 'login',
    component: Login,
  },
  {
    path: '',
    component: Home,
  },
  {
    path: 'manager',
    component: Manager,
    canActivate: [authGuard]
  },
  {
    path: '**', redirectTo: '', pathMatch: 'full'
  },
];
