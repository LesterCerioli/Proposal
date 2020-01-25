import { Component } from '@angular/core';

@Component({
  selector: 'app-proposal',
  templateUrl: './proposal.component.html'
})
export class ProposalComponent {
  public currentCount = 0;

  public incrementProposal() {
    this.currentCount++;
  }
  
}
