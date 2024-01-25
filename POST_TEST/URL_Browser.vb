Imports System.Reflection
Imports System.Configuration


Public Class URL_Browser
    'http://abgne.tw/code-snippets/dotnet-webbrowser.html
    ''' <summary>
    ''' 導入頁面
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub URL_Browser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tssLabel.Text = CStr(MethodInfo.GetCurrentMethod.Name)
        URL_WebBrowser.Navigate(Me.URL_TextBox.Text)
    End Sub

    ''' <summary>
    ''' 更新
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnREFRESH_Click(sender As Object, e As EventArgs) Handles btnREFRESH.Click
        Me.tssLabel.Text = CStr(MethodInfo.GetCurrentMethod.Name)
        URL_WebBrowser.Refresh()
    End Sub
    ''' <summary>
    ''' 停止
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSTOP_Click(sender As Object, e As EventArgs) Handles btnSTOP.Click
        Me.tssLabel.Text = CStr(MethodInfo.GetCurrentMethod.Name)
        URL_WebBrowser.Stop()
    End Sub
    ''' <summary>
    ''' 上一頁
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPREVIOUS_Click(sender As Object, e As EventArgs) Handles btnPREVIOUS.Click
        Me.tssLabel.Text = CStr(MethodInfo.GetCurrentMethod.Name)
        URL_WebBrowser.GoBack()
    End Sub
    ''' <summary>
    ''' 下一頁
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnNEXT_Click(sender As Object, e As EventArgs) Handles btnNEXT.Click
        Me.tssLabel.Text = CStr(MethodInfo.GetCurrentMethod.Name)
        URL_WebBrowser.GoForward()
    End Sub


    ''' <summary>
    ''' 按下LINK
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnLINK_Click(sender As Object, e As EventArgs) Handles btnLINK.Click
        Me.tssLabel.Text = CStr(MethodInfo.GetCurrentMethod.Name)
        URL_WebBrowser.Navigate(Me.URL_TextBox.Text)
    End Sub
    ''' <summary>
    ''' ENTER動作
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub URL_TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles URL_TextBox.KeyUp
        Me.tssLabel.Text = CStr(MethodInfo.GetCurrentMethod.Name)
        If e.KeyCode = Keys.Enter Then
            URL_WebBrowser.Navigate(Me.URL_TextBox.Text)
        End If
    End Sub

End Class