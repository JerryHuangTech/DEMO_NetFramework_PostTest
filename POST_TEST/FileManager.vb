Imports System.ComponentModel
Imports System.IO
Imports System.Security.Cryptography
Imports System.Reflection.MethodBase
Public Class FileManager

    ''' <summary>
    ''' 建立文字檔 Creat Text File = CrtTxt
    ''' </summary>
    '''<param name="FullPath" >完整路徑與檔名</param>
    '''<param name="Content" >寫入內容</param>
    ''' <param name="isCover" >是否覆蓋原內容(Default:false)</param>
    ''' <remarks>
    ''' Imports System.IO
    ''' </remarks>
    Public Shared Sub CrtTxt(ByVal FullPath As String, ByVal Content As String, Optional ByVal isCover As Boolean = False)
        Dim _myFile As FileStream = Nothing
        Dim _myWriter As StreamWriter = Nothing

        Dim _rlt As String = ""

        Try

            '不存在則建立
            If isCover Then
                '覆蓋內容
                _myFile = System.IO.File.Open(FullPath, FileMode.Create)
            Else
                '接續內容
                _myFile = System.IO.File.Open(FullPath, FileMode.Append)
            End If

            '引用StringWriter類別
            _myWriter = New StreamWriter(_myFile)

            '寫字串至檔案
            _myWriter.WriteLine(Content)

        Catch ex As Exception
            _rlt = Tool.getErr(ex, "(WebService) " & System.Reflection.MethodBase.GetCurrentMethod.Name & "(): ")

        Finally

            '釋放資源
            If _myWriter IsNot Nothing Then
                _myWriter.Dispose()
            End If

            If _myFile IsNot Nothing Then
                _myFile.Dispose()
            End If

        End Try

    End Sub
End Class
