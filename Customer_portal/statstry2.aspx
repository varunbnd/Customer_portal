<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="statstry2.aspx.cs" Inherits="Customer_portal.statstry2" %>

<!DOCTYPE html>

<html lang="en-US">
<body>

<h1>Farmer stats</h1>

<div id="piechart"></div>

<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>

<script type="text/javascript">
google.charts.load('current', {'packages':['corechart']});
google.charts.setOnLoadCallback(drawChart);

// Draw the chart and set the chart values
function drawChart() {
  var data = google.visualization.arrayToDataTable([
  ['Lands', 'Hours per Day'],
  ['Wheat', 8],
  ['Cotton', 2],
  ['Jowar', 4],
  ['Sugarcane', 2],
  ['Rice', 8]
]);

  // Optional; add a title and set the width and height of the chart
  var options = {'title':'My Average Day', 'width':750, 'height':500};

  // Display the chart inside the <div> element with id="piechart"
  var chart = new google.visualization.PieChart(document.getElementById('piechart'));
  chart.draw(data, options);
}
</script>

</body>
</html>

