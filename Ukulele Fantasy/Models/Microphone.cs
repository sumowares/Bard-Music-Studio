using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Ukulele_Fantasy.Models
{
    public static class Microphone
    {
        public static int InputDevice = 0;
        private static readonly List<string> InputDevices = new List<string>();

        public static void SetInputDevice(int id)
        {
            InputDevice = id;
        }

        public static List<string> GetInputDevices()
        {
            for (var i = 0; i < WaveInEvent.DeviceCount; i++)
            {
                InputDevices.Add(WaveInEvent.GetCapabilities(i).ProductName);
            }

            return InputDevices;
        }
    }
}
