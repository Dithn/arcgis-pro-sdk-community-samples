## ScreenCoordsToMapPoint

<!-- TODO: Write a brief abstract explaining this sample -->
This sample demonstrates how to convert screen coordinates to a map point  
  


<a href="https://pro.arcgis.com/en/pro-app/sdk/" target="_blank">View it live</a>

<!-- TODO: Fill this section below with metadata about this sample-->
```
Language:              C#
Subject:               Map Exploration
Contributor:           ArcGIS Pro SDK Team <arcgisprosdk@esri.com>
Organization:          Esri, https://www.esri.com
Date:                  04/04/2024
ArcGIS Pro:            3.3
Visual Studio:         2022
.NET Target Framework: net8.0-windows
```

## Resources

[Community Sample Resources](https://github.com/Esri/arcgis-pro-sdk-community-samples#resources)

### Samples Data

* Sample data for ArcGIS Pro SDK Community Samples can be downloaded from the [Releases](https://github.com/Esri/arcgis-pro-sdk-community-samples/releases) page.  

## How to use the sample
<!-- TODO: Explain how this sample can be used. To use images in this section, create the image file in your sample project's screenshots folder. Use relative url to link to this image using this syntax: ![My sample Image](FacePage/SampleImage.png) -->
1. Download the Community Sample data (see under the 'Resources' section for downloading sample data).  The sample data contains required data for this sample add-in.  Make sure that the Sample data is unzipped in c:\data and "C:\Data\Interacting with Maps" is available.
2. In Visual Studio click the Build menu. Then select Build Solution.  
3. Click Start button to open ArcGIS Pro.  
4. ArcGIS Pro opens.   
5. Open the "C:\Data\Interacting with Maps\Interacting with Maps.aprx" project which contains the required data needed for this sample.  
6. From the "Catalog dockpane" open the "Portland 3D City" map.  
7. Open the MapToolScreenToMap.cs source and note the *SketchOutputMode = SketchOutputMode.Screen* setting in the constructor.  This is required when a MapTool is used in both 2D and 3D mapviews.  
8. Set a breakpoint in the OnSketchCompleteAsync method.  
9. Click on the Add-In tab on the ribbon and select the *Demo Screen To Map* map tool.  
10. Using the map tool click anywhere on the ground area on the "Portland 3D City" map.  
11. In Visual Studio step through the OnSketchCompleteAsync method and examine the point conversion logic.  
12. Continue program execution.  
![UI](Screenshots/Screen0.png)   
13. Using the map tool click anywhere in the sky on the "Portland 3D City" map.  
14. In Visual Studio step through the OnSketchCompleteAsync method and note that the converted map point is empty.  
![UI](Screenshots/Screen1.png)   
  

<!-- End -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://esri.github.io/arcgis-pro-sdk/images/ArcGISPro.png"  alt="ArcGIS Pro SDK for Microsoft .NET Framework" height = "20" width = "20" align="top"  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[Home](https://github.com/Esri/arcgis-pro-sdk/wiki) | <a href="https://pro.arcgis.com/en/pro-app/latest/sdk/api-reference" target="_blank">API Reference</a> | [Requirements](https://github.com/Esri/arcgis-pro-sdk/wiki#requirements) | [Download](https://github.com/Esri/arcgis-pro-sdk/wiki#installing-arcgis-pro-sdk-for-net) | <a href="https://github.com/esri/arcgis-pro-sdk-community-samples" target="_blank">Samples</a>
