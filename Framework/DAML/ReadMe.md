## DAML

<!-- TODO: Write a brief abstract explaining this sample -->
This sample demonstrates how to modify the Pro UI using DAML  
  


<a href="https://pro.arcgis.com/en/pro-app/sdk/" target="_blank">View it live</a>

<!-- TODO: Fill this section below with metadata about this sample-->
```
Language:              C#
Subject:               Framework
Contributor:           ArcGIS Pro SDK Team <arcgisprosdk@esri.com>
Organization:          Esri, https://www.esri.com
Date:                  11/04/2024
ArcGIS Pro:            3.4
Visual Studio:         2022
.NET Target Framework: net8.0-windows
```

## Resources

[Community Sample Resources](https://github.com/Esri/arcgis-pro-sdk-community-samples#resources)

### Samples Data

* Sample data for ArcGIS Pro SDK Community Samples can be downloaded from the [Releases](https://github.com/Esri/arcgis-pro-sdk-community-samples/releases) page.  

## How to use the sample
<!-- TODO: Explain how this sample can be used. To use images in this section, create the image file in your sample project's screenshots folder. Use relative url to link to this image using this syntax: ![My sample Image](FacePage/SampleImage.png) -->
1. In Visual Studio click the Build menu. Then select Build Solution.
2. Click Start button to open ArcGIS Pro.  
3. ArcGIS Pro will open.  
4. Open any project with at least one feature layer.  
5. Notice the following customizations made to the Pro UI:  
* The Bookmarks button has been removed in the Navigate group on the Map tab  
<img src="https://ArcGIS.github.io/arcgis-pro-sdk/images/ProSnippetsDAML/DeleteCoreButton.png" width="40%">  
* A new button has been inserted into the Navigate group on the Map Tab  
<img src="https://ArcGIS.github.io/arcgis-pro-sdk/images/ProSnippetsDAML/NewButtonCoreGroup.png" width="40%">  
* With any Map view active, right click on a feature layer in the TOC. Notice the New Button context menu item added.  
<img src="https://ArcGIS.github.io/arcgis-pro-sdk/images/ProSnippetsDAML/NewMenuItemInContextMenu.png" width="40%">  
* Click the Project tab to access Pro's backstage.  Notice the missing Open and New project tabs.  A new tab called "Geocode" has been inserted above the Save project button.  
<img src="https://ArcGIS.github.io/arcgis-pro-sdk/images/ProSnippetsDAML/BackstageDeleteExistingTabsInsertNewTabs.png" width="40%">  
* Click the Project tab to access Pro's backstage. Click the Options tab to display the Options Property Sheet.  Notice the new "Sample Project Settings" property page inserted within the Project group.  
<img src="https://ArcGIS.github.io/arcgis-pro-sdk/images/ProSnippetsDAML/PropertySheetOptionsDialog.png" width="40%">  
* With any Map active, right click on the Map in the Contents pane to access the context menu. Notice the new button inserted into the context menu.  
<img src="https://ArcGIS.github.io/arcgis-pro-sdk/images/ProSnippetsDAML/2DMapContextMenu.png" width="40%">  
* With any Scene active, right click on the Scene in the Contents pane to access the context menu. Notice the new button inserted into the context menu.  
<img src="https://ArcGIS.github.io/arcgis-pro-sdk/images/ProSnippetsDAML/SceneContextMenu.png" width="40%">  
* In the Catalog pane, right click on the Map Container to access its context menu. Notice a new Menu inserted into the context menu.  
<img src="https://ArcGIS.github.io/arcgis-pro-sdk/images/ProSnippetsDAML/MapContainerContextMenu.png" width="40%">  
* In the Catalog pane, right click on any Map item to access its context menu. Notice a new button inserted into the context menu.  
<img src="https://ArcGIS.github.io/arcgis-pro-sdk/images/ProSnippetsDAML/MapContentContextMenu.png" width="40%">  
* In the Catalog pane, right click on any Local Scene to access its context menu. Notice a new button inserted into the context menu.  
<img src="https://ArcGIS.github.io/arcgis-pro-sdk/images/ProSnippetsDAML/SceneContentContextMenu.png" width="40%">  
  

<!-- End -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://esri.github.io/arcgis-pro-sdk/images/ArcGISPro.png"  alt="ArcGIS Pro SDK for Microsoft .NET Framework" height = "20" width = "20" align="top"  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[Home](https://github.com/Esri/arcgis-pro-sdk/wiki) | <a href="https://pro.arcgis.com/en/pro-app/latest/sdk/api-reference" target="_blank">API Reference</a> | [Requirements](https://github.com/Esri/arcgis-pro-sdk/wiki#requirements) | [Download](https://github.com/Esri/arcgis-pro-sdk/wiki#installing-arcgis-pro-sdk-for-net) | <a href="https://github.com/esri/arcgis-pro-sdk-community-samples" target="_blank">Samples</a>
