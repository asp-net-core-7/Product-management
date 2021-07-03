
const name = document.querySelector('#name')
const qty = document.querySelector('#qty')
const remark = document.querySelector('#remark')
const button = document.querySelector('#add-btn')
const list = document.querySelector('#list')

button.addEventListener('click', function (e) {
    e.preventDefault();
    if (name.value == '' && qty.value == '' && remark.value == '') {
        alert('No product added');
    }
    else {
        const newRow = document.createElement('tr');

        const newName = document.createElement('td');
        newName.innerHTML = name.value;
        newRow.appendChild(newName);

        const newPrice = document.createElement('td');
        newPrice.innerHTML = qty.value;
        newRow.appendChild(newPrice);

        const newType = document.createElement('td');
        newType.innerHTML = remark.value;
        newRow.appendChild(newType);

        list.appendChild(newRow);
    }
});






