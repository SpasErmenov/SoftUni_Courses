function solve(arg1, arg2, arg3){
    let largestNumber = arg1;
    
    if(arg2 > largestNumber){
        largestNumber = arg2
    }
    if(arg3 > largestNumber){
        largestNumber = arg3
    }
    console.log(`The largest number is ${largestNumber}.`)
}

solve(-3, -5, -22.5)