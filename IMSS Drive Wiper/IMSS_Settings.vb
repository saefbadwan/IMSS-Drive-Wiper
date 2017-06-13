Public Class IMSS_Settings
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        My.Settings.Reload()
        _IMSS_Numeric.Value = My.Settings._IMSS_NumberOfPassesOper
        If My.Settings._IMSS_ZeroSpace = True Then _IMSS_zeroSpace_CheckBox.CheckState = CheckState.Checked Else _IMSS_zeroSpace_CheckBox.CheckState = CheckState.Unchecked
        If My.Settings._IMSS_CleanFreeSpace = True Then _IMSS_CleanFreeSpace_CheckBox.CheckState = CheckState.Checked Else _IMSS_CleanFreeSpace_CheckBox.CheckState = CheckState.Unchecked
    End Sub
    Private Sub _IMSS_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Save.Click
        My.Settings.Reset()
        My.Settings._IMSS_NumberOfPassesOper = _IMSS_Numeric.Value
        My.Settings._IMSS_ZeroSpace = _IMSS_zeroSpace_CheckBox.Checked
        My.Settings._IMSS_CleanFreeSpace = _IMSS_CleanFreeSpace_CheckBox.Checked
        My.Settings.Save()
        My.Settings.Reload()
        Me.Close()
    End Sub

    Private Sub _IMS_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMS_Cancel.Click
        Me.Close()
    End Sub

End Class