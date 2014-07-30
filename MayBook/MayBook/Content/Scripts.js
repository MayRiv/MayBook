var MayBook = function () {
    return {
        SendMessage:    function () {
            /*
            bla-bla-bla

            */
            alert(1)
            var message = document.getElementById("message-text").value
            var pathname = window.location.pathname
            var array = pathname.split('/');
            alert(array[3])
            var params = "body=" + message + "&receiverId=" + array[3]

            var req = new XMLHttpRequest()
            req.open("POST", "/Posts/Send", true)

            //Send the proper header information along with the request
            req.setRequestHeader("Content-type", "application/x-www-form-urlencoded")
            req.setRequestHeader("Content-length", params.length)
            req.setRequestHeader("Connection", "close")


            req.send(params)
        }   
    }
}()