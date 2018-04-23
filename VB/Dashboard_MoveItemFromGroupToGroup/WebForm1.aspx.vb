Imports System
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DashboardCommon

Namespace Dashboard_MoveItemFromGroupToGroup
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub ASPxDashboardViewer1_DashboardLoaded(ByVal sender As Object, _
                                           ByVal e As DashboardLoadedWebEventArgs)
            Dim dashboard As Dashboard = e.Dashboard
            Dim comboBox As ComboBoxDashboardItem =
                CType(dashboard.Items("comboBoxDashboardItem1"), ComboBoxDashboardItem)
            Dim treeView As TreeViewDashboardItem =
                CType(dashboard.Items("treeViewDashboardItem1"), TreeViewDashboardItem)
            Dim topGroup As DashboardItemGroup =
                CType(dashboard.Groups("dashboardItemGroup1"), DashboardItemGroup)

            Dim root As DashboardLayoutGroup = e.Dashboard.LayoutRoot
            Dim comboBoxLayoutItem As DashboardLayoutItem = root.FindRecursive(comboBox)
            Dim treeViewLayoutItem As DashboardLayoutItem = root.FindRecursive(treeView)
            Dim topGroupItem As DashboardLayoutGroup = root.FindRecursive(topGroup)

            comboBoxLayoutItem.MoveAbove(treeViewLayoutItem)
            comboBox.Group = topGroup
        End Sub

        Protected Sub ASPxDashboardViewer1_ConfigureDataConnection(ByVal sender As Object, _
                                           ByVal e As ConfigureDataConnectionWebEventArgs)
            If e.ConnectionName = "WebsiteStatisticsDataConnection" Then
                Dim parameters As XmlFileConnectionParameters =
                    CType(e.ConnectionParameters, XmlFileConnectionParameters)
                Dim databasePath As String = Server.MapPath("App_Data/WebsiteStatisticsData.xml")
                parameters.FileName = databasePath
            End If
        End Sub
    End Class
End Namespace