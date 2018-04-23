using System;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DashboardCommon;

namespace Dashboard_MoveItemFromGroupToGroup {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
        }

        protected void ASPxDashboardViewer1_DashboardLoaded(object sender, 
            DashboardLoadedWebEventArgs e) {
            Dashboard dashboard = e.Dashboard;
            ComboBoxDashboardItem comboBox = 
                (ComboBoxDashboardItem)dashboard.Items["comboBoxDashboardItem1"];
            TreeViewDashboardItem treeView = 
                (TreeViewDashboardItem)dashboard.Items["treeViewDashboardItem1"];
            DashboardItemGroup topGroup = 
                (DashboardItemGroup)dashboard.Groups["dashboardItemGroup1"];

            DashboardLayoutGroup root = e.Dashboard.LayoutRoot;;
            DashboardLayoutItem comboBoxLayoutItem = root.FindRecursive(comboBox);
            DashboardLayoutItem treeViewLayoutItem = root.FindRecursive(treeView);
            DashboardLayoutGroup topGroupItem = root.FindRecursive(topGroup);
            
            comboBoxLayoutItem.MoveAbove(treeViewLayoutItem);            
            comboBox.Group = topGroup;             
        }

        protected void ASPxDashboardViewer1_ConfigureDataConnection(object sender, 
            ConfigureDataConnectionWebEventArgs e) {
                if (e.ConnectionName == "WebsiteStatisticsDataConnection") {
                XmlFileConnectionParameters parameters =
                    (XmlFileConnectionParameters)e.ConnectionParameters;
                string databasePath = Server.MapPath("App_Data/WebsiteStatisticsData.xml");                   
                parameters.FileName = databasePath;
            }
        }
    }
}