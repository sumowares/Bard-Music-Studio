using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukulele_Fantasy.Models
{
    public static class Keycodes
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        private const uint WM_KEYDOWN = 0x0100;
        private const uint WM_KEYUP = 0x0101;

        public static Dictionary<string, Keys> Keys = new Dictionary<string, Keys>()
        {
            // First Position
            {"G0", System.Windows.Forms.Keys.G},
            {"C0", System.Windows.Forms.Keys.A},
            {"E0", System.Windows.Forms.Keys.D},
            {"A0", System.Windows.Forms.Keys.H},

            {"F0", System.Windows.Forms.Keys.F},
            {"D0", System.Windows.Forms.Keys.S},
            {"B0", System.Windows.Forms.Keys.J},

            {"G#0", System.Windows.Forms.Keys.D9},
            {"C#0", System.Windows.Forms.Keys.D6},
            {"F#0", System.Windows.Forms.Keys.D8},

            {"Bb0", System.Windows.Forms.Keys.D0},
            {"Eb0", System.Windows.Forms.Keys.NumPad7},

            // Second Position
            {"G1", System.Windows.Forms.Keys.T},
            {"C1", System.Windows.Forms.Keys.Q},
            {"E1", System.Windows.Forms.Keys.E},
            {"A1", System.Windows.Forms.Keys.Y},

            {"F1", System.Windows.Forms.Keys.R},
            {"D1", System.Windows.Forms.Keys.W},
            {"B1", System.Windows.Forms.Keys.U},

            {"G#1", System.Windows.Forms.Keys.D4},
            {"C#1", System.Windows.Forms.Keys.D1},
            {"F#1", System.Windows.Forms.Keys.D3},

            {"Bb1", System.Windows.Forms.Keys.D5},
            {"Eb1", System.Windows.Forms.Keys.D2},
        };

        public static void SendKey(System.Windows.Forms.Keys keycode, string note)
        {
            if (iGVars.EntryPoint.GVars.CurrentVolume > iGVars.EntryPoint.GVars.Threshold)
            {
                if (DateTime.Now > iGVars.EntryPoint.GVars.PlayNextNoteTime)
                {
                    iGVars.EntryPoint.GVars.PlayNextNoteTime = DateTime.Now.AddMilliseconds(iGVars.EntryPoint.GVars.DelayBetweenNotes);
                    iGVars.EntryPoint.GVars.LastKeyPlayed = keycode;
                    iGVars.EntryPoint.UpdateExternalLog(note + " has been detected, attempting to send key [" + keycode.ToString() + "] to FFXIV.");

                    PostMessage(iGVars.EntryPoint.GVars.MainWindowHandle, WM_KEYDOWN, ((int)keycode), 0);
                    ReleaseKey();
                    iGVars.EntryPoint.GVars.HoldingNote = true;
                }
                else
                {
                    iGVars.EntryPoint.UpdateExternalLog("Skipping note too early.");
                }
            }
            else
            {
                iGVars.EntryPoint.UpdateExternalLog("Skipping note too quite.");
            }
        }

        public static void ReleaseKey()
        {
            PostMessage(iGVars.EntryPoint.GVars.MainWindowHandle, WM_KEYUP, ((int)iGVars.EntryPoint.GVars.LastKeyPlayed), 0);
        }

        public static void SendKeyboardInput(string note)
        {
            // First Position
            if (note == "G0")
            {
                SendKey(Keycodes.Keys["G0"], note);
            }

            if (note == "C0")
            {
                SendKey(Keycodes.Keys["C0"], note);
            }

            if (note == "E0")
            {
                SendKey(Keycodes.Keys["E0"], note);
            }

            if (note == "A0")
            {
                SendKey(Keycodes.Keys["A0"], note);
            }

            if (note == "F0")
            {
                SendKey(Keycodes.Keys["F0"], note);
            }

            if (note == "D0")
            {
                SendKey(Keycodes.Keys["D0"], note);
            }

            if (note == "B0")
            {
                SendKey(Keycodes.Keys["B0"], note);
            }

            if (note == "Bb0")
            {
                SendKey(Keycodes.Keys["Bb0"], note);
            }

            if (note == "Eb0")
            {
                SendKey(Keycodes.Keys["Eb0"], note);
            }

            if (note == "F#0")
            {
                SendKey(Keycodes.Keys["F#0"], note);
            }

            if (note == "C#0")
            {
                SendKey(Keycodes.Keys["C#0"], note);
            }

            if (note == "G#0")
            {
                SendKey(Keycodes.Keys["G#0"], note);
            }


            // Second Position
            if (note == "G1")
            {
                SendKey(Keycodes.Keys["G1"], note);
            }

            if (note == "C1")
            {
                SendKey(Keycodes.Keys["C1"], note);
            }

            if (note == "E1")
            {
                SendKey(Keycodes.Keys["E1"], note);
            }

            if (note == "A1")
            {
                SendKey(Keycodes.Keys["A1"], note);
            }

            if (note == "F1")
            {
                SendKey(Keycodes.Keys["F1"], note);
            }

            if (note == "D1")
            {
                SendKey(Keycodes.Keys["D1"], note);
            }

            if (note == "B1")
            {
                SendKey(Keycodes.Keys["B1"], note);
            }

            if (note == "Bb1")

            {
                SendKey(Keycodes.Keys["Bb1"], note);
            }

            if (note == "Eb1")
            {
                SendKey(Keycodes.Keys["Eb1"], note);
            }

            if (note == "F#1")
            {
                SendKey(Keycodes.Keys["F#1"], note);
            }

            if (note == "C#1")
            {
                SendKey(Keycodes.Keys["C#1"], note);
            }

            if (note == "G#1")
            {
                SendKey(Keycodes.Keys["G#1"], note);
            }

        }
    }
}
