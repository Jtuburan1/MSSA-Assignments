var i = 0;
function countNumbers() {

    if (i < 100) {
        i = i + 1;
        postMessage(i);// webworker commnunicates with webpage

    }
    setTimeout("countNumbers()", 500);// introduce delay
}
countNumbers();