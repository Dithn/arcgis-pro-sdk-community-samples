## Overlay3D

<!-- TODO: Write a brief abstract explaining this sample -->
This sample shows how to add overlay graphics to 3D map view.  
  


<a href="https://pro.arcgis.com/en/pro-app/sdk/" target="_blank">View it live</a>

<!-- TODO: Fill this section below with metadata about this sample-->
```
Language:              C#
Subject:               Map Exploration
Contributor:           ArcGIS Pro SDK Team <arcgisprosdk@esri.com>
Organization:          Esri, https://www.esri.com
Date:                  10/01/2023
ArcGIS Pro:            3.2
Visual Studio:         2022
.NET Target Framework: net6.0-windows
```

## Resources

[Community Sample Resources](https://github.com/Esri/arcgis-pro-sdk-community-samples#resources)

### Samples Data

* Sample data for ArcGIS Pro SDK Community Samples can be downloaded from the [Releases](https://github.com/Esri/arcgis-pro-sdk-community-samples/releases) page.  

## How to use the sample
<!-- TODO: Explain how this sample can be used. To use images in this section, create the image file in your sample project's screenshots folder. Use relative url to link to this image using this syntax: ![My sample Image](FacePage/SampleImage.png) -->
1. Download the Community Sample data (see under the 'Resources' section for downloading sample data).  The sample data contains required data for this sample add-in.  Make sure that the Sample data is unzipped in c:\data and "C:\Data\Interacting with Maps" is available.
2. In Visual Studio click the Build menu. Then select Build Solution.  
3. Launch the debugger to open ArcGIS Pro.  
4. Open the "C:\Data\Interacting with Maps\Interacting with Maps.aprx" project which contains the required data needed for this sample.  
5. From the "Catalog dockpane" open the "Portland 3D City" map.  
![UI](Screenshots/Screen0.png)   
6. Click on the Add-In tab on the ribbon and open the "Overlay 3D Dockpane" using the "Show Overlay 3D Dockpane" button.  
7. On the 'Overlay 3D Dockpane' click the refresh button, this will update the 'Trees Name field selection" list.  
8. Select one of the "Tree Names" (i.e. Ponderosa Pine) in order to add these records to the graphic overlay.  
![UI](Screenshots/Screen01.png)   
9. Once a "Tree Name" is selected the "Symbol for Overlay Graphic" list is updated using one of two '3D symbol style' categories.  
10. Uncheck the 'Trees' layer on the content dockpane to better view the added overlay graphics.  
11. Select a "Symbol for 'overlay graphics'" and observe how the symbols are added to the mapview.  
![UI](Screenshots/Screen02.png)   
12. Add more symbols to the mapview and optionally 'Clear the graphics overlay'/  
![UI](Screenshots/Screen1.png)    
  

<!-- End -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://esri.github.io/arcgis-pro-sdk/images/ArcGISPro.png"  alt="ArcGIS Pro SDK for Microsoft .NET Framework" height = "20" width = "20" align="top"  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[Home](https://github.com/Esri/arcgis-pro-sdk/wiki) | <a href="https://pro.arcgis.com/en/pro-app/latest/sdk/api-reference" target="_blank">API Reference</a> | [Requirements](https://github.com/Esri/arcgis-pro-sdk/wiki#requirements) | [Download](https://github.com/Esri/arcgis-pro-sdk/wiki#installing-arcgis-pro-sdk-for-net) | <a href="https://github.com/esri/arcgis-pro-sdk-community-samples" target="_blank">Samples</a>
