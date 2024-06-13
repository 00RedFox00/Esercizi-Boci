function wrt(val) {
    document.getElementById("rdo").value+=val.value;
}
function clr(){
    document.getElementById("rdo").value="";
    //document.getElementsByTagName("BODY")[0].classList.toggle("changecolor1");
    //window.setTimeout("black()", 50)
}
/*function black() {
    document.getElementsByTagName("BODY")[0].classList.toggle("changecolor2");
}*/
function rst() {
    document.getElementById('rst').value = eval(document.getElementById('rdo').value)
}