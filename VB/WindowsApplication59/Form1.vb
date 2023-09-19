Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Namespace WindowsApplication59

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            InitData()
            gridControl1.UseEmbeddedNavigator = True
            gridControl1.ForceInitialize()
            Dim col As GridColumn = gridView1.Columns.AddField("Tasks")
            col.UnboundType = DevExpress.Data.UnboundColumnType.Integer
            col.Visible = True
            AddHandler gridView1.CustomUnboundColumnData, New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(AddressOf gridView1_CustomUnboundColumnData)
        End Sub

        Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            If Not Equals(e.Column.FieldName, "Tasks") Then Return
            If Not e.IsGetData Then Return
            Dim row As DataRow = TryCast(TryCast(view.DataSource, IList)(e.ListSourceRowIndex), DataRowView).Row
            e.Value = row.GetChildRows("Project_Tasks").Length
        End Sub

        Private Sub InitData()
            dataTable1.Rows.Add(New Object() {0, "Software", 4000})
            dataTable1.Rows.Add(New Object() {1, "Hardware", 1500})
            dataTable1.Rows.Add(New Object() {2, "Project X", 100000})
            dataTable2.Rows.Add(New Object() {Nothing, 0, "Drivers"})
            dataTable2.Rows.Add(New Object() {Nothing, 0, "Application"})
            dataTable2.Rows.Add(New Object() {Nothing, 1, "All the stuff"})
            dataTable2.Rows.Add(New Object() {Nothing, 2, "Part X"})
            dataTable2.Rows.Add(New Object() {Nothing, 2, "Part Y"})
            dataTable2.Rows.Add(New Object() {Nothing, 2, "Part Z"})
        End Sub
    End Class
End Namespace
