Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rng_ As New Random
        Dim keys As New List(Of String)({"K5PXQ-X1SW6-2RAMR-ZBM2X", "T1JVS-NNMBD-K1QTN-SUBP8", "AXFRG-JW6EC-47MP1-HV4EE", "F8616-XBS76-FKTZG-4DRA5", "F8KG2-9MAD3-7XCGM-98NCH", "F9FN7-JUXR6-VPCSB-3Q23Z", "FB75A-ZUAAP-G1AWS-NE6KQ", "8WMJA-7KW6V-1RVT8-V7S79", "8WY77-YRAWM-KFUEP-FRPP1", "8XD53-332PB-SKSU1-8EQJ9", "M888P-VE2XP-SA373-BX83Y", "M8NJ7-A5559-XHUAS-NFTMJ"})
        TextBox1.Text = keys(rng_.Next(0, 10))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
