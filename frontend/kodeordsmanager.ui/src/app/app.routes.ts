import {Routes} from '@angular/router';
import {Auth} from './core/auth/auth';

export const routes: Routes = [
  {
    path: 'auth',
    component: Auth,

  },
  {path: '**', redirectTo: '', pathMatch: 'full'},
];
