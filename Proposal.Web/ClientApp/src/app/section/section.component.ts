import { Component } from '@angular/core';

@Component({
  selector: 'app-section',
  templateUrl: './section.component.html'
})
export class SectionComponent {
  public currentCount = 0;

  public incrementSection() {
    this.currentCount++;
  }
}
