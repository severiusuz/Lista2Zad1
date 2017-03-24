using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zad1.Core.Services;

namespace Zad1
{
    public partial class Form1 : Form
    {
        private readonly IDateChecker _dateChecker;
        
        public Form1()
        {
            InitializeComponent();
            _dateChecker = new DateChecker();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstDate = date1.Value;
            var secondDate = date2.Value;

            var difference = _dateChecker.ShowDifference(firstDate, secondDate);

            box1.Text = difference.ToString(@"d\:hh\:mm\:ss");
        }
    }
}
