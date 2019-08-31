import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CalendarComponent } from './calendar.component';
import { FullCalendarModule } from '@fullcalendar/angular'; // for FullCalendar!
import { CalendarRoutingModule } from './calendar-routing.module';

@NgModule({
  declarations: [CalendarComponent],
  imports: [
    CommonModule,
    FullCalendarModule,
    CalendarRoutingModule
  ]
})
export class CalendarModule { }
