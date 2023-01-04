function PrintText(){
    const header = document.getElementsByTagName('h1');

    const input = document.getElementById('new-header-name');

    const value = input.value;

    header[0].innerHTML = `<p> ${value} </p>`;
}