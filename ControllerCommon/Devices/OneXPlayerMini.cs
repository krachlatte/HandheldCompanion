﻿using System.Numerics;

namespace ControllerCommon.Devices
{
    public class OneXPlayerMini : Device
    {
        public OneXPlayerMini() : base()
        {
            this.ProductSupported = true;

            // device specific settings
            this.WidthHeightRatio = 2.4f;
            this.ProductIllustration = "device_onexplayer_mini";

            this.AngularVelocityAxis = new Vector3(1.0f, 1.0f, 1.0f);
            this.AccelerationAxis = new Vector3(-1.0f, -1.0f, 1.0f);
        }
    }
}
