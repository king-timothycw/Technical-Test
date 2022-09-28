import React from "react";
import ReactDom from "react-dom/client";
import "./homepage";

async function render() {
  const cartElement = document.getElementById("product-list-app");

  if (cartElement) {
    const { ProductListApp } = await import("./ProductListApp");

    const root = ReactDom.createRoot(cartElement);

    root.render(<ProductListApp />);
  }
}

render();
