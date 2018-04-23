Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication59
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.dataColumn4 = New System.Data.DataColumn()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.dataTable2 = New System.Data.DataTable()
			Me.dataColumn5 = New System.Data.DataColumn()
			Me.dataColumn6 = New System.Data.DataColumn()
			Me.dataColumn7 = New System.Data.DataColumn()
			Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colBudget = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataMember = "Table1"
			Me.gridControl1.DataSource = Me.dataSet1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(423, 266)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Relations.AddRange(New System.Data.DataRelation() { New System.Data.DataRelation("Project_Tasks", "Table1", "Table2", New String() { "ID"}, New String() { "Project"}, False)})
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1, Me.dataTable2})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn3, Me.dataColumn4})
			Me.dataTable1.Constraints.AddRange(New System.Data.Constraint() { New System.Data.UniqueConstraint("Constraint2", New String() { "ID"}, True)})
			Me.dataTable1.PrimaryKey = New System.Data.DataColumn() { Me.dataColumn1}
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.AllowDBNull = False
			Me.dataColumn1.AutoIncrement = True
			Me.dataColumn1.ColumnName = "ID"
			Me.dataColumn1.DataType = GetType(Integer)
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "Name"
			' 
			' dataColumn4
			' 
			Me.dataColumn4.ColumnName = "Budget"
			Me.dataColumn4.DataType = GetType(Decimal)
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colName, Me.colBudget})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' dataTable2
			' 
			Me.dataTable2.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn5, Me.dataColumn6, Me.dataColumn7})
			Me.dataTable2.Constraints.AddRange(New System.Data.Constraint() { New System.Data.UniqueConstraint("Constraint1", New String() { "ID"}, True), New System.Data.ForeignKeyConstraint("Relation1", "Table1", New String() { "ID"}, New String() { "Project"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)})
			Me.dataTable2.PrimaryKey = New System.Data.DataColumn() { Me.dataColumn5}
			Me.dataTable2.TableName = "Table2"
			' 
			' dataColumn5
			' 
			Me.dataColumn5.AllowDBNull = False
			Me.dataColumn5.AutoIncrement = True
			Me.dataColumn5.ColumnName = "ID"
			Me.dataColumn5.DataType = GetType(Integer)
			' 
			' dataColumn6
			' 
			Me.dataColumn6.AllowDBNull = False
			Me.dataColumn6.ColumnName = "Project"
			Me.dataColumn6.DataType = GetType(Integer)
			' 
			' dataColumn7
			' 
			Me.dataColumn7.ColumnName = "Description"
			' 
			' colID
			' 
			Me.colID.Caption = "ID"
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			' 
			' colName
			' 
			Me.colName.Caption = "Name"
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			' 
			' colBudget
			' 
			Me.colBudget.Caption = "Budget"
			Me.colBudget.FieldName = "Budget"
			Me.colBudget.Name = "colBudget"
			Me.colBudget.Visible = True
			Me.colBudget.VisibleIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(423, 266)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private dataColumn4 As System.Data.DataColumn
		Private dataTable2 As System.Data.DataTable
		Private dataColumn5 As System.Data.DataColumn
		Private dataColumn6 As System.Data.DataColumn
		Private dataColumn7 As System.Data.DataColumn
		Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private colBudget As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

