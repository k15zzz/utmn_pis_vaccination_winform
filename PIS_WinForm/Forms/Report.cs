using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS_WinForm.Forms
{
    public partial class Report : Form
    {
        public Report(GlobalClasses.NonStaticClasses.Report report)
        {
            InitializeComponent();

            var towns = report.GetTown();


            dataGridViewReport.Columns.Add("Город", "City");
            dataGridViewReport.Columns.Add("Количество", "Count");
            dataGridViewReport.Columns.Add("Стоимость", "Cost");

            foreach (var town in towns)
                dataGridViewReport.Rows.Add(town.Name, town.Count, town.Cost);
        }
    }
}
