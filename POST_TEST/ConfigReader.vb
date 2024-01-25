
''' <summary>
''' 可客製化讀取Config資訊
''' </summary>
''' <remarks></remarks>
Public Class ConfigReader

    ''' <summary>
    ''' 取得Web Config檔內的設定值
    ''' </summary>
    ''' <param name="SectionName">組態區段路徑和名稱</param>
    ''' <param name="SettingKey">組態Key值</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetSpecifyingConfigSetting(ByVal SectionName As String, ByVal SettingKey As String) As String
        Try
            Return System.Configuration.ConfigurationManager.GetSection(SectionName)(SettingKey).ToString
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    ''' <summary>
    ''' 取的Web Config檔內的appSettings區塊中的數值
    ''' </summary>
    ''' <param name="SettingKey">組態Key值</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetAppSettings(ByVal SettingKey As String) As String
        Try
            Return System.Configuration.ConfigurationManager.AppSettings(SettingKey).ToString
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    ''' <summary>
    ''' 取得web.Config AppSetting設定參數
    ''' </summary>
    ''' <param name="name">參數名稱</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Shared Function getConfig(ByVal name As String) As String
        Dim _rlt As String = ""
        Try
            _rlt = System.Configuration.ConfigurationManager.AppSettings.Item(name).ToString()
        Catch ex As Exception
            Dim _tmp As String
            _tmp = Tool.getErr(ex, System.Reflection.MethodBase.GetCurrentMethod.Name & " ===================(WebService " & Now.ToShortTimeString() & " )")
            LogWriter.WriteErrorLog(_tmp)
        End Try

        Return _rlt
    End Function

    ''' <summary>
    ''' 取得web.Config ConnectionString設定參數
    ''' </summary>
    ''' <param name="name">參數名稱</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Shared Function getConnString(ByVal name As String) As String
        Dim _rlt As String = ""
        Try
            _rlt = System.Configuration.ConfigurationManager.ConnectionStrings.Item(name).ToString()
        Catch ex As Exception
            Dim _tmp As String
            _tmp = Tool.getErr(ex, System.Reflection.MethodBase.GetCurrentMethod.Name & " ===================(WebService " & Now.ToShortTimeString() & " )")
            LogWriter.WriteErrorLog(_tmp)
        End Try

        Return _rlt
    End Function



End Class
