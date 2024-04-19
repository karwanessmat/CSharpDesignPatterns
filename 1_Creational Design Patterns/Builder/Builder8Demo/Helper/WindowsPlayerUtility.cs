using System.Runtime.InteropServices;
using System.Text;

namespace Builder8Demo.Helper;

internal static class WindowsPlayerUtility
{
    [DllImport("winmm.dll")]
    private static extern int mciSendString(string command, StringBuilder stringReturn, int returnLength, IntPtr hwndCallback);

    public static void ExecuteMciCommand(string commandString)
    {
        var sb = new StringBuilder();
        var result = mciSendString(commandString, sb, 1024 * 1024, IntPtr.Zero);
        Console.WriteLine(result);
    }
}