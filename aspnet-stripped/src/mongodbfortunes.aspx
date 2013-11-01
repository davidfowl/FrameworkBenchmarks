<%@ Page Language="C#" AutoEventWireup="true" Inherits="MongoDBFortunesPage" %>

<!DOCTYPE html>
<html>
<head><title>Fortunes</title></head>
<body>
    <table>
        <tr>
            <th>id</th>
            <th>message</th>
        </tr>
        <% foreach (var fortune in Fortunes)
           { %><tr>
            <td><% = fortune.ID %></td>
            <td><%: fortune.Message %></td>
        </tr>
        <% } %></table>
</body>
</html>
