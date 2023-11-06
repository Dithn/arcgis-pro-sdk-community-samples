## DeleteFeaturesBasedOnSubtype

<!-- TODO: Write a brief abstract explaining this sample -->
This addin lists all subtypes for a Feature Class and allows deleting all features with a specific subtype  
  


<a href="https://pro.arcgis.com/en/pro-app/sdk/" target="_blank">View it live</a>

<!-- TODO: Fill this section below with metadata about this sample-->
```
Language:              C#
Subject:               Geodatabase
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
3. Click Start button to open ArcGIS Pro.  
4. ArcGIS Pro will open.  
5. Open the "C:\Data\Interacting with Maps\Interacting with Maps.aprx" project which contains the required data needed for this sample.  
6. Make sure the Map Pane and the corresponding Table of Contents (TOC) Pane are Open and the Map Pane is Active  
7. Select "Crimes" on the Contents table of content.  
![UI](Screenshots/Screen1.png)  
8. Click on the Add-In Tab and note the "Delete All Features Having Subtype" dropdown.  
9. Note that when no Layer is selected in the TOC, clicking on the combobox will show an empty list. An empty list will also be shown if the Layer is not a Feature Layer i.e. if it is a standalone table.  
10. Select the  "Crimes" feature layer because it has a defined subtype.   
11. Opening the Combobox will list all the subtypes for the FeatureClass.  
![UI](Screenshots/Screen2.png)  
12. On Selecting a Subtype, all the features with that subtype will be deleted from the FeatureClass and thereby cleared from the Map.  
13. Finally you can use the "Undo" button to restore the subtype data you just deleted.  
![UI](Screenshots/Screen3.png)      
  

<!-- End -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://esri.github.io/arcgis-pro-sdk/images/ArcGISPro.png"  alt="ArcGIS Pro SDK for Microsoft .NET Framework" height = "20" width = "20" align="top"  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[Home](https://github.com/Esri/arcgis-pro-sdk/wiki) | <a href="https://pro.arcgis.com/en/pro-app/latest/sdk/api-reference" target="_blank">API Reference</a> | [Requirements](https://github.com/Esri/arcgis-pro-sdk/wiki#requirements) | [Download](https://github.com/Esri/arcgis-pro-sdk/wiki#installing-arcgis-pro-sdk-for-net) | <a href="https://github.com/esri/arcgis-pro-sdk-community-samples" target="_blank">Samples</a>
