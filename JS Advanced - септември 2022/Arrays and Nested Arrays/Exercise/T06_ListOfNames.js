function listOfNames(arrOfNames){
    let res = arrOfNames.sort((a,b)=> a.localeCompare(b));
    for(let i = 0; i < res.length;i++){
        console.log(`${i+1}.${res[i]}`)
    }
}

listOfNames(['bb','aa','cc']);