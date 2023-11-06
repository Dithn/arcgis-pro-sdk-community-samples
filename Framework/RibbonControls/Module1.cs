// Copyright 2019 Esri 
//
// 
//   Licensed under the Apache License, Version 2.0 (the "License"); 
//   you may not use this file except in compliance with the License. 
//   You may obtain a copy of the License at 
//
//       https://www.apache.org/licenses/LICENSE-2.0 
//
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
using ArcGIS.Core.Events;
using ArcGIS.Core.Data;
using ArcGIS.Core.Internal.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.CodeDom.Compiler;

namespace RibbonControls
{
  /// <summary>
  /// This sample illustrates every type of ribbon control currently available in ArcGIS Pro.  Ribbon controls are declared in DAML with code classes containing the control implementation.
  /// </summary>
  /// <remarks>
  /// 1. Download the Community Sample data (see under the 'Resources' section for downloading sample data).  Make sure that the Sample data is unzipped in c:\data.
  /// 1. Open this solution in Visual Studio.  
  /// 1. Click the build menu and select Build Solution.
  /// 1. Click the Start button to open ArCGIS Pro.  ArcGIS Pro will open.
  /// 1. Open the project "FeatureTest.aprx" in the "C:\Data\FeatureTest" folder.
  /// 1. Click on the "Sample Tab" tab.
  /// 1. View the various ribbon controls.   Don't forget the keytips when defining DAML items. 
  /// ![UI](Screenshots/RibbonControls.png)
  /// ![UI](Screenshots/RibbonControls_KeyTips.png) 
  /// 1. Group 1 contains a toolbar (which consists of a LabelControl, CombobBox and Button), CheckBox and EditBox.
  /// 1. Group 2 contains a Button, MapTool, ToolPalette, ButtonPalette and SplitButton with an additional launcher button.
  /// 1. Group 3 contains a toolbar (which consits of a CustomControl and Spinner), LabelControl and Menu.
  /// 1. Group 4 contains an inline Gallery and a Gallery button. 
  /// Note: this is how you can make use of the KeyTips you defined in your config.daml:
  /// To use KeyTips you must first press the Alt key or the F10 key, this shows the available KeyTip letters for the tabs on the Pro ribbon:
  /// ![UI](Screenshots/Screen1.png)
  /// Next you press any of displayed KeyTips letters (white and framed in black).  So for example to get to the �Sample Tab� I simply press the �X� key.  Now the UI is updated to show the �Sample Tab�s� Key Tips:
  /// ![UI](Screenshots/Screen2.png)
  /// Finally I can choose a KeyTip from the selected �Sample Tab� tab.  For example if I want to execute the �Button 2� command on the �Sample Tab�, I simply press the �X� key followed by the �E� key.  The command is executed and I get this:
  /// ![UI](Screenshots/Screen3.png)
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
        return _this ?? (_this = (Module1)FrameworkApplication.FindModule("RibbonControls_Module"));
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

  internal sealed class ValueChangedEventArgs : EventArgs
  {
    internal double? _value;
    internal ValueChangedEventArgs(double? value)
    {
      _value = value;
    }
  }

  internal class SliderChangedEvent : CompositePresentationEvent<ValueChangedEventArgs>
  {
    public static SubscriptionToken Subscribe(Action<ValueChangedEventArgs> action, bool keepSubscriberAlive = false)
    {
      return FrameworkApplication.EventAggregator.GetEvent<SliderChangedEvent>().Register(action, keepSubscriberAlive);
    }

    public static void Unsubscribe(Action<ValueChangedEventArgs> action)
    {
      FrameworkApplication.EventAggregator.GetEvent<SliderChangedEvent>().Unregister(action);
    }

    public static void Unsubscribe(SubscriptionToken token)
    {
      FrameworkApplication.EventAggregator.GetEvent<SliderChangedEvent>().Unregister(token);
    }

    internal static void Publish(ValueChangedEventArgs eventArgs)
    {
      FrameworkApplication.EventAggregator.GetEvent<SliderChangedEvent>().Broadcast(eventArgs);
    }
  }

  internal class SpinnerChangedEvent : CompositePresentationEvent<ValueChangedEventArgs>
  {
    public static SubscriptionToken Subscribe(Action<ValueChangedEventArgs> action, bool keepSubscriberAlive = false)
    {
      return FrameworkApplication.EventAggregator.GetEvent<SpinnerChangedEvent>().Register(action, keepSubscriberAlive);
    }

    public static void Unsubscribe(Action<ValueChangedEventArgs> action)
    {
      FrameworkApplication.EventAggregator.GetEvent<SpinnerChangedEvent>().Unregister(action);
    }

    public static void Unsubscribe(SubscriptionToken token)
    {
      FrameworkApplication.EventAggregator.GetEvent<SpinnerChangedEvent>().Unregister(token);
    }

    internal static void Publish(ValueChangedEventArgs eventArgs)
    {
      FrameworkApplication.EventAggregator.GetEvent<SpinnerChangedEvent>().Broadcast(eventArgs);
    }
  }
}
