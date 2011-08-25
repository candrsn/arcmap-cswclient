﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;

namespace ArcMapAddin1
{
    public class ButtonCSW : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public ButtonCSW()
        {
        }

        protected override void OnClick()
        {
            //
            //  TODO: Sample code showing how to access button host
            //
            FormCSW fCSW = new FormCSW();
            fCSW.Show();

            ArcMap.Application.CurrentTool = null;
        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
