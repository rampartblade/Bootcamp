import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  message=''
  title = 'my-app';
  asdawd = "yahallo parent"
  plus = "add"
  minus = "min"
  counter = 0
  items =['sepatu','sendal','tas']

  addCounter(){
    this.counter++
  }

  removeCounter(){
    this.counter--
  }

  addItemInParent(newItem: string){
    this.items.push(newItem)
  }

  /* deleteMsg(msg:string) {
    const index: number = this.items.indexOf(msg);
    if (index !== -1) {
        this.items.splice(index, 1);
    } 
  } */
}
