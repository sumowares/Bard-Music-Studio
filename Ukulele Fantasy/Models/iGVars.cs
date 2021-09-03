using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukulele_Fantasy.Models
{
    public static class iGVars
    {
        public static EntryPoint EntryPoint { get; set; }

        public static string CurrentFIle { get; set; }

        public static string LastNotePlayed { get; set; }

        public static float LastVolumePlayed { get; set; }

    }
}
