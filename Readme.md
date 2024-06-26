<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580295/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T207077)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx.cs](./CS/Dashboard_MoveItemFromGroupToGroup/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/Dashboard_MoveItemFromGroupToGroup/WebForm1.aspx.vb))
<!-- default file list end -->
# How to move an existing dashboard item to another group


<strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx">ASPxDashboard control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.</em><br><br>The following example demonstrates how to move an existing dashboard item from the dashboard item <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument17586">group</a> to another group in code.<br>In this example, the <a href="http://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWebASPxDashboardViewertopic">ASPxDashboardViewer</a> loads an existing dashboard with the predefined layout from an <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument15405">XML file</a>. <br>The following steps are performed to move the <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument17659">combo box</a> placed in the bottom group into the top group.<br>- The required layout items and the dashboard layout group are obtained using the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboardLayoutGroup_FindRecursivetopic">FindRecursive</a> method.<br>- The <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboardLayoutNode_MoveAbovetopic">MoveAbove</a> method is used to move a combo box layout item above the tree view placed in the top group.<br>- The <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboardItem_Grouptopic">Group</a> property specifies a new parent group for the combo box.

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-move-an-existing-dashboard-item-to-another-group-t207077&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-move-an-existing-dashboard-item-to-another-group-t207077&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
