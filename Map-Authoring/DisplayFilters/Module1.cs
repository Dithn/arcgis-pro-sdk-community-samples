/*

   Copyright 2020 Esri

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       https://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

   See the License for the specific language governing permissions and
   limitations under the License.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using ArcGIS.Core.CIM;
using ArcGIS.Core.Data;
using ArcGIS.Core.Geometry;
using ArcGIS.Desktop.Catalog;
using ArcGIS.Desktop.Core;
using ArcGIS.Desktop.Editing;
using ArcGIS.Desktop.Extensions;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Framework.Dialogs;
using ArcGIS.Desktop.Framework.Threading.Tasks;
using ArcGIS.Desktop.Mapping;

namespace DisplayFilters
{
    /// <summary>
    /// This sample demonstrates how to add Display Filters to Feature Layers.
    /// </summary>
    /// <remarks>
    /// 1. Download the Community Sample data (see under the 'Resources' section for downloading sample data).  The sample data contains a folder called 'C:\Data\DisplayFilters' with sample data required for this solution.  Make sure that the Sample data is unzipped in c:\data and "C:\Data\DisplayFilters" is available.
    /// 1. In Visual Studio click the Build menu. Then select Build Solution.  
    /// 1. Launch the debugger to open ArcGIS Pro.
    /// 1. Create a new blank Map project. 
    /// 1. Add the C:\Data\DisplayFilters\Hydrology.lpkx layer file to the map. This is a sample dataset of the Hydrology in the US available with the [ArcGIS Pro SDK Community Data](https://github.com/Esri/arcgis-pro-sdk-community-samples#samples-data).
    ///      ![UI](screenshots/Hydrology.PNG)
    /// 1. Click the Add-In tab.  There should be two buttons created by this sample on this tab in the "Display Filters" group: Apply Display Filters 1 amd Apply Display Filters 2.
    ///      ![UI](screenshots/buttons.PNG)
    /// 1. These buttons create and apply display filters to view the dense Hydrology dataset. 
    /// 1. The "Apply Display Filters 1" button uses the CIMDefinition of the Hydrology layer using the GetDefinition\SetDefinition method pair. 
    /// 1. The "Apply Display Filters 2" button uses the LayerDocument class to retrieve and work with the CIMDefinition.
    ///      ![UI](screenshots/DisplayFilter.PNG)
    /// </remarks>
    internal class Module1 : Module
  {
    private static Module1 _this = null;

    /// <summary>
    /// Retrieve the singleton instance to this module here
    /// </summary>
    public static Module1 Current
    {
      get
      {
        return _this ?? (_this = (Module1)FrameworkApplication.FindModule("DisplayFilters_Module"));
      }
    }

    #region Overrides
    /// <summary>
    /// Called by Framework when ArcGIS Pro is closing
    /// </summary>
    /// <returns>False to prevent Pro from closing, otherwise True</returns>
    protected override bool CanUnload()
    {
      //TODO - add your business logic
      //return false to ~cancel~ Application close
      return true;
    }

    #endregion Overrides

  }
}
