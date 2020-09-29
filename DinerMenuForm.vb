Public Class DinerMenuForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Spaghetti.Click
        Me.Item1Label.Text = "Spaghetti"
        Me.Item2Label.Text = "cheese and shit"
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ChickenParmesan.Click
        Me.Item1Label.Text = "Chicken Parmesan"
        Me.Item2Label.Text = "cheese and shit"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Home.Click
        Dim textBox As Control
        Item1Label.Text = ""
        For Each textBox In Me.Controls
            If TypeOf textBox Is TextBox Then
                textBox.Text = ""
            End If
        Next

        Item2Label.Text = ""
        For Each textBox In Me.Controls
            If TypeOf textBox Is TextBox Then
                textBox.Text = ""
            End If
        Next

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Item1Label.Click

    End Sub

    Private Sub Pizza_Click(sender As Object, e As EventArgs) Handles Pizza.Click
        Me.Item1Label.Text = "Pizza"
        Me.Item2Label.Text = "cheese and shit"


    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
