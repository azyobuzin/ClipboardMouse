using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipboardMouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_SizeChanged(object sender, EventArgs e)
        {
            this.Size = label1.Size;
        }

        private void mouseTimer_Tick(object sender, EventArgs e)
        {
            this.Location = Point.Add(Cursor.Position, new Size(20, 20));
        }

        private void clipboardTimer_Tick(object sender, EventArgs e)
        {
            clipboardTimer.Interval = 1000;
            if (Clipboard.ContainsText())
            {
                label1.Text = Clipboard.GetText();
            }
            else
            {
                label1.Text = "[Nothing or not text]";
            }
        }
    }
}
