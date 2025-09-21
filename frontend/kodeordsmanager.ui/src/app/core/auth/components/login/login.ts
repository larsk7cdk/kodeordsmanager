import {Component, inject} from '@angular/core';
import {FormBuilder, FormGroup, ReactiveFormsModule, Validators} from '@angular/forms';
import {AuthService} from '../../services/auth-service';
import {Router} from '@angular/router';
import {ButtonModule} from 'primeng/button';
import {PanelModule} from 'primeng/panel';
import {InputTextModule} from 'primeng/inputtext';
import { FloatLabelModule } from 'primeng/floatlabel';
import { FieldsetModule } from 'primeng/fieldset';

@Component({
  selector: 'app-login',
  imports: [
    ReactiveFormsModule,
    ButtonModule,
    PanelModule,
    InputTextModule,
    FloatLabelModule,
    FieldsetModule
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
            this.router.navigateByUrl('/manager');
          }
        );
    }
  }
}

export default Login
