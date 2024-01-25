''' <summary>
''' 所有Enum設定
''' </summary>
''' <remarks></remarks>
Public Class EnumSet
    ''' <summary>
    ''' SQL執行類型
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum CMDType As Integer
        Query
        Update
    End Enum

    ''' <summary>
    ''' Log記錄類型
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum WTType As Integer
        INFO
        DATA
        ERR
    End Enum

    ''' <summary>
    ''' 回傳執行狀況
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ExeStatus As Integer
        OK = 0                      '0 執行正常

        NoData = 10                 '10.無此事件單
        EventStatusEmpty = 11       '11.此事件單無狀態
        EventstatusError = 12       '12.事件單狀態有誤
        EventInfoNumEmpty = 13      '13.通知單編號為空
        EventInfoNumError = 14      '14.通知單編號有誤(通知單編號不為空，且與參數不符)

        VolumeEventLost = 20        '20.大量訊息無對應監控事件單 (本身存在 1.但VOL_SERIL_NO IS Empty; 2.代表大量的第一筆找不到)
        VolumeEventStatusEmpty = 21 '21.大量訊息對應監控事件單無狀態 (代表大量當筆存在，但狀態為空)
        VolumeEventStatusError = 22 '22.大量訊息對應監控事件單狀態有誤 (代表大量當筆存在，但狀態有誤)

        ParameterIsEmpty = 30       '30.參數為空
        DBConnectionError = 31      '31.連線失敗
        ParameterTooLong = 32       '32.參數過長
        ParameterError = 33         '33.參數有誤
        NothingReturn = 34          '34.查詢事件單後再次查詢最終結果，最終結果無資料            

        Unknow = 999                '999.其它
    End Enum

    ''' <summary>
    ''' 執行SQL 類別
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum QueryContext As Integer
        EventField = 1
        EventStatus = 2
        EventVolume = 3
        EventDefine = 4
        EventView = 5
        EventS2 = 6
        EventM = 7
        EventUploadFile = 8
        EventProcessHistory = 9 '取得ProcessHistory

        EventBaseInfo = 101
    End Enum

    ''' <summary>
    ''' 更新類別
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum UpdateContext As Integer
        EventBPAP = 1
        EventDeadLine = 2
    End Enum

End Class

