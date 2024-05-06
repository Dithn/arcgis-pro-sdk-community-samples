## OpenItemDialogBrowseFilter

<!-- TODO: Write a brief abstract explaining this sample -->
This sample demonstrates working with browse dialog filters.    
  


<a href="https://pro.arcgis.com/en/pro-app/sdk/" target="_blank">View it live</a>

<!-- TODO: Fill this section below with metadata about this sample-->
```
Language:              C#
Subject:               Content
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
Using the sample:  
  
1. In Visual Studio click the Build menu. Then select Build Solution.
2. Click Start button to open ArcGIS Pro.  
3. ArcGIS Pro will open.   
4. Open any project.  
5. Click the Dialog filters tab on the Pro ribbon.  
6. Notice the in-line gallery that displays a collection of Dialog filters.  
7. Click the gallery expander to view the entire gallery. The filters in this sample are grouped into two categories: Custom Pro browse filters and Built-in browse filters.  
![UI](screenshots/FilterGallery.png)  
8. Clicking on each filter will display Pro's OpenItemDialog set to that specific filter.  
9. The table below offers a brief explanation of these filters showcased in this sample.    
  
|Browse dialog image with filter| Filter type| Description|  
|------------- |:-------------:| -----:|  
|![Polygon FGDB](screenshots/PolygonFGDB.png)    | Custom Pro BrowseProjectFilter<br />**Polygon FGDB**: Show Polygon File GDB|  
|![Custom Item](screenshots/CustomItem.png)    | Custom Pro BrowseProjectFilter<br />**Custom Item**: Show files with the "customItem" file extension. Sample file located in the [community sample data](https://github.com/Esri/arcgis-pro-sdk-community-samples#samples-data). After you extract the contents of the zip file, the file can be found in the folder C:\Data\BrowseDialogFilters|  
|![Composite Filter](screenshots/compositeFilter.png)    | Custom Pro Browse BrowseProjectFilter<br />**Composite Filter**: Show Composite Filter File GDB|  
|![Line FGDB](screenshots/lineFGDB.png)    | Custom Pro BrowseProjectFilter<br />**Line FGDB**: Show Line File GDB|  
|![DAML Filter](screenshots/DAMLFilter.png)    | Custom Pro BrowseProjectFilter<br />**DAML Filter**: Line File GDB filter created from DAML definition files |  
|![Lyr and Lyrx](screenshots/LyrLyrx.png)  | Built-in Pro BrowseProjectFilter<br />**Lyr and Lyrx**:Show Lyrx and lyr files     |  
|![Geodatabase](screenshots/Geodatabase.png)  | Built-in Pro BrowseProjectFilter<br />**Geodatabase**: Show all Geodatabases|  
|![Custom Item](screenshots/AddToMapCustomItem.png)  | Built-in Pro BrowseProjectFilter<br />**Custom Item**: Browse custom item in Pro's Add to map dialog|      
10. Click the "Browse Filter Spy+" button choice at the bottom of the in-line gallery or on the Pro ribbon.    
11. The Browse Filter Spy+ dialog allows you to choose between 3 options - Pro Browse Filters, Pro FilterFlags and ProTypeIDs.  
    * **Pro Browse Filters**: Using this choice you can see all the Browse Filters defined in DAML. This includes Pro's built in filters and those defined in Add-ins (config.daml).   
    You can select any of the browse filters and see its DAML Definition below. The Open Filter button will display Pro's OpenItemDialog set to that specific filter.   
    * **Pro FilterFlags**: Using this choice you can see the enum values for BrowseProjectFilter.FilterFlag. Additionally, when you select any filterFlag,      you can see the typeIDs that participate in that filter flag.  
    * **ProTypeIDs**: This choice allows you to see all the TypeIDs defined in Pro. This includes the typeIDs for custom items created by Add-ins.   
    Additionally, when you select a TypeID in the data grid, you can see the DAML definition of the type ID. This will allow you to see the filterFlags used by that typeID.  
![UI](screenshots/ProFilters.png)  
  

<!-- End -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://esri.github.io/arcgis-pro-sdk/images/ArcGISPro.png"  alt="ArcGIS Pro SDK for Microsoft .NET Framework" height = "20" width = "20" align="top"  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[Home](https://github.com/Esri/arcgis-pro-sdk/wiki) | <a href="https://pro.arcgis.com/en/pro-app/latest/sdk/api-reference" target="_blank">API Reference</a> | [Requirements](https://github.com/Esri/arcgis-pro-sdk/wiki#requirements) | [Download](https://github.com/Esri/arcgis-pro-sdk/wiki#installing-arcgis-pro-sdk-for-net) | <a href="https://github.com/esri/arcgis-pro-sdk-community-samples" target="_blank">Samples</a>
