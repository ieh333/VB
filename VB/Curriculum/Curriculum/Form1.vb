Public Class Form1
    Public message As String
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedValue = vbNullString Then
            Select Case ComboBox1.SelectedIndex
                Case 0
                    message = "Български език и литература"
                Case 1
                    message = "Математика"
                Case 2
                    message = "Английски език"
                Case 3
                    message = "География"
                Case 4
                    message = "История"
                Case 5
                    message = "Физика"
                Case 6
                    message = "Химия"
                Case 7
                    message = "Биология"
                Case 8
                    message = "Информационни технологии"
                Case 9
                    message = "Информатика"
            End Select
            Result.Items.Insert(0, message)
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.SelectedIndex
            Case 0
                message = "Български език и литература"
            Case 1
                message = "Математика"
            Case 2
                message = "Английски език"
            Case 3
                message = "География"
            Case 4
                message = "История"
            Case 5
                message = "Физика"
            Case 6
                message = "Химия"
            Case 7
                message = "Биология"
            Case 8
                message = "Информационни технологии"
            Case 9
                message = "Информатика"
        End Select
        Result.Items.Insert(1, message)
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Select Case ComboBox3.SelectedIndex
            Case 0
                message = "Български език и литература"
            Case 1
                message = "Математика"
            Case 2
                message = "Английски език"
            Case 3
                message = "География"
            Case 4
                message = "История"
            Case 5
                message = "Физика"
            Case 6
                message = "Химия"
            Case 7
                message = "Биология"
            Case 8
                message = "Информационни технологии"
            Case 9
                message = "Информатика"
        End Select
        Result.Items.Insert(2, message)
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Select Case ComboBox4.SelectedIndex
            Case 0
                message = "Български език и литература"
            Case 1
                message = "Математика"
            Case 2
                message = "Английски език"
            Case 3
                message = "География"
            Case 4
                message = "История"
            Case 5
                message = "Физика"
            Case 6
                message = "Химия"
            Case 7
                message = "Биология"
            Case 8
                message = "Информационни технологии"
            Case 9
                message = "Информатика"
        End Select
        Result.Items.Insert(3, message)
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Select Case ComboBox5.SelectedIndex
            Case 0
                message = "Български език и литература"
            Case 1
                message = "Математика"
            Case 2
                message = "Английски език"
            Case 3
                message = "География"
            Case 4
                message = "История"
            Case 5
                message = "Физика"
            Case 6
                message = "Химия"
            Case 7
                message = "Биология"
            Case 8
                message = "Информационни технологии"
            Case 9
                message = "Информатика"
        End Select
        Result.Items.Insert(4, message)
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        Select Case ComboBox6.SelectedIndex
            Case 0
                message = "Български език и литература"
            Case 1
                message = "Математика"
            Case 2
                message = "Английски език"
            Case 3
                message = "География"
            Case 4
                message = "История"
            Case 5
                message = "Физика"
            Case 6
                message = "Химия"
            Case 7
                message = "Биология"
            Case 8
                message = "Информационни технологии"
            Case 9
                message = "Информатика"
        End Select
        Result.Items.Insert(5, message)
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Application.Exit()
    End Sub
End Class
