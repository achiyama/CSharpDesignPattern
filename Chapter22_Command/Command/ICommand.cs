using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter22_Command.Command;

/// <summary>
/// 命令を表現するインターフェース
/// </summary>
public interface ICommand
{
    void Execute();
}
