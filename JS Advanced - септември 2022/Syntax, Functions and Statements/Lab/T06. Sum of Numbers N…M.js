function solve(n, m){
    let result = 0;
    let firstArg = Number(n);
    let secondArg = Number(m);

    for(i = firstArg; i <= m; i++){
        result += i;
    }
    console.log(result)
}

solve(`1`, `5`)