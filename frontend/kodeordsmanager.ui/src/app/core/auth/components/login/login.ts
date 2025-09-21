import {Component, inject} from '@angular/core';
import {FormBuilder, FormGroup, ReactiveFormsModule, Validators} from '@angular/forms';
import {AuthService} from '../../services/auth-service';
import {Router} from '@angular/router';

@Component({
  selector: 'app-login',
  imports: [
    ReactiveFormsModule
  ],
  templateUrl: './login.html',
  styleUrl: './login.scss'
})
class Login {
  private fb = inject(FormBuilder);
  private router = inject(Router);
  private authService = inject(AuthService);

  form: FormGroup = this.fb.group({
    email: ['', Validators.required],
    password: ['', Validators.required]
  });

  // constructor(private fb: FormBuilder,
  //             private authService: AuthService,
  //             private router: Router) {
  //   this.form = this.fb.group({
  //     email: ['', Validators.required],
  //     password: ['', Validators.required]
  //   });
  // }

  login() {
    const values = this.form.value;

    if (values.email && values.password) {
      this.authService.login(values.email, values.password)
        .subscribe(
          () => {
            this.router.navigateByUrl('/');
          }
        );
    }
  }
}

export default Login
