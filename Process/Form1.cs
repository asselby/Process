using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProcessFirstHW
{
    public partial class Form1 : Form
    {
               public Form1()
        {
            InitializeComponent();
        }


        private void show_button(object sender, EventArgs e)
        {
            var allProcess = from p in Process.GetProcesses()
                             orderby p.Id
                             select new
                             {
                                 p.Id,
                                 p.MachineName,
                                 p.ProcessName,
                                 p.MainWindowTitle,
                                 p.Threads
                             };
                            

            foreach (var item in allProcess)
            {
              listView1.Items.Add(item.ToString());

            }
       
        }


    }
}
