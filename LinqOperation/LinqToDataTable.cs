using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperation
{
    public class LinqToDataTable
    {
        public void AddToTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("ProductName");
            dataTable.Rows.Add("1", "Electric Fan");
            dataTable.Rows.Add("2", "Electric car");
            dataTable.Rows.Add("3", "Electric Light");
            dataTable.Rows.Add("4", "Tubelight");
            dataTable.Rows.Add("5", "Electric shoes");
            DisplayProducts(dataTable);

        }
        public void DisplayProducts(DataTable table)
        {
            var productname = from Products in table.AsEnumerable() select Products.Field<string>("ProductName");
            foreach(var product in productname)
            {
                Console.WriteLine(product);
            } 
        }
    }
}
