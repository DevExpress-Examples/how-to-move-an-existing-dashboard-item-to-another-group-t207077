<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx.cs](./CS/Dashboard_MoveItemFromGroupToGroup/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/Dashboard_MoveItemFromGroupToGroup/WebForm1.aspx.vb))
<!-- default file list end -->
# How to move an existing dashboard item to another group


<strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx">ASPxDashboard control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.</em><br><br>The following example demonstrates how to move an existing dashboard item from the dashboard item <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument17586">group</a> to another group in code.<br>In this example, the <a href="http://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWebASPxDashboardViewertopic">ASPxDashboardViewer</a> loads an existing dashboard with the predefined layout from an <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument15405">XML file</a>. <br>The following steps are performed to move the <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument17659">combo box</a> placed in the bottom group into the top group.<br>- The required layout items and the dashboard layout group are obtained using the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboardLayoutGroup_FindRecursivetopic">FindRecursive</a> method.<br>- The <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboardLayoutNode_MoveAbovetopic">MoveAbove</a> method is used to move a combo box layout item above the tree view placed in the top group.<br>- The <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboardItem_Grouptopic">Group</a> property specifies a new parent group for the combo box.

<br/>


