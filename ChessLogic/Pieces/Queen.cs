namespace ChessLogic;

public class Queen : Piece
{
    public override PieceType Type => PieceType.Queen;
    public override Player Color { get; }

    private static readonly Direction[] dirs = new Direction[]
    {
        Direction.North,
        Direction.South,
        Direction.East,

        Direction.West,
        Direction.NorthWest,
        Direction.NorthWest,
        Direction.SouthWest,
        Direction.SouthEast
    };

    public Queen(Player color)
    {
        Color = color;
    }

    public override Piece Copy()
    {
        Queen copy = new Queen(Color);
        copy.HasMoved = HasMoved;
        return copy;
    }

    public override IEnumerable<Move> GetMoves(Position form, Board board)
    {
        return MovePositionInDir(form, board, dirs).Select(to => new NormalMove(form, to));
    }
}