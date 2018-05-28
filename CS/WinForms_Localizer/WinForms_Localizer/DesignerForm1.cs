using DevExpress.DashboardCommon.Localization;
using DevExpress.DashboardWin.Localization;
using DevExpress.XtraBars;
using DevExpress.XtraMap;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinForms_Localizer
{
    public partial class DesignerForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DesignerForm1()
        {
            DashboardWinLocalizer.Active = new MyDashboardWinLocalizer();
            DashboardLocalizer.Active = new MyDashboardCoreLocalizer();
            InitializeComponent();
            dashboardDesigner.LoadDashboard(@"..\..\Dashboards\dashboard1.xml");


        }
    }
}
