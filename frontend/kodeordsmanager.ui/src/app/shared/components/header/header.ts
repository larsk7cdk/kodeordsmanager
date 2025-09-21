import {Component, inject} from '@angular/core';
import {AuthService} from '../../../core/auth/services/auth-service';
import {Router} from '@angular/router';
import { ButtonModule} from 'primeng/button';

@Component({
  selector: 'app-header',
  imports: [
    ButtonModule
  ],
  templateUrl: './header.html',
  styleUrl: './header.scss',
  standalone: true,
})
export class Header {
  router: Router = inject(Router);
  authService:AuthService = inject(AuthService);
}
