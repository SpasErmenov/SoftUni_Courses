function solve(name, population, treasury){
    var obj = {
        oName: name,
        oPop: population,
        oTrea: treasury
    }
    return obj;
}
console.log(solve('Tortuga', 7000, 15000).oName)
solve('Tortuga', 7000, 15000);