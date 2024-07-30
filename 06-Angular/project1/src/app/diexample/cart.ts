import { Product } from './products';

export class Cart {
  private products: Product[] = [];

  addProduct(product: Product) {
    this.products.push(product);
  }

  getProducts() {
    return this.products;
  }
}
