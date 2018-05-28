Imports DevExpress.DashboardCommon.Localization
Imports DevExpress.DashboardWin.Localization
Imports DevExpress.Utils.Localization
Imports System

Namespace WinForms_Localizer
    Friend Class MyDashboardCoreLocalizer
        Inherits DashboardLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As DashboardStringId) As String
            Return System.Enum.GetName(GetType(DashboardStringId), id)
        End Function
    End Class
End Namespace