function solve(param){
    let size;
    let line = "";
    if(param > 0){
        size = param;
    }else{
        size = 5;
    }

    for(i = 0; i < size; i++){
        for(j = 0; j < size; j++){
            line += `* `;
        }
        console.log(line)
        line = "";
    }
}

solve(5)
