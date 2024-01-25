Public Class ConstSet
#Region "資料庫控制項目"
    Public Const TBNAME_EVENT As String = "EVENT"
    Public Const TBNAME_INFO As String = "INFO"
    Public Const TBNAME_MONITOR As String = "MONITOR"
    Public Const TBNAME_OUTSIDEWINDOW As String = "OUTSIDE"
    Public Const TBNAME_PARAMETER As String = "PARAMETER"
    Public Const TBNAME_UPLOADFILE As String = "UPLOADFILE"
    Public Const TBNAME_UPDATE As String = "UPDATE"

    Public Const COLNAME_INFO As String = "INFO"
    Public Const CULTURE As String = "ZH_TW"

    Public Const TIMEOUT As Integer = 600
    Public Const LOGDATACOUNT As Integer = 1 'Log 資料筆數(-1:不限, 0:不記錄, N:最多記錄N筆)
    Public Const PKMAXLEN As Integer = 40 '參數 最大長度

    Public Const MTIMELIMIT As Integer = 2  'M Type 顯示時間限制(Min.)
#End Region

#Region "成功/失敗"
    Public Const SSC As String = "SAVE_SUCCESS"
    Public Const SF As String = "SAVE_FAILE"
#End Region

#Region "LOG文字"
    Public Const BStartLing As String = "╔════════════════════ 【 Start 】 ════════════════════╗"
    Public Const BEndLing As String = "╚════════════════════ 【  End  】 ════════════════════╝"
    Public Const StartLing As String = "┌────────── [ Start ] ──────────┐"
    Public Const EndLing As String = "└────────── [  End  ] ──────────┘"
    Public Const LStartLing As String = "---------- [ Start ] ----------"
    Public Const LEndLing As String = "---------- [  End  ]----------"
#End Region

End Class
