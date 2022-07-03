using Chapter22_Command.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter22_Command.Drawer
{
    public partial class DrawCanvas : UserControl, IDrawable
    {
        /// <summary>
        /// 描画色
        /// </summary>
        private readonly Color _color = Color.Black;

        /// <summary>
        /// 半径
        /// </summary>
        private readonly int _radius = 6;

        /// <summary>
        /// 履歴
        /// </summary>
        private MacroCommand? _history = null;

        public DrawCanvas()
        {
            InitializeComponent();
        }

        public void Draw(int x, int y)
        {
            using (var g = CreateGraphics())
            using (var brush = new SolidBrush(_color))
            {
                var rectangle = new Rectangle(x, y, _radius, _radius);
                g.FillEllipse(brush, rectangle);
            }
        }

        public void SetHistory(MacroCommand history) => _history = history;

        /// <summary>
        /// 再描画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (_history != null)
            {
                _history.Execute();
            }
        }
    }
}
