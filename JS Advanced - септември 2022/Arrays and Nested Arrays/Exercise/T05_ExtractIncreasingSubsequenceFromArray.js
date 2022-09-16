function extractIncreasingSubnet(arr){
    let res = [];
    let biggestOne = arr.shift();
    res.push(biggestOne);

    for(el of arr){
        if(el >= biggestOne){
            res.push(el);
            biggestOne = el;
        }
    }
    return res;
}

extractIncreasingSubnet([1,3,8,4,10, 12, 3, 2, 24])