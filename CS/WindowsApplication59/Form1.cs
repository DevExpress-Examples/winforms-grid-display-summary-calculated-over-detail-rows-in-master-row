using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace WindowsApplication59
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitData();

            gridControl1.UseEmbeddedNavigator = true;
            gridControl1.ForceInitialize();
            GridColumn col = gridView1.Columns.AddField("Tasks");
            col.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            col.Visible = true;
            gridView1.CustomUnboundColumnData+=new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(gridView1_CustomUnboundColumnData);
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName != "Tasks") return;
            if (!e.IsGetData) return;
            DataRow row = ((view.DataSource as IList)[e.ListSourceRowIndex] as DataRowView).Row;
            e.Value = row.GetChildRows("Project_Tasks").Length;
        }

        void InitData()
        {
            dataTable1.Rows.Add(new object[] { 0, "Software", 4000 });
            dataTable1.Rows.Add(new object[] { 1, "Hardware", 1500 });
            dataTable1.Rows.Add(new object[] { 2, "Project X", 100000 });
            dataTable2.Rows.Add(new object[] { null, 0, "Drivers" });
            dataTable2.Rows.Add(new object[] { null, 0, "Application" });
            dataTable2.Rows.Add(new object[] { null, 1, "All the stuff" });
            dataTable2.Rows.Add(new object[] { null, 2, "Part X" });
            dataTable2.Rows.Add(new object[] { null, 2, "Part Y" });
            dataTable2.Rows.Add(new object[] { null, 2, "Part Z" });
        }
    }
}