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
        Me.btnTestPost.Location = New System.Drawing.Point(684, 405)
        Me.btnTestPost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTestPost.Name = "btnTestPost"
        Me.btnTestPost.Size = New System.Drawing.Size(100, 29)
        Me.btnTestPost.TabIndex = 0
        Me.btnTestPost.Text = "Start"
        Me.btnTestPost.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "回傳: "
        '
        'btn_ClearAll
        '
        Me.btn_ClearAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ClearAll.Location = New System.Drawing.Point(796, 405)
        Me.btn_ClearAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_ClearAll.Name = "btn_ClearAll"
        Me.btn_ClearAll.Size = New System.Drawing.Size(100, 29)
        Me.btn_ClearAll.TabIndex = 3
        Me.btn_ClearAll.Text = "ClearALL"
        Me.btn_ClearAll.UseVisualStyleBackColor = True
        '
        'URL_TextBox
        '
        Me.URL_TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.URL_TextBox.Location = New System.Drawing.Point(65, 41)
        Me.URL_TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.URL_TextBox.Name = "URL_TextBox"
        Me.URL_TextBox.Size = New System.Drawing.Size(717, 25)
        Me.URL_TextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "URL: "
        '
        'btnDirectLink
        '
        Me.btnDirectLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDirectLink.Location = New System.Drawing.Point(792, 41)
        Me.btnDirectLink.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDirectLink.Name = "btnDirectLink"
        Me.btnDirectLink.Size = New System.Drawing.Size(100, 29)
        Me.btnDirectLink.TabIndex = 6
        Me.btnDirectLink.Text = "直接連結"
        Me.btnDirectLink.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 453)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(912, 25)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssLabel
        '
        Me.tssLabel.Name = "tssLabel"
        Me.tssLabel.Size = New System.Drawing.Size(129, 19)
        Me.tssLabel.Text = "目前未做任何動作"
        '
        'MESSAGE_LOG
        '
        Me.MESSAGE_LOG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MESSAGE_LOG.Location = New System.Drawing.Point(17, 115)
        Me.MESSAGE_LOG.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MESSAGE_LOG.Multiline = True
        Me.MESSAGE_LOG.Name = "MESSAGE_LOG"
        Me.MESSAGE_LOG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MESSAGE_LOG.Size = New System.Drawing.Size(872, 230)
        Me.MESSAGE_LOG.TabIndex = 11
        '
        'tbSelectXML
        '
        Me.tbSelectXML.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSelectXML.Location = New System.Drawing.Point(65, 6)
        Me.tbSelectXML.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbSelectXML.Name = "tbSelectXML"
        Me.tbSelectXML.Size = New System.Drawing.Size(717, 25)
        Me.tbSelectXML.TabIndex = 13
        '
        'btnSelectXML
        '
        Me.btnSelectXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectXML.Location = New System.Drawing.Point(791, 6)
        Me.btnSelectXML.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSelectXML.Name = "btnSelectXML"
        Me.btnSelectXML.Size = New System.Drawing.Size(100, 29)
        Me.btnSelectXML.TabIndex = 14
        Me.btnSelectXML.Text = "選擇XML"
        Me.btnSelectXML.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "File: "
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(431, 385)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "每次POST筆數"
        '
        'txtPostTimes
        '
        Me.txtPostTimes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPostTimes.Location = New System.Drawing.Point(545, 381)
        Me.txtPostTimes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPostTimes.Name = "txtPostTimes"
        Me.txtPostTimes.Size = New System.Drawing.Size(73, 25)
        Me.txtPostTimes.TabIndex = 17
        Me.txtPostTimes.Text = "1"
        Me.txtPostTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 385)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "每次間隔時間(秒)"
        '
        'txtSecond
        '
        Me.txtSecond.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSecond.Location = New System.Drawing.Point(348, 381)
        Me.txtSecond.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(73, 25)
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
        Me.txtCircle.Location = New System.Drawing.Point(128, 381)
        Me.txtCircle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCircle.Name = "txtCircle"
        Me.txtCircle.Size = New System.Drawing.Size(73, 25)
        Me.txtCircle.TabIndex = 20
        Me.txtCircle.Text = "1"
        Me.txtCircle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 385)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "循環執行次數"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(276, 419)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "間隔時間(秒)倒數:"
        '
        'lblSecond
        '
        Me.lblSecond.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Location = New System.Drawing.Point(405, 419)
        Me.lblSecond.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(82, 15)
        Me.lblSecond.TabIndex = 23
        Me.lblSecond.Text = "送出後倒數"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 419)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 15)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "目前執行之剩餘次數:"
        '
        'lblTimes
        '
        Me.lblTimes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTimes.AutoSize = True
        Me.lblTimes.Location = New System.Drawing.Point(167, 419)
        Me.lblTimes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimes.Name = "lblTimes"
        Me.lblTimes.Size = New System.Drawing.Size(82, 15)
        Me.lblTimes.TabIndex = 25
        Me.lblTimes.Text = "送出後倒數"
        '
        'chkLoop
        '
        Me.chkLoop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkLoop.AutoSize = True
        Me.chkLoop.Location = New System.Drawing.Point(19, 362)
        Me.chkLoop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkLoop.Name = "chkLoop"
        Me.chkLoop.Size = New System.Drawing.Size(86, 19)
        Me.chkLoop.TabIndex = 27
        Me.chkLoop.Text = "無限循環"
        Me.chkLoop.UseVisualStyleBackColor = True
        '
        'MasterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 478)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(927, 513)
        Me.Name = "MasterForm"
        Me.Text = "POST TEST"
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
