Imports DevExpress.DashboardCommon.Localization
Imports System

Namespace WinForms_Localizer

    Friend Class MyDashboardCoreLocalizer
        Inherits DashboardLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As DashboardStringId) As String
            Return [Enum].GetName(GetType(DashboardStringId), id)
        End Function
    End Class
End Namespace
