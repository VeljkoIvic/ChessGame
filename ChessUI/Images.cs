using System;
using ChessLogic;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ChessUI;
public static class Images
{
    private static readonly Dictionary<PieceType, ImageSource> WhiteSources = new()
    {
        { PieceType.Pawn, LoadImage("Asset/PawnW.png") },
        { PieceType.Bishop, LoadImage("Asset/BishopW.png") },
        { PieceType.Knight, LoadImage("Asset/KnightW.png") },
        { PieceType.Rook, LoadImage("Asset/RookW.png") },
        { PieceType.Queen, LoadImage("Asset/QueenW.png") },
        { PieceType.King, LoadImage("Asset/KingW.png") },
    };

    private static readonly Dictionary<PieceType, ImageSource> BlackSources = new()
    {
        { PieceType.Pawn, LoadImage("Asset/PawnB.png") },
        { PieceType.Bishop, LoadImage("Asset/BishopB.png") },
        { PieceType.Knight, LoadImage("Asset/KnightB.png") },
        { PieceType.Rook, LoadImage("Asset/RookBB.png") },
        { PieceType.Queen, LoadImage("Asset/QueenB.png") },
        { PieceType.King, LoadImage("Asset/KingB.png") },
    };

    private static ImageSource LoadImage(string filePath)
    {
        return new BitmapImage(new Uri(filePath, UriKind.Relative));
    }

    public static ImageSource GetImage(Player color, PieceType type)
    {
        return color switch
        {
            Player.White => WhiteSources[type],
            Player.Black => BlackSources[type],
            _ => null
        };
    }

    public static ImageSource GetImage(Piece piece)
    {
        if (piece == null)
        {
            return null;
        }
        return GetImage(piece.Color, piece.Type);
    }
}
