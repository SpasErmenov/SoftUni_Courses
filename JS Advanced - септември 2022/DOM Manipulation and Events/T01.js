let list = document.getElementById("list");

function addItem(){
    //console.log(list);
    let input = document.getElementById("inputText");

    let value = input.value;

    let li = document.createElement('li');

    li.textContent = value;

    list.append(li);

    input.value = " ";



    console.log(list);
}