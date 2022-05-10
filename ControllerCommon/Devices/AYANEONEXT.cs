﻿namespace ControllerCommon.Devices
{
    public class AYANEONEXT : Device
    {
        public AYANEONEXT() : base()
        {
            this.ProductSupported = true;

            // device specific settings
            this.WidthHeightRatio = 2.4f;
            this.ProductIllustration = "device_aya_next";
        }
    }
}
