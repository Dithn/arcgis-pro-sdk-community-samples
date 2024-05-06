## ReplaceAttachments

<!-- TODO: Write a brief abstract explaining this sample -->
This is a sample to update attachments with a given name with new attachment data, in all Tables/FeatureClasses  related to the Table/FeatureClass associated with the layer selected  
  


<a href="https://pro.arcgis.com/en/pro-app/sdk/" target="_blank">View it live</a>

<!-- TODO: Fill this section below with metadata about this sample-->
```
Language:              C#
Subject:               Geodatabase
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
      
  
1. Download the Community Sample data (see under the 'Resources' section for downloading sample data).  The sample data contains a folder called 'C:\Data\Working with Core Geometry and Data' with sample data required for this solution.  Make sure that the Sample data is unzipped in c:\data and "C:\Data\Working with Core Geometry and Data" is available.
2. In Visual Studio click the Build menu. Then select Build Solution.  
3. Click Start button to debug ArcGIS Pro.  
4. In ArcGIS Pro open the Project called "Workshop.aprx" in the "C:\Data\Working with Core Geometry and Data" folder.  This project and data is required because it contains data that is attachment enabled.  
5. Use the ArcGIS Pro "Explore" button and identify the polygon overlaying part of Wyoming.   
![UI](Screenshots/Screen1.png)  
6. Note the attachment called 'redlands.png' which is displayed below the tabular data in the identify layer popup.  
7. Click the 'Show Replace Attachments Addin' button to show the "Replace Attachments" dockpane.  
![UI](Screenshots/Screen2.png)  
8. Use the pull-downs on the "Replace Attachments" dockpane to make selections as shown on the screen below.  
![UI](Screenshots/Screen3.png)  
9. Click on the "File Selection" Button on the right of "Path of the New Attachment File" and select the image file "c:\data\Redlands.png"  
![UI](Screenshots/Screen4.png)  
10. Click the "Go" button to replace all attachments of the given name with the new attachment data.  
11. Use the ArcGIS Pro "Explore" button and identify the polygon   
12. Note the changed attachment  
![UI](Screenshots/Screen5.png)  
  

<!-- End -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://esri.github.io/arcgis-pro-sdk/images/ArcGISPro.png"  alt="ArcGIS Pro SDK for Microsoft .NET Framework" height = "20" width = "20" align="top"  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[Home](https://github.com/Esri/arcgis-pro-sdk/wiki) | <a href="https://pro.arcgis.com/en/pro-app/latest/sdk/api-reference" target="_blank">API Reference</a> | [Requirements](https://github.com/Esri/arcgis-pro-sdk/wiki#requirements) | [Download](https://github.com/Esri/arcgis-pro-sdk/wiki#installing-arcgis-pro-sdk-for-net) | <a href="https://github.com/esri/arcgis-pro-sdk-community-samples" target="_blank">Samples</a>
