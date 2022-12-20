//web page trying to connect to web worker
this.addEventListener('connect', (e) => { // lambda 

    let port = e.ports[0]; // first available port
    port.start();
    port.addEventListener('message', function (e) { // anonymous

        if (e.data.length > 0) {
            let result = e.data[0];
            for (let i = 1; i < e.data.length; i++) {
                result = result + e.data[i];
            }
            port.postMessage(result);
        }

    });
        
        
        

});