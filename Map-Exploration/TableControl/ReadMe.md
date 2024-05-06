## TableControl

<!-- TODO: Write a brief abstract explaining this sample -->
This sample demonstrates using the TableControl on a dockpane.   
In this example we will populate the tablecontrol with content from the selected item in the Catalog pane.   
We will add toolbar buttons to the dockPane to modify the selected rows of the tablecontrol data. We will also customize the default row context menu.   
  


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
1. Download the Community Sample data (see under the 'Resources' section for downloading sample data)
2. Make sure that the Sample data is unzipped in c:\data  
3. In Visual Studio click the Build menu.Then select Build Solution.  
4. Launch the debugger to open ArcGIS Pro.  
5. Open any project.  
6. Click on the Add-In tab.  
7. Click on the* Show Preview* button.  
8. A dockpane will be displayed with an empty TableControl.  
9. Open the Catalog pane and navigate to a datasource from the Community Samples Data.  
10. The TableControl will populate with data when a datasource is highlighted.  
![UI](screenshots/TableControl_1.png)  
11. Click on the Toggle Sel, Select All and Clear Sel to select or unselect the table rows.  
12. Click the Add to Map button to add the data to the active map.  
13. Right click on a row and see the custom context menu. Choose Zoom to Row to zoom to the active row in the map.  
![UI](screenshots/TableControl_ContextMenu.png)  
14. Click the Find button to see the Find UI.  
![UI](screenshots/TableControl_Find.png)  
15. Use the Identify tool on the Add-in tab to identify a feature.  
16. The table control will scroll to that row and select it in the table.  
  

<!-- End -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://esri.github.io/arcgis-pro-sdk/images/ArcGISPro.png"  alt="ArcGIS Pro SDK for Microsoft .NET Framework" height = "20" width = "20" align="top"  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[Home](https://github.com/Esri/arcgis-pro-sdk/wiki) | <a href="https://pro.arcgis.com/en/pro-app/latest/sdk/api-reference" target="_blank">API Reference</a> | [Requirements](https://github.com/Esri/arcgis-pro-sdk/wiki#requirements) | [Download](https://github.com/Esri/arcgis-pro-sdk/wiki#installing-arcgis-pro-sdk-for-net) | <a href="https://github.com/esri/arcgis-pro-sdk-community-samples" target="_blank">Samples</a>
