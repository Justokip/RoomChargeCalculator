Public Class Form1

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNightlyCharge.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decRoomCharges As Integer
        Dim decAddCharges As Integer
        Dim decSubTotal As Decimal
        txtNightlyCharge.Text = (80.5)
        decRoomCharges = CDec(txtNights.Text * txtNightlyCharge.Text)
        lblRoomCharges = decRoomCharges
        decAddCharges = CDec(txtRoomService.Text + txtMisc.Text + txtTelephone.Text)
        lblAddCharges = decRoomCharges
        decSubTotal = decRoomCharges + decAddCharges

    End Sub
End Class
