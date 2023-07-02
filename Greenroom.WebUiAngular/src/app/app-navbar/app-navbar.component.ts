import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { MatButtonModule } from '@angular/material/button'

@Component({
  selector: 'app-navbar',
  templateUrl: './app-navbar.component.html',
  styleUrls: ['./app-navbar.component.scss'],
  standalone: true,
  imports: [
    RouterLink,
    MatButtonModule
  ]
})
export class AppNavbarComponent {

}
