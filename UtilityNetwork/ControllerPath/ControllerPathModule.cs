/*

   Copyright 2024 Esri

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
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;

namespace ControllerPath
{
  /// <summary>
  /// This add-in demonstrates how to use the Pro SDK for .Net to find the shortest path between a feature  and its subnetwork controller by leveraging the Utility Network Trace API. The add-in is designed to work with pressure zones and pressure systems.
  /// 
  /// The functionality includes:
  /// 1. Subnetwork controller trace
  /// 1. Connectivity trace
  /// 1. Shortest path trace
  /// 1. Discover multiple flow paths
  /// 1. Highlight features that are on the path a subnetwork controller
  /// 1. Fetch feature information (network and field attributes) during  trace
  /// 
  /// The sample uses the NapervilleWater.gdb, a file geodatabase available in the Community Sample data at C:\Data\UtilityNetwork (see under the "Resources" section for downloading sample data).
  /// 
  /// </summary>
  /// <remarks>
  ///  1. In Visual Studio click the Build menu.  Then select Build Solution.
  ///  2. Click Start button to open ArcGIS Pro.
  ///  3. ArcGIS Pro will open.
  ///  4. Open a map view referencing a utility network with the correct schema (Naperville Water).
  ///  
  ///  5. Select a feature that belongs in a pressure system (for example, a fire hydrant) as a starting element.
  ///  ![UI](Screenshots/Screenshot1.PNG)  
  ///  
  ///  6. Click on the **Find Path** button on the add-in.
  ///  ![UI](Screenshots/Screenshot2.PNG)
  ///  
  ///  7. You will see the number of subnetwork controllers including the shortest path between selected element and its controller.
  ///  ![UI](Screenshots/Screenshot4.PNG)
  ///  ![UI](Screenshots/Screenshot3.PNG)  
  /// </remarks>
  internal class ControllerPathModule : Module
  {
    private static ControllerPathModule _this = null;

    /// <summary>
    /// Retrieve the singleton instance to this module here
    /// </summary>
    public static ControllerPathModule Current => _this ??= (ControllerPathModule)FrameworkApplication.FindModule("ControllerPath_Module");

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
