using DevExpress.DashboardCommon.Localization;
using DevExpress.DashboardWin.Localization;
using DevExpress.Utils.Localization;
using System;

namespace WinForms_Localizer
{
    internal class MyDashboardCoreLocalizer : DashboardLocalizer
    {
        public override string GetLocalizedString(DashboardStringId id)
        {
            return Enum.GetName(typeof(DashboardStringId), id);
        }
    }
}