function previousDate(year, month, date){
    let pattern = `${year}/${month}/${date}`;
    let myDate = new Date(pattern);
    myDate.setDate(myDate.getDate() - 1)
    console.log(`${myDate.getFullYear()}-${myDate.getMonth() + 1}-${myDate.getDate()}`);
    console.log()
}

previousDate(2016, 10, 1);