## CustomStyling

<!-- TODO: Write a brief abstract explaining this sample -->
 Show how to apply custom styles to a UserControl that work in both Light and Dark modes.  
   


<a href="https://pro.arcgis.com/en/pro-app/sdk/" target="_blank">View it live</a>

<!-- TODO: Fill this section below with metadata about this sample-->
```
Language:              C#
Subject:               Framework
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
 New at 1.4, ArcGIS Pro supports a Light theme, Dark theme, and a variant of the Dark theme for use with High Contrast. Developers who want their Add-ins to blend in with Pro must likewise style their Add-in UIs to provide a Light and Dark themeing. In most cases, developers need only apply 'ESRI' styles to their UserControl content (refer to the ProGuide at [ProGuide: Style Guide](https://github.com/esri/arcgis-pro-sdk/wiki/proguide-style-guide). However, there may be situations where you need to derive your own styles and have them switch between a custom Light and Dark mode to mirror the current theme being applied to Pro. This sample shows you how.    
 The sample contains a custom UserControl as well as a custom Light and Dark theme that is applied at runtime in conjunction with the Light or Dark theme applied to Pro.    
 Steps:    
  
1. In Visual Studio click the Build menu. Then select Build Solution.
 2. Click Start button to open ArcGIS Pro.  
 3. The style applied to the Dockpane custom UserControl should match the Light or Dark mode of Pro.  
![UI](Screenshots/Screen1.png)  
 4. Toggle the Pro theme (via backstage->Options->Application->General settings). Restart Pro.  
 5. Re-start the Debugger and Re-open the Dockpane in ArcGIS Pro.  
 6. The custom style should have changed (Light to Dark or vice versa) to match the corresponding change made to Pro.  
![UI](Screenshots/Screen2.png)  
 7. Please also refer to the companion ProGuide at [ProGuide: Applying Custom Styles](https://github.com/Esri/arcgis-pro-sdk/wiki/ProGuide-Applying-Custom-Styles) for more information.    
   

<!-- End -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://esri.github.io/arcgis-pro-sdk/images/ArcGISPro.png"  alt="ArcGIS Pro SDK for Microsoft .NET Framework" height = "20" width = "20" align="top"  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[Home](https://github.com/Esri/arcgis-pro-sdk/wiki) | <a href="https://pro.arcgis.com/en/pro-app/latest/sdk/api-reference" target="_blank">API Reference</a> | [Requirements](https://github.com/Esri/arcgis-pro-sdk/wiki#requirements) | [Download](https://github.com/Esri/arcgis-pro-sdk/wiki#installing-arcgis-pro-sdk-for-net) | <a href="https://github.com/esri/arcgis-pro-sdk-community-samples" target="_blank">Samples</a>
