using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Value_Types
    {
       
        public void ValueTypes()
        {
            char character = '2';

            bool isLightOn = true;
            bool hasLegs = false;

            //Numbers

            byte byteMin = 0;
            byte byteMax = 255;

            short shortMin = -32768;
            short shortMax = 32767;

            int intMin = -24789798;
            int intMax = 23987898;

            long longerNumber = 48789787980;

            float floatnumber = 2.345f;

            double doubleExample = 3.434534534543d;

            decimal decimalExample = 3.8977897987897m;

            int? nullValue = null;

            DateTime today = DateTime.Now;
            DateTime someDay = new DateTime(1978, 1, 1);
        }

        public void Declaration()
        {
            int thisIsANumber;
            bool itIsCold;
            double doubleexample;
            string firstName;
            DateTime someDay;


        }

        public

    }
}
