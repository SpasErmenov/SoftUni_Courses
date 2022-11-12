function solve(param){

    let count = 0;

    const parser = {
        increment() { count++; },
        decrement() { count--; },
        reset() {count = 0; }
    
    };

    for(let command of param){
        parser[command]();
    }

    console.log(count);
}



solve(['increment']);