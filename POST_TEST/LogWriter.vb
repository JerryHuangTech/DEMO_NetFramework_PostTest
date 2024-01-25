Imports System
Imports System.IO
Imports System.Reflection
Imports System.Globalization
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Runtime.InteropServices

''' <summary>
''' Log 紀錄
''' </summary>
''' <remarks></remarks>
Public Class LogWriter
    ''' <summary>
    ''' 錯誤訊息寫入文字檔
    ''' </summary>
    ''' <param name="title">傳入錯誤的主要訊息</param>
    ''' <param name="msg">傳入錯誤之Exception (請轉String)</param>
    ''' <remarks></remarks>
    Public Shared Sub WriteErrorLog(Optional ByVal title As String = "Exception", Optional ByVal msg As String = "")
        Dim msg_ALL As String = ""
        msg_ALL = Converter.ConvertNULLToString(title) + If(Converter.ConvertNULLToString(msg) <> "", "：" + Converter.ConvertNULLToString(msg), "")

        WriteLog(msg, EnumSet.WTType.ERR)
    End Sub

    ''' <summary>
    ''' Data訊息寫入文字檔
    ''' </summary>
    ''' <param name="title">資料寫入的主要開頭資訊</param>
    ''' <param name="msg">資料寫入的詳細資訊</param>
    ''' <remarks></remarks>
    Public Shared Sub WriteDataInfo(ByVal title As String, Optional ByVal msg As String = "")
        Dim msg_ALL As String = ""
        msg_ALL = Converter.ConvertNULLToString(title) + If(Converter.ConvertNULLToString(msg) <> "", "：" + Converter.ConvertNULLToString(msg), "")

        WriteLog(msg_ALL, EnumSet.WTType.DATA)
    End Sub

    ''' <summary>
    ''' 系統訊息
    ''' </summary>
    ''' <param name="msg">錯誤訊息</param>
    ''' <remarks></remarks>
    Public Shared Sub WriteInfo(ByVal title As String, Optional ByVal msg As String = "")
        Dim msg_ALL As String = ""
        msg_ALL = Converter.ConvertNULLToString(title) + If(Converter.ConvertNULLToString(msg) <> "", "：" + Converter.ConvertNULLToString(msg), "")
        WriteLog(msg_ALL, EnumSet.WTType.INFO)
    End Sub

    ''' <summary>
    ''' 訊息寫入文字檔
    ''' </summary>
    ''' <param name="msg">訊息</param>
    ''' <remarks></remarks>
    Public Shared Sub WriteLog(ByVal msg As String, Optional ByVal Type As EnumSet.WTType = EnumSet.WTType.INFO)
        Dim _get_name As String = "LogFile"
        Dim _get_path As String = "C:\"
        Dim _fileName As String = ""
        Dim _point As String = ""
        Try
            _get_name = ConfigReader.getConfig("LogName")
            _get_path = ConfigReader.getConfig("LogPath")
            _fileName = _get_name & Now.ToString("yyyyMMdd") & ".txt"

            Select Case Type
                Case EnumSet.WTType.INFO
                    _point = "[INFO]   "

                Case EnumSet.WTType.DATA
                    _point = "[DATA]○ "

                Case EnumSet.WTType.ERR
                    _point = "[ERR ]● "

            End Select

            '產出文字檔
            FileManager.CrtTxt(_get_path & _fileName, "[" & Now.ToString("HH:mm:ss") & "] " & _point & msg & vbCrLf)

        Catch ex As Exception
            Dim _tmp As String
            _tmp = Tool.getErr(ex, "(WebService) " & System.Reflection.MethodBase.GetCurrentMethod.Name & "(): ")
            LogWriter.WriteErrorLog(_tmp)
        End Try

    End Sub

End Class
