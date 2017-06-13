Public Class IMSS_DRIVEPANEL
    Public Property _IMSS_STATUS_IMAGE As Image
        Get
            Return _IMSS_Drive_Logo.Image
        End Get
        Set(ByVal _IMSS_VALUE As Image)
            _IMSS_Drive_Logo.Image = _IMSS_VALUE
        End Set
    End Property
    Public Property _IMSS_DRIVE_NAME As String
        Get
            Return _IMSS_DriverName_Label.Text
        End Get
        Set(ByVal _IMSS_VALUE As String)
            _IMSS_DriverName_Label.Text = _IMSS_VALUE
        End Set
    End Property
    Public Property _IMSS_CHECK_STATUS As Boolean
        Get
            Return _IMSS_MainCeckBox_CheckBox.Checked
        End Get
        Set(ByVal _IMSS_VALUE As Boolean)
            If _IMSS_VALUE = True Then
                _IMSS_MainCeckBox_CheckBox.CheckState = CheckState.Checked
            Else
                _IMSS_MainCeckBox_CheckBox.CheckState = CheckState.Unchecked
            End If
        End Set
    End Property
End Class
