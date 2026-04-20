using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Cache
    {
        public static bool tentExist = false;

        public static int windSpeed;
        public static string windDirect;
        public static bool n_canopy = false;
        public static bool e_canopy = false;
        public static bool s_canopy = false;
        public static bool w_canopy = false;
        public static Random Rnd = new Random();
        public static string food_category;
        public static int food_prepTime;
    }
}
