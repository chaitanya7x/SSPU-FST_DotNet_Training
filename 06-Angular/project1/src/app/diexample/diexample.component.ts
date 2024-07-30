import { Component } from '@angular/core';
import { Computer } from './computer';
import { Cart } from './cart';
import { Product } from './products';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-diexample',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './diexample.component.html',
  styleUrls: ['./diexample.component.css']
})
export class DIExampleComponent {
  public computer: Computer;
  public cart: Cart;
  public product: Product;

  constructor() {
    this.computer = new Computer();
    this.cart = new Cart();
    this.product = new Product(1, 'Default Product', 1);
    this.product = new Product(1, 'io Product', 1);
  }

  makeComputer() {
    return this.computer.complete();
  }

  addToCart() {
    this.cart.addProduct(this.product);
    console.log('Product added to cart:', this.product);
    console.log('Cart contents:', this.cart.getProducts());
  }
}
