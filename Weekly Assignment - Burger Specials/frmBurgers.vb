Public Class Form1
    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        btnExit.Enabled = True
        lblConfirmation.Visible = True
    End Sub

    Private Sub btnBeef_Click(sender As Object, e As EventArgs) Handles btnBeef.Click
        picPrime.Visible = True
        picVeggie.Visible = False
        btnSelectMeal.Enabled = True

    End Sub

    Private Sub picVeggie_Click(sender As Object, e As EventArgs) Handles picVeggie.Click

    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        picVeggie.Visible = True
        picPrime.Visible = False
        btnSelectMeal.Enabled = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
