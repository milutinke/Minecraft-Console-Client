using System;
using System.Runtime.InteropServices;

namespace MinecraftClient.WinAPI
{
    /// <summary>
    /// Windows console mode helpers.
    /// </summary>
    public static class WindowsConsoleMode
    {
        private const int StdInputHandle = -10;
        private const uint EnableQuickEditMode = 0x0040;
        private const uint EnableExtendedFlags = 0x0080;

        public static void DisableQuickEdit()
        {
            if (!OperatingSystem.IsWindows())
                return;

            try
            {
                IntPtr inputHandle = GetStdHandle(StdInputHandle);
                if (inputHandle == IntPtr.Zero || inputHandle == new IntPtr(-1))
                    return;

                if (!GetConsoleMode(inputHandle, out uint mode))
                    return;

                uint updatedMode = (mode | EnableExtendedFlags) & ~EnableQuickEditMode;
                if (updatedMode != mode)
                    _ = SetConsoleMode(inputHandle, updatedMode);
            }
            catch
            {
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);
    }
}
