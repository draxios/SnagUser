'==========================================================================
'
' 
' NAME: SCCM LOOKUP
' VERSION: 9.0.0.0
'
' AUTHOR: Scott Stevens, IDS
' DATE  : 06/16/2015
'
' COMMENT: To help with the addition of machines to certain IDS SCCM collections. (For pushing out software easily.)
'
' 
' CHANGES: 0.9.2.1 - First Stable Version
'          0.9.5.0 - New version with sorting code, because now there's not two lists for names and IDs.
'          0.9.6.0 - Last Ninja Version before DART/Window projects.
'          0.9.9.5 - Updated testing version, after failures with SCCM Dart/Window due to server access problems.
'          1.0.0.0 - Final version for production. Added clipboard use, scrolling collection results, progress bar, logging, batch add multiuse, design, UI, BUGS! New icons, etc.
'          1.1.0.0 - Same as above, cerimonial version.
'          1.1.1.0 - Allow clipboard of lots of names. Fixed label issues.
'		
'==========================================================================

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'give me a wonderful name and version number on the main title bar
        Me.Text = Application.ProductName & " v" & Application.ProductVersion

        'connect to SCCM
        ConnectToSCCM(ProgressBar)

        statusLabel.Text = "Connected to " & SiteServer
    End Sub

    Private Sub btnSelectedClear_Click(sender As Object, e As EventArgs)
        lstIDsToAdd.Items.Clear()
        CollectionsToAdd.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        lstUsers.Items.Clear()
        SystemsToAdd.Clear()
    End Sub

    Private Sub btnAddTitles_Click(sender As Object, e As EventArgs) Handles btnAddTitles.Click

        Dim selectedOnes As Windows.Forms.ListBox.SelectedIndexCollection
        selectedOnes = lstCollections.SelectedIndices

        For Each intBuff As Integer In selectedOnes
            'new code to allow sorting of listbox
            lstIDsToAdd.Items.Add(lstCollections.Items(intBuff))
            CollectionsToAdd.Add(lstCollections.Items(intBuff))
        Next
    End Sub

    Private Sub btnAddNames_Click(sender As Object, e As EventArgs) Handles btnAddNames.Click

        If txtComputers.Text = "" Then Exit Sub

        Dim buffer() As String = Split(txtComputers.Text, vbNewLine)

        For Each temper As String In buffer
            If temper <> "" Then
                lstUsers.Items.Add(UCase(temper))
                SystemsToAdd.Add(UCase(temper))
            End If
        Next

        txtComputers.Text = ""

    End Sub


    Private Sub btnAddFromClipboard_Click(sender As Object, e As EventArgs) Handles btnAddFromClipboard.Click

        Dim grabClipboard = Clipboard.GetText
        If grabClipboard = "" Then Exit Sub

        If grabClipboard.Contains(vbNewLine) Then

            Dim splitter = Split(grabClipboard, vbNewLine)
            For Each littlepiece As String In splitter
                If Len(littlepiece) < 15 And Len(littlepiece) > 5 Then
                    lstUsers.Items.Add(UCase(littlepiece))
                    SystemsToAdd.Add(UCase(littlepiece))
                End If
            Next

        Else
            If Len(grabClipboard) > 14 Or Len(grabClipboard) < 5 Then
                MsgBox("The clipboard values are whack. Please try copying again.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            lstUsers.Items.Add(UCase(grabClipboard))
            SystemsToAdd.Add(UCase(grabClipboard))
        End If

    End Sub

    Private Sub btnPush_Click(sender As Object, e As EventArgs) Handles btnPush.Click

        If lstIDsToAdd.Items.Count = 0 Or lstUsers.Items.Count = 0 Then
            UpdateStatus("You must add more information to continue. Check data fields.")
            MsgBox("Please enter more information to continue.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        AllowEvents()
        ProgressBar.Style = ProgressBarStyle.Marquee
        AllowEvents()

        Dim addBuffer As String = ""
        Dim addUsers As String = ""
        Dim splitResult()
        Dim inResult As Boolean = False
        Dim IDstoAdd As New ArrayList

        'get a arraylist of all collections to add to
        For Each addBuffer In CollectionsToAdd

            splitResult = Split(addBuffer, ";")
            'MsgBox("Added to the array IDstoAdd: " & splitResult(1))
            'MsgBox("addbuffer = " & addBuffer)
            splitResult = Split(addBuffer, ";")
            'MsgBox("Added to the array IDstoAdd: " & splitResult(1))
            IDstoAdd.Add(splitResult(1))
            AllowEvents()
        Next

        'loop through each user, to add all machines to each user.
        For Each addUsers In SystemsToAdd

            'set the computer to be added
            strComputer = addUsers

            'loop through all COLIDs and load them one by one.
            For Each addBuffer In IDstoAdd
                inResult = IsItInTheCollection(addBuffer, strComputer)

                If inResult = False Then
                    UpdateStatus("Workstation is not in the collection, adding now.")
                    AddingCollectionId = addBuffer
                    UpdateStatus("Adding CollectionID : " & addBuffer)
                    AddMachineToCollection(strComputer, addBuffer)
                    UpdateStatus("Added workstation to collection successfully!")
                    WriteToLog("Added workstation to collection successfully!")
                Else
                    'skipping because already in collection
                    UpdateStatus("Workstation not added due to duplicate found.")
                    WriteToLog("Workstation not added due to duplicate found.")
                    Threading.Thread.Sleep(500)
                End If

                Threading.Thread.Sleep(2000)
                AllowEvents()
            Next
            AllowEvents()
        Next

        AllowEvents()
        WriteToLog("All workstations added to the selected collections successfully!")
        UpdateStatus("All workstations added to the selected collections successfully!")
        AllowEvents()
        ProgressBar.Style = ProgressBarStyle.Continuous
        AllowEvents()
    End Sub

 
    Private Sub btnLookup_Click(sender As Object, e As EventArgs) Handles btnLookup.Click

        btnLookup.Enabled = False
        btnCopy.Enabled = False
        btnSave.Enabled = False

        statusLabel.Text = "Running Queries"

        Dim strSQLQuery As String = ""
        Dim strResult As String = ""
        Dim foundCollections As New ArrayList

        Dim objSubColCol
        Dim objSubColItem
        Dim tempPuter As String = ""

        txtComputers.Text = ""
        ProgressBar.Value = 0
        ProgressBar.Maximum = txtCollections.Lines.Count

        For Each tempID As String In txtCollections.Lines

            tempID = Trim(tempID)
            If tempID = "" Then Continue For

            strSQLQuery = "SELECT LastLogonUserName FROM SMS_R_System WHERE Name='" & tempID & "'"

            strSQLQuery = "select SMS_R_System.LastLogonUserName, SMS_R_System.NetbiosName, SMS_R_System.ResourceId from SMS_R_System where SMS_R_System.LastLogonUserName = ##PRM:SMS_R_System.LastLogonUserName##"

            'MsgBox("%" & strSQLQuery & "%")

            objSubColCol = oSMS.ExecQuery(strSQLQuery)

            MsgBox("query sent")
            tempPuter = ""

            Try
                For Each objSubColItem In objSubColCol
                    'MsgBox("Adding user name = " & objSubColItem.Name)
                    tempPuter &= objSubColItem.Name & ", "  'CHG REQUEST 5/24/2018
                    'tempPuter &= objSubColItem.Name & vbNewLine
                Next



                'txtComputers.Text &= Strings.Left(tempPuter, (Len(tempPuter) - 2)) & vbNewLine
                txtComputers.Text &= tempPuter & vbNewLine
            Catch ex As Exception
                txtComputers.Text &= "No users(s) found" & vbNewLine
            End Try

            statusLabel.Text &= "."
            ProgressBar.Value += 1
        Next

        statusLabel.Text = "Queries completed successfully!"
        ProgressBar.Value = 0
        btnLookup.Enabled = True
        btnCopy.Enabled = True
        btnSave.Enabled = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtComputers.Text = "" Then
            statusLabel.Text = "There are no users listed to save."
            Exit Sub
        End If

        sd1.ShowDialog()
        If sd1.FileName = "" Then Exit Sub
        If IO.File.Exists(sd1.FileName) Then IO.File.Delete(sd1.FileName)

        For Each tempComputer As String In txtComputers.Lines

            If tempComputer = "" Then Continue For
            System.IO.File.AppendAllText(sd1.FileName, tempComputer & vbNewLine)

        Next

        statusLabel.Text = "File written successfully!"
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click

        Dim copyList As String = ""

        For Each tempComputer As String In txtComputers.Lines

            If tempComputer = "" Then Continue For
            copyList &= tempComputer & vbNewLine

        Next

        statusLabel.Text = "List copied to clipboard!"
        Clipboard.SetText(copyList)
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click

        If txtComputers.Text = "" Then
            statusLabel.Text = "There are no users listed to save."
            Exit Sub
        End If

        sd1.ShowDialog()
        If sd1.FileName = "" Then Exit Sub

        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object

        'Start a new workbook in Excel.
        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Add

        'Add data to cells of the first worksheet in the new workbook.
        oSheet = oBook.Worksheets(1)
        oSheet.Range("A1").Value = "Last Name"
        oSheet.Range("B1").Value = "First Name"
        oSheet.Range("A1:B1").Font.Bold = True
        oSheet.Range("A2").Value = "Doe"
        oSheet.Range("B2").Value = "John"

        'Save the Workbook and quit Excel.
        oBook.SaveAs(sd1.FileName & ".xls")
        oSheet = Nothing
        oBook = Nothing
        oExcel.Quit()
        oExcel = Nothing
        GC.Collect()
    End Sub
End Class
