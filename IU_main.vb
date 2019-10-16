Public Class IU_main

#Region "---- Procédures Formulaire ----"

    Private Sub IU_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '-- Initalisation des contrôles
        LB_resultat.Text = ""

    End Sub

    Private Sub NUD_a_ValueChanged(sender As Object, e As EventArgs) Handles NUD_a.ValueChanged
        If sender.Value < 0 Then
            sender.ForeColor = Color.Red
        Else
            sender.ForeColor = Color.Black
        End If
    End Sub

    Private Sub NUD_b_ValueChanged(sender As Object, e As EventArgs) Handles NUD_b.ValueChanged
        If sender.Value < 0 Then
            sender.ForeColor = Color.Red
        Else
            sender.ForeColor = Color.Black
        End If
    End Sub

#End Region

#Region "---- Procédures / Fonctions ----"

#End Region

#Region "---- Procédures Boutons ----"

    Private Sub BT_total_Click(sender As Object, e As EventArgs) Handles BT_total.Click
        Dim total As Double = NUD_a.Value + NUD_b.Value

        '-- Calcul
        LB_resultat.Text = total

        '-- Mise en forme
        If total < 0 Then
            LB_resultat.ForeColor = Color.Red
        Else
            LB_resultat.ForeColor = Color.Black
        End If

    End Sub



#End Region


End Class
