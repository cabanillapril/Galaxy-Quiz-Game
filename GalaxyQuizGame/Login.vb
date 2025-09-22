'Developed by: April Anne C. Cabanilla
'CYS: BSCS - 2A
'Instructor: Mr. Eddiemar Sinco
'Subject: Object Oriented Programming
'College of Communication and Information Technology
'University of Northern Philippines @2024-2025

Public Class Login
    'load the login form
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set the default PasswordChar to hide the password
        txtPass.PasswordChar = "•"

    End Sub

    'event handler for the Login button click
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String
        Dim password As String

        'get input from the text boxes
        username = txtUser.Text
        password = txtPass.Text

        'compare the values
        If (username.Equals("aprilcabanilla") And password.Equals("admin")) Then
            'show the MenuForm and hide the Login form
            Dim menuForm As New MenuForm()
            menuForm.Show()
            Me.Hide() 'optionally hide the login form
        Else
            MessageBox.Show("Error", "Invalid username or password!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'show/hide password using the CheckBox
    Private Sub chckBox_CheckedChanged(sender As Object, e As EventArgs) Handles chckBox.CheckedChanged
        'toggle the PasswordChar property based on the CheckBox state
        If chckBox.Checked Then
            txtPass.PasswordChar = "" 'show the password 
        Else
            txtPass.PasswordChar = "•" 'hide the password 
        End If
    End Sub

    'sub to handle the Forgot Password label
    Private Sub labelForgotPass_Click(sender As Object, e As EventArgs) Handles labelForgotPass.Click
        MessageBox.Show("Please contact support to reset your password.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'handle the Enter key press to trigger login
    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown, txtUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick() 'simulate the login button click
        End If
    End Sub

    'sub to handle the About label
    Private Sub labelAbout_Click(sender As Object, e As EventArgs) Handles labelAbout.Click
        MessageBox.Show("Version 1.0 " & vbCrLf & "Developed by: April Anne C. Cabanilla" & vbCrLf & "CYS: BSCS 2A" & vbCrLf & "College of Communication and Information Technology" & vbCrLf & "@2024-2025 University of Northern Philippines", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    'sub for the Support click event to display the contact info
    Private Sub labelSupport_Click(sender As Object, e As EventArgs) Handles labelSupport.Click
        MessageBox.Show("Contact us: " & vbCrLf & "Phone Number: 09358031831" & vbCrLf & "Email: cabanillapril@gmail.com", "Support", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'ensure the application terminates when the form is closed
    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class
