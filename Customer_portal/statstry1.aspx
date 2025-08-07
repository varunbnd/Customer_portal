<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="statstry1.aspx.cs" Inherits="Customer_portal.statstry1" %>

<!DOCTYPE html>

<html>
<head>
<script type="text/javascript">
window.onload = function () {
	var chart = new CanvasJS.Chart("chartContainer",
	{
		title:{
			text: "Farming stats on farming lands"
		},
		legend: {
			maxWidth: 350,
			itemWidth: 120
		},
		data: [
		{
			type: "pie",
			showInLegend: true,
			legendText: "{indexLabel}",
			dataPoints: [
				{ y: 4181563, indexLabel: "Rice" },
				{ y: 2175498, indexLabel: "wheat" },
				{ y: 3125844, indexLabel: "Nutri cerals" },
				{ y: 1176121, indexLabel: "Pulses"},
				{ y: 1727161, indexLabel: "Oil seeds" },
				{ y: 4303364, indexLabel: "suagarcane"},
				{ y: 1717786, indexLabel: "Cotton"}
			]
		}
		]
	});
	chart.render();
}
</script>
<script type="text/javascript" src="https://canvasjs.com/assets/script/canvasjs.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            height: 440px;
            width: 100%;
        }
    </style>
</head>
<body>
<div id="chartContainer" class="auto-style1"></div>




</body>
</html>