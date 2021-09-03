using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukulele_Fantasy.AudioEngine
{
    public static class AudiableNotes
    {
        public static Dictionary<string, float> NoteFrequency = new Dictionary<string, float>
        {
            { "G", 392f },
            { "C", 262f },
            { "E", 330f },
            { "A", 440f },

            { "F", 350f},
            { "D", 294f},
            { "B", 495f},

            { "G#", 416f},
            { "C#", 280f},
            { "F#", 370f},


            { "Bb", 464f},
            { "Eb", 310f}
        };
    }
}
