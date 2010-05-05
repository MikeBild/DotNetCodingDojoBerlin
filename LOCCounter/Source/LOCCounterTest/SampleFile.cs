using System;
using System.Diagnostics;

namespace LOCExample
{

    /* Comment */
    public class LOCExample //Comment
    {
        /*
         * Debug log
         */
        public void LOG()
        {
            //Comment
            for (var i = 0; i < 10; i++)
            {
                /*
                Debug.WriteLine("Example");
                Debug.WriteLine("Example");*/
            }


            /*Trace.WriteLine("Eample"); //Comment
             */
            Debug.WriteLine("Example //no comment /* no comment */");
            Debug.WriteLine("//*/");
            Debug.WriteLine("*/*");

            /*Trace.WriteLine("Example");*/
        }
    }
}
