let list = document.getElementById('items')

function addItem() {
    let text = document.getElementById('newItemText');

    let newItemValue = text.value;

    let li = document.createElement('li');
    
    li.textContent = newItemValue;

    list.appendChild(li);

    text.value = '';
}