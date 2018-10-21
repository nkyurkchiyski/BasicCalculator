using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.GUI
{
    public partial class History : Form
    {
        private string historyData;

        public History(string historyData)
        {
            this.historyData = historyData;
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            string[] operationsData = this.historyData.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < operationsData.Length; i++)
            {
                string[] op = operationsData[i].Split();
                
                ListViewItem item = new ListViewItem(op);
                this.historyListView.Items.Add(item);
            }
        }

    }
}
