import {Component, signal} from '@angular/core';
import {RouterOutlet} from '@angular/router';
import {FormsModule} from '@angular/forms';
import {Dialog, DialogModule} from 'primeng/dialog';
import {ButtonDirective, ButtonModule} from 'primeng/button';
import {InputTextModule} from 'primeng/inputtext';

@Component({
  selector: 'app-root',
  imports: [FormsModule,
    DialogModule,
    InputTextModule,
    ButtonModule,],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  showLogin = true;       // Dialog vises i midten ved load
  email = '';

  login() {
    // TODO: kald din auth-service her
    console.log('Logger ind som:', this.email);
  }
}
