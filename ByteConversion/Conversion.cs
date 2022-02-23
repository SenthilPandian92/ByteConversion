using System;
using System.Collections.Generic;
using System.Text;

namespace ByteConversion
{
    public static class Conversion
    {

       public static string MegabyteToBytes(long number)
        {
            var result = number * 1024 * 1024;
            return number.ToString() + " MB = " + result + " Byte"  ;
        }

        public static string GigabyteToMegaBytes(long number)
        {
            var result = number * 1024 ;
            return number.ToString() + " GB = " + result + " MB";
        }

        public static string TerabyteToGigaBytes(long number)
        {
            var result = number * 1024 ;
            return number.ToString() + " TB = " + result + " GB";
        }
    }


}
