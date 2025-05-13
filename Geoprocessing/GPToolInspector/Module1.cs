/*

   Copyright 2025 Esri

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
using ArcGIS.Desktop.KnowledgeGraph;
using ArcGIS.Desktop.Layouts;
using ArcGIS.Desktop.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GPToolInspector
{
	/// <summary>
	/// GPToolInspector is an Add-in that reads the ArcGIS Pro toolboxes folder and displays all discovered toolboxes and tools in a tree view.  The tree view can be used to 'drill down' to find any tool by category, or the tree view can be searched by tool description for locating a specific tool.  Clicking on a tool node displays a popup dialog showing the tool usage in form of a code snippet that is ready to be applied within your add-in or managed configuration code.
	/// </summary>
	/// <remarks>
	/// 1. Download this repo onto your local machine and open the GPToolInspector solution using Visual Studio 2022.
	/// 1. In Visual Studio click the Build menu. Then select Build Solution.
	/// 1. Click Start button to open ArcGIS Pro.
	/// 1. ArcGIS Pro will open. 
	/// 1. Open any project and then open the "GP Tools" tab on the ArcGIS Pro ribbon.  The "Show GP Tool Inspector" button can be used to open the "Inspect GP Tools" dockpane.
	/// ![UI](Screenshots/Screen1.png)
	/// 1. The "Inspect GP Tools" dockpane will open.  The "System Toolboxes" tree view in the dockpane displays all the toolboxes and tools found in the ArcGIS Pro toolboxes folder.  The tree view can be used to 'drill down' to find any tool by category.
	/// 1. Once a 'Tool' node is located , clicking on the node will display a popup dialog showing the tool usage in form of a code snippet that is ready to be applied within your add-in or managed configuration code.
	/// ![UI](Screenshots/Screen2.png)
	/// 1. Use the search text box above the tree view to search by tool description.  Enter a tool descriptin like for example: "Create Feature".
	/// ![UI](Screenshots/Screen3.png)
	/// 1. The search results will be displayed in form of a listview.  Click on a 'Tool' node to display the tool usage in form of a code snippet.
	/// ![UI](Screenshots/Screen4.png)
	/// </remarks>
	internal class Module1 : Module
  {
    private static Module1 _this = null;

    /// <summary>
    /// Retrieve the singleton instance to this module here
    /// </summary>
    public static Module1 Current => _this ??= (Module1)FrameworkApplication.FindModule("GPToolInspector_Module");

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
