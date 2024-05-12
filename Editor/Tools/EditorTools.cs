using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Lancy.Tools
{
    public class EditorTools
    {
        [MenuItem("Tools/Make Screenshoot &s")]
        public static void MakeScreen()
        {
            if (Directory.Exists("Screenshoots") == false)
            {
                Directory.CreateDirectory("Screenshoots");
            }

            ScreenCapture.CaptureScreenshot($"Screenshoots//Screenshoot__{DateTime.Now.ToString("MM-dd-yy (HH-mm-ss)")}.png");
        }
    }
}