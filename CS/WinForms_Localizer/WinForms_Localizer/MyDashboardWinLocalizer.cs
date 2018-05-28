using DevExpress.DashboardWin.Localization;
using DevExpress.Utils.Localization;
using System;

namespace WinForms_Localizer
{
    internal class MyDashboardWinLocalizer : DashboardWinLocalizer
    {
        public override string GetLocalizedString(DashboardWinStringId id)
        {
            return Enum.GetName(typeof(DashboardWinStringId), id);
        }
    }
}