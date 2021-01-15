using System;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace VolumeDisplay
{
    internal static class AeroGlassHelper
    {
        [DllImport("dwmapi.dll")]
        private extern static int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS margin);

        /// <summary>
        /// Sets the form to have an Aero Glass background.
        /// </summary>
        public static void Set(IntPtr formHandler)
        {
            MARGINS margin = new MARGINS(-1, -1, -1, -1);

            DwmExtendFrameIntoClientArea(formHandler, ref margin);
        }

        internal struct MARGINS
        {
            public int m_Top;
            public int m_Bottom;
            public int m_Left;
            public int m_Right;

            public MARGINS(int top, int bottom, int left, int right)
            {
                m_Top = top;
                m_Bottom = bottom;
                m_Left = left;
                m_Right = right;
            }
        }
    }
}