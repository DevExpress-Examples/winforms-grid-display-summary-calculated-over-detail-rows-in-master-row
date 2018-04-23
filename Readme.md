# How to display a summary calculated over detail rows in a master grid view column


<p>To accomplish this task, create an unbound column in the master GridView and handle the CustomUnboundColumnData event. Within the event, cast the view's DataSource to your datasource type and get the currently processed row by its index. Then, use datasource methods to obtain the child row list for this row, and iterate it to calculate a total.</p>

<br/>


