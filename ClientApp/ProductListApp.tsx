import React, { useEffect, useState } from "react";
import { Product } from "./model";

export function ProductListApp() {
  const [products, setProducts] = useState<Product[]>([]);

  useEffect(() => {
    fetch("/Products")
      .then((response) => response.json())
      .then((products) => setProducts(products));
  }, []);

  return (
    <div className="card">
      <div className="card-header">
        <h3>Products</h3>
      </div>
      <div className="list-group list-group-flush">
        {products.map((p) => (
          <div key={p.productId} className="list-group-item">
            <h4>{p.title}</h4>
            <p>{p.description}</p>
            {/**
             * // TODO: Add to cart button form
             */}
          </div>
        ))}
      </div>
    </div>
  );
}
