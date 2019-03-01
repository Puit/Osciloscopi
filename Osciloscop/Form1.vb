Public Class Form1
    Dim Clicat As Boolean = False
    Dim ClicatVPulse As Boolean = False
    Dim RBtn_VPulse As Boolean = False
    Dim RBtn_Senoi As Boolean = False


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CREEM UNA VARIABLE QUE DEPENDRA DE SI HEM CREAT ELS EIXOS PREVIAMENT O NO
        Dim Clicat, ClicatVPulse As Boolean
        Clicat = False
        ClicatVPulse = False
        If Clicat = False And ClicatVPulse = False Then
            Me.Pct_Cuadricula.Refresh()
        End If
    End Sub
    Private Sub Eixos_Horitzontals(ByVal Columnes As Integer, ByVal Files As Integer)
        'Crea els eixos en horitzontal

        Dim X1, Y1, X2, Y2, Amplada, Altura As Single
        Dim SenyalPen As New Pen(Color.Black, 1)
        Amplada = Pct_Cuadricula.Width / Columnes
        Altura = Pct_Cuadricula.Height
        For eixos = 0 To Columnes Step 1
            X1 = X1 + Amplada
            X2 = X1
            Y1 = 0
            Y2 = Altura
            Me.Pct_Cuadricula.CreateGraphics.DrawLine(SenyalPen, X1, Y1, X2, Y2)

        Next eixos

    End Sub
    Private Sub Eixos_Verticals(ByVal Columnes As Integer, ByVal Files As Integer)
        'Crea els eixos en vertical
        Dim X1, Y1, X2, Y2, Amplada, Altura As Single
        Dim SenyalPen As New Pen(Color.Black, 1)
        Amplada = Pct_Cuadricula.Width
        Altura = Pct_Cuadricula.Height / Files
        For eixos = 0 To Columnes Step 1
            X1 = 0
            X2 = Amplada
            Y1 = Y1 + Altura
            Y2 = Y1

            Me.Pct_Cuadricula.CreateGraphics.DrawLine(SenyalPen, X1, Y1, X2, Y2)

        Next eixos

    End Sub
    Private Sub Eixos_Horitzontals_Mitg(ByVal Columnes As Integer, ByVal Files As Integer)
        'Crea els eixos que hi han al mitg, però només els que van d'esquerra a dreta

        Dim X1, Y1, X2, Y2, Amplada, Altura As Single
        Dim SenyalPen As New Pen(Color.Black, 1)
        Amplada = Pct_Cuadricula.Width / (Columnes * 5)
        Altura = Pct_Cuadricula.Height
        X1 = 0
        X2 = 0
        Y1 = 0
        Y2 = 0
        For eixos = 0 To (Columnes * 5) Step 1
            X1 = X1 + Amplada
            X2 = X1
            Y1 = (Pct_Cuadricula.Height / 2) - (Pct_Cuadricula.Height / 150)
            Y2 = (Pct_Cuadricula.Height / 2) + (Pct_Cuadricula.Height / 150)
            Me.Pct_Cuadricula.CreateGraphics.DrawLine(SenyalPen, X1, Y1, X2, Y2)

        Next eixos

    End Sub
    Private Sub Eixos_Verticals_Mitg(ByVal Columnes As Integer, ByVal Files As Integer)
        'Crea els eixos que hi han al mitg, però només els que van d'adalt a baix
        Dim X1, Y1, X2, Y2, Amplada, Altura As Single
        Dim SenyalPen As New Pen(Color.Black, 1)
        Amplada = Pct_Cuadricula.Width
        Altura = Pct_Cuadricula.Height / (Files * 5)
        X1 = 0
        X2 = 0
        Y1 = 0
        Y2 = 0
        For eixos = 0 To (Files * 5) Step 1
            Y1 = Y1 + Altura
            Y2 = Y1
            X1 = (Pct_Cuadricula.Width / 2) - (Pct_Cuadricula.Width / 150)
            X2 = (Pct_Cuadricula.Width / 2) + (Pct_Cuadricula.Width / 150)
            Me.Pct_Cuadricula.CreateGraphics.DrawLine(SenyalPen, X1, Y1, X2, Y2)

        Next eixos

    End Sub
    Private Sub Eixos_Puntets_Alts(ByVal Columnes As Single, ByVal Files As Single)
        'Crea l'eix de punts que hi ha a la part alta de la pantalla

        Dim X1, Y1, Ajustar, Gruix, Amplada, Altura As Single
        Dim SenyalPen As New Pen(Color.Black, 1)
        Amplada = Pct_Cuadricula.Width / (Columnes * 5)
        Altura = Pct_Cuadricula.Height
        X1 = 0
        Ajustar = 0
        Y1 = 0
        Gruix = 0
        For eixos = 0 To (Columnes * 5) Step 1
            X1 = X1 + Amplada
            Ajustar = Pct_Cuadricula.Height / 250
            Y1 = (Pct_Cuadricula.Height / Files) * 1.5
            Gruix = Pct_Cuadricula.Height / 500
            Me.Pct_Cuadricula.CreateGraphics.DrawEllipse(SenyalPen, X1, Y1, Gruix - Ajustar, Gruix - Ajustar)

        Next eixos

    End Sub
    Private Sub Eixos_Puntets_Baix(ByVal Columnes As Single, ByVal Files As Single)
        'Crea l'eix de punts que hi ha a la part baixa de la pantalla

        Dim X1, Y1, Ajustar, Gruix, Amplada, Altura As Single
        Dim SenyalPen As New Pen(Color.Black, 1)
        Amplada = (Pct_Cuadricula.Width / (Columnes * 5))
        Altura = Pct_Cuadricula.Height
        X1 = 0
        Ajustar = 0
        Y1 = 0
        Gruix = 0
        For eixos = 0 To (Columnes * 5) Step 1
            X1 = (X1 + Amplada)
            Ajustar = Pct_Cuadricula.Height / 250
            Y1 = Pct_Cuadricula.Height - ((Pct_Cuadricula.Height / Files) * 1.5)
            Gruix = Pct_Cuadricula.Height / 500
            Me.Pct_Cuadricula.CreateGraphics.DrawEllipse(SenyalPen, X1, Y1, Gruix - Ajustar, Gruix - Ajustar)

        Next eixos

    End Sub
    Private Sub Grafica_VPulse(ByVal Amplada As Single)
        Dim PER, TD, TR, PW, TF, V2, V1, Tiempo, Tension, Zero, PERREF As Single
        Dim SenyalPen As New Pen(Color.Blue, 3)

        'CREEM LES VARIABLES NECESSARIES PER FER LA GRAFICA
        Zero = (Pct_Cuadricula.Height) / 2
        Tiempo = ((Pct_Cuadricula.Width) / 10) / CSng(TxtBx_Tiempo.Text)
        Tension = ((Pct_Cuadricula.Height) / 8) / CSng(TxtBx_Tension.Text)
        PER = (CSng(TxtBx_Per.Text) * Tiempo) - TD + TF
        PERREF = PER
        TD = CSng(TxtBx_Td.Text) * Tiempo
        TR = TD + CSng(TxtBx_Tr.Text) * Tiempo
        PW = TR + CSng(TxtBx_Pw.Text) * Tiempo
        TF = PW + CSng(TxtBx_Tf.Text) * Tiempo
        V2 = Zero - CSng(TxtBx_V2.Text) * Tension
        V1 = Zero - CSng(TxtBx_V1.Text) * Tension
        'Condicionals per si les dades introduides no son correctes
        If TxtBx_Tiempo.Text > 0 Then
            If TxtBx_Tension.Text > 0 Then
                If TxtBx_Pw.Text >= 0 Then
                    If TxtBx_Tr.Text >= 0 Then
                        If TxtBx_Tf.Text >= 0 Then
                            If TxtBx_Td.Text >= 0 Then
                                If PER < TF Then
                                    TxtBx_Per.BackColor = Color.Red
                                    MsgBox("El PER ha de ser mes gran que la suma dels altres temps")
                                Else
                                    TxtBx_Per.BackColor = Color.White

                                    '(SenyalPen, x1, y1, x2, y2)    Primera linea _
                                    Me.Pct_Cuadricula.CreateGraphics.DrawLine(SenyalPen, 0, V1, TD, V1)

                                    For Dibuix = 0 To Amplada Step PERREF
                                        'Segon linea /
                                        Me.Pct_Cuadricula.CreateGraphics.DrawLine(SenyalPen, TD, V1, TR, V2)
                                        'Tercera linea --
                                        Me.Pct_Cuadricula.CreateGraphics.DrawLine(SenyalPen, TR, V2, PW, V2)
                                        'Quarta linea \
                                        Me.Pct_Cuadricula.CreateGraphics.DrawLine(SenyalPen, PW, V2, TF, V1)
                                        'Cinquena linea _
                                        Me.Pct_Cuadricula.CreateGraphics.DrawLine(SenyalPen, TF, V1, PER, V1)

                                        TD = PER
                                        TR = TD + CSng(TxtBx_Tr.Text) * Tiempo
                                        PW = TR + CSng(TxtBx_Pw.Text) * Tiempo
                                        TF = PW + CSng(TxtBx_Tf.Text) * Tiempo
                                        PER = PER + PERREF

                                    Next Dibuix

                                End If
                            Else
                                MsgBox("El temps Td ha de ser igual o més gran que 0")
                            End If
                        Else
                            MsgBox("El temps Tf ha de ser igual o més gran que 0")
                        End If
                    Else
                        MsgBox("El temps Tr ha de ser igual o més gran que 0")
                    End If
                Else
                    MsgBox("El temps Pw ha de ser igual o més gran que 0")
                End If
        Else
                MsgBox("La tensió ha de ser més gran que 0")
        End If
            Else
                MsgBox("El temps ha de ser més gran que 0")
            End If

    End Sub

    Private Sub Btn_Ejes_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Ejes.Click
        'CLICAT QUEDA ACTIVAT
        Clicat = True
        Me.Pct_Cuadricula.Refresh()
        Me.Pct_Cuadricula.CreateGraphics()
        Eixos_Horitzontals(10, 8)
        Eixos_Verticals(10, 8)
        Eixos_Horitzontals_Mitg(10, 8)
        Eixos_Verticals_Mitg(10, 8)
        Eixos_Puntets_Alts(10, 8)
        Eixos_Puntets_Baix(10, 8)
    End Sub

    Private Sub Pct_Cuadricula_SizeChanged(sender As Object, e As System.EventArgs) Handles Pct_Cuadricula.SizeChanged
        'NOMES ACTUA SI CLICAT ESTA ACTIVAT, AIXÍ NO CREA LES LINIES SI CANVIEM LA MIDA DE LA PANTALLA
        'PERO SENSE APRETAR EL BOTÓ
        If Clicat = True Then
            Me.Pct_Cuadricula.Refresh()
            Me.Pct_Cuadricula.CreateGraphics()
            Eixos_Horitzontals(10, 8)
            Eixos_Verticals(10, 8)
            Eixos_Horitzontals_Mitg(10, 8)
            Eixos_Verticals_Mitg(10, 8)
            Eixos_Puntets_Alts(10, 8)
            Eixos_Puntets_Baix(10, 8)
        End If
        If ClicatVPulse = True Then
            Me.Pct_Cuadricula.Refresh()
            Me.Pct_Cuadricula.CreateGraphics()
            Eixos_Horitzontals(10, 8)
            Eixos_Verticals(10, 8)
            Eixos_Horitzontals_Mitg(10, 8)
            Eixos_Verticals_Mitg(10, 8)
            Eixos_Puntets_Alts(10, 8)
            Eixos_Puntets_Baix(10, 8)
            Grafica_VPulse(Pct_Cuadricula.Width)
        End If
    End Sub


    Private Sub Btn_VPulse_Click(sender As System.Object, e As System.EventArgs) Handles Btn_VPulse.Click
        If IsNumeric(TxtBx_Per.Text) And IsNumeric(TxtBx_Pw.Text) And IsNumeric(TxtBx_Td.Text) And IsNumeric(TxtBx_Tension.Text) And IsNumeric(TxtBx_Tf.Text) And IsNumeric(TxtBx_Tiempo.Text) And IsNumeric(TxtBx_Tr.Text) And IsNumeric(TxtBx_V1.Text) And IsNumeric(TxtBx_V2.Text) Then
            'CREEM TOTS ELS EIXOS
            Clicat = True
            ClicatVPulse = True
            If RBtn_VPulse = True Then
                Me.Pct_Cuadricula.Refresh()
                Me.Pct_Cuadricula.CreateGraphics()
                Eixos_Horitzontals(10, 8)
                Eixos_Verticals(10, 8)
                Eixos_Horitzontals_Mitg(10, 8)
                Eixos_Verticals_Mitg(10, 8)
                Eixos_Puntets_Alts(10, 8)
                Eixos_Puntets_Baix(10, 8)
                Grafica_VPulse(Pct_Cuadricula.Width)
            End If
        End If
    End Sub
    'D'aqui cap a baix son tots els MouseWheel
    Private Sub TxtBx_Per_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TxtBx_Per.MouseWheel
        If IsNumeric(TxtBx_Per.Text) Then
            If e.Delta > 0 Then
                TxtBx_Per.Text = TxtBx_Per.Text + 1
            Else
                TxtBx_Per.Text = TxtBx_Per.Text - 1
            End If
        Else
            TxtBx_Per.Text = "0"

        End If
    End Sub

    Private Sub TxtBx_Pw_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TxtBx_Pw.MouseWheel
        If IsNumeric(TxtBx_Pw.Text) Then
            If e.Delta > 0 Then
                TxtBx_Pw.Text = TxtBx_Pw.Text + 1
            Else
                TxtBx_Pw.Text = TxtBx_Pw.Text - 1
            End If
        Else
            TxtBx_Pw.Text = "0"

        End If
    End Sub

    Private Sub TxtBx_Td_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TxtBx_Td.MouseWheel
        If IsNumeric(TxtBx_Td.Text) Then
            If e.Delta > 0 Then
                TxtBx_Td.Text = TxtBx_Td.Text + 1
            Else
                TxtBx_Td.Text = TxtBx_Td.Text - 1
            End If
        Else
            TxtBx_Td.Text = "0"

        End If
    End Sub

    Private Sub TxtBx_Tension_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TxtBx_Tension.MouseWheel
        If IsNumeric(TxtBx_Tension.Text) Then
            If e.Delta > 0 Then
                TxtBx_Tension.Text = TxtBx_Tension.Text + 1
            Else
                TxtBx_Tension.Text = TxtBx_Tension.Text - 1
            End If
        Else
            TxtBx_Tension.Text = "0"

        End If
    End Sub

    Private Sub TxtBx_Tf_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TxtBx_Tf.MouseWheel
        If IsNumeric(TxtBx_Tf.Text) Then
            If e.Delta > 0 Then
                TxtBx_Tf.Text = TxtBx_Tf.Text + 1
            Else
                TxtBx_Tf.Text = TxtBx_Tf.Text - 1
            End If
        Else
            TxtBx_Tf.Text = "0"

        End If
    End Sub

    Private Sub TxtBx_Tiempo_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TxtBx_Tiempo.MouseWheel
        If IsNumeric(TxtBx_Tiempo.Text) Then
            If e.Delta > 0 Then
                TxtBx_Tiempo.Text = TxtBx_Tiempo.Text + 1
            Else
                TxtBx_Tiempo.Text = TxtBx_Tiempo.Text - 1
            End If
        Else
            TxtBx_Tiempo.Text = "0"

        End If
    End Sub

    Private Sub TxtBx_Tr_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TxtBx_Tr.MouseWheel
        If IsNumeric(TxtBx_Tr.Text) Then
            If e.Delta > 0 Then
                TxtBx_Tr.Text = TxtBx_Tr.Text + 1
            Else
                TxtBx_Tr.Text = TxtBx_Tr.Text - 1
            End If
        Else
            TxtBx_Tr.Text = "0"

        End If
    End Sub

    Private Sub TxtBx_V1_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TxtBx_V1.MouseWheel
        If IsNumeric(TxtBx_V1.Text) Then
            If e.Delta > 0 Then
                TxtBx_V1.Text = TxtBx_V1.Text + 1
            Else
                TxtBx_V1.Text = TxtBx_V1.Text - 1
            End If
        Else
            TxtBx_V1.Text = "0"

        End If
    End Sub

    Private Sub TxtBx_V2_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TxtBx_V2.MouseWheel

        If IsNumeric(TxtBx_V2.Text) Then
            If e.Delta > 0 Then
                TxtBx_V2.Text = TxtBx_V2.Text + 1
            Else
                TxtBx_V2.Text = TxtBx_V2.Text - 1
            End If
        Else
            TxtBx_V2.Text = "0"

        End If
    End Sub

    Private Sub RBtn_Pulse_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RBtn_Pulse.CheckedChanged
        RBtn_VPulse = True
        RBtn_Senoi = False
        If RBtn_VPulse = True Then
            Lbl_Frecuencia.Visible = False
            TxtBx_Frecuencia.Visible = False
            Lbl_TensioMaxima.Visible = False
            TxtBx_TensionMaxima.Visible = False
            TxtBx_V1.Visible = True
            TxtBx_V2.Visible = True
            Lbl_V1.Visible = True
            Lbl_V2.Visible = True
            Btn_VPulse.Enabled = True
            Btn_Senoidal.Enabled = False

            Lbl_Td.Visible = True
            TxtBx_Td.Visible = True
            Lbl_Per.Visible = True
            TxtBx_Per.Visible = True
            Lbl_Pw.Visible = True
            TxtBx_Pw.Visible = True
            Lbl_Tr.Visible = True
            TxtBx_Tr.Visible = True
            Lbl_Tf.Visible = True
            TxtBx_Tf.Visible = True
        End If
    End Sub

    Private Sub RBtn_Senoidal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RBtn_Senoidal.CheckedChanged
        RBtn_VPulse = False
        RBtn_Senoi = True
        If RBtn_Senoi = True Then
            Lbl_Frecuencia.Visible = True
            TxtBx_Frecuencia.Visible = True
            Lbl_TensioMaxima.Visible = True
            TxtBx_TensionMaxima.Visible = True
            TxtBx_V1.Visible = False
            TxtBx_V2.Visible = False
            Lbl_V1.Visible = False
            Lbl_V2.Visible = False
            Btn_VPulse.Enabled = False
            Btn_Senoidal.Enabled = True

            Lbl_Td.Visible = False
            TxtBx_Td.Visible = False
            Lbl_Per.Visible = False
            TxtBx_Per.Visible = False
            Lbl_Pw.Visible = False
            TxtBx_Pw.Visible = False
            Lbl_Tr.Visible = False
            TxtBx_Tr.Visible = False
            Lbl_Tf.Visible = False
            TxtBx_Tf.Visible = False
        End If
    End Sub
    Private Sub Btn_Senoidal_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Senoidal.Click
        'Aquesta part no funciona correctament...
        Dim TMaxima, Frecuencia, Tiempo, Tensio, Vx1, Vy1, Vx2, Vy2, Amplada As Single
        Dim SenyalPen As New Pen(Color.Blue, 3)

        If IsNumeric(TxtBx_Frecuencia.Text) And IsNumeric(TxtBx_TensionMaxima.Text) And IsNumeric(TxtBx_Tiempo.Text) And IsNumeric(TxtBx_Tension.Text) Then
            Frecuencia = CSng(TxtBx_Frecuencia.Text)
            Amplada = Pct_Cuadricula.Width
            Tiempo = CSng(TxtBx_Tiempo.Text) / 10
            Tensio = CSng(TxtBx_Tension.Text)
            TMaxima = CSng(TxtBx_TensionMaxima.Text)
            Clicat = True

            For Dibuix = 0 To Amplada Step Tiempo / 10
                Vy1 = TMaxima * Math.Sin(2 * (Math.PI) * Frecuencia * Tiempo)
                Vx1 = TMaxima * Math.Cos(2 * (Math.PI) * Frecuencia * Tiempo)
                Vy2 = Vy1 - 0.01
                Vx2 = Vx1 - 0.01
                'Segon linea /                                       x1,y1,x2,y2
                Me.Pct_Cuadricula.CreateGraphics.DrawLine(SenyalPen, Vx1, Vy1, Vx2, Vy2)

                Me.Pct_Cuadricula.Refresh()
                Me.Pct_Cuadricula.CreateGraphics()
                Eixos_Horitzontals(10, 8)
                Eixos_Verticals(10, 8)
                Eixos_Horitzontals_Mitg(10, 8)
                Eixos_Verticals_Mitg(10, 8)
                Eixos_Puntets_Alts(10, 8)
                Eixos_Puntets_Baix(10, 8)

            Next Dibuix
        End If
    End Sub
 
End Class
