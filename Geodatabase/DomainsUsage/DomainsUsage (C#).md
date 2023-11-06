## DomainsUsage

<!-- TODO: Write a brief abstract explaining this sample -->
This addin will list all domains in the workspace corresponding to the selected layer and on selecting a domain a query layer will be generated which lists the datasets which reference the selected domains  
  
NOTE: In order to list the domains, the owner of the GDB_ITEMS is used which is inferred using the owner of the default version  
      It is assumed that the default version will either be dbo.DEFAULT or sde.DEFAULT  
  


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
1. In Visual Studio click the Build menu. Then select Build Solution.
2. Click Start button to open ArcGIS Pro.  
3. ArcGIS Pro will open.   
4. Open a map view that contains at least one Feature Layer whose source points to a Feature Class from an Enterprise Geodatabase (SQL Server)  
5. Make sure the Map Pane and the corresponding Table of Contents (TOC) Pane are Open and the Map Pane is Active  
6. Click on the Add-In Tab  
7. Observe that the Domains Combo Box is disabled until a SQL Server FeatureClass backed Feature Layer is selected in the TOC  
8. On selecting a SQL Server FeatureClass backed layer, the combo box is enabled  
9. The combobox lists all domains and selecting a domain will generate a Query Layer with the name "RelatedDomains"+ the domain name selected  
10. The Query layer lists the datasets referencing the domain selected   
  

<!-- End -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://esri.github.io/arcgis-pro-sdk/images/ArcGISPro.png"  alt="ArcGIS Pro SDK for Microsoft .NET Framework" height = "20" width = "20" align="top"  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[Home](https://github.com/Esri/arcgis-pro-sdk/wiki) | <a href="https://pro.arcgis.com/en/pro-app/latest/sdk/api-reference" target="_blank">API Reference</a> | [Requirements](https://github.com/Esri/arcgis-pro-sdk/wiki#requirements) | [Download](https://github.com/Esri/arcgis-pro-sdk/wiki#installing-arcgis-pro-sdk-for-net) | <a href="https://github.com/esri/arcgis-pro-sdk-community-samples" target="_blank">Samples</a>
