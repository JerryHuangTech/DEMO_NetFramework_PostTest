Imports System
Imports System.Text
Imports System.Object
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Data.EntityClient
Imports System.Security.Cryptography
Imports System.Reflection.MethodBase

Public Class Tool

    ''' <summary>
    ''' 傳回錯誤訊息
    ''' </summary>
    ''' <param name="obj">Exception object</param>
    ''' <param name="msg">顯示資訊</param>
    ''' <returns>錯誤訊息</returns>
    ''' <remarks></remarks>
    Public Shared Function getErr(ByRef obj As Exception, Optional ByVal msg As String = "") As String
        Dim _s As New StringBuilder
        Dim _rlt As String = ""

        If msg <> "" Then
            _s.AppendLine(msg)
        End If

        _s.AppendLine("Message: " & obj.Message)
        _s.AppendLine("StackTrace: " & obj.StackTrace)

        _rlt = _s.ToString

        releaseObj(_s)

        Return _rlt
    End Function

    ''' <summary>
    ''' Release Object
    ''' </summary>
    ''' <param name="obj">Object</param>
    ''' <remarks></remarks>
    Public Shared Sub releaseObj(ByRef obj As Object)
        Try
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally

        End Try
    End Sub

    ''' <summary>
    ''' 檢查PK長度
    ''' </summary>
    ''' <param name="pk">預設40，可自訂</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CheckPK(ByVal pk As String, Optional ByVal MAXLength As Integer = 0) As DataRow
        Dim _InfoDt As New DataTable
        Dim _infoDr As DataRow
        MAXLength = If(MAXLength = 0, ConstSet.PKMAXLEN, MAXLength)

        'Info Table init
        _InfoDt.TableName = ConstSet.TBNAME_INFO
        With _InfoDt.Columns
            .Add(ConstSet.COLNAME_INFO)
        End With

        'Status Default Setting
        _infoDr = _InfoDt.NewRow
        _infoDr(ConstSet.COLNAME_INFO) = CType(EnumSet.ExeStatus.OK, Integer)

        Try
            If IsNothing(pk) OrElse pk.ToString.Trim = "" Then
                _infoDr(ConstSet.COLNAME_INFO) = CType(EnumSet.ExeStatus.ParameterIsEmpty, Integer)
                '_ds.Tables.Add(New DataTable With {.TableName = ConstSet.TBNAME_EVENT})
                LogWriter.WriteErrorLog(GetCurrentMethod.Name & ": 參數為空")
            ElseIf Len(pk.ToString.Trim) > MAXLength Then
                _infoDr(ConstSet.COLNAME_INFO) = CType(EnumSet.ExeStatus.ParameterTooLong, Integer)
                '_ds.Tables.Add(New DataTable With {.TableName = ConstSet.TBNAME_EVENT})
                LogWriter.WriteErrorLog(GetCurrentMethod.Name & ": 參數過長")
            End If
        Catch ex As Exception
            LogWriter.WriteErrorLog(GetCurrentMethod.Name, Converter.ConvertNULLToString(ex))
        End Try
        Return _infoDr
    End Function
End Class
