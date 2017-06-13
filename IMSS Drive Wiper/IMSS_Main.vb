Public Class IMSS_MainControl
    Private Shared _IMSS_CONTROL As IMSS_MainControl
    Public Shared Function _IMSS_CREATE_CONTROL() As IMSS_MainControl
        If _IMSS_CONTROL Is Nothing Then
            _IMSS_CONTROL = New IMSS_MainControl
        End If
        Return _IMSS_CONTROL
    End Function
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IMSS_LoadDrive()
    End Sub
    Private Sub _IMSS_Refresh_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Refresh_Button.Click
        _IMSS_LoadDrive()
    End Sub

#Region " IMSS Functions Decleration Uint"
    Private Sub _IMSS_Slide(ByVal _IMSS_From As Short, ByVal _IMSS_To As Short, ByVal _IMSS_Step As Short)
        For i As Integer = _IMSS_From To _IMSS_To Step _IMSS_Step
            Me.Location = New Point(i, Me.Location.Y)
            Application.DoEvents()
        Next i
    End Sub
    Private Sub _IMSS_LoadDrive()
        Me._IMSS_DrivesHolders_Panel.Controls.Clear()
        For Each _IMSS_DRIVE In My.Computer.FileSystem.Drives
            If _IMSS_DRIVE.IsReady And Not _IMSS_DRIVE.DriveType = IO.DriveType.CDRom And Not _IMSS_DRIVE.DriveType = IO.DriveType.Unknown And Not _IMSS_DRIVE.DriveType = IO.DriveType.NoRootDirectory Then
                If _IMSS_DRIVE.DriveType = IO.DriveType.Fixed Then
                    Me._IMSS_DrivesHolders_Panel.Controls.Add(_IMSS_CREAT_DRIVE_CONTROl(New Object() {_IMSS_DRIVE.Name, True, My.Resources.Drive_16x16}))
                ElseIf _IMSS_DRIVE.DriveType = IO.DriveType.Removable Then
                    Me._IMSS_DrivesHolders_Panel.Controls.Add(_IMSS_CREAT_DRIVE_CONTROl(New Object() {_IMSS_DRIVE.Name, True, My.Resources.UsbDrive_16x16}))
                Else
                    Me._IMSS_DrivesHolders_Panel.Controls.Add(_IMSS_CREAT_DRIVE_CONTROl(New Object() {_IMSS_DRIVE.Name, True, My.Resources.Drive_16x16}))
                End If
            End If
        Next _IMSS_DRIVE : Me.Refresh()
    End Sub
    Private Function _IMSS_CREAT_DRIVE_CONTROl(ByRef _IMSS_DRIVE_INFO() As Object) As IMSS_DRIVEPANEL
        Dim _IMSS_LocalDrive As New IMSS_DRIVEPANEL With {._IMSS_DRIVE_NAME = _IMSS_DRIVE_INFO(0),
                                                  ._IMSS_CHECK_STATUS = _IMSS_DRIVE_INFO(1),
                                                  ._IMSS_STATUS_IMAGE = _IMSS_DRIVE_INFO(2)}
        Return _IMSS_LocalDrive
    End Function

#End Region

#Region " IMSS Click Functions Decleartions"
    Private Sub _IMSS_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Close.Click
        Application.Exit()
    End Sub

    Private Sub _IMSS_Next_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Next_Button.Click
        _IMSS_Slide(0, -419, -24) : Me.Location = New Point(Me.Location.X - 10, Me.Location.Y)
        For Each _IMSS_DRIVEPANEL As IMSS_DRIVEPANEL In _IMSS_DrivesHolders_Panel.Controls
            If _IMSS_DRIVEPANEL._IMSS_CHECK_STATUS = True Then
                _IMSS_DriveTarget.Text = "Current Drive : " & _IMSS_DRIVEPANEL._IMSS_DRIVE_NAME.Substring(0, 2)
                _IMSS_StartCoreDiskWiper(_IMSS_DRIVEPANEL._IMSS_DRIVE_NAME.Substring(0, 2))
            End If
        Next _IMSS_DRIVEPANEL
    End Sub

    Private Sub _IMSS_Settings_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Settings_Button.Click
        Dim _IMSS_Settings As New IMSS_Settings
        _IMSS_Settings.ShowDialog()
    End Sub

    Private Sub _IMSS_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Cancel.Click
        '838
        Shell("Taskkill /F /IM IMSS_CoreDiskWiper.exe", AppWinStyle.Hide, True)
        Application.Exit()
    End Sub
#End Region

#Region " IMSS Run Core Disk Wiper"
    Private psi As ProcessStartInfo
    Private cmd As Process
    Private Delegate Sub InvokeWithString(ByVal _IMSS_VALUE As String)
    Private Sub _IMSS_StartCoreDiskWiper(ByRef _IMSS_VALUE As String)
        psi = New ProcessStartInfo(Environment.CurrentDirectory & "\IMSS_CoreDiskWiper.exe")

        Dim systemencoding As System.Text.Encoding = _
            System.Text.Encoding.GetEncoding(Globalization.CultureInfo.CurrentUICulture.TextInfo.OEMCodePage)

        With psi
            .Arguments = _IMSS_GetArguments(_IMSS_VALUE)
            .UseShellExecute = False  ' Required for redirection
            .RedirectStandardError = True
            .RedirectStandardOutput = True
            .CreateNoWindow = True
            .StandardOutputEncoding = systemencoding  ' Use OEM encoding for console applications
            .StandardErrorEncoding = systemencoding
        End With

        ' EnableraisingEvents is required for Exited event
        cmd = New Process With {.StartInfo = psi, .EnableRaisingEvents = True}
        AddHandler cmd.Exited, AddressOf _IMSS_CMD_Exited
        cmd.Start()
        cmd.BeginOutputReadLine()
        cmd.BeginErrorReadLine()
    End Sub
    Private Function _IMSS_GetArguments(ByVal _IMSS_VALUE As String) As String
        Dim _IMSS_Arguments As String = "-p " & My.Settings._IMSS_NumberOfPassesOper & " -q -c -z " & """" & _IMSS_VALUE & """"
        If Not My.Settings._IMSS_ZeroSpace = True Then
            _IMSS_Arguments = _IMSS_Arguments.Replace("-z", "")
        End If
        If Not My.Settings._IMSS_CleanFreeSpace = True Then
            _IMSS_Arguments = _IMSS_Arguments.Replace("-c", "")
        End If
        Return _IMSS_Arguments
    End Function
    'Private Sub _IMSS_ERROR_Async_Data_Received(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
    '    Invoke(New InvokeWithString(AddressOf _IMSS_ERROR_Sync_Output), e.Data)
    'End Sub
    'Private Sub _IMSS_Async_Data_Received(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
    '    Invoke(New InvokeWithString(AddressOf _IMSS_Sync_Output), e.Data)
    'End Sub
    'Private Sub _IMSS_Sync_Output(ByVal _IMSS_VALUE As String)

    'End Sub
    'Private Sub _IMSS_ERROR_Sync_Output(ByVal _IMSS_VALUE As String)

    'End Sub

    Private Sub _IMSS_CMD_Exited()
        _IMSS_Slide(-419, 0, 24) : Me.Location = New Point(Me.Location.X + 10, Me.Location.Y)
        MessageBox.Show("All selected drive has been successfully clean", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

#End Region
End Class
