Imports DevExpress.DashboardWin.Localization
Imports System

Namespace WinForms_Localizer

    Friend Class MyDashboardWinLocalizer
        Inherits DashboardWinLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As DashboardWinStringId) As String
            Return [Enum].GetName(GetType(DashboardWinStringId), id)
        End Function
    End Class
End Namespace
