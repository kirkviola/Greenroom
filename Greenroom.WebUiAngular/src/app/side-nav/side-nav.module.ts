import { MatSidenavModule } from '@angular/material/sidenav';
import { NgModule } from '@angular/core';
import { SideNavComponent } from './side-nav.component';
import { SharedModule } from '../shared/shared.module';
import { RouterLink } from '@angular/router';



@NgModule({
  declarations: [
    SideNavComponent,
  ],
  imports: [
    SharedModule,
    MatSidenavModule,
    RouterLink,
  ],
  exports: [
    SideNavComponent,
    MatSidenavModule,
  ]
})
export class SideNavModule { }
