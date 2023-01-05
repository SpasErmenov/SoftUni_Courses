let list = document.getElementById('items')

function addItem() {
    let text = document.getElementById('newItemText');

    let newItemValue = text.value;

    let li = document.createElement('li');
    
    li.textContent = newItemValue;

    list.appendChild(li);

    text.value = '';
}
//events 
document.getElementById('firstButton').addEventListener('click', () => {
    console.log('I am clicked!');
});

document.getElementById('justClick').addEventListener("click", (event) => {

    let button = event.target;
    button.textContent = Number(button.textContent) + 1;
    //console.log(button.textContent);
});