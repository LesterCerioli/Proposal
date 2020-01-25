import { Component } from '@angular/core';

@Component({
  selector: 'app-resources-component',
  templateUrl: './resources.component.html'
})
export class ResourcesComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
