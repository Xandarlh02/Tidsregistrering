import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InputPageComponent } from 'src/app/input-page/input-page.component';
import { OverviewPageComponent } from 'src/app/overview-page/overview-page.component';

const routes: Routes = [
  { path: '', component: InputPageComponent},
  { path: 'inputpage', component: InputPageComponent},
  { path: 'overviewpage', component: OverviewPageComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
