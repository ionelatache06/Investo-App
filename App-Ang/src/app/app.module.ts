import { BrowserModule, HammerGestureConfig, HAMMER_GESTURE_CONFIG } from '@angular/platform-browser';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import {BsDropdownModule, TabsModule, BsDatepickerModule, PaginationModule, ButtonsModule} from 'ngx-bootstrap';
import { RouterModule } from '@angular/router';
import { JWT_OPTIONS, JwtModule } from '@auth0/angular-jwt';
import { NgxGalleryModule } from 'ngx-gallery';
import { FileUploadModule } from 'ng2-file-upload';
import { TimeagoModule } from 'ngx-timeago';
import { EmbedVideo } from 'ngx-embed-video';
import { HighchartsChartModule } from 'highcharts-angular';
import { MatDividerModule, MatCardModule} from '@angular/material';

import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { AuthService } from './_services/auth.service';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { ListsComponent } from './lists/lists.component';
import { MessagesComponent } from './messages/messages.component';
import { appRoutes } from './routes';
import { MemberCardComponent } from './members/member-list/member-card/member-card.component';
import { MemberDetailComponent } from './members/member-list/member-detail/member-detail.component';
import { AlertifyService } from './_services/alertify.service';
import { AuthGuard } from './_guards/auth.guard';
import { MemberDetailResolver } from './_resolvers/meber-detail.resolver';
import { UserService } from './_services/user.service';
import { MemberListResolver } from './_resolvers/meber-list.resolver';
import { MemberEditComponent } from './members/member-list/member-edit/member-edit.component';
import { MemberEditResolver } from './_resolvers/meber-edit.resolver';
import { PreventUnsavedChanges } from './_guards/prevent-unsaved-changes.guard';
import { PhotoEditorComponent } from './members/member-list/photo-editor/photo-editor.component';
import { ListsResolver } from './_resolvers/lists.resolver';
import { MessagesResolver } from './_resolvers/messages.resolver';
import { MemberMessagesComponent } from './members/member-list/member-messages/member-messages.component';
import { DashboardComponent } from './modules/dashboard/dashboard.component';
import { AreaComponent } from './widgets/area/area.component';
import { PieComponent } from './widgets/pie/pie.component';
import { Line2Component } from './widgets/line2/line2.component';

export function tokenGetter(){
   return localStorage.getItem('token');
}

export class CustomHammerConfig extends HammerGestureConfig  {
   overrides = {
       pinch: { enable: false },
       rotate: { enable: false }
   };
}

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      HomeComponent,
      RegisterComponent,
      MemberListComponent,
      ListsComponent,
      MessagesComponent,
      MemberCardComponent, 
      MemberDetailComponent, 
      MemberEditComponent, 
      PhotoEditorComponent,
      MemberMessagesComponent,
      DashboardComponent,
      AreaComponent,
      PieComponent,
      Line2Component
      
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      BrowserAnimationsModule,
      FormsModule,
      ReactiveFormsModule,
      BsDropdownModule.forRoot(),
      BsDatepickerModule.forRoot(),
      PaginationModule.forRoot(),
      TabsModule.forRoot(),
      ButtonsModule.forRoot(),
      RouterModule.forRoot(appRoutes),
      NgxGalleryModule,
      FileUploadModule,
      EmbedVideo.forRoot(),
      TimeagoModule.forRoot(),
      HighchartsChartModule, 
      MatCardModule,
      JwtModule.forRoot({
         config: {
            tokenGetter: tokenGetter,
            whitelistedDomains: ['localhost:5000'],
            blacklistedRoutes: ['localhost:5000/api/auth']
         }
      })
      
   ],
   providers: [
      AuthService,
      AlertifyService,
      AuthGuard,
      UserService,
      MemberDetailResolver, 
      MemberListResolver,
      MemberEditResolver,
      PreventUnsavedChanges,
      ListsResolver,
      MessagesResolver,
      { provide: HAMMER_GESTURE_CONFIG, useClass: CustomHammerConfig }
      
   ],
   bootstrap: [
      AppComponent
   ], 
   schemas: [
      NO_ERRORS_SCHEMA 
   ]
})
export class AppModule { }
