<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class URL_Browser
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.URL_TextBox = New System.Windows.Forms.TextBox()
        Me.URL_WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.btnLINK = New System.Windows.Forms.Button()
        Me.btnREFRESH = New System.Windows.Forms.Button()
        Me.btnSTOP = New System.Windows.Forms.Button()
        Me.btnPREVIOUS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNEXT = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 367)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(549, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssLabel
        '
        Me.tssLabel.Name = "tssLabel"
        Me.tssLabel.Size = New System.Drawing.Size(103, 17)
        Me.tssLabel.Text = "目前未做任何動作"
        '
        'URL_TextBox
        '
        Me.URL_TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.URL_TextBox.Font = New System.Drawing.Font("微軟正黑體 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.URL_TextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.URL_TextBox.Location = New System.Drawing.Point(44, 12)
        Me.URL_TextBox.Name = "URL_TextBox"
        Me.URL_TextBox.Size = New System.Drawing.Size(493, 23)
        Me.URL_TextBox.TabIndex = 1
        '
        'URL_WebBrowser
        '
        Me.URL_WebBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.URL_WebBrowser.Location = New System.Drawing.Point(12, 69)
        Me.URL_WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.URL_WebBrowser.Name = "URL_WebBrowser"
        Me.URL_WebBrowser.Size = New System.Drawing.Size(525, 295)
        Me.URL_WebBrowser.TabIndex = 2
        '
        'btnLINK
        '
        Me.btnLINK.Location = New System.Drawing.Point(12, 40)
        Me.btnLINK.Name = "btnLINK"
        Me.btnLINK.Size = New System.Drawing.Size(75, 23)
        Me.btnLINK.TabIndex = 3
        Me.btnLINK.Text = "LINK"
        Me.btnLINK.UseVisualStyleBackColor = True
        '
        'btnREFRESH
        '
        Me.btnREFRESH.Location = New System.Drawing.Point(93, 40)
        Me.btnREFRESH.Name = "btnREFRESH"
        Me.btnREFRESH.Size = New System.Drawing.Size(75, 23)
        Me.btnREFRESH.TabIndex = 4
        Me.btnREFRESH.Text = "REFRESH"
        Me.btnREFRESH.UseVisualStyleBackColor = True
        '
        'btnSTOP
        '
        Me.btnSTOP.Location = New System.Drawing.Point(174, 40)
        Me.btnSTOP.Name = "btnSTOP"
        Me.btnSTOP.Size = New System.Drawing.Size(75, 23)
        Me.btnSTOP.TabIndex = 5
        Me.btnSTOP.Text = "STOP"
        Me.btnSTOP.UseVisualStyleBackColor = True
        '
        'btnPREVIOUS
        '
        Me.btnPREVIOUS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPREVIOUS.Location = New System.Drawing.Point(381, 40)
        Me.btnPREVIOUS.Name = "btnPREVIOUS"
        Me.btnPREVIOUS.Size = New System.Drawing.Size(75, 23)
        Me.btnPREVIOUS.TabIndex = 6
        Me.btnPREVIOUS.Text = "Previous"
        Me.btnPREVIOUS.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "URL"
        '
        'btnNEXT
        '
        Me.btnNEXT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNEXT.Location = New System.Drawing.Point(462, 40)
        Me.btnNEXT.Name = "btnNEXT"
        Me.btnNEXT.Size = New System.Drawing.Size(75, 23)
        Me.btnNEXT.TabIndex = 8
        Me.btnNEXT.Text = "Next"
        Me.btnNEXT.UseVisualStyleBackColor = True
        '
        'URL_Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 389)
        Me.Controls.Add(Me.btnNEXT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPREVIOUS)
        Me.Controls.Add(Me.btnSTOP)
        Me.Controls.Add(Me.btnREFRESH)
        Me.Controls.Add(Me.btnLINK)
        Me.Controls.Add(Me.URL_WebBrowser)
        Me.Controls.Add(Me.URL_TextBox)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "URL_Browser"
        Me.Text = "URL Browser"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents URL_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents tssLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents URL_WebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents btnLINK As System.Windows.Forms.Button
    Friend WithEvents btnREFRESH As System.Windows.Forms.Button
    Friend WithEvents btnSTOP As System.Windows.Forms.Button
    Friend WithEvents btnPREVIOUS As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNEXT As System.Windows.Forms.Button
End Class
