using Chapter22_Command.Command;
using Chapter22_Command.Drawer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter22_Command
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 描画履歴
        /// </summary>
        private MacroCommand _history = new MacroCommand();

        /// <summary>
        /// ドラッグ中
        /// </summary>
        private bool _drag = false;

        public MainForm()
        {
            InitializeComponent();
            DrawCanvas.SetHistory(_history);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            _history.Clear();
            // 再描画する
            DrawCanvas.Invalidate();
        }

        private void DrawCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (_drag)
            {
                var command = new DrawCommand(DrawCanvas, e.Location);
                command.Execute();
                _history.Append(command);
            }
        }

        private void DrawCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            _drag = true;
        }

        private void DrawCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            _drag = false;
        }
    }
}
