## AdvancedUIDemo

<!-- TODO: Write a brief abstract explaining this sample -->
This sample shows how to:    
* Handle project item collection changes  
* Add and delete a bookmark  
* Leverage existing ArcGIS Pro commands  
* Add styling to buttons to follow ArcGIS Pro styling guidelines  
  


<a href="https://pro.arcgis.com/en/pro-app/sdk/" target="_blank">View it live</a>

<!-- TODO: Fill this section below with metadata about this sample-->
```
Language:              C#
Subject:               Framework
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
1. In Visual Studio click the Build menu. Then select Build Solution.
2. Click Start button to open ArcGIS Pro.  
3. ArcGIS Pro will open.   
4. Open a project with a map that has bookmarks and click on the 'Add-in' tab.  
5. Click the 'Show bookmarks' button to show the bookmark dockpane  
6. On the 'bookmark dockpane' click the 'Get Maps' button to fill the 'Available Maps' dropdown.  
7. Select a map on the 'Available Maps' dropdown.  
8. Click on any of the 'Bookmark' thumbnails to zoom to a given bookmark.  
9. Click the 'New Bookmark' button.  
![UI](Screenshots/Screen.png)  
### UI Controls  
**Burger button:**  
10. Click on the burger button conrol on the top right corner of the dockpane to display the menu options.  
**Search text box:**  
11. Notice the Search box control located above the list of bookmarks in the dockpane.  
12. Type the name of one of your bookmarks. Click the arrow next to it and notice the bookmark gets selected in the gallery of bookmarks and the map view zooms to that bookmark.  
![UI](Screenshots/search-Text.png)     
 **Circular Animation:**  
 13. In the Project pane, right click the "Maps" folder and select "'New Map" from the context menu.  
 2. Notice the circular animation control dispayed on the bookmark dockpane while the new map is being opened.  
 ![UI](Screenshots/circular-animation.png)  
 **Message label:**  
 14. In the drop down control that lists the colelction of maps in the project, select the new map you created in the step above.  
 2. Since this new map has no bookmarks associated with it yet, notice how the bookmark list view is now replaced with a Message label control.  
 ![UI](Screenshots/message-label.png)  
  

<!-- End -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://esri.github.io/arcgis-pro-sdk/images/ArcGISPro.png"  alt="ArcGIS Pro SDK for Microsoft .NET Framework" height = "20" width = "20" align="top"  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[Home](https://github.com/Esri/arcgis-pro-sdk/wiki) | <a href="https://pro.arcgis.com/en/pro-app/latest/sdk/api-reference" target="_blank">API Reference</a> | [Requirements](https://github.com/Esri/arcgis-pro-sdk/wiki#requirements) | [Download](https://github.com/Esri/arcgis-pro-sdk/wiki#installing-arcgis-pro-sdk-for-net) | <a href="https://github.com/esri/arcgis-pro-sdk-community-samples" target="_blank">Samples</a>
