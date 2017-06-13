<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_DRIVEPANEL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_DRIVEPANEL))
        Me._IMSS_MainPanl = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_MainCeckBox_CheckBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me._IMSS_DriverName_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Drive_Logo = New System.Windows.Forms.PictureBox()
        Me._IMSS_MainPanl.SuspendLayout()
        CType(Me._IMSS_Drive_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanl
        '
        Me._IMSS_MainPanl.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanl.Controls.Add(Me._IMSS_Drive_Logo)
        Me._IMSS_MainPanl.Controls.Add(Me._IMSS_DriverName_Label)
        Me._IMSS_MainPanl.Controls.Add(Me._IMSS_MainCeckBox_CheckBox)
        Me._IMSS_MainPanl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanl.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanl.Name = "_IMSS_MainPanl"
        Me._IMSS_MainPanl.Size = New System.Drawing.Size(229, 34)
        Me._IMSS_MainPanl.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanl.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me._IMSS_MainPanl.Style.BackColor2.Color = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MainPanl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanl.Style.BorderColor.Color = System.Drawing.Color.Silver
        Me._IMSS_MainPanl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanl.Style.GradientAngle = 90
        Me._IMSS_MainPanl.TabIndex = 0
        '
        '_IMSS_MainCeckBox_CheckBox
        '
        '
        '
        '
        Me._IMSS_MainCeckBox_CheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_MainCeckBox_CheckBox.Checked = True
        Me._IMSS_MainCeckBox_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me._IMSS_MainCeckBox_CheckBox.CheckValue = "Y"
        Me._IMSS_MainCeckBox_CheckBox.Dock = System.Windows.Forms.DockStyle.Left
        Me._IMSS_MainCeckBox_CheckBox.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainCeckBox_CheckBox.Name = "_IMSS_MainCeckBox_CheckBox"
        Me._IMSS_MainCeckBox_CheckBox.Size = New System.Drawing.Size(19, 34)
        Me._IMSS_MainCeckBox_CheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainCeckBox_CheckBox.TabIndex = 1
        '
        '_IMSS_DriverName_Label
        '
        Me._IMSS_DriverName_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_DriverName_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_DriverName_Label.Location = New System.Drawing.Point(22, 8)
        Me._IMSS_DriverName_Label.Name = "_IMSS_DriverName_Label"
        Me._IMSS_DriverName_Label.Size = New System.Drawing.Size(17, 15)
        Me._IMSS_DriverName_Label.TabIndex = 2
        Me._IMSS_DriverName_Label.Text = "G:\"
        '
        '_IMSS_Drive_Logo
        '
        Me._IMSS_Drive_Logo.Image = CType(resources.GetObject("_IMSS_Drive_Logo.Image"), System.Drawing.Image)
        Me._IMSS_Drive_Logo.Location = New System.Drawing.Point(210, 6)
        Me._IMSS_Drive_Logo.Name = "_IMSS_Drive_Logo"
        Me._IMSS_Drive_Logo.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_Drive_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_Drive_Logo.TabIndex = 3
        Me._IMSS_Drive_Logo.TabStop = False
        '
        'IMSS_DRIVEPANEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_MainPanl)
        Me.Name = "IMSS_DRIVEPANEL"
        Me.Size = New System.Drawing.Size(229, 34)
        Me._IMSS_MainPanl.ResumeLayout(False)
        Me._IMSS_MainPanl.PerformLayout()
        CType(Me._IMSS_Drive_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanl As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_DriverName_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_MainCeckBox_CheckBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents _IMSS_Drive_Logo As System.Windows.Forms.PictureBox

End Class
