Namespace Forms.OptionsPages
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UpdatesPage
        Inherits OptionsPage

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdatesPage))
            Me.lblUpdatesExplanation = New System.Windows.Forms.Label()
            Me.btnUpdateCheckNow = New System.Windows.Forms.Button()
            Me.chkCheckForUpdatesOnStartup = New System.Windows.Forms.CheckBox()
            Me.cboUpdateCheckFrequency = New System.Windows.Forms.ComboBox()
            Me.lblProxyAddress = New System.Windows.Forms.Label()
            Me.txtProxyAddress = New System.Windows.Forms.TextBox()
            Me.lblProxyPort = New System.Windows.Forms.Label()
            Me.numProxyPort = New System.Windows.Forms.NumericUpDown()
            Me.chkUseProxyForAutomaticUpdates = New System.Windows.Forms.CheckBox()
            Me.chkUseProxyAuthentication = New System.Windows.Forms.CheckBox()
            Me.lblProxyUsername = New System.Windows.Forms.Label()
            Me.txtProxyUsername = New System.Windows.Forms.TextBox()
            Me.lblProxyPassword = New System.Windows.Forms.Label()
            Me.txtProxyPassword = New System.Windows.Forms.TextBox()
            Me.btnTestProxy = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            CType(Me.numProxyPort, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblUpdatesExplanation
            '
            Me.lblUpdatesExplanation.Location = New System.Drawing.Point(3, 0)
            Me.lblUpdatesExplanation.Name = "lblUpdatesExplanation"
            Me.lblUpdatesExplanation.Size = New System.Drawing.Size(604, 26)
            Me.lblUpdatesExplanation.TabIndex = 3
            Me.lblUpdatesExplanation.Text = "mRemoteNG can periodically connect to the mRemoteNG website to check for updates " &
    "and product announcements."
            '
            'btnUpdateCheckNow
            '
            Me.btnUpdateCheckNow.Location = New System.Drawing.Point(241, 41)
            Me.btnUpdateCheckNow.Name = "btnUpdateCheckNow"
            Me.btnUpdateCheckNow.Size = New System.Drawing.Size(120, 32)
            Me.btnUpdateCheckNow.TabIndex = 2
            Me.btnUpdateCheckNow.Text = "Check Now"
            Me.btnUpdateCheckNow.UseVisualStyleBackColor = True
            '
            'chkCheckForUpdatesOnStartup
            '
            Me.chkCheckForUpdatesOnStartup.AutoSize = True
            Me.chkCheckForUpdatesOnStartup.Location = New System.Drawing.Point(6, 29)
            Me.chkCheckForUpdatesOnStartup.Name = "chkCheckForUpdatesOnStartup"
            Me.chkCheckForUpdatesOnStartup.Size = New System.Drawing.Size(213, 17)
            Me.chkCheckForUpdatesOnStartup.TabIndex = 0
            Me.chkCheckForUpdatesOnStartup.Text = "Check for updates and announcements"
            Me.chkCheckForUpdatesOnStartup.UseVisualStyleBackColor = True
            '
            'cboUpdateCheckFrequency
            '
            Me.cboUpdateCheckFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboUpdateCheckFrequency.FormattingEnabled = True
            Me.cboUpdateCheckFrequency.Location = New System.Drawing.Point(22, 52)
            Me.cboUpdateCheckFrequency.Name = "cboUpdateCheckFrequency"
            Me.cboUpdateCheckFrequency.Size = New System.Drawing.Size(128, 21)
            Me.cboUpdateCheckFrequency.TabIndex = 1
            '
            'lblProxyAddress
            '
            Me.lblProxyAddress.Location = New System.Drawing.Point(13, 39)
            Me.lblProxyAddress.Name = "lblProxyAddress"
            Me.lblProxyAddress.Size = New System.Drawing.Size(96, 24)
            Me.lblProxyAddress.TabIndex = 0
            Me.lblProxyAddress.Text = "Address:"
            Me.lblProxyAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtProxyAddress
            '
            Me.txtProxyAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtProxyAddress.Location = New System.Drawing.Point(115, 43)
            Me.txtProxyAddress.Name = "txtProxyAddress"
            Me.txtProxyAddress.Size = New System.Drawing.Size(240, 20)
            Me.txtProxyAddress.TabIndex = 1
            '
            'lblProxyPort
            '
            Me.lblProxyPort.Location = New System.Drawing.Point(361, 43)
            Me.lblProxyPort.Name = "lblProxyPort"
            Me.lblProxyPort.Size = New System.Drawing.Size(64, 23)
            Me.lblProxyPort.TabIndex = 2
            Me.lblProxyPort.Text = "Port:"
            Me.lblProxyPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numProxyPort
            '
            Me.numProxyPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numProxyPort.Location = New System.Drawing.Point(431, 46)
            Me.numProxyPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
            Me.numProxyPort.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numProxyPort.Name = "numProxyPort"
            Me.numProxyPort.Size = New System.Drawing.Size(64, 20)
            Me.numProxyPort.TabIndex = 3
            Me.numProxyPort.Value = New Decimal(New Integer() {80, 0, 0, 0})
            '
            'chkUseProxyForAutomaticUpdates
            '
            Me.chkUseProxyForAutomaticUpdates.AutoSize = True
            Me.chkUseProxyForAutomaticUpdates.Location = New System.Drawing.Point(16, 19)
            Me.chkUseProxyForAutomaticUpdates.Name = "chkUseProxyForAutomaticUpdates"
            Me.chkUseProxyForAutomaticUpdates.Size = New System.Drawing.Size(168, 17)
            Me.chkUseProxyForAutomaticUpdates.TabIndex = 0
            Me.chkUseProxyForAutomaticUpdates.Text = "Use a proxy server to connect"
            Me.chkUseProxyForAutomaticUpdates.UseVisualStyleBackColor = True
            '
            'chkUseProxyAuthentication
            '
            Me.chkUseProxyAuthentication.AutoSize = True
            Me.chkUseProxyAuthentication.Enabled = False
            Me.chkUseProxyAuthentication.Location = New System.Drawing.Point(16, 69)
            Me.chkUseProxyAuthentication.Name = "chkUseProxyAuthentication"
            Me.chkUseProxyAuthentication.Size = New System.Drawing.Size(216, 17)
            Me.chkUseProxyAuthentication.TabIndex = 2
            Me.chkUseProxyAuthentication.Text = "This proxy server requires authentication"
            Me.chkUseProxyAuthentication.UseVisualStyleBackColor = True
            '
            'lblProxyUsername
            '
            Me.lblProxyUsername.Location = New System.Drawing.Point(13, 89)
            Me.lblProxyUsername.Name = "lblProxyUsername"
            Me.lblProxyUsername.Size = New System.Drawing.Size(96, 24)
            Me.lblProxyUsername.TabIndex = 0
            Me.lblProxyUsername.Text = "Username:"
            Me.lblProxyUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtProxyUsername
            '
            Me.txtProxyUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtProxyUsername.Location = New System.Drawing.Point(109, 93)
            Me.txtProxyUsername.Name = "txtProxyUsername"
            Me.txtProxyUsername.Size = New System.Drawing.Size(240, 20)
            Me.txtProxyUsername.TabIndex = 1
            '
            'lblProxyPassword
            '
            Me.lblProxyPassword.Location = New System.Drawing.Point(13, 121)
            Me.lblProxyPassword.Name = "lblProxyPassword"
            Me.lblProxyPassword.Size = New System.Drawing.Size(96, 24)
            Me.lblProxyPassword.TabIndex = 2
            Me.lblProxyPassword.Text = "Password:"
            Me.lblProxyPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtProxyPassword
            '
            Me.txtProxyPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtProxyPassword.Location = New System.Drawing.Point(109, 125)
            Me.txtProxyPassword.Name = "txtProxyPassword"
            Me.txtProxyPassword.Size = New System.Drawing.Size(240, 20)
            Me.txtProxyPassword.TabIndex = 3
            Me.txtProxyPassword.UseSystemPasswordChar = True
            '
            'btnTestProxy
            '
            Me.btnTestProxy.Location = New System.Drawing.Point(16, 151)
            Me.btnTestProxy.Name = "btnTestProxy"
            Me.btnTestProxy.Size = New System.Drawing.Size(120, 32)
            Me.btnTestProxy.TabIndex = 4
            Me.btnTestProxy.Text = "Test Proxy"
            Me.btnTestProxy.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.chkUseProxyForAutomaticUpdates)
            Me.GroupBox1.Controls.Add(Me.btnTestProxy)
            Me.GroupBox1.Controls.Add(Me.lblProxyUsername)
            Me.GroupBox1.Controls.Add(Me.txtProxyUsername)
            Me.GroupBox1.Controls.Add(Me.lblProxyAddress)
            Me.GroupBox1.Controls.Add(Me.txtProxyAddress)
            Me.GroupBox1.Controls.Add(Me.lblProxyPassword)
            Me.GroupBox1.Controls.Add(Me.lblProxyPort)
            Me.GroupBox1.Controls.Add(Me.txtProxyPassword)
            Me.GroupBox1.Controls.Add(Me.numProxyPort)
            Me.GroupBox1.Controls.Add(Me.chkUseProxyAuthentication)
            Me.GroupBox1.Location = New System.Drawing.Point(6, 79)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(601, 197)
            Me.GroupBox1.TabIndex = 5
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Proxy"
            '
            'UpdatesPage
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.btnUpdateCheckNow)
            Me.Controls.Add(Me.lblUpdatesExplanation)
            Me.Controls.Add(Me.cboUpdateCheckFrequency)
            Me.Controls.Add(Me.chkCheckForUpdatesOnStartup)
            Me.Name = "UpdatesPage"
            Me.PageIcon = CType(resources.GetObject("$this.PageIcon"), System.Drawing.Icon)
            Me.Size = New System.Drawing.Size(610, 489)
            CType(Me.numProxyPort, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblUpdatesExplanation As System.Windows.Forms.Label
        Friend WithEvents btnUpdateCheckNow As System.Windows.Forms.Button
        Friend WithEvents chkCheckForUpdatesOnStartup As System.Windows.Forms.CheckBox
        Friend WithEvents cboUpdateCheckFrequency As System.Windows.Forms.ComboBox
        Friend WithEvents lblProxyAddress As Label
        Friend WithEvents txtProxyAddress As TextBox
        Friend WithEvents lblProxyPort As Label
        Friend WithEvents numProxyPort As NumericUpDown
        Friend WithEvents chkUseProxyForAutomaticUpdates As CheckBox
        Friend WithEvents chkUseProxyAuthentication As CheckBox
        Friend WithEvents lblProxyUsername As Label
        Friend WithEvents txtProxyUsername As TextBox
        Friend WithEvents lblProxyPassword As Label
        Friend WithEvents txtProxyPassword As TextBox
        Friend WithEvents btnTestProxy As Button
        Friend WithEvents GroupBox1 As GroupBox
    End Class
End Namespace