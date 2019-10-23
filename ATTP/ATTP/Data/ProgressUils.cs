using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ATTP.Data
{
    class ProgressUils
    {
        private const float refHeight = 1080;//1677;
        private const float refWidth = 632;//940;

        private float deviceHeight = 1; // Initializing to 1
        private float deviceWidth = 1;  // Initializing to 1

        public ProgressUils() { }

        public void setDevice(int deviceHeight, int deviceWidth)
        {
            this.deviceHeight = deviceHeight;
            this.deviceWidth = deviceWidth;
        }

        public float getFactoredValue(int value)
        {

            float refRatio = refHeight / refWidth;
            float devRatio = deviceHeight / deviceWidth;

            float factoredValue = value * (refRatio / devRatio);

            Debug.WriteLine("RR:" + refRatio + "  DR: " + devRatio + " DIV:" + (refRatio / devRatio));
            Debug.WriteLine("Calculated Value for " + value + "  : " + factoredValue);

            return factoredValue;


        }

        // Deriving Proportinate Height
        public float getFactoredHeight(int value)
        {
            return (float)((value / refHeight) * deviceHeight);
        }

        // Deriving Proportinate Width
        public float getFactoredWidth(int value)
        {
            return (float)((value / refWidth) * deviceWidth);
        }

        // Deriving Sweep Angle
        public int getSweepAngle(int goal, int achieved)
        {
            int SweepAngle = 260;
            float factor = (float)achieved / goal;
            Debug.WriteLine("SWEEP ANGLE : " + (int)(SweepAngle * factor));

            return (int)(SweepAngle * factor);

        }














    }
}
