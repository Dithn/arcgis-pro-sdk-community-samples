## VoxelSample

<!-- TODO: Write a brief abstract explaining this sample -->
Illustrates use of various aspects of the Voxel API.  
  


<a href="https://pro.arcgis.com/en/pro-app/sdk/" target="_blank">View it live</a>

<!-- TODO: Fill this section below with metadata about this sample-->
```
Language:              C#
Subject:               VoxelLayers
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
1. This sample specificially requires the sample data in CommunitySampleData-VoxelLayer-mm-dd-yyyy.zip (see Sample data link above).
2. Make sure you unzip to c:\data and have C:\Data\VoxelData available before you run this sample.  
3. Build the sample and start a debug session.  
4. In ArcGIS Pro open a new 'Local Scene' and change the Map's projection to 'WGS 1984' Geographic Coordinate system.  WKID is: 4326.    
5. Note: if the projection of the local scene doesn't match the projection used in the Voxel data, the data cannot be displayed on the scene.  
![UI](Screenshots/Screen1.png)  
6. Then use the 'CreateLayer' button to create a sample voxel layer.  
7. The voxel layer should look like this:  
![UI](Screenshots/Screenshot1.png)  
The sample primarily focuses on:   
- Layer creation   
- Isosurfaces    
- Slices    
- Sections    
- Locked Sections    
- Voxel Coordinate Spaces  
For additional examples refer to <a href="https://github.com/Esri/arcgis-pro-sdk/wiki/ProSnippets-VoxelLayers">Voxel Snippets</a>  
For concepts refer to the <a href="https://github.com/Esri/arcgis-pro-sdk/wiki/ProConcepts-Voxel-Layers">Voxel Pro Guide</a>.  
  

<!-- End -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://esri.github.io/arcgis-pro-sdk/images/ArcGISPro.png"  alt="ArcGIS Pro SDK for Microsoft .NET Framework" height = "20" width = "20" align="top"  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[Home](https://github.com/Esri/arcgis-pro-sdk/wiki) | <a href="https://pro.arcgis.com/en/pro-app/latest/sdk/api-reference" target="_blank">API Reference</a> | [Requirements](https://github.com/Esri/arcgis-pro-sdk/wiki#requirements) | [Download](https://github.com/Esri/arcgis-pro-sdk/wiki#installing-arcgis-pro-sdk-for-net) | <a href="https://github.com/esri/arcgis-pro-sdk-community-samples" target="_blank">Samples</a>
