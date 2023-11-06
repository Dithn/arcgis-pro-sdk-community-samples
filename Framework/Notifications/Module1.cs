//   Copyright 2019 Esri

//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at

//       https://www.apache.org/licenses/LICENSE-2.0

//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using System.Threading.Tasks;

namespace Notifications
{
  /// <summary>
  /// This sample illustrates notifications in the application.  There are two main categories of notifications - toast notifications
  /// which are transient message to the user that contains relevant, time-sensitive information and provides quick access to related 
  /// content in an application; these appear in the top right hand corner of the display and last for a few seconds. The second category 
  /// of notification are more permanent and are displayed in the notification dock pane.  These type of notifications can be further 
  /// classified into application and project notifications. 
  /// </summary>
  /// <remarks>
  /// 1. In Visual studio click the Build menu. Then select Build Solution.
  /// 1. Click Start button to open ArcGIS Pro.
  /// 1. ArcGIS Pro will open, open any project or create a new project.
  /// 1. Activate the Add-In tab. 
  /// ![UI](Screenshots/Screen1.png)
  /// 1. Click the 'Toast Notification' button and see a toast notification appear in the upper right of the application.
  /// ![UI](Screenshots/Screen2.png)
  /// 1. Click the 'Notification with Feedback' button and see a toast notification appear in the upper right of the application.  Click on that toast notification and a messagebox saying 'This message was just removed' will appear. 
  /// ![UI](Screenshots/Screen3.png)
  /// 1. Click the 'Add Set of Notifications' button and see a number of notifications added to the notification dock pane.  This button will also open the notification dock pane if it's now already open.
  /// ![UI](Screenshots/Screen4.png)
  /// 1. Click the 'Remove Notifications' button and see two of those notifications be removed from the notification dock pane.
  /// ![UI](Screenshots/Screen5.png)
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
        return _this ?? (_this = (Module1)FrameworkApplication.FindModule("Notifications_Module"));
      }
    }

    internal static void ShowNotificationDockpane()
    {
      IPlugInWrapper wrapper = FrameworkApplication.GetPlugInWrapper("esri_core_notificationButton");
      var command = wrapper as ICommand;

      if ((command != null) && command.CanExecute(null))
        command.Execute(null);
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
