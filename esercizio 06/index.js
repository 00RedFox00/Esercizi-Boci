//const numeri = [];
//const operatori = [];
let risultati = [];

let b = 0;

function wrt(val) {
    let numeri = document.getElementById('rdo').value;
    let a = document.getElementById('rdo').value.length;
    b ++;
    document.getElementById('rdo').value += val.value;
    if (b > 1){
        
    }
}
function nbr(val) {
    document.getElementById('rdo').value += val.value;
}
function clr() {
    console.log('*CLEAR EFFETTUATO*')
    document.getElementById('rdo').value = '';
    for (let a = 0; a < risultati.length; a++){
        risultati.shift();
        console.log(risultati);
    }
    //console.log('status ARRAY => ' + nump);
}
function ris() {



    /*
    //console.log('NUMERI => ' + document.getElementById('rdo').value.match(/[0-9]+/g));
    let numeri = (document.getElementById('rdo').value.match(/[0-9]+/g));
    console.log(numeri);
    //console.log('SEGNI => ' + document.getElementById('rdo').value.match(/[+--,*,/]/g));
    let operatori = (document.getElementById('rdo').value.match(/[+--,*,/]/g));
    console.log(operatori);

    for (let i = 0; i < numeri.length; i++){
        if (risultati.length == 0){
            if (operatori[i] == '+') {
                risultati.unshift(parseInt(numeri[i]) + parseInt(numeri[i+1]));
            } else if (operatori[i] == '-') {
                risultati.unshift(parseInt(numeri[i]) - parseInt(numeri[i+1]));
            } else if (operatori[i] == '*') {
                risultati.unshift(parseInt(numeri[i]) * parseInt(numeri[i+1]));
            } else if (operatori[i] == '/') {
                risultati.unshift(parseInt(numeri[i]) / parseInt(numeri[i+1]));
            } else {
            }
            //risultati.unshift(parseInt(numeri[i]) + operatori[i] + parseInt(numeri[i+1]));
        } else if (risultati.length > 0) {
            if (operatori[i] == '+') {
                risultati.unshift(parseInt(risultati[0]) + parseInt(numeri[i+1]));
            } else if (operatori[i] == '-') {
                risultati.unshift(parseInt(risultati[0]) - parseInt(numeri[i+1]));
            } else if (operatori[i] == '*') {
                risultati.unshift(parseInt(risultati[0]) * parseInt(numeri[i+1]));
            } else if (operatori[i] == '/') {
                risultati.unshift(parseInt(risultati[0]) / parseInt(numeri[i+1]));
            } else {
            }
            //risultati.unshift(parseInt(risultati[0]) + parseInt(operatori[i]) + parseInt(numeri[i+1]));
        } else {
        }
    }
    console.log(risultati[0]);*/
}
