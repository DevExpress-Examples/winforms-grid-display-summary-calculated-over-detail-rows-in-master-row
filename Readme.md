<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128627446/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1581)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Winforms Data Grid - Calculate a summary against detail rows and display it in a master row cell

This example creates an [unbound column](https://docs.devexpress.com/WindowsForms/1477/controls-and-libraries/data-grid/unbound-columns) in the master `GridView` and handles the [CustomUnboundColumnData](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.CustomUnboundColumnData) event to calculate the number of detail rows and display the number in the master row.

![Winforms Data Grid - Calculate a summary against detail rows and display it in a master row cell](https://raw.githubusercontent.com/DevExpress-Examples/how-to-display-a-summary-calculated-over-detail-rows-in-a-master-grid-view-column-e1581/13.1.4%2B/media/winforms-grid-custom-totals.png)

```csharp
public Form1() {
    // ...
    gridControl1.ForceInitialize();
    GridColumn col = gridView1.Columns.AddField("Tasks");
    col.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
    col.Visible = true;
    gridView1.CustomUnboundColumnData+=new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(gridView1_CustomUnboundColumnData);
}
private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
    GridView view = sender as GridView;
    if (e.Column.FieldName != "Tasks") return;
    if (!e.IsGetData) return;
    DataRow row = ((view.DataSource as IList)[e.ListSourceRowIndex] as DataRowView).Row;
    e.Value = row.GetChildRows("Project_Tasks").Length;
}
```


## Files to Review

* [Form1.cs](./CS/WindowsApplication59/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication59/Form1.vb))


## Documentation

* [Unbound Columns](https://docs.devexpress.com/WindowsForms/1477/controls-and-libraries/data-grid/unbound-columns)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-display-summary-calculated-over-detail-rows-in-master-row&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-display-summary-calculated-over-detail-rows-in-master-row&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
