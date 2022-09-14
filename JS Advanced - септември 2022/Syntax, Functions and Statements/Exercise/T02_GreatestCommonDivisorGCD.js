function GCD(number1, number2){

    if(number1 % 7 == 0 && number2 % 7 == 0){
        console.log("7");
    }
    else if(number1 % 5 == 0 && number2 % 5 == 0){
        console.log("5");
    }
    else if(number1 % 3 == 0 && number2 % 3 == 0){
        console.log("3");
    }
    else if(number1 % 2 == 0 && number2 % 2 == 0){
        console.log("2");
    }
    else if(number1 % 1 == 0 && number2 % 1 == 0){
        console.log("1");
    }

}

GCD(15, 5);
GCD(20,100);
GCD(2154, 458);
GCD(21, 35);