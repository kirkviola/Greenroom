import { Component, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CourseOverviewComponent } from './course-overview/course-overview.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    CourseOverviewComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([
      {
        path: '',
        component: CourseOverviewComponent,
      }
    ])
  ]
})
export class CoursesModule { }
