/*function wordsUppercase(text){
    let res = [];
    let buff = "";

    for(let i = 0; i < text.length; i++){
        let ch = text.charCodeAt(i);
        if((ch >= 65 && ch <= 90) || (ch >= 97 && ch <= 122)){
            buff += text[i];
        }else{
            res.push(buff);
            buff = "";
        }
    }
    if (buff){
        res.push(buff);
    }
    console.log(res);
}

wordsUppercase('Hi, how are you?');
console.log(`----------------`);
wordsUppercase('hello');
*/

function wordsUppercaseTwo(textTwo){
    return textTwo.match(/\w+/g).join(", ").toUpperCase();
}

wordsUppercaseTwo('Hi, how are you?');
console.log(`----------------`);
wordsUppercaseTwo('hello');