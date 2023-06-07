using PIS_WinForm.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS_WinForm.GlobalClasses.NonStaticClasses
{
    public class Report
    {
       private List<Town> townList = new List<Town>();

        public Report AddTown(string name, int count, double cost)
        {
            var town = new Town();

            town.Name = name;
            town.Count = count;
            town.Cost = cost;

            townList.Add(town);

            return this;
        }

        public DataGridView GetDataGridView()
        {
            DataGridView dataGridView = new DataGridView();

            dataGridView.Columns.Add("Город", "City");
            dataGridView.Columns.Add("Количество", "Count");
            dataGridView.Columns.Add("Стоимость", "Cost");

            foreach (var town in townList)
                dataGridView.Rows.Add(town.Name, town.Count, town.Count);

            return dataGridView;
        }

        public Town[] GetTown()
        {
            return townList.ToArray();
        }

        public class Town
        {
            public string Name { get; set; }
            public int Count { get; set; }
            public double Cost { get; set; }
        }
    }
}
