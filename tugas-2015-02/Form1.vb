Public Class Form1
    Dim Angka1 As Integer
    Dim Angka2 As Integer
    Dim operasi As String
    Dim status As Boolean

    Private Sub input(ByVal angka As Char)
        If Me.status = True Then
            If (Me.resultText.Text = "0") Then
                Me.resultText.Text = Convert.ToString(angka)
            Else
                Dim resultText As TextBox = Me.resultText
                resultText.Text = (resultText.Text & Convert.ToString(angka))
            End If
        Else
            Me.resultText.Text = Convert.ToString(angka)
            Me.status = True
        End If
    End Sub
    Private Sub inputOperator(ByVal oprator As String)
        If (Me.resultText.Text <> "0") Then
            If (Me.operasi = String.Empty) Then
                Me.Angka1 = Convert.ToInt32(Me.resultText.Text)
                Me.resultText.Text = Me.Angka1.ToString
                Me.status = False
            Else
                Me.hitung()
            End If
            Me.operasi = oprator
        End If
    End Sub

    Private Sub hitung()
        Me.Angka2 = Convert.ToInt32(Me.resultText.Text)
        Select Case Me.operasi
            Case "+"
                Me.Angka1 = (Me.Angka1 + Me.Angka2)
                Exit Select
            Case "-"
                Me.Angka1 = (Me.Angka1 - Me.Angka2)
                Exit Select
        End Select
        Me.resultText.Text = Me.Angka1.ToString
        Me.status = False
    End Sub
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Me.resultText.Text = "0"
        Me.Angka1 = 0
        Me.operasi = String.Empty
    End Sub

    Private Sub BtnHasil_Click(sender As Object, e As EventArgs) Handles BtnHasil.Click
        If ((Me.resultText.Text <> "0") And (Me.Angka1 <> 0)) Then
            Me.hitung()
            Me.operasi = String.Empty
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Me.inputOperator("+")
    End Sub

    Private Sub BtnKurang_Click(sender As Object, e As EventArgs) Handles BtnKurang.Click
        Me.inputOperator("-")
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        If (Me.status AndAlso (Me.resultText.Text <> "0")) Then
            Dim resultText As TextBox = Me.resultText
            resultText.Text = (resultText.Text & "0")
        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Me.input("1")
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Me.input("2")
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Me.input("3")
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Me.input("4")
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        Me.input("5")
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        Me.input("6")
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        Me.input("7")
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        Me.input("8")
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        Me.input("9")
    End Sub
    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        End
    End Sub
End Class
