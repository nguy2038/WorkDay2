Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click

        Dim fullname As String
        fullname = txtFullName.Text

        Dim fullnametrimmed As String
        fullnametrimmed = fullname.Trim()

        Dim idxSpace As Integer
        idxSpace = fullnametrimmed.IndexOf(" ")

        Dim firstname As String
        firstname = fullnametrimmed.Substring(0, idxSpace)
        txtFirstName.Text = firstname

    End Sub

End Class
