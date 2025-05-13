## DisplayFilters

<!-- TODO: Write a brief abstract explaining this sample -->
This sample demonstrates how to add Display Filters to Feature Layers.  
  


<a href="https://pro.arcgis.com/en/pro-app/sdk/" target="_blank">View it live</a>

<!-- TODO: Fill this section below with metadata about this sample-->
```
Language:              C#
Subject:               Framework
Contributor:           ArcGIS Pro SDK Team <arcgisprosdk@esri.com>
Organization:          Esri, https://www.esri.com
Date:                  05/06/2025
ArcGIS Pro:            3.5
Visual Studio:         2022
.NET Target Framework: net8.0-windows
```

## Resources

[Community Sample Resources](https://github.com/Esri/arcgis-pro-sdk-community-samples#resources)

### Samples Data

* Sample data for ArcGIS Pro SDK Community Samples can be downloaded from the [Releases](https://github.com/Esri/arcgis-pro-sdk-community-samples/releases) page.  

## How to use the sample
<!-- TODO: Explain how this sample can be used. To use images in this section, create the image file in your sample project's screenshots folder. Use relative url to link to this image using this syntax: ![My sample Image](FacePage/SampleImage.png) -->
1. Download the Community Sample data (see under the 'Resources' section for downloading sample data).  The sample data contains a folder called 'C:\Data\DisplayFilters' with sample data required for this solution.  Make sure that the Sample data is unzipped in c:\data and "C:\Data\DisplayFilters" is available.
2. In Visual Studio click the Build menu. Then select Build Solution.    
3. Launch the debugger to open ArcGIS Pro.  
4. Create a new blank Map project.   
5. Add the C:\Data\DisplayFilters\Hydrology.lpkx layer file to the map. This is a sample dataset of the Hydrology in the US available with the [ArcGIS Pro SDK Community Data](https://github.com/Esri/arcgis-pro-sdk-community-samples#samples-data).  
     ![UI](screenshots/Hydrology.PNG)  
6. Click the Add-In tab.  There should be two buttons created by this sample on this tab in the "Display Filters" group: Apply Display Filters 1 amd Apply Display Filters 2.  
     ![UI](screenshots/buttons.PNG)  
7. These buttons create and apply display filters to view the dense Hydrology dataset.   
8. The "Apply Display Filters 1" button uses the CIMDefinition of the Hydrology layer using the GetDefinition\SetDefinition method pair.   
9. The "Apply Display Filters 2" button uses the LayerDocument class to retrieve and work with the CIMDefinition.  
     ![UI](screenshots/DisplayFilter.PNG)  
  

<!-- End -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://esri.github.io/arcgis-pro-sdk/images/ArcGISPro.png"  alt="ArcGIS Pro SDK for Microsoft .NET Framework" height = "20" width = "20" align="top"  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[Home](https://github.com/Esri/arcgis-pro-sdk/wiki) | <a href="https://pro.arcgis.com/en/pro-app/latest/sdk/api-reference" target="_blank">API Reference</a> | [Requirements](https://github.com/Esri/arcgis-pro-sdk/wiki#requirements) | [Download](https://github.com/Esri/arcgis-pro-sdk/wiki#installing-arcgis-pro-sdk-for-net) | <a href="https://github.com/esri/arcgis-pro-sdk-community-samples" target="_blank">Samples</a>
