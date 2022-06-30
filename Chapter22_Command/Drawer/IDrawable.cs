using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter22_Command.Drawer;

/// <summary>
/// 描画対象を表現するインターフェース
/// </summary>
public interface IDrawable
{
    void Draw(int x, int y);
}
