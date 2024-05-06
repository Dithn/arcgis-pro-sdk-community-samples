## ProWindowMVVM

<!-- TODO: Write a brief abstract explaining this sample -->
the ProWindowMVVM sample demonstrates how to implement a ProWindow using the Model-View-ViewModel pattern (MVVM).    
  


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
2. Click Start button to debug ArcGIS Pro.  
3. In ArcGIS Pro open any project.  
4. Open the Add-in Tab and click on the 'Test ProWindow Dialog' button.  
5. The Modal ProWindowDialog opens.  See TestProWindowDialog:OnClick on how the ProWindowDialog is instantiated and initialized.    
6. Find 'TODO: set data context' in the source code, this is where the ProWindowDialog datacontext property is set to ProWindowDialogVM. If you add a new ProWindow via the Pro SDK item templates you have to add this code snippet yourself.    
![UI](Screenshots/Screenshot1.png)    
7. Enter some input data.  
![UI](Screenshots/Screenshot2.png)    
8. In MVVM you need to control the window closing from the ViewModel class.  This is accomplished by the addition of 'CommandParameter="{Binding ElementName=ProWindowDialogWin}"' to each button that closes the ProWindow.    
9. In the code behind you can then use the command parameter to control the DialogResult and Close () of the ProWindow with the following snippets: (proWindow as ProWindow).DialogResult = true; and (proWindow as ProWindow).Close();  
10. Click either 'Ok' or 'Cancel' you get the appropriate DialogResult returned by the ShowDialog method:  
![UI](Screenshots/Screenshot3.png)    
11. Finally you can use the dialog's data changes which have been stored in the Module class.  
![UI](Screenshots/Screenshot4.png)      
  

<!-- End -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://esri.github.io/arcgis-pro-sdk/images/ArcGISPro.png"  alt="ArcGIS Pro SDK for Microsoft .NET Framework" height = "20" width = "20" align="top"  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[Home](https://github.com/Esri/arcgis-pro-sdk/wiki) | <a href="https://pro.arcgis.com/en/pro-app/latest/sdk/api-reference" target="_blank">API Reference</a> | [Requirements](https://github.com/Esri/arcgis-pro-sdk/wiki#requirements) | [Download](https://github.com/Esri/arcgis-pro-sdk/wiki#installing-arcgis-pro-sdk-for-net) | <a href="https://github.com/esri/arcgis-pro-sdk-community-samples" target="_blank">Samples</a>
