import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import  HeaderComponent  from './shared/ui/header/header.component';
import  SideComponent from './shared/ui/side/side.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, HeaderComponent, SideComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'ecommerce-front-end';
}
