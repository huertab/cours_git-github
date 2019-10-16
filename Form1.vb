Public Class IU_main

#Region "---- Procédures Formulaire ----"

    Private Sub IU_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '-- Initalisation des contrôles
        LB_resultat.Text = ""

    End Sub

#End Region

#Region "---- Procédures / Fonctions ----"

#End Region

#Region "---- Procédures Boutons ----"

    Private Sub BT_total_Click(sender As Object, e As EventArgs) Handles BT_total.Click
        LB_resultat.Text = NUD_a.Value + NUD_b.Value
    End Sub

#End Region


End Class
