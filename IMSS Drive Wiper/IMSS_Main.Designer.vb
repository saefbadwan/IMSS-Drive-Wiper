<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_MainControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_MainControl))
        Me._IMSS_Description = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Title = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_OperPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Settings_Button = New System.Windows.Forms.Button()
        Me._IMSS_Cancel = New System.Windows.Forms.Button()
        Me._IMSS_Close = New System.Windows.Forms.Button()
        Me._IMSS_Next_Button = New System.Windows.Forms.Button()
        Me._IMSS_SelectDrive_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_DrivesHolders_Panel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ImsS_DRIVEPANEL1 = New IMSS_Drive_Wiper.IMSS_DRIVEPANEL()
        Me._IMSS_Refresh_Button = New System.Windows.Forms.PictureBox()
        Me._IMSS_MainLogo = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me._IMSS_DriveTarget = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._IMSS_StartDescription_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_OperPanel.SuspendLayout()
        Me._IMSS_DrivesHolders_Panel.SuspendLayout()
        CType(Me._IMSS_Refresh_Button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_MainLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_Description
        '
        '
        '
        '
        Me._IMSS_Description.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Description.Location = New System.Drawing.Point(61, 51)
        Me._IMSS_Description.Name = "_IMSS_Description"
        Me._IMSS_Description.Size = New System.Drawing.Size(312, 108)
        Me._IMSS_Description.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_Description.TabIndex = 6
        Me._IMSS_Description.Text = resources.GetString("_IMSS_Description.Text")
        Me._IMSS_Description.TextLineAlignment = System.Drawing.StringAlignment.Near
        Me._IMSS_Description.WordWrap = True
        '
        '_IMSS_Title
        '
        Me._IMSS_Title.AutoSize = True
        '
        '
        '
        Me._IMSS_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Title.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Title.Location = New System.Drawing.Point(47, 24)
        Me._IMSS_Title.Name = "_IMSS_Title"
        Me._IMSS_Title.Size = New System.Drawing.Size(241, 21)
        Me._IMSS_Title.TabIndex = 5
        Me._IMSS_Title.Text = "Welcome to IMSS Drive Wiper"
        '
        '_IMSS_OperPanel
        '
        Me._IMSS_OperPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_OperPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_OperPanel.Controls.Add(Me._IMSS_Settings_Button)
        Me._IMSS_OperPanel.Controls.Add(Me._IMSS_Cancel)
        Me._IMSS_OperPanel.Controls.Add(Me._IMSS_Close)
        Me._IMSS_OperPanel.Controls.Add(Me._IMSS_Next_Button)
        Me._IMSS_OperPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_OperPanel.Location = New System.Drawing.Point(0, 330)
        Me._IMSS_OperPanel.Name = "_IMSS_OperPanel"
        Me._IMSS_OperPanel.Size = New System.Drawing.Size(838, 44)
        Me._IMSS_OperPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_OperPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_OperPanel.Style.BackColor2.Color = System.Drawing.Color.LightGray
        Me._IMSS_OperPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_OperPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_OperPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me._IMSS_OperPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_OperPanel.Style.GradientAngle = 90
        Me._IMSS_OperPanel.TabIndex = 9
        '
        '_IMSS_Settings_Button
        '
        Me._IMSS_Settings_Button.Location = New System.Drawing.Point(3, 11)
        Me._IMSS_Settings_Button.Name = "_IMSS_Settings_Button"
        Me._IMSS_Settings_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Settings_Button.TabIndex = 6
        Me._IMSS_Settings_Button.Text = "Settings"
        Me._IMSS_Settings_Button.UseVisualStyleBackColor = True
        '
        '_IMSS_Cancel
        '
        Me._IMSS_Cancel.Location = New System.Drawing.Point(759, 11)
        Me._IMSS_Cancel.Name = "_IMSS_Cancel"
        Me._IMSS_Cancel.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Cancel.TabIndex = 5
        Me._IMSS_Cancel.Text = "Cancel"
        Me._IMSS_Cancel.UseVisualStyleBackColor = True
        '
        '_IMSS_Close
        '
        Me._IMSS_Close.Location = New System.Drawing.Point(256, 11)
        Me._IMSS_Close.Name = "_IMSS_Close"
        Me._IMSS_Close.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Close.TabIndex = 3
        Me._IMSS_Close.Text = "Close"
        Me._IMSS_Close.UseVisualStyleBackColor = True
        '
        '_IMSS_Next_Button
        '
        Me._IMSS_Next_Button.Location = New System.Drawing.Point(337, 11)
        Me._IMSS_Next_Button.Name = "_IMSS_Next_Button"
        Me._IMSS_Next_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Next_Button.TabIndex = 2
        Me._IMSS_Next_Button.Text = "Next"
        Me._IMSS_Next_Button.UseVisualStyleBackColor = True
        '
        '_IMSS_SelectDrive_Label
        '
        '
        '
        '
        Me._IMSS_SelectDrive_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_SelectDrive_Label.Location = New System.Drawing.Point(144, 189)
        Me._IMSS_SelectDrive_Label.Name = "_IMSS_SelectDrive_Label"
        Me._IMSS_SelectDrive_Label.Size = New System.Drawing.Size(204, 23)
        Me._IMSS_SelectDrive_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_SelectDrive_Label.TabIndex = 11
        Me._IMSS_SelectDrive_Label.Text = "Please select the drives you want to wipe : "
        '
        '_IMSS_DrivesHolders_Panel
        '
        Me._IMSS_DrivesHolders_Panel.AutoScroll = True
        Me._IMSS_DrivesHolders_Panel.Controls.Add(Me.ImsS_DRIVEPANEL1)
        Me._IMSS_DrivesHolders_Panel.Location = New System.Drawing.Point(144, 217)
        Me._IMSS_DrivesHolders_Panel.Name = "_IMSS_DrivesHolders_Panel"
        Me._IMSS_DrivesHolders_Panel.Size = New System.Drawing.Size(257, 100)
        Me._IMSS_DrivesHolders_Panel.TabIndex = 0
        '
        'ImsS_DRIVEPANEL1
        '
        Me.ImsS_DRIVEPANEL1._IMSS_CHECK_STATUS = True
        Me.ImsS_DRIVEPANEL1._IMSS_DRIVE_NAME = "G:\"
        Me.ImsS_DRIVEPANEL1._IMSS_STATUS_IMAGE = CType(resources.GetObject("ImsS_DRIVEPANEL1._IMSS_STATUS_IMAGE"), System.Drawing.Image)
        Me.ImsS_DRIVEPANEL1.Location = New System.Drawing.Point(3, 3)
        Me.ImsS_DRIVEPANEL1.Name = "ImsS_DRIVEPANEL1"
        Me.ImsS_DRIVEPANEL1.Size = New System.Drawing.Size(229, 34)
        Me.ImsS_DRIVEPANEL1.TabIndex = 0
        '
        '_IMSS_Refresh_Button
        '
        Me._IMSS_Refresh_Button.Image = Global.IMSS_Drive_Wiper.My.Resources.Resources._IMSS_Refresh_Icon_16x16
        Me._IMSS_Refresh_Button.Location = New System.Drawing.Point(365, 194)
        Me._IMSS_Refresh_Button.Name = "_IMSS_Refresh_Button"
        Me._IMSS_Refresh_Button.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_Refresh_Button.TabIndex = 12
        Me._IMSS_Refresh_Button.TabStop = False
        '
        '_IMSS_MainLogo
        '
        Me._IMSS_MainLogo.Image = CType(resources.GetObject("_IMSS_MainLogo.Image"), System.Drawing.Image)
        Me._IMSS_MainLogo.Location = New System.Drawing.Point(12, 229)
        Me._IMSS_MainLogo.Name = "_IMSS_MainLogo"
        Me._IMSS_MainLogo.Size = New System.Drawing.Size(96, 96)
        Me._IMSS_MainLogo.TabIndex = 8
        Me._IMSS_MainLogo.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(430, 92)
        Me.ProgressBar1.MarqueeAnimationSpeed = 4
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(372, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 13
        '
        '_IMSS_DriveTarget
        '
        Me._IMSS_DriveTarget.AutoSize = True
        '
        '
        '
        Me._IMSS_DriveTarget.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_DriveTarget.Location = New System.Drawing.Point(454, 71)
        Me._IMSS_DriveTarget.Name = "_IMSS_DriveTarget"
        Me._IMSS_DriveTarget.Size = New System.Drawing.Size(79, 15)
        Me._IMSS_DriveTarget.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_DriveTarget.TabIndex = 14
        Me._IMSS_DriveTarget.Text = "Current Drive : "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(432, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        '_IMSS_StartDescription_Label
        '
        Me._IMSS_StartDescription_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_StartDescription_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_StartDescription_Label.Location = New System.Drawing.Point(432, 121)
        Me._IMSS_StartDescription_Label.Name = "_IMSS_StartDescription_Label"
        Me._IMSS_StartDescription_Label.Size = New System.Drawing.Size(294, 15)
        Me._IMSS_StartDescription_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_StartDescription_Label.TabIndex = 17
        Me._IMSS_StartDescription_Label.Text = "Please wait this process will take from 1 minutes to 4 minutes"
        '
        'IMSS_MainControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_StartDescription_Label)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me._IMSS_DriveTarget)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me._IMSS_Refresh_Button)
        Me.Controls.Add(Me._IMSS_DrivesHolders_Panel)
        Me.Controls.Add(Me._IMSS_SelectDrive_Label)
        Me.Controls.Add(Me._IMSS_OperPanel)
        Me.Controls.Add(Me._IMSS_MainLogo)
        Me.Controls.Add(Me._IMSS_Description)
        Me.Controls.Add(Me._IMSS_Title)
        Me.Name = "IMSS_MainControl"
        Me.Size = New System.Drawing.Size(838, 374)
        Me._IMSS_OperPanel.ResumeLayout(False)
        Me._IMSS_DrivesHolders_Panel.ResumeLayout(False)
        CType(Me._IMSS_Refresh_Button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_MainLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _IMSS_MainLogo As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Description As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Title As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_OperPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_SelectDrive_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_DrivesHolders_Panel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ImsS_DRIVEPANEL1 As IMSS_Drive_Wiper.IMSS_DRIVEPANEL
    Friend WithEvents _IMSS_Refresh_Button As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Close As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Next_Button As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Cancel As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Settings_Button As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents _IMSS_DriveTarget As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_StartDescription_Label As DevComponents.DotNetBar.LabelX

End Class
