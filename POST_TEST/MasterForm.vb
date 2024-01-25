Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Reflection
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Windows.Forms
Imports System.Configuration
Imports System.Diagnostics
Imports System.Threading

Public Class MasterForm


#Region "必要元素"
    'Create the Open file object
    Dim ofd As New OpenFileDialog()

    'Create the XmlDocument.
    Dim doc As XmlDocument = New XmlDocument()

    ' This integer variable keeps track of the 
    ' remaining time.
    Public timeLeft As Integer = 0

    Public circle As Integer = 0
    Public circleMark As Integer = 0

    Public strSoapXML As String = ""
#End Region

#Region "主程式"
    ''' <summary>
    ''' 針對傳統HTTP POST的路徑設計
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MasterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tssLabel.Text = CStr(MethodInfo.GetCurrentMethod.Name)
        Me.URL_TextBox.Text = CommonClass.GetConfigValue("URL")
    End Sub

    Private Sub btnDirectLink_Click(sender As Object, e As EventArgs) Handles btnDirectLink.Click
        Me.tssLabel.Text = CStr(MethodInfo.GetCurrentMethod.Name)
        Dim URL_B As New URL_Browser
        URL_B.URL_TextBox.Text = Me.URL_TextBox.Text
        URL_B.Show()

    End Sub

    Private Sub btn_ClearAll_Click(sender As Object, e As EventArgs) Handles btn_ClearAll.Click
        ClearTXTBOX()
    End Sub

    Private Sub ClearTXTBOX()
        Me.tssLabel.Text = CStr(MethodInfo.GetCurrentMethod.Name)
        MESSAGE_LOG.Text = ""
    End Sub

    ''' <summary>
    ''' 檢查DataTable的每個 cell value 不會是Nothing或Null
    ''' </summary>
    ''' <param name="CheckRowData">需要被檢查與轉換為String.Trim的DataRow之Cell</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Check_Cell_NonNULL(ByVal CheckRowData As Object) As String
        Dim objTemp_GoalData As New Object
        objTemp_GoalData = CheckRowData
        Try
            '空則回傳空字串，以免停止，此外也能遏止發生Nothing錯誤，例如該Cell需要被Trim會Catch
            If objTemp_GoalData Is DBNull.Value OrElse objTemp_GoalData Is Nothing Then
                Return ""
            Else '若有值轉String並且Trim
                Return objTemp_GoalData.ToString.Trim
            End If
        Catch ex As Exception
            Return ""
        End Try

        objTemp_GoalData = Nothing
    End Function


    ''' <summary>
    ''' 開啟XML控制
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSelectXML_Click(sender As Object, e As EventArgs) Handles btnSelectXML.Click
        ofd.Filter = "XML|*.xml"
        If ofd.ShowDialog = DialogResult.OK Then
            tbSelectXML.Text = ofd.FileName

            'ReLoad xml doc
            doc = New XmlDocument
            doc.Load(ofd.FileName)

        End If
    End Sub



    'Private Sub InitializeTimer()
    '    ' Run this procedure in an appropriate event.
    '    Timer1.Interval = 600
    '    Timer1.Enabled = True
    'End Sub

    ''' <summary>
    ''' POST控制器
    ''' </summary>
    Private Sub PostController()
        Dim numPost As Integer = 1
        Try
            numPost = If(CommonClass.ConvertNullToEmpty(Me.txtPostTimes.Text) <> "" Or "0", CInt(Me.txtPostTimes.Text), 1)
        Catch ex As Exception
            MsgBox("你的" + txtPostTimes.Name + "應該要數字，系統主動傳" + CStr(numPost))
        End Try

        timeLeft = 0
        Try
            timeLeft = If(CommonClass.ConvertNullToEmpty(Me.txtSecond.Text) <> "", CInt(Me.txtSecond.Text), 0)
        Catch ex As Exception
            MsgBox("你的" + txtSecond.Name + "應該要數字，系統主動傳" + CStr(timeLeft))
        End Try


        circleMark += 1
        Me.MESSAGE_LOG.Text += "==循環 第[" + CStr(Me.circleMark) + "]次＝＝＊" + Environment.NewLine

        Dim time As Integer = 1
        For i As Integer = 1 To numPost
            Me.MESSAGE_LOG.Text += "==POST 第[" + CStr(i) + "]筆＝＝＊" + Environment.NewLine
            'If timeLeft = 0 Or i = 1 Then
            PostFuncation()
            'Else
            '    ''暫停秒數
            '    Me.MESSAGE_LOG.Text += "==SLEEP[" + CStr(timeLeft) + "]Sec. START==" + Environment.NewLine
            '    Thread.Sleep(timeLeft * 1000)
            '    PostFuncation()
            'End If
        Next

        LogWriter.WriteInfo(Me.MESSAGE_LOG.Text)
    End Sub



    '多工可參考這段配合 https://msdn.microsoft.com/zh-tw/library/system.threading.thread(v=vs.110).aspx
    'https://stackoverflow.com/questions/25911816/multi-threading-with-return-value-vb-net
    '一下去就是跑好幾個
    '          LogWriter.WriteLog("●ThreadVolume Start")
    '        Dim ThreadVolume As New System.Threading.Thread(AddressOf  你要執行的function，可有可無的回傳true之類的)
    'Try
    '            ThreadVolume.Start()
    '            ThreadVolume.Join()
    '        Catch ex As Exception
    '            LogWriter.WriteErrorLog(ex, "ThreadVolume")
    '        End Try
    '        ThreadVolume = Nothing

    ''' <summary>
    ''' POST執行前置作業與叫用POST
    ''' </summary>
    ''' <returns></returns>
    Private Function PostFuncation() As Boolean
        Dim bolSuccess As Boolean = False
        Dim DateTime_Start As String = DateTime.Now.ToString()
        Me.MESSAGE_LOG.Text += "POST================================START" + Environment.NewLine
        Me.MESSAGE_LOG.Text += "DateTime:[" + DateTime_Start + "]" + Environment.NewLine

        Try
            Dim XML_String As String = doc.InnerXml.ToString
            Me.MESSAGE_LOG.Text += XML_String.ToString + Environment.NewLine
            Me.MESSAGE_LOG.Text += "SOAP Reuquest----------------------------START" + Environment.NewLine
            Dim objCom As New CommonClass


            Dim strReturn As String = objCom.CallWebservice(XML_String, Me.URL_TextBox.Text.ToString)
            Me.MESSAGE_LOG.Text += strReturn + Environment.NewLine

            Me.MESSAGE_LOG.Text += "SOAP Reuquest----------------------------END" + Environment.NewLine
            bolSuccess = True
        Catch ex As Exception
            Me.MESSAGE_LOG.Text += ex.ToString
        End Try

        Me.MESSAGE_LOG.Text += "POST================================END" + Environment.NewLine

        Return bolSuccess
    End Function

    ''' <summary>
    ''' 按鈕
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnTestPost_Click(sender As Object, e As EventArgs) Handles btnTestPost.Click
        If chkLoop.Checked Then
            Me.txtCircle.Text = 1
        End If
        timeLeft = CInt(Check_Cell_NonNULL(Me.txtSecond.Text))
        circle = CInt(Check_Cell_NonNULL(Me.txtCircle.Text))
        circleMark = 0
        ClearTXTBOX()

        '1.第一次進來 直接POST
        Me.lblTimes.Text = circle & "次"
        PostController()
        circle -= 1
        '2.第二次開始用Timer
        Timer_Controller()

    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    Private Sub Timer_Controller()
        If chkLoop.Checked Then
            circle = 1
        End If
        If circle > 0 Then
            '開始執行
            Timer1.Start()
        End If
    End Sub

    ''' <summary>
    ''' 倒數計時器
    ''' </summary>
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Me.lblTimes.Text = circle & "次"
            If timeLeft > 0 Then
                ' Display the new time left
                ' by updating the Time Left label.
                timeLeft -= 1
                Me.lblSecond.Text = timeLeft & " seconds 後執行"
            Else
                ' If the user ran out of time, stop the timer, show
                ' a MessageBox, and fill in the answers.
                '清除舊的資訊
                ClearTXTBOX()
                circle -= 1
                Me.lblTimes.Text = circle & "次"
                Timer1.Stop()
                PostController()
                Timer_Controller()
            End If
        Catch ex As Exception
            MsgBox("Timer1_Tick錯誤:" + ex.ToString)
        End Try

    End Sub

#End Region


    '使用 WebRequest 類別傳送資料 https://msdn.microsoft.com/zh-tw/library/debx8sh9(v=vs.110).aspx
    '其他 http://stackoverflow.com/questions/4015324/http-request-with-post
    'http://jjnnykimo.pixnet.net/blog/post/25277457-c%23,-%E4%BD%BF%E7%94%A8-httpwebrequest-%E5%90%91%E7%B6%B2%E7%AB%99%E6%8F%90%E4%BA%A4%E8%B3%87%E6%96%99
    'http://www.111cn.net/net/WebService/43660.htm POST各種方式
    'http://developer.51cto.com/art/200909/151099.htm
    'http://vb.net-informations.com/excel-2007/vb.net_export_from_datagridview_to_excel.htm

    'string array
    'http://stackoverflow.com/questions/33104705/how-to-send-a-post-request-with-array-of-strings-in-the-body
    'https://www.roelvanlisdonk.nl/2013/10/09/how-to-post-a-string-array-to-a-asp-net-web-api-rest-service-that-uses-json-from-a-net-2-0-assembly/
    'https://forums.asp.net/t/2010247.aspx?Send+string+array+to+web+api
    'https://msdn.microsoft.com/zh-tw/library/debx8sh9(v=vs.110).aspx?cs-save-lang=1&cs-lang=vb#code-snippet-14
    '


End Class
