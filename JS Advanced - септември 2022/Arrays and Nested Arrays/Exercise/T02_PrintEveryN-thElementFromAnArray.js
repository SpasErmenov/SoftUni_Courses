function printEveryNthElement(arr, step){
    let ress = [];
    for(let i = 0; i < arr.length; i+=step){
        ress.push(arr[i])
    }
    return ress;
}

printEveryNthElement(['5','20','31','4','20'],2)