using Chapter22_Command.Command;
using System.Drawing;

namespace Chapter22_Command.Drawer;

/// <summary>
/// 点の描画命令を表現するクラス
/// </summary>
public class DrawCommand : ICommand
{
    private IDrawable _drawable;

    private Point _position;

    public DrawCommand(IDrawable drawable, Point position)
    {
        _drawable = drawable;
        _position = position;
    }

    public void Execute()
    {
        _drawable.Draw(_position.X, _position.Y);
    }
}
