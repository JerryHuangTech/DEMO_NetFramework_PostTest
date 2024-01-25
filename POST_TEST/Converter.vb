Imports System.Security.Cryptography
Imports System.IO

''' <summary>
''' 型別轉換函式庫
''' </summary>
''' <remarks></remarks>
Public Class Converter
#Region "String 轉換"
    ''' <summary>
    ''' 讓Null或Nothing在ToString轉換為""
    ''' </summary>
    ''' <param name="RowData">接受Object</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Shared Function ConvertNULLToString(ByVal RowData As Object) As String
        Dim objTemp_GoalData As New Object
        objTemp_GoalData = RowData
        Try
            '空則回傳空字串，以免停止
            If objTemp_GoalData Is DBNull.Value OrElse objTemp_GoalData Is Nothing Then
                Return ""
            Else '若有值轉String並且Trim
                Return objTemp_GoalData.ToString.Trim
            End If
        Catch ex As Exception
            LogWriter.WriteErrorLog("ConvertNULLToString失敗", Converter.ConvertNULLToString(ex))
            Return ""
        End Try
    End Function
#End Region


#Region ""

    ''' <summary>
    ''' 中文字以2位元計算字串長度
    ''' </summary>
    ''' <param name="txt">字串</param>
    ''' <returns>字串長度</returns>
    ''' <remarks></remarks>
    Public Shared Function getCLen(ByVal txt As String) As Integer
        Return System.Text.Encoding.Default.GetBytes(txt).Length()
    End Function

    ''' <summary>
    ''' 數字字串轉整數
    ''' </summary>
    ''' <param name="txt">數字字串</param>
    ''' <param name="errMsg">錯誤時顯示的訊息(選擇性)</param>
    ''' <returns>傳回整數或0</returns>
    ''' <remarks>
    '''</remarks>
    Public Shared Function chkInt(ByVal txt As String, Optional ByVal errMsg As String = "") As Integer
        Dim _val As Integer = 0
        Try
            If Trim(txt) <> "" Then
                If IsNumeric(txt) Then
                    _val = CInt(txt)
                Else
                    'error
                    If errMsg <> "" Then
                        Console.WriteLine(errMsg)
                    End If
                End If
            End If
        Catch ex As Exception
            Dim _tmp As String
            _tmp = Tool.getErr(ex, System.Reflection.MethodBase.GetCurrentMethod.Name & " ===================(WebService " & Now.ToShortTimeString() & " )")
            LogWriter.WriteErrorLog(_tmp)
        End Try

        Return _val
    End Function

#End Region

End Class
