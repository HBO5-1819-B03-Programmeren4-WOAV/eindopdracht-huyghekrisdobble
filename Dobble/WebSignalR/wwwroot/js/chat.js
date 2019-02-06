"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

connection.on("ReceiveMessage", function (user, message) {
    var msg = message;
    var json = JSON.parse(message);
    var username = json.username;
    var tijd = json.tijd;
    var aantal_pogingen = json.aantal_pogingen;
    var aantal_juist = json.aantal_juist;
    var Totaalscore = json.Totaalscore;
    var MaxScore = json.MaxScore;
    var Level = json.Level;
    var encodedMsg = user + " " + tijd + " " + username + " " + aantal_juist+ "/" + aantal_pogingen + " Totaalscore:" + Totaalscore + " MaxScore:" + MaxScore + " Level:" + Level;
    var li = document.createElement("li");
    li.textContent = encodedMsg; document.getElementById("messagesList").appendChild(li);
    document.getElementById("tijd").innerText = tijd;
    document.getElementById("user").innerText = username;
    document.getElementById("pogingen").innerText = aantal_juist + "/" + aantal_pogingen;
     

   
});

connection.start().catch(function (err) { return console.error(err.toString()); });

//document.getElementById("sendButton").addEventListener("click", function (event) {
//    var user = document.getElementById("userInput").value; var message = document.getElementById("messageInput").value; connection.invoke("SendMessage", user, message).catch(function (err) { return console.error(err.toString()); }); event.preventDefault();
//}); 

