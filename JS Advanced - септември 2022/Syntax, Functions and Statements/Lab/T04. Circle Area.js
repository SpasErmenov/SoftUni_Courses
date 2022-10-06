function Solve(arg){
    let result;
    let argType = typeof(arg);

    if(argType === `number`)
    {
        result = Math.PI * Math.pow(arg, 2)
        console.log(result.toFixed(2))
    }else{
        console.log(`We can not calculate the circle area, because we receive a ${argType}.`)
    }
    
}
Solve(5)
Solve('pet')