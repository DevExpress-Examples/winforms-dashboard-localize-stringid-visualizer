Imports DevExpress.DashboardCommon.Localization
Imports DevExpress.DashboardWin.Localization
Imports DevExpress.XtraBars

Namespace WinForms_Localizer

    Public Partial Class DesignerForm1
        Inherits Ribbon.RibbonForm

        Public Sub New()
            DashboardWinLocalizer.Active = New MyDashboardWinLocalizer()
            DashboardLocalizer.Active = New MyDashboardCoreLocalizer()
            InitializeComponent()
            dashboardDesigner.LoadDashboard("..\..\Dashboards\dashboard1.xml")
        End Sub
    End Class
End Namespace
