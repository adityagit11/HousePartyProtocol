import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app/app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { NewsComponent } from './news/news.component';
import { ArrayComponent } from './array/array.component';
import { StringComponent } from './string/string.component';
import { MatrixComponent } from './matrix/matrix.component';
import { LinkedListComponent } from './linked-list/linked-list.component';
import { StackComponent } from './stack/stack.component';
import { QueueComponent } from './queue/queue.component';
import { TreeComponent } from './tree/tree.component';
import { HashingComponent } from './hashing/hashing.component';
import { GraphComponent } from './graph/graph.component';
import { ApiService } from './services/api.service';
import { QuestiondataentryComponent } from './questiondataentry/questiondataentry.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    NewsComponent,
    ArrayComponent,
    StringComponent,
    MatrixComponent,
    LinkedListComponent,
    StackComponent,
    QueueComponent,
    TreeComponent,
    HashingComponent,
    GraphComponent,
    QuestiondataentryComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [ApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
