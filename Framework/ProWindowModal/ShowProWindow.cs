/*

   Copyright 2023 Esri

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
using ArcGIS.Desktop.Layouts;
using ArcGIS.Desktop.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProWindowModal
{
  internal class ShowProWindow : Button
  {

    private ProWindow _prowindow = null;

protected override void OnClick()
{
  //already open?
  if (_prowindow != null)
    return;

  // set a fixed offset for the Window on the top/left

  double left = 250; //Window's left edge, in relation to the desktop
  double top = 150; //Window's top edge, in relation to the desktop

  _prowindow = new ProWindow();
  _prowindow.WindowStartupLocation = System.Windows.WindowStartupLocation.Manual; 
  _prowindow.Left = left;
  _prowindow.Top = top;
  _prowindow.SaveWindowPosition = false;
  _prowindow.Owner = FrameworkApplication.Current.MainWindow;
  _prowindow.Closed += (o, e) => { _prowindow = null; };
  //_prowindow.Show();
  //uncomment for modal
  _prowindow.ShowDialog();
}

  }
}
