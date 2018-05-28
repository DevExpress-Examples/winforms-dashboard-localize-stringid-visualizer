Imports DevExpress.DashboardCommon.Localization
Imports DevExpress.DashboardWin.Localization
Imports DevExpress.XtraBars
Imports DevExpress.XtraMap
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace WinForms_Localizer
    Partial Public Class DesignerForm1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            DashboardWinLocalizer.Active = New MyDashboardWinLocalizer()
            DashboardLocalizer.Active = New MyDashboardCoreLocalizer()
            InitializeComponent()
            dashboardDesigner.LoadDashboard("..\..\Dashboards\dashboard1.xml")


        End Sub
    End Class
End Namespace
