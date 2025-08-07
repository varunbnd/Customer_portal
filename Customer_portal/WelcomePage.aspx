<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomePage.aspx.cs" Inherits="Customer_portal.WelcomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server" lang="en">
    <title></title>

    <style>

.slideshow-container {
  max-width: 100%;
  max-height: 100%;
  position: relative;
  margin: auto;
}


/* Fading animation */
.fade {
  -webkit-animation-name: fade;
  -webkit-animation-duration: 2.5s;
  animation-name: fade;
  animation-duration: 2.5s;
}

@-webkit-keyframes fade {
  from {opacity: .4}
  to {opacity: 1}
}

@keyframes fade {
  from {opacity: .4}
  to {opacity: 1}
}

</style>


    <style type="text/css">
        body {
  background-image: url("images/pexels-vlad-che&#539;an-2600219.jpg");
  background-repeat: no-repeat;
  background-attachment: fixed;
  background-size:cover;
}          
        .auto-style1 {
            text-align: center;
            width: 1475px;
        }
        ul {
  list-style-type: none;
  margin: 0;
  padding: 0;
  overflow: hidden;
  background-color: #333;
}

li {
  float: left;
        height: 39px;
    }


li a, .dropbtn {
  display: inline-block;
  color: white;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
        height: 11px;
    }

li a:hover, .dropdown:hover .dropbtn {
  background-color: red;
}

li.dropdown {
  display: inline-block;
        width: 62px;
        height: 36px;
    }

.dropdown-content {
  display: none;
  position: absolute;
  background-color: #f9f9f9;
  min-width: 160px;
  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
  z-index: 1;
}

.dropdown-content a {
  color: black;
  padding: 12px 16px;
  text-decoration: none;
  display: block;
  text-align: left;
}

.dropdown-content a:hover {background-color: #f1f1f1;}

.dropdown:hover .dropdown-content {
  display: block;
}
        .auto-style2 {
            height: 62px;
        }
        .auto-style4 {
            height: 53px;
            width: 1476px;
        }
        .auto-style5 {
            width: 189px;
            height: 60px;
        }
        .auto-style6 {
            width: 124px;
            height: 71px;
        }
        
img{
    width: 1458px;
    height: 680px;
    object-fit:cover;
            margin-top: 0px;
        }
        .w3-section {
            height: 289px;
        }
    </style>

</head>
<body>
    <!--images url-->
    <form id="form1" runat="server">
    <div style="background-image: url('images/173548 (1).jpg')" class="auto-style1">
        <br />
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Agriculture</strong><br />
        <br />
<asp:Image ID="Image1" runat="server" CssClass="auto-style2" Height="148px" ImageUrl="~/images/Logo.jpg" Width="246px" style="margin-left: 49px" />
        <br />
        <br />
    </div>
    <div>
     <!--images url-->
        <!--navigation bar(horizontal)-->
        <ul class="auto-style4">
            
             <li class="dropdown" style="width: 116px">

                <a href="javascript:void(0)" class="dropbtn">Crop Stats</a>
                <div class="dropdown-content">
                    <a href="statstry1.aspx">Crop types</a>
                    <a href="statstry2.aspx">Crop sizes</a>
                    
                </div>
            </li>
            <li class="dropdown">

                <a href="javascript:void(0)" class="dropbtn">3I's</a>
                <div class="dropdown-content">
                    <a href="https://www.manage.gov.in/publications/Success%20Stories%20-%20Farmers%20.pdf">Inspiring</a>
                    <a href="https://cuesa.org/article/16-inspiring-women-farmers-you-should-know">Inovative</a>
                    <a href="https://timesofindia.indiatimes.com/blogs/the-interviews-blog/farmers-are-intelligent-as-they-respond-to-incentives-let-the-government-give-money-directly-to-the-farmers/">Intelligent</a>
                </div>
            </li>
          
            <li>
                <a href="http://localhost:51766/Soiltypetables/Indexuserview" class="auto-style6">Soil Type</a> <a href="http://localhost:51766/Cropdistributioncenters/Indexuserlist" class="auto-style5">Seeds Distribution center</a>

             
            </li>
          
        </ul>
     </div>
        


        <br />


<div class="w3-content w3-section">
  <img class="mySlides" src="Images/Images_Slideshow/1_1.png"/>
  <img class="mySlides" src="Images/Images_Slideshow/2.jpg"/>
  <img class="mySlides" src="Images/Images_Slideshow/6_6.jpg"/>
   <img class="mySlides" src="Images/Images_Slideshow/3_3.jpg"/>
    <img class="mySlides" src="Images/Images_Slideshow/5_5.jpg"/>
    <img class="mySlides" src="Images/Images_Slideshow/4_4.png"/>
</div>

        <br />
<br />
        <br />

<script>
    var myIndex = 0;
    carousel();

    function carousel() {
        var i;
        var x = document.getElementsByClassName("mySlides");
        for (i = 0; i < x.length; i++) {
            x[i].style.display = "none";
        }
        myIndex++;
        if (myIndex > x.length) { myIndex = 1 }
        x[myIndex - 1].style.display = "block";
        setTimeout(carousel, 3000); 
    }
</script>

         

    </form>
    </body>
</html>
