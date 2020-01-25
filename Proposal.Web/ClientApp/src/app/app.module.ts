import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ResourcesComponent } from './resources/resources.component';
import { CustomersComponent } from './customers/customers.component';
import { SectionComponent } from './section/section.component';
import { TemplatesComponent } from './templates/templates.component';
import { ProposalComponent } from './proposal/proposal.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ResourcesComponent,
    CustomersComponent,
    SectionComponent,
    TemplatesComponent,
    ProposalComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'resources', component: ResourcesComponent },
      { path: 'customers', component: CustomersComponent },
      { path: 'section', component: SectionComponent },
      { path: 'templates', component: TemplatesComponent },
      { path: 'proposal', component: ProposalComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
