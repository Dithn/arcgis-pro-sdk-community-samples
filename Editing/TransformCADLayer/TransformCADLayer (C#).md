## TransformCADLayer

<!-- TODO: Write a brief abstract explaining this sample -->
This sample can be used to transform a CAD layer by entering a scale factor, rotation, local coordinates and corresponding grid coordinates. The parameters are entered and a world file is created. The CAD layer's map location is updated based on the new world file transformation parameters corresponding with the entered values.   
  


<a href="https://pro.arcgis.com/en/pro-app/sdk/" target="_blank">View it live</a>

<!-- TODO: Fill this section below with metadata about this sample-->
```
Language:              C#
Subject:               Editing
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
1. Build or debug the sample through Visual Studio.
2. In Pro, select the CAD layer in the table of contents.    
3. The contextual ribbon for the CAD layer becomes available to access the add-in button for Transform from the Alignment group.  
![UI](Screenshots/Screen1.png)  
4. Click the button and enter the parameters for local coordinates, grid coordinates, scale and rotation values.  
![UI](Screenshots/Screen2.png)  
5. Check the box "Update ground to grid corrections" to apply the scale and rotation values to the map's ground to grid correction settings.  
![UI](Screenshots/Screen3.png)  
6. Click the Reset button to set all the transformation parameters back to starting values.  
7. Click the OK button to transform the CAD layer based on the entered transformation parameters.  
  

<!-- End -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://esri.github.io/arcgis-pro-sdk/images/ArcGISPro.png"  alt="ArcGIS Pro SDK for Microsoft .NET Framework" height = "20" width = "20" align="top"  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[Home](https://github.com/Esri/arcgis-pro-sdk/wiki) | <a href="https://pro.arcgis.com/en/pro-app/latest/sdk/api-reference" target="_blank">API Reference</a> | [Requirements](https://github.com/Esri/arcgis-pro-sdk/wiki#requirements) | [Download](https://github.com/Esri/arcgis-pro-sdk/wiki#installing-arcgis-pro-sdk-for-net) | <a href="https://github.com/esri/arcgis-pro-sdk-community-samples" target="_blank">Samples</a>
