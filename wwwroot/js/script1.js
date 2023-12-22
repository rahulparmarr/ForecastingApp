//male
var males = Array.from(document.querySelectorAll('.datainput'));
var arr = []
males.map(elem => {
    arr.push(parseInt(elem.value));

})
var sum = arr.reduce(function (acc, value) {
    return acc + value;
}, 0);


//female
var females = Array.from(document.querySelectorAll('.datainput2'));
var arr2 = []
females.map(elem => {
    arr2.push(parseInt(elem.value));

})
var sum2 = arr2.reduce(function (acc, value) {
    return acc + value;
}, 0);







function CountryTotal(totals) {
    
    document.getElementById("countryTotal").textContent = totals;

}




function totals(totalValue) {
    document.getElementById("total").textContent = totalValue;
    //document.getElementById("total").value = totalValue;
    
}

function totals2(totalValue) {
    
    document.getElementById("total2").textContent = totalValue;
}


function dataMale() {
    var g = document.querySelectorAll(".datainput");
    var h = Array.from(g);
    var narr = []
    h.map(elem => {
        narr.push(parseInt(elem.value));

    })
    var s = narr.reduce(function (acc, value) {
        return acc + value;
    }, 0);

    totals(s);
    var fe = document.getElementById("total2").innerText;
    var female = parseInt(fe);
    CountryTotal(female + s);
}


function dataFemale() {
    var g = document.querySelectorAll(".datainput2");
    var h = Array.from(g);
    var narr = []
    h.map(elem => {
        narr.push(parseInt(elem.value));

    })
    var s = narr.reduce(function (acc, value) {
        return acc + value;
    }, 0);

    totals2(s);
    var m = document.getElementById("total").innerText;
    var male = parseInt(m);
    CountryTotal(male + s);
}

totals(sum);
totals2(sum2)
CountryTotal(sum + sum2);