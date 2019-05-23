Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim intA As Integer
        Dim intB As Integer
        Dim intC As Integer
        Dim dblD As Double
        Dim dblX1 As Double
        Dim dblX2 As Double
        Integer.TryParse(a.Text, intA)
        Integer.TryParse(b.Text, intB)
        Integer.TryParse(c.Text, intC)
        dblD = Math.Pow(intB, 2) - 4 * intA * intC
        If dblD > 0 Then
            dblX1 = (-intB + Math.Sqrt(dblD)) / (2 * intA)
            dblX2 = (-intB - Math.Sqrt(dblD)) / (2 * intA)
            x1.Text = dblX1
            x2.Text = dblX2
        ElseIf dblD = 0 Then
            dblX1 = (-intB) / (2 * intA)
            dblX2 = (-intB) / (2 * intA)
            x1.Text = dblX1
            x2.Text = dblX2
        Else
            No_solution.Text = "Няма реални корени."
        End If

    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Application.Exit()
    End Sub
End Class
