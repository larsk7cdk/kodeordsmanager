import {Component, signal} from '@angular/core';
import {RouterOutlet} from '@angular/router';
import {FormsModule} from '@angular/forms';
import {Dialog, DialogModule} from 'primeng/dialog';
import {ButtonDirective, ButtonModule} from 'primeng/button';
import {InputTextModule} from 'primeng/inputtext';
import {Auth} from './core/auth/auth';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-root',
  imports: [
    RouterOutlet
  ],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {

}
