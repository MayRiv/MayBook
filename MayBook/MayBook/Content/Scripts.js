﻿var MayBook = function () {
    return {
        SendMessage:    function () {
            var message = document.getElementById("message-text").value
            var pathname = window.location.pathname
            var array = pathname.split('/');
            var params = "body=" + message + "&receiverId=" + array[3]
            var req = new XMLHttpRequest()
            req.open("POST", "/Posts/Send", true)
            req.setRequestHeader("Content-type", "application/x-www-form-urlencoded")
            req.setRequestHeader("Content-length", params.length)
            req.setRequestHeader("Connection", "close")
            req.send(params)
        },
        Change: function (id) {
            var div = document.getElementById(id)
            var body = document.getElementById('message-' + id).innerHTML
            alert('<input id="edit-message-text" type="text" value="' + body + '"/>')
            div.innerHTML = '<input id="edit-message-text" type="text" value=' + body + ' "/>  <input type="button" value="Submit" onclick="MayBook.UpdateChanging('+id+')" />'

        },
        UpdateChanging: function (id) {
            
            var params = 'body=' + document.getElementById('edit-message-text').value + '&id=' + id;
            var req = new XMLHttpRequest()
            req.open("POST", "/Posts/Change", true)
            req.setRequestHeader("Content-type", "application/x-www-form-urlencoded")
            req.setRequestHeader("Content-length", params.length)
            req.send(params)
        },
        Delete: function (id) {
            var req = new XMLHttpRequest()
            req.open("POST", "/Posts/Delete", true)
            var params = 'id=' + id;
            req.setRequestHeader("Content-type", "application/x-www-form-urlencoded")
            req.setRequestHeader("Content-length", params.length)
            req.setRequestHeader("Connection", "close")
            req.send(params)
        }
    }
}()