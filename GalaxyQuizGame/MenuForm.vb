'Developed by: April Anne C. Cabanilla
'CYS: BSCS - 2A
'Instructor: Mr. Eddiemar Sinco
'Subject: Object Oriented Programming
'College of Communication and Information Technology
'University of Northern Philippines @2024-2025


Imports System.Net

Public Class MenuForm
    Private quizForm As QuizForm 'instance to use QuizForm

    'sub to open a new instance of the quiz form when the menu item is clicked
    Private Sub menuQuiz_Click(sender As Object, e As EventArgs) Handles MenuQuiz.Click
        OpenQuiz()
    End Sub

    'to open a new instance of the quiz form when the button is clicked (new game button)
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        OpenQuiz()
    End Sub

    'sub to log out and show the login form
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Dim loginForm As New Login()
        loginForm.Show()
        AddHandler loginForm.FormClosed, Sub(sender2, e2) Application.Exit()
    End Sub


    'the ff. code is for file menu



    'sub to open a new instance of the quiz form from the file menu
    Private Sub menuitemNewQuiz_Click(sender As Object, e As EventArgs) Handles menuitemNewQuiz.Click
        'close the existing quiz form if it's open
        If quizForm IsNot Nothing AndAlso Not quizForm.IsDisposed Then
            quizForm.Close()
        End If

        'open a new quiz form
        OpenQuiz()
    End Sub


    'sub to save the history of quiz results (assuming we hav a history feature)
    Private Sub menuitemSaveProgress_Click(sender As Object, e As EventArgs) Handles menuitemSaveProgress.Click
        'implement save progress functionality 
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Progress Files (*.progress)|*.progress|All Files (*.*)|*.*"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            'save the quiz progress
        End If
    End Sub

    Private Sub menuitemLoadProgress_Click(sender As Object, e As EventArgs) Handles menuitemLoadProgress.Click
        'implement load progress functionality here
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Progress Files (*.progress)|*.progress|All Files (*.*)|*.*"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            'load the quiz progress
        End If
    End Sub

    'sub to print the history of quiz results (for display only)
    Private Sub menuitemPrint_Click(sender As Object, e As EventArgs) Handles menuitemPrint.Click
        MessageBox.Show("Printing Quiz History.", "Print")
    End Sub

    'sub to exit the application
    Private Sub menuitemExit_Click(sender As Object, e As EventArgs) Handles menuitemExit.Click
        Application.Exit()
    End Sub


    'the ff. code is for edit menu


    'method to copy selected text in a TextBox
    Public Sub CopySelectedText()
        Dim textBox = TryCast(Me.ActiveControl, TextBox)
        If textBox IsNot Nothing Then
            If textBox.SelectedText.Length > 0 Then
                Clipboard.SetText(textBox.SelectedText)
            Else
                MessageBox.Show("No text selected to copy.", "Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No TextBox control has focus for copying text.", "Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'method to select all text in a TextBox
    Public Sub SelectAllText()
        Dim textBox = TryCast(Me.ActiveControl, TextBox)
        If textBox IsNot Nothing Then
            textBox.SelectAll()
        Else
            MessageBox.Show("No TextBox control has focus for selecting text.", "Select All Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'implement copy
    Private Sub menuitemCopy_Click(sender As Object, e As EventArgs) Handles menuitemCopy.Click
        Dim activeControl = Me.ActiveControl
        If TypeOf activeControl Is TextBox Then
            Dim textBox As TextBox = CType(activeControl, TextBox)
            If textBox.SelectedText.Length > 0 Then
                Clipboard.SetText(textBox.SelectedText)
            Else
                MessageBox.Show("No text selected to copy.", "Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No TextBox control is currently active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'implement select all
    Private Sub menuitemSelectAll_Click(sender As Object, e As EventArgs) Handles menuitemSelectAll.Click
        Dim activeControl = Me.ActiveControl
        If TypeOf activeControl Is TextBox Then
            Dim textBox As TextBox = CType(activeControl, TextBox)
            textBox.SelectAll() 'select all text in the TextBox
        Else
            MessageBox.Show("No TextBox control is currently active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    'the ff. code is for help menu


    'display information about the application
    Private Sub menuitemAbout_Click(sender As Object, e As EventArgs) Handles menuitemAbout.Click
        MessageBox.Show("Quiz App Version 1.0" & vbCrLf & "Developed by: April Anne C. Cabanilla" & vbCrLf & "CYS: BSCS - 2A" & vbCrLf & "© 2024-2025 University of Northern Philippines", "About Quiz", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    'sub to display the latest version information
    Private Sub menuitemUpdates_Click(sender As Object, e As EventArgs) Handles menuitemUpdates.Click
        MessageBox.Show("The latest version is installed.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'sub to show the user guide with detailed instructions
    Private Sub menuitemUserGuide_Click(sender As Object, e As EventArgs) Handles menuitemUserGuide.Click
        Dim userGuideText As String = "User Guide:" & vbCrLf & vbCrLf &
                                  "1. Starting the Quiz:" & vbCrLf &
                                  "    - Launch the application and the main menu will appear." & vbCrLf & vbCrLf &
                                  "2. Taking the Quiz:" & vbCrLf &
                                  "    - Answer each question by selecting the appropriate choice button." & vbCrLf &
                                  "    - Click 'Next' to proceed to the next question." & vbCrLf & vbCrLf &
                                  "3. File Menu:" & vbCrLf &
                                  "    - New Quiz: Opens a new quiz instance. If a quiz is already open, it will be closed before opening a new one." & vbCrLf &
                                  "    - Save Progress: Saves your quiz progress to a file. Choose the file location and name using the Save File dialog." & vbCrLf &
                                  "    - Load Progress: Loads quiz progress from a file. Select the file containing the saved progress using the Open File dialog. (simulation only)" & vbCrLf &
                                  "    - Print: Prints the history of quiz results. (simulation only)" & vbCrLf &
                                  "    - Exit: Closes the application. Any unsaved progress will be lost." & vbCrLf & vbCrLf &
                                  "4. Edit Menu:" & vbCrLf &
                                  "    - Copy: Copies the selected text in the currently active TextBox to the clipboard. An error message will appear if no text is selected or no TextBox is active." & vbCrLf &
                                  "    - Select All: Selects all text in the currently active TextBox. If no TextBox is active, an error message will appear." & vbCrLf & vbCrLf &
                                  "5. Help Menu:" & vbCrLf &
                                  "    - User Guide: Displays this user guide with detailed instructions on using the application." & vbCrLf &
                                  "    - About: Shows information about the application, including the version and developer details." & vbCrLf &
                                  "    - Updates: Provides information about the latest version of the application and updates."

        MessageBox.Show(userGuideText, "User Guide", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    'ensure the application closes entirely when the form is closed
    Private Sub MenuForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Application.Exit() ' Close the entire application
        End If
    End Sub

    'helper method to open the quiz form
    Private Sub OpenQuiz()
        If quizForm Is Nothing OrElse quizForm.IsDisposed Then
            quizForm = New QuizForm()
        End If
        quizForm.Show()
    End Sub
    'handles how to play click
    Private Sub lblHow_Click(sender As Object, e As EventArgs) Handles lblHow.Click
        MessageBox.Show("➼ Choose the answer you think is correct. " & vbCrLf & "➼ If you're not sure, a helpful clue will guide you." & vbCrLf & "➼ Correct answers earn you points. " & vbCrLf & "➼ 10 items quiz result will be displayed after the game.", "How to play", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
