Public Class frmMenu


    Private Sub btnOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrders.Click
        Me.Hide()
        frmOrders.Show()
    End Sub

    Private Sub btnMeals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMeals.Click
        Me.Hide()
        frmMeal.Show()
    End Sub

    Private Sub btnEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployees.Click
        Me.Hide()
        frmEmployees.Show()
    End Sub


    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Me.Hide()
        frmReports.Show()
    End Sub

    Private Sub btnSettingsHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettingsHelp.Click
        Me.Hide()
        frmSettingsHelp.Show()
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

End Class