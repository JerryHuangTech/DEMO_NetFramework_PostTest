Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Configuration

Public Class CommonClass
    ''' <summary>
    ''' 實際呼叫post
    ''' </summary>
    ''' <param name="SoapStr"></param>
    ''' <param name="strWebRequest"></param>
    ''' <returns></returns>
    Public Function CallWebservice(ByVal SoapStr As String, ByVal strWebRequest As String) As String
        'Dim SoapStr As String = ConvertNullToEmpty(MasterForm.strSoapXML)
        'Dim strWebRequest As String = ConvertNullToEmpty()
        Dim isSuccess As Boolean = False
        Dim Request As WebRequest
        Dim Response As WebResponse
        Dim DataStream As Stream
        Dim Reader As StreamReader
        Dim SoapByte() As Byte
        Dim pSuccess As Boolean = True
        Dim ReturnString As String = "CallWebservice內部程式運作失敗"

        If SoapStr = "" Then
            MsgBox("讀取的XML為空")
            Return ReturnString
            Exit Function


        End If

        Try
            SoapByte = System.Text.Encoding.UTF8.GetBytes(SoapStr)

            Request = WebRequest.Create(strWebRequest)
            Request.Headers.Add("SOAPAction", "http://google.com/Send")

            Request.ContentType = "text/xml; charset=utf-8"
            Request.ContentLength = SoapByte.Length
            Request.Method = "POST"

            DataStream = Request.GetRequestStream()
            DataStream.Write(SoapByte, 0, SoapByte.Length)
            DataStream.Close()

            Response = Request.GetResponse()
            DataStream = Response.GetResponseStream()
            Reader = New StreamReader(DataStream)
            Dim SD2Request As String = Reader.ReadToEnd()

            DataStream.Close()
            Reader.Close()
            Response.Close()


            ReturnString = (CType(Response, HttpWebResponse).StatusDescription)
        Catch ex As WebException
            'MsgBox(ex.ToString())
            ReturnString = ex.ToString
        End Try

        Return ReturnString
    End Function

    ''' <summary>
    ''' 檢查每個 cell value 不會是Nothing或Null (建議使用於簡短文字，如Keyword或變數值)
    ''' </summary>
    ''' <param name="CheckData">需要被檢查與轉換為String.Trim的DataRow之Cell</param>
    ''' <returns></returns>
    ''' <remarks>工具</remarks>
    Overloads Shared Function ConvertNullToEmpty(ByVal CheckData As Object) As String
        Dim objTemp_GoalData As New Object
        objTemp_GoalData = CheckData
        Try
            '空則回傳空字串，以免停止，此外也能遏止發生Nothing錯誤，例如該Cell需要被Trim會Catch
            If objTemp_GoalData Is DBNull.Value OrElse objTemp_GoalData Is Nothing OrElse objTemp_GoalData = "" Then
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
    ''' 取得Config
    ''' </summary>
    ''' <param name="key"></param>
    ''' <returns></returns>
    Overloads Shared Function GetConfigValue(ByVal key As String) As String
        Dim Temp As String = ""
        Dim appSettings = ConfigurationManager.AppSettings
        If ConvertNullToEmpty(key) <> "" Then
            Temp = ConvertNullToEmpty(appSettings(key))
        End If
        Return Temp
    End Function


End Class
