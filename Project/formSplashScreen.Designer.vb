<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formSplashScreen))
        Me.labelCompanyName = New System.Windows.Forms.Label()
        Me.labelAppTitle = New System.Windows.Forms.Label()
        Me.labelCopyright = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelCompanyName
        '
        Me.labelCompanyName.BackColor = System.Drawing.Color.Transparent
        Me.labelCompanyName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCompanyName.ForeColor = System.Drawing.Color.Gold
        Me.labelCompanyName.Location = New System.Drawing.Point(22, 56)
        Me.labelCompanyName.Name = "labelCompanyName"
        Me.labelCompanyName.Size = New System.Drawing.Size(513, 23)
        Me.labelCompanyName.TabIndex = 6
        Me.labelCompanyName.Text = "CompanyName"
        Me.labelCompanyName.UseWaitCursor = True
        '
        'labelAppTitle
        '
        Me.labelAppTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelAppTitle.BackColor = System.Drawing.Color.Transparent
        Me.labelAppTitle.Font = New System.Drawing.Font("Tahoma", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAppTitle.ForeColor = System.Drawing.Color.White
        Me.labelAppTitle.Location = New System.Drawing.Point(15, 72)
        Me.labelAppTitle.Name = "labelAppTitle"
        Me.labelAppTitle.Size = New System.Drawing.Size(520, 71)
        Me.labelAppTitle.TabIndex = 7
        Me.labelAppTitle.Text = "Title"
        Me.labelAppTitle.UseWaitCursor = True
        '
        'labelCopyright
        '
        Me.labelCopyright.BackColor = System.Drawing.Color.Transparent
        Me.labelCopyright.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCopyright.ForeColor = System.Drawing.Color.White
        Me.labelCopyright.Location = New System.Drawing.Point(12, 342)
        Me.labelCopyright.Name = "labelCopyright"
        Me.labelCopyright.Size = New System.Drawing.Size(523, 16)
        Me.labelCopyright.TabIndex = 8
        Me.labelCopyright.Text = "Copyright"
        Me.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.labelCopyright.UseWaitCursor = True
        '
        'formSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(548, 367)
        Me.ControlBox = False
        Me.Controls.Add(Me.labelCopyright)
        Me.Controls.Add(Me.labelCompanyName)
        Me.Controls.Add(Me.labelAppTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents labelCompanyName As System.Windows.Forms.Label
    Friend WithEvents labelAppTitle As System.Windows.Forms.Label
    Friend WithEvents labelCopyright As System.Windows.Forms.Label

End Class
