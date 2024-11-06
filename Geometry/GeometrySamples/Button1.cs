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
using System.Threading.Tasks;
using System.Windows;
using ArcGIS.Core.CIM;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Mapping;
using ArcGIS.Desktop.Framework.Threading.Tasks;
using ArcGIS.Core.Data;
using ArcGIS.Core.Geometry;
using ArcGIS.Desktop.Editing;

namespace GeometrySamples
{
  internal class Button1 : Button
  {
    protected override void OnClick()
    {
      var polyLayer = MapView.Active.Map.GetLayersAsFlattenedList().OfType<FeatureLayer>().FirstOrDefault(f => f.ShapeType == esriGeometryType.esriGeometryPolygon);
      if (polyLayer == null)
      {
        MessageBox.Show($@"To run this sample you need to have a polygon feature class layer.");
        return;
      }
      QueuedTask.Run(() =>
      {
				using var fc = polyLayer.GetTable() as FeatureClass;
				if (fc == null) return;

				var fcDefinition = fc.GetDefinition();

				var editOperation = new EditOperation
				{
					Name = "Create outer ring"
				};

				using (var cursor = fc.Search())
				{
					while (cursor.MoveNext())
					{
						using var feature = cursor.Current as Feature;
						if (feature == null) continue;

						var outerRings = Module1.Current.GetOutermostRings(feature.GetShape() as Polygon);
						if (outerRings != null)
							editOperation.Create(polyLayer, outerRings);
					}
				}
				editOperation.Execute();
			});
    }
  }
}