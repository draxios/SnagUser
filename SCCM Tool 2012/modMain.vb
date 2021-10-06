Module modMain

    Public AreWeConnectedToSCCM As Boolean = False
    Public strComputer As String = ""
    Public AddingCollectionId
    Public sResourceID

    Public splitResult() As String = {""}

    Public LoadedCollections As New ArrayList
    Public CollectionsToAdd As New ArrayList
    Public SystemsToAdd As New ArrayList

    Public PushHistory As New ArrayList
    Public LastPushed As New ArrayList

    Public KeepLog As Boolean = False
    Public Sub WriteToLog(text As String)
        On Error Resume Next
        If KeepLog = True Then System.IO.File.AppendAllText("\\XXXXXXXXX\Logs\Ninja\" & Environment.UserName & "-" & Now.ToString("MMddyyyy") & ".log", Environment.UserName & " (" & Now() & "): " & text & vbNewLine)
    End Sub

    Public Sub AllowEvents()
        Application.DoEvents()
        Threading.Thread.Sleep(1)
        Application.DoEvents()
        Threading.Thread.Sleep(1)
        Application.DoEvents()
    End Sub

    Public Sub UpdateStatus(text As String)
        AllowEvents()
        frmMain.statusLabel.Text = text
        AllowEvents()
    End Sub

End Module
