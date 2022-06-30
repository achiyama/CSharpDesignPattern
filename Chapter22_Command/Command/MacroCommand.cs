using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter22_Command.Command;

/// <summary>
/// 複数の命令をまとめた命令を表現するクラス
/// </summary>
public class MacroCommand : ICommand
{
    private Stack<ICommand> _commands = new();

    /// <summary>
    /// 実行
    /// </summary>
    public void Execute()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }
    }

    /// <summary>
    /// 追加
    /// </summary>
    /// <param name="command"></param>
    public void Append(ICommand command)
    {
        if (command != this)
        {
            _commands.Push(command);
        }
    }

    /// <summary>
    /// 最後の命令を削除
    /// </summary>
    public void Undo()
    {
        if (_commands.Any())
        {
            _commands.Pop();
        }
    }

    /// <summary>
    /// 全部削除
    /// </summary>
    public void Clear()
    {
        _commands.Clear();
    }
}
