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

namespace Chapter22_Command
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 描画履歴
        /// </summary>
        private MacroCommand _history = new MacroCommand();

        public MainForm()
        {
            InitializeComponent();
        }

        private void DrawCanvas_Load(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Clearボタンが押されました");
            _history.Clear();
            DrawCanvas.Invalidate();
        }
    }
}
