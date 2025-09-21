import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {shareReplay, tap} from 'rxjs';
import moment from 'moment';
import {AuthResult} from '../nodels/authResult';
import {environment} from '../../../../environments/environment';
import {Router} from '@angular/router';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private http: HttpClient = inject(HttpClient);
  private router = inject(Router);

  login(email: string, password: string) {
    return this.http.post<AuthResult>(environment.apiBaseUrl + '/auth/login', {email, password})
      .pipe(
        tap((authResult: AuthResult) => {
          this.setSession(authResult)
        }),
        shareReplay()
      );
  }

  private setSession(authResult: AuthResult) {
    const expiresAt = moment().add(authResult.expiresIn, 'second');

    localStorage.setItem('token', authResult.token);
    localStorage.setItem("expires_at", JSON.stringify(expiresAt.valueOf()));
  }

  logout() {
    localStorage.removeItem("token");
    localStorage.removeItem("expires_at");

    this.router.navigate(['']);
  }

  public isLoggedIn() {
    return moment().isBefore(this.getExpiration());
  }

  isLoggedOut() {
    return !this.isLoggedIn();
  }

  getExpiration() {
    const expiration = localStorage.getItem("expires_at");
    const expiresAt = JSON.parse(expiration!);
    return moment(expiresAt);
  }
}
