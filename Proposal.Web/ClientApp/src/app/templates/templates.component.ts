import { Component } from '@angular/core';

@Component({
  selector: 'app-templates',
  templateUrl: './templates.component.html'
})
export class TemplatesComponent {
  public currentCount = 0;

  public incrementTemplates() {
    this.currentCount++;
  }
  
}
