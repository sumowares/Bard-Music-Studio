using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukulele_Fantasy.Models
{
    public class Gvars
    {
        public System.Windows.Forms.Keys LastKeyPlayed;

        public int Threshold { get; set; } = 18;

        public int CurrentVolume;

        public bool MetronomeShowing = false;

        public IntPtr MainWindowHandle { get; set; }

        public bool HoldingNote { get; set; }

        public DateTime LastNotePlayedTime { get; set; }

        public DateTime PlayNextNoteTime { get; set; } = DateTime.Now.AddMilliseconds(250);

        public int DelayBetweenNotes { get; set; } = 150;

        public int NoiseGate { get; set; } = 850;

        public string MusicFolderPath { get; set; } = "./";

        public float SystemVolume { get; set; } = 100;

        public float LastVolumePlayed { get; set; }
    }
}
