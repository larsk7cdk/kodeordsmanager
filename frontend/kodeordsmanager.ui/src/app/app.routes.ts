import {Routes} from '@angular/router';
import {Manager} from './features/manager/manager';
import {authGuard} from './core/auth/guards/auth-guard';
import Login from './core/auth/components/login/login';

export const routes: Routes = [
  {
    path: 'auth',
    component: Login,
  },
  {
    path: '',
    component: Manager,
    canActivate: [authGuard]
  },
  {
    path: '**', redirectTo: '', pathMatch: 'full'
  },
];
