## LayerPopups

<!-- TODO: Write a brief abstract explaining this sample -->
This sample illustrates how to customize ArcGIS Pro's Layer Pop-up screen.  The sample shows how to define layer popups that will be persisted in the layer's CIM definition and defines a set of 'helper' classes modelled after the similar pattern ArcGIS.Desktop.Mapping implements for Renderer definitions. Popups can be defined that incorporate text, field values, images, charts, etc.  
  


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
1. Download the Community Sample data (see under the 'Resources' section for downloading sample data).  The sample data contains a project called 'AdminSample.aprx' that includes data that is used by this sample.  Make sure that the Sample data is unzipped in c:\data and "C:\Data\Admin" is available.
2. Open this solution in Visual Studio.    
3. Click the build menu and select Build Solution.  
4. Launch the debugger to open ArCGIS Pro.    
5. Open the project "AdminSample.aprx" in the "C:\Data\Admin\" folder since this project contains data referenced by the sample code.  
6. Click on the Add-in tab and see that three buttons in a 'Layer Popup' group were added.  
![UI](Screenshots/Screen1.png)    
7. Click on any of the US state polygons to see the 'standard' layer popup.   
![UI](Screenshots/Screen2.png)    
8. Close the popup.    
9. Click the 'SimplePopup' button and click on any of the US state polygons to see the 'simple' layer popup.  Notice the changed title and the additional text above the field data.    
![UI](Screenshots/Screen3.png)    
10. Close the popup.    
11. Click the 'AdvancedPopup' button and click on any of the US state polygons to see the 'advanced' layer popup.  Notice the additional graphs on the bottom of the layer popup window.    
![UI](Screenshots/Screen4.png)    
12. Close the popup.  
13. Click the 'ResetPopup' button to reset the layer popup to its original view.    
  

<!-- End -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://esri.github.io/arcgis-pro-sdk/images/ArcGISPro.png"  alt="ArcGIS Pro SDK for Microsoft .NET Framework" height = "20" width = "20" align="top"  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[Home](https://github.com/Esri/arcgis-pro-sdk/wiki) | <a href="https://pro.arcgis.com/en/pro-app/latest/sdk/api-reference" target="_blank">API Reference</a> | [Requirements](https://github.com/Esri/arcgis-pro-sdk/wiki#requirements) | [Download](https://github.com/Esri/arcgis-pro-sdk/wiki#installing-arcgis-pro-sdk-for-net) | <a href="https://github.com/esri/arcgis-pro-sdk-community-samples" target="_blank">Samples</a>
