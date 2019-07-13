import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
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


const routes: Routes = [
  { path: 'news', component: NewsComponent },
  { path: 'array', component: ArrayComponent },
  { path: 'string', component: StringComponent },
  { path: 'matrix', component: MatrixComponent },
  { path: 'linked-list', component: LinkedListComponent },
  { path: 'stack', component: StackComponent },
  { path: 'queue', component: QueueComponent },
  { path: 'tree', component: TreeComponent },
  { path: 'hashing', component: HashingComponent },
  { path: 'graph', component: GraphComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
