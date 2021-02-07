using Devil_Supreme.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attacklogs
{
    public partial class Attacklogs : Form
    {
        public Attacklogs()
        {
            InitializeComponent();
        }

        private async Task timer1_Tick(object sender, EventArgs e)
        {
            Logsincomming.Text = await Attacklog.Getlogs();
            Logsincomming.SelectionStart = Logsincomming.Text.Length;
            Logsincomming.ScrollToCaret();
        }

        private async void timer2_TickAsync(object sender, EventArgs e)
        {
            Logsincomming.Text = await Attacklog.Getlogs();
        }

        private async void timer3_TickAsync(object sender, EventArgs e)
        {
            Logsincomming.SelectionStart = Logsincomming.Text.Length;
            Logsincomming.ScrollToCaret();
        }
    }
}
