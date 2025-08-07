<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Temparature convert.aspx.cs" Inherits="Customer_portal.Temparature_convert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
 <p style="background-image:url('Images/background-2_crud.jpg');"></p>
            	<h2>Temperature Converter</h2>
<p>Type a value in the Fahrenheit field to convert the value to Celsius:</p>

<p>
  <label>Fahrenheit</label>
  <input id="inputFahrenheit" type="number" placeholder="Fahrenheit" oninput="temperatureConverter(this.value)" onchange="temperatureConverter(this.value)">
</p>
<p>Celcius: <span id="outputCelcius"></span></p>

<script>
    function temperatureConverter(valNum) {
        valNum = parseFloat(valNum);
        document.getElementById("outputCelcius").innerHTML = (9/5)(valNum - 32) / 1.8;
    }
</script>

    </form>
</body>
</html>
