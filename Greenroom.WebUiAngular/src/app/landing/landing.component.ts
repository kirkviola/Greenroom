import { Component, OnInit } from '@angular/core';
import { baseUrl } from '../shared/app-constants';
import { User, UserService } from '../users/user.service';

@Component({
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.scss']
})
export class LandingComponent implements OnInit {
  url = baseUrl;
  user: User;

  constructor(private userService: UserService) {}

  ngOnInit(): void {
    this.userService.getById(2)
      .subscribe(u => {
        this.user = u;
      });
  }
}
