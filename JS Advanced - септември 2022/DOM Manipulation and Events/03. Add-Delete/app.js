let list = document.getElementById('items');
function addItem() {
    let input = document.getElementById('newItemText');
    let value = input.value;

    let li = document.createElement('li');
    li.textContent = value;

    let deleteBtn = document.createElement('a');
    deleteBtn.textContent = "Delete";

    deleteBtn.addEventListener('click', function(event) {
        li.remove();
    });

    li.append(deleteBtn);
    list.append(li);

    input.value = " ";
    
}