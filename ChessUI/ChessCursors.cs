using System.IO;
using System.Windows;
using System.Windows.Input;

namespace ChessUI;

public static class ChessCursors
{

    public static readonly Cursor WhiteCursor = loadCursor("Assets/CursorW.cur");
    public static readonly Cursor BlackCursor = loadCursor("Assets/CursorB.cur");
    private static Cursor loadCursor(string filePath)
    {
        Stream stream = Application.GetResourceStream(new Uri(filePath, UriKind.Relative)).Stream;
        return new Cursor(stream, true);
    }
}