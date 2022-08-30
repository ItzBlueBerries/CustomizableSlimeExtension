using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CustomizableSlime
{
    internal class Checks
    {
        public static void AssetsCheck()
        {
            if (Directory.Exists("CustomizableSlime"))
            {
                if (!File.Exists("CustomizableSlime/Images/slime_icon_2.png") && !File.Exists("CustomizableSlime/Images/plort_icon_2.png") && !File.Exists("CustomizableSlime/Images/exotic_slime_icon_2.png"))
                {
                    File.Create("CustomizableSlime/Images/slime_icon_2.png");
                    File.Create("CustomizableSlime/Images/plort_icon_2.png");
                    File.Create("CustomizableSlime/Images/exotic_slime_icon_2.png");
                    throw new IOException("\nCustomizable Slime EX Files does not exist! Don't worry, it has been created for you during this error message.");
                }
            }
        }
    }
}