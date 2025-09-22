'Developed by: April Anne C. Cabanilla
'CYS: BSCS - 2A
'Instructor: Mr. Eddiemar Sinco
'Subject: Object Oriented Programming
'College of Communication and Information Technology
'University of Northern Philippines @2024-2025

Public Class QuizForm

    Dim hasAnsweredCorrectly As Boolean = False 'flag for correct ans
    Dim firstAttempt As Boolean = True 'flag for first ans

    'sructure for a quiz question
    Structure Question
        Dim QuestionText As String
        Dim Choices As String()
        Dim CorrectAnswer As Integer
        Dim Clue As String
        Dim Details As String
        Dim ImagePath As String
    End Structure

    'list to hold our questions
    Dim QuizQuestions As New List(Of Question)
    Dim currentQuestionIndex As Integer = 0
    Dim random As New Random()
    Dim score As Integer = 0

    Private Sub QuizForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load questions
        LoadQuizQuestions()

        'shuffle questions
        ShuffleQuestions()

        'start with the first question
        DisplayQuestion(currentQuestionIndex)

        'disable the Next button initially
        btnNext.Enabled = False
    End Sub

    'load the quiz questions
    Private Sub LoadQuizQuestions()
        'question 1
        QuizQuestions.Add(New Question With {
            .QuestionText = "What is the largest planet in the Solar System?",
            .Choices = {"Earth", "Mars", "Jupiter", "Saturn"},
            .CorrectAnswer = 2,
            .Clue = "It's known as the gas giant.",
            .Details = "Jupiter is the largest planet in the Solar System, with a mass one-thousandth that of the Sun.",
            .ImagePath = "C:\Users\lenovo\source\repos\GalaxyQuizGame\GalaxyQuizGame\Resources\q1.jpg"
        })

        'question 2
        QuizQuestions.Add(New Question With {
            .QuestionText = "Which planet is closest to the Sun?",
            .Choices = {"Venus", "Mars", "Mercury", "Earth"},
            .CorrectAnswer = 2,
            .Clue = "It's the smallest planet in the Solar System.",
            .Details = "Mercury is the closest planet to the Sun, with a year that lasts only 88 Earth days.",
            .ImagePath = "C:\Users\lenovo\source\repos\GalaxyQuizGame\GalaxyQuizGame\Resources\q2.jpg"
        })

        ' Question 3
        QuizQuestions.Add(New Question With {
            .QuestionText = "What is the name of the galaxy we live in?",
            .Choices = {"Andromeda", "Milky Way", "Triangulum", "Whirlpool"},
            .CorrectAnswer = 1,
            .Clue = "It’s named after a common terrestrial phenomenon.",
            .Details = "The Milky Way is a spiral galaxy containing our Solar System and many other stars and planets.",
            .ImagePath = "C:\Users\lenovo\source\repos\GalaxyQuizGame\GalaxyQuizGame\Resources\q3.jpg"
        })

        ' Question 4
        QuizQuestions.Add(New Question With {
            .QuestionText = "Which planet has the most moons?",
            .Choices = {"Earth", "Mars", "Saturn", "Neptune"},
            .CorrectAnswer = 2,
            .Clue = "It’s known for its prominent ring system.",
            .Details = "Saturn has over 80 known moons, more than any other planet in our Solar System.",
            .ImagePath = "C:\Users\lenovo\source\repos\GalaxyQuizGame\GalaxyQuizGame\Resources\q4.jpg"
        })

        ' Question 5
        QuizQuestions.Add(New Question With {
            .QuestionText = "What is the hottest planet in the Solar System?",
            .Choices = {"Venus", "Mars", "Mercury", "Jupiter"},
            .CorrectAnswer = 0,
            .Clue = "Its thick atmosphere traps heat.",
            .Details = "Venus has a runaway greenhouse effect, making it the hottest planet in the Solar System.",
            .ImagePath = "C:\Users\lenovo\source\repos\GalaxyQuizGame\GalaxyQuizGame\Resources\q5.jpg"
        })

        ' Question 6
        QuizQuestions.Add(New Question With {
            .QuestionText = "Which planet is known as the 'Red Planet'?",
            .Choices = {"Mars", "Jupiter", "Saturn", "Neptune"},
            .CorrectAnswer = 0,
            .Clue = "It’s named for its reddish appearance.",
            .Details = "Mars is known as the Red Planet due to iron oxide on its surface, giving it a reddish appearance.",
            .ImagePath = "C:\Users\lenovo\source\repos\GalaxyQuizGame\GalaxyQuizGame\Resources\q6.jpg"
        })

        ' Question 7
        QuizQuestions.Add(New Question With {
            .QuestionText = "What is the name of the first human to walk on the Moon?",
            .Choices = {"Neil Armstrong", "Buzz Aldrin", "Michael Collins", "Yuri Gagarin"},
            .CorrectAnswer = 0,
            .Clue = "He took 'one small step for man' in 1969.",
            .Details = "Neil Armstrong was the first person to set foot on the Moon during the Apollo 11 mission.",
            .ImagePath = "C:\Users\lenovo\source\repos\GalaxyQuizGame\GalaxyQuizGame\Resources\q7.jpg"
        })

        ' Question 8
        QuizQuestions.Add(New Question With {
            .QuestionText = "What is the name of the largest volcano in the Solar System?",
            .Choices = {"Olympus Mons", "Mount Everest", "Mauna Kea", "Mount Fuji"},
            .CorrectAnswer = 0,
            .Clue = "It’s located on Mars.",
            .Details = "Olympus Mons is a shield volcano on Mars and is about 13.6 miles (22 km) high, making it the tallest volcano in the Solar System.",
            .ImagePath = "C:\Users\lenovo\source\repos\GalaxyQuizGame\GalaxyQuizGame\Resources\q8.jpg"
        })

        ' Question 9
        QuizQuestions.Add(New Question With {
            .QuestionText = "What is the name of the ring system found around the planet Saturn?",
            .Choices = {"E-Rings", "F-Rings", "G-Rings", "Saturn's Rings"},
            .CorrectAnswer = 3,
            .Clue = "They are the most visible and complex ring system.",
            .Details = "Saturn’s rings are composed of ice, rock, and dust, making them the most complex and prominent ring system in our Solar System.",
            .ImagePath = "C:\Users\lenovo\source\repos\GalaxyQuizGame\GalaxyQuizGame\Resources\q9.jpg"
        })

        ' Question 10
        QuizQuestions.Add(New Question With {
            .QuestionText = "Which celestial body is known for its Great Red Spot?",
            .Choices = {"Mars", "Saturn", "Jupiter", "Neptune"},
            .CorrectAnswer = 2,
            .Clue = "It’s the largest storm in the Solar System.",
            .Details = "Jupiter’s Great Red Spot is a massive storm that has been raging for at least 400 years.",
            .ImagePath = "C:\Users\lenovo\source\repos\GalaxyQuizGame\GalaxyQuizGame\Resources\q10.jpg"
        })
    End Sub

    'shuffle the questions in the list
    Private Sub ShuffleQuestions()
        Dim n As Integer = QuizQuestions.Count
        For i As Integer = 0 To n - 1
            Dim j As Integer = random.Next(i, n) 'get a random integer 
            Dim temp As Question = QuizQuestions(i) 'swap the elements without losing the original value at index i
            QuizQuestions(i) = QuizQuestions(j)
            QuizQuestions(j) = temp
        Next 'next iteration
    End Sub

    'display the current question and options
    Private Sub DisplayQuestion(index As Integer)
        Dim question As Question = QuizQuestions(index)

        'set question and choices
        lblQuestion.Text = question.QuestionText
        btnChoice1.Text = question.Choices(0)
        btnChoice2.Text = question.Choices(1)
        btnChoice3.Text = question.Choices(2)
        btnChoice4.Text = question.Choices(3)

        'load and display the image
        Try
            picQuestionImage.Image = Image.FromFile(question.ImagePath)
        Catch ex As Exception
            picQuestionImage.Image = Nothing
        End Try

        lblFeedback.Text = ""

        'reset button colors to default
        btnChoice1.BackColor = SystemColors.Control
        btnChoice2.BackColor = SystemColors.Control
        btnChoice3.BackColor = SystemColors.Control
        btnChoice4.BackColor = SystemColors.Control

        'disable the Next button until an answer is selected
        btnNext.Enabled = False
    End Sub

    'function to check if the chosen answer is correct


    Private Sub CheckAnswer(selectedChoice As Integer)
        Dim question As Question = QuizQuestions(currentQuestionIndex)

        ' Check if the user has already answered correctly
        If hasAnsweredCorrectly And Not firstAttempt Then
            Return ' Exit if the user has already answered correctly
        End If

        ' Reset button colors to default
        btnChoice1.BackColor = SystemColors.Control
        btnChoice2.BackColor = SystemColors.Control
        btnChoice3.BackColor = SystemColors.Control
        btnChoice4.BackColor = SystemColors.Control

        If selectedChoice = question.CorrectAnswer Then
            ' Correct answer
            If firstAttempt Then
                lblFeedback.Text = "Correct! " & question.Details
                score += 1
                hasAnsweredCorrectly = True ' Mark as answered correctly
                ' Highlight the correct button in green
                Dim correctButton As Button = GetButtonByChoice(question.CorrectAnswer)
                correctButton.BackColor = Color.Green
            Else
                lblFeedback.Text = "Correct! " & question.Details
                ' Highlight the correct button in green, but do not update score
                Dim correctButton As Button = GetButtonByChoice(question.CorrectAnswer)
                correctButton.BackColor = Color.Green
            End If
            btnNext.Enabled = True ' Enable the Next button
        Else
            ' Wrong answer
            lblFeedback.Text = "Wrong! Clue: " & question.Clue
            ' Highlight the wrong button in red
            Dim wrongButton As Button = GetButtonByChoice(selectedChoice)
            wrongButton.BackColor = Color.Red
            btnNext.Enabled = True ' Enable the Next button, regardless of answer correctness
        End If

        ' After the first attempt, disable the ability to change the answer
        If firstAttempt Then
            firstAttempt = False
        End If
    End Sub



    'button click events for each choice
    Private Sub btnChoice1_Click(sender As Object, e As EventArgs) Handles btnChoice1.Click
        CheckAnswer(0)
    End Sub

    Private Sub btnChoice2_Click(sender As Object, e As EventArgs) Handles btnChoice2.Click
        CheckAnswer(1)
    End Sub

    Private Sub btnChoice3_Click(sender As Object, e As EventArgs) Handles btnChoice3.Click
        CheckAnswer(2)
    End Sub

    Private Sub btnChoice4_Click(sender As Object, e As EventArgs) Handles btnChoice4.Click
        CheckAnswer(3)
    End Sub

    ' Get button by choice
    Private Function GetButtonByChoice(choice As Integer) As Button
        Select Case choice
            Case 0
                Return btnChoice1
            Case 1
                Return btnChoice2
            Case 2
                Return btnChoice3
            Case 3
                Return btnChoice4
            Case Else
                Return Nothing
        End Select
    End Function

    'move to the next question or show the final score if it was the last question
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentQuestionIndex < QuizQuestions.Count - 1 Then
            currentQuestionIndex += 1
            DisplayQuestion(currentQuestionIndex)
            hasAnsweredCorrectly = False ' Reset flag for the new question
            firstAttempt = True ' Reset for the new question
        Else
            ' Show final score
            MessageBox.Show("Quiz complete! Your final score is: " & score.ToString() & " out of " & QuizQuestions.Count.ToString() & ".")
            Me.Close() ' Close the quiz form
        End If
    End Sub

End Class
