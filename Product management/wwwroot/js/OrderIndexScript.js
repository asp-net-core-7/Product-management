
const name = document.querySelector('#name')
const qty = document.querySelector('#qty')
const remark = document.querySelector('#remark')
const button = document.querySelector('#add-btn')
const list = document.querySelector('#list')
const productContainer = document.getElementById('product-container')

button.addEventListener('click', function () {

    
        fetch('Product/GetAllProductJson')
            .then(response => response.json())
            .then(data => productList(data))

    
    function productList(pList) {
        const productList = pList;
        const newRow = document.createElement("div")
        newRow.innerHTML = `<div  class="row mb-3">
                    <div class="col-4">
                        <select id="name" class="custom-select">

                            $(for (let product of productList) {
                                <option>$(product.name)</option>
                                
                            })
                            
                         

                        </select>
                    </div>
                    <div class="col">
                        <input id="qty" type="text" class="form-control" placeholder="Quantity">
                    </div>
                    <div class="col">
                        <input id="remark" type="text" class="form-control" placeholder="Remark">
                    </div>
                </div>`
        productContainer.prepend(newRow);
    }
});






