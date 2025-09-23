import {Component, inject} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {ButtonModule} from 'primeng/button';
import {environment} from '../../../environments/environment';
import {Observable} from 'rxjs';
import {ManagerResult} from './models/managerResult';
import {AuthService} from '../../core/auth/services/auth-service';
import {AsyncPipe, JsonPipe} from '@angular/common';

@Component({
  selector: 'app-manager',
  imports: [
    ButtonModule,
    JsonPipe,
    AsyncPipe
  ],
  templateUrl: './manager.html',
  styleUrl: './manager.scss',
  standalone: true,
})
export class Manager {
  private http: HttpClient = inject(HttpClient);
  private authService: AuthService = inject(AuthService);

  data$: Observable<ManagerResult> | undefined = undefined;

  fetchData() {
    const email = this.authService.getEmail();

    this.data$ = this.http.post<ManagerResult>(environment.apiBaseUrl + '/manager/GetAll', {email}, {withCredentials: true});
  }
}
