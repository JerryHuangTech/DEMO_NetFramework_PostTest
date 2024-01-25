<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnTestPost = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_ClearAll = New System.Windows.Forms.Button()
        Me.URL_TextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDirectLink = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MESSAGE_LOG = New System.Windows.Forms.TextBox()
        Me.tbSelectXML = New System.Windows.Forms.TextBox()
        Me.btnSelectXML = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPostTimes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtCircle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTimes = New System.Windows.Forms.Label()
        Me.chkLoop = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTestPost
        '
        Me.btnTestPost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTestPost.Location = New System.Drawing.Point(513, 324)
        Me.btnTestPost.Name = "btnTestPost"
        Me.btnTestPost.Size = New System.Drawing.Size(75, 23)
        Me.btnTestPost.TabIndex = 0
        Me.btnTestPost.Text = "Start"
        Me.btnTestPost.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "回傳: "
        '
        'btn_ClearAll
        '
        Me.btn_ClearAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ClearAll.Location = New System.Drawing.Point(597, 324)
        Me.btn_ClearAll.Name = "btn_ClearAll"
        Me.btn_ClearAll.Size = New System.Drawing.Size(75, 23)
        Me.btn_ClearAll.TabIndex = 3
        Me.btn_ClearAll.Text = "ClearALL"
        Me.btn_ClearAll.UseVisualStyleBackColor = True
        '
        'URL_TextBox
        '
        Me.URL_TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.URL_TextBox.Location = New System.Drawing.Point(49, 33)
        Me.URL_TextBox.Name = "URL_TextBox"
        Me.URL_TextBox.Size = New System.Drawing.Size(539, 22)
        Me.URL_TextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "URL: "
        '
        'btnDirectLink
        '
        Me.btnDirectLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDirectLink.Location = New System.Drawing.Point(594, 33)
        Me.btnDirectLink.Name = "btnDirectLink"
        Me.btnDirectLink.Size = New System.Drawing.Size(75, 23)
        Me.btnDirectLink.TabIndex = 6
        Me.btnDirectLink.Text = "直接連結"
        Me.btnDirectLink.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 360)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(684, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssLabel
        '
        Me.tssLabel.Name = "tssLabel"
        Me.tssLabel.Size = New System.Drawing.Size(104, 17)
        Me.tssLabel.Text = "目前未做任何動作"
        '
        'MESSAGE_LOG
        '
        Me.MESSAGE_LOG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MESSAGE_LOG.Location = New System.Drawing.Point(13, 92)
        Me.MESSAGE_LOG.Multiline = True
        Me.MESSAGE_LOG.Name = "MESSAGE_LOG"
        Me.MESSAGE_LOG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MESSAGE_LOG.Size = New System.Drawing.Size(655, 185)
        Me.MESSAGE_LOG.TabIndex = 11
        '
        'tbSelectXML
        '
        Me.tbSelectXML.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSelectXML.Location = New System.Drawing.Point(49, 5)
        Me.tbSelectXML.Name = "tbSelectXML"
        Me.tbSelectXML.Size = New System.Drawing.Size(539, 22)
        Me.tbSelectXML.TabIndex = 13
        '
        'btnSelectXML
        '
        Me.btnSelectXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectXML.Location = New System.Drawing.Point(593, 5)
        Me.btnSelectXML.Name = "btnSelectXML"
        Me.btnSelectXML.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectXML.TabIndex = 14
        Me.btnSelectXML.Text = "選擇XML"
        Me.btnSelectXML.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 12)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "File: "
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(323, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 12)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "每次POST筆數"
        '
        'txtPostTimes
        '
        Me.txtPostTimes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPostTimes.Location = New System.Drawing.Point(409, 305)
        Me.txtPostTimes.Name = "txtPostTimes"
        Me.txtPostTimes.Size = New System.Drawing.Size(56, 22)
        Me.txtPostTimes.TabIndex = 17
        Me.txtPostTimes.Text = "1"
        Me.txtPostTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(158, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 12)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "每次間隔時間(秒)"
        '
        'txtSecond
        '
        Me.txtSecond.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSecond.Location = New System.Drawing.Point(261, 305)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(56, 22)
        Me.txtSecond.TabIndex = 19
        Me.txtSecond.Text = "0"
        Me.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'txtCircle
        '
        Me.txtCircle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCircle.Location = New System.Drawing.Point(96, 305)
        Me.txtCircle.Name = "txtCircle"
        Me.txtCircle.Size = New System.Drawing.Size(56, 22)
        Me.txtCircle.TabIndex = 20
        Me.txtCircle.Text = "1"
        Me.txtCircle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 12)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "循環執行次數"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(207, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 12)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "間隔時間(秒)倒數:"
        '
        'lblSecond
        '
        Me.lblSecond.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Location = New System.Drawing.Point(304, 335)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(65, 12)
        Me.lblSecond.TabIndex = 23
        Me.lblSecond.Text = "送出後倒數"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 335)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 12)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "目前執行之剩餘次數:"
        '
        'lblTimes
        '
        Me.lblTimes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTimes.AutoSize = True
        Me.lblTimes.Location = New System.Drawing.Point(125, 335)
        Me.lblTimes.Name = "lblTimes"
        Me.lblTimes.Size = New System.Drawing.Size(65, 12)
        Me.lblTimes.TabIndex = 25
        Me.lblTimes.Text = "送出後倒數"
        '
        'chkLoop
        '
        Me.chkLoop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkLoop.AutoSize = True
        Me.chkLoop.Location = New System.Drawing.Point(14, 289)
        Me.chkLoop.Name = "chkLoop"
        Me.chkLoop.Size = New System.Drawing.Size(72, 16)
        Me.chkLoop.TabIndex = 27
        Me.chkLoop.Text = "無限循環"
        Me.chkLoop.UseVisualStyleBackColor = True
        '
        'MasterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 382)
        Me.Controls.Add(Me.chkLoop)
        Me.Controls.Add(Me.lblTimes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCircle)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPostTimes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSelectXML)
        Me.Controls.Add(Me.tbSelectXML)
        Me.Controls.Add(Me.MESSAGE_LOG)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnDirectLink)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.URL_TextBox)
        Me.Controls.Add(Me.btn_ClearAll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTestPost)
        Me.MinimumSize = New System.Drawing.Size(700, 420)
        Me.Name = "MasterForm"
        Me.Text = "GSS POST TEST"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTestPost As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_ClearAll As System.Windows.Forms.Button
    Friend WithEvents URL_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDirectLink As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MESSAGE_LOG As System.Windows.Forms.TextBox
    Friend WithEvents tbSelectXML As TextBox
    Friend WithEvents btnSelectXML As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPostTimes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtCircle As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSecond As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTimes As Label
    Friend WithEvents chkLoop As CheckBox
End Class
