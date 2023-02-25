// Every 30 seconds fetch a count of the products and then update the HTML
// Notes:
//     This updates one element with the id product-count - does not handle multiple elements.
//     An alternative would be to do this in-component, doing the fetch in a useEffect in parent and passing count through
setInterval(
  () =>
    fetch("/Products/Count")
      .then((response) => response.json())
      .then((productCount) => {
        const productCountElement = document.getElementById("product-count");

        if (productCountElement) {
          productCountElement.innerHTML = `${productCount}`;
        }
      }),
  30000
);
