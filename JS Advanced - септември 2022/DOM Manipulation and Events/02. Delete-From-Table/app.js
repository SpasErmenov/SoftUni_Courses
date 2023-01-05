function deleteByEmail() {
    
    let email = document.getElementsByName("email")[0].value;
    let result = document.getElementById("result");

    let listOfCustomers = document
       .getElementById("customers")
       .getElementsByTagName('td');

    for(let customer of listOfCustomers){
        
        if (customer.textContent === email) {
            customer.parentElement.remove();
            result.textContent = 'Deleted.'
        } else {
            result.textContent = 'Not found.'
        }
    }
}