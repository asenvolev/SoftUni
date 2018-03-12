function checkLeapYear(year) {
    let bool = false;
    if (year%4===0 && year % 100 ===0 && year%400===0) {
        bool = true;
    } else if (year%4===0 && year % 100 ===0) {
        bool = false
    } else if (year%4===0) {
        bool = true
    }
    else{
        bool = false
    }
    
    if (bool) {
        console.log('yes')
    }else{
        console.log('no')
    }
}

checkLeapYear(2108)