import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-server-error',
  templateUrl: './server-error.component.html',
  styleUrls: ['./server-error.component.scss']
})
export class ServerErrorComponent implements OnInit {
  error: any;

  constructor(private router: Router) {
    const navigtion = this.router.getCurrentNavigation();
    this.error = navigtion && navigtion.extras && navigtion.extras.state && navigtion.extras.state.error;
   }

  ngOnInit(): void {
  }

}
