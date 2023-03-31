<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChatRoomApplication.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<script src="http://code.jquery.com/jquery-1.8.2.min.js" type="text/javascript"></script>
<script src="Scripts/jquery.signalR-1.0.1.min.js" type="text/javascript"></script>
<script src="signalr/hubs" type="text/javascript"></script>
<script type="text/javascript">
    $(function () {
        // Proxy created on the fly          
        var chat = $.connection.chatHub;
        // Get the user name and store it to prepend to messages.
        $('#displayname').val(prompt('Enter your name:', ''));

        // Declare a function on the chat hub so the server can invoke it          
        chat.client.sendMessage = function (name, message) {
            var encodedName = $('<div />').text(name).html();
            var encodedMsg = $('<div />').text(message).html();
            $('#messages').append('<li>' + encodedName + ':&nbsp;&nbsp;' + encodedMsg + '</li>');
        };

        // Start the connection
        $.connection.hub.start().done(function () {
            $("#send").click(function () {
                // Call the chat method on the server
                chat.server.send($('#displayname').val(), $('#msg').val());
            });
        });
    });
</script>

</head>
<body>
    <div>
    <input type="text" id="msg" />
<input type="button" id="send" value="Send" />
<input type="hidden" id="displayname" />
<ul id="messages">
</ul>
  </div>
</body>
</html>
