## ConstructingGeometries_CSharp

<!-- TODO: Write a brief abstract explaining this sample -->
This sample provide four buttons showing the construction of geometry types of type MapPoint, Multipoint, Polyline, and Polygon and shows how to:  
* Construct and manipulate geometries  
* Use GeometryEngine functionality  
* Search and retrieve features  
  


<a href="https://pro.arcgis.com/en/pro-app/sdk/" target="_blank">View it live</a>

<!-- TODO: Fill this section below with metadata about this sample-->
```
Language:              C#
Subject:               Geometry, Geodatabase
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
1. Download the Community Sample data (see under the 'Resources' section for downloading sample data)
2. Make sure that the Sample data is unzipped in c:\data   
3. The project used for this sample is 'C:\Data\FeatureTest\FeatureTest.aprx'  
4. In Visual Studio click the Build menu. Then select Build Solution.  
5. Click Start button to open ArcGIS Pro.  
6. ArcGIS Pro will open, select the FeatureTest.aprx project  
7. Click on the ADD-IN tab and make sure that your active map contains Setup/point/multipoint/line/polygon features buttons as shown below.  
![UI](Screenshots/ScreenPoints.png)  
8. Click on Setup button to enable the create point and create multipoint buttons   
![UI](Screenshots/ScreenPoint1.png)  
9. Click the createPoints button to create random points over the current extent of the map  
10. The map extent shows the random created points and also enables create polylines button  
![UI](Screenshots/ScreenPoint2.png)  
11. Click the createPolylines button to create random lines the current extent of the map  
12. The map extent shows the random lines and also enables create polygons button  
![UI](Screenshots/ScreenPoint3.png)  
13. Click the createPolygons button to create random polygon over the current extent of the map  
![UI](Screenshots/ScreenPoint4.png)  
  

<!-- End -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://esri.github.io/arcgis-pro-sdk/images/ArcGISPro.png"  alt="ArcGIS Pro SDK for Microsoft .NET Framework" height = "20" width = "20" align="top"  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[Home](https://github.com/Esri/arcgis-pro-sdk/wiki) | <a href="https://pro.arcgis.com/en/pro-app/latest/sdk/api-reference" target="_blank">API Reference</a> | [Requirements](https://github.com/Esri/arcgis-pro-sdk/wiki#requirements) | [Download](https://github.com/Esri/arcgis-pro-sdk/wiki#installing-arcgis-pro-sdk-for-net) | <a href="https://github.com/esri/arcgis-pro-sdk-community-samples" target="_blank">Samples</a>
