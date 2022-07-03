using Chapter22_Command.Command;
using System.Drawing;

namespace Chapter22_Command.Drawer;

/// <summary>
/// 点の描画命令を表現するクラス
/// </summary>
public class DrawCommand : ICommand
{
    /// <summary>
    /// 描画対象
    /// </summary>
    private IDrawable _drawable;

    /// <summary>
    /// 描画位置
    /// </summary>
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
