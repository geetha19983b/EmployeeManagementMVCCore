import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import './vendor';
import { JhipNetSharedModule } from 'app/shared/shared.module';
import { JhipNetCoreModule } from 'app/core/core.module';
import { JhipNetAppRoutingModule } from './app-routing.module';
import { JhipNetHomeModule } from './home/home.module';
import { JhipNetEntityModule } from './entities/entity.module';
// jhipster-needle-angular-add-module-import JHipster will add new module here
import { MainComponent } from './layouts/main/main.component';
import { NavbarComponent } from './layouts/navbar/navbar.component';
import { FooterComponent } from './layouts/footer/footer.component';
import { PageRibbonComponent } from './layouts/profiles/page-ribbon.component';
import { ErrorComponent } from './layouts/error/error.component';

@NgModule({
  imports: [
    BrowserModule,
    JhipNetSharedModule,
    JhipNetCoreModule,
    JhipNetHomeModule,
    // jhipster-needle-angular-add-module JHipster will add new module here
    JhipNetEntityModule,
    JhipNetAppRoutingModule
  ],
  declarations: [MainComponent, NavbarComponent, ErrorComponent, PageRibbonComponent, FooterComponent],
  bootstrap: [MainComponent]
})
export class JhipNetAppModule {}
