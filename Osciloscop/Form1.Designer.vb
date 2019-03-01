<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Pct_Cuadricula = New System.Windows.Forms.PictureBox()
        Me.GBx_Tensiones = New System.Windows.Forms.GroupBox()
        Me.Lbl_TensioMaxima = New System.Windows.Forms.Label()
        Me.TxtBx_TensionMaxima = New System.Windows.Forms.TextBox()
        Me.Lbl_V2 = New System.Windows.Forms.Label()
        Me.Lbl_V1 = New System.Windows.Forms.Label()
        Me.TxtBx_V2 = New System.Windows.Forms.TextBox()
        Me.TxtBx_V1 = New System.Windows.Forms.TextBox()
        Me.GBx_Tiempos = New System.Windows.Forms.GroupBox()
        Me.Lbl_Frecuencia = New System.Windows.Forms.Label()
        Me.TxtBx_Frecuencia = New System.Windows.Forms.TextBox()
        Me.Lbl_Tf = New System.Windows.Forms.Label()
        Me.Lbl_Tr = New System.Windows.Forms.Label()
        Me.Lbl_Pw = New System.Windows.Forms.Label()
        Me.Lbl_Per = New System.Windows.Forms.Label()
        Me.Lbl_Td = New System.Windows.Forms.Label()
        Me.TxtBx_Tf = New System.Windows.Forms.TextBox()
        Me.TxtBx_Tr = New System.Windows.Forms.TextBox()
        Me.TxtBx_Pw = New System.Windows.Forms.TextBox()
        Me.TxtBx_Td = New System.Windows.Forms.TextBox()
        Me.TxtBx_Per = New System.Windows.Forms.TextBox()
        Me.GBx_Escala = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Lbl_Tiempo = New System.Windows.Forms.Label()
        Me.Lbl_Tension = New System.Windows.Forms.Label()
        Me.TxtBx_Tiempo = New System.Windows.Forms.TextBox()
        Me.TxtBx_Tension = New System.Windows.Forms.TextBox()
        Me.GBx_TS = New System.Windows.Forms.GroupBox()
        Me.RBtn_Senoidal = New System.Windows.Forms.RadioButton()
        Me.RBtn_Pulse = New System.Windows.Forms.RadioButton()
        Me.Btn_VPulse = New System.Windows.Forms.Button()
        Me.Btn_Senoidal = New System.Windows.Forms.Button()
        Me.Btn_Ejes = New System.Windows.Forms.Button()
        Me.Pnl_Botons = New System.Windows.Forms.Panel()
        CType(Me.Pct_Cuadricula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBx_Tensiones.SuspendLayout()
        Me.GBx_Tiempos.SuspendLayout()
        Me.GBx_Escala.SuspendLayout()
        Me.GBx_TS.SuspendLayout()
        Me.Pnl_Botons.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pct_Cuadricula
        '
        Me.Pct_Cuadricula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pct_Cuadricula.BackColor = System.Drawing.Color.LightGray
        Me.Pct_Cuadricula.Location = New System.Drawing.Point(12, 12)
        Me.Pct_Cuadricula.Name = "Pct_Cuadricula"
        Me.Pct_Cuadricula.Size = New System.Drawing.Size(407, 367)
        Me.Pct_Cuadricula.TabIndex = 0
        Me.Pct_Cuadricula.TabStop = False
        '
        'GBx_Tensiones
        '
        Me.GBx_Tensiones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBx_Tensiones.Controls.Add(Me.Lbl_TensioMaxima)
        Me.GBx_Tensiones.Controls.Add(Me.TxtBx_TensionMaxima)
        Me.GBx_Tensiones.Controls.Add(Me.Lbl_V2)
        Me.GBx_Tensiones.Controls.Add(Me.Lbl_V1)
        Me.GBx_Tensiones.Controls.Add(Me.TxtBx_V2)
        Me.GBx_Tensiones.Controls.Add(Me.TxtBx_V1)
        Me.GBx_Tensiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBx_Tensiones.Location = New System.Drawing.Point(425, 12)
        Me.GBx_Tensiones.Name = "GBx_Tensiones"
        Me.GBx_Tensiones.Size = New System.Drawing.Size(235, 76)
        Me.GBx_Tensiones.TabIndex = 0
        Me.GBx_Tensiones.TabStop = False
        Me.GBx_Tensiones.Text = "Tensiones (V)"
        '
        'Lbl_TensioMaxima
        '
        Me.Lbl_TensioMaxima.AutoSize = True
        Me.Lbl_TensioMaxima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TensioMaxima.Location = New System.Drawing.Point(63, 16)
        Me.Lbl_TensioMaxima.Name = "Lbl_TensioMaxima"
        Me.Lbl_TensioMaxima.Size = New System.Drawing.Size(121, 16)
        Me.Lbl_TensioMaxima.TabIndex = 5
        Me.Lbl_TensioMaxima.Text = "Tensión Máxima"
        '
        'TxtBx_TensionMaxima
        '
        Me.TxtBx_TensionMaxima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx_TensionMaxima.Location = New System.Drawing.Point(87, 38)
        Me.TxtBx_TensionMaxima.Name = "TxtBx_TensionMaxima"
        Me.TxtBx_TensionMaxima.Size = New System.Drawing.Size(60, 20)
        Me.TxtBx_TensionMaxima.TabIndex = 4
        '
        'Lbl_V2
        '
        Me.Lbl_V2.AutoSize = True
        Me.Lbl_V2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_V2.Location = New System.Drawing.Point(172, 20)
        Me.Lbl_V2.Name = "Lbl_V2"
        Me.Lbl_V2.Size = New System.Drawing.Size(26, 16)
        Me.Lbl_V2.TabIndex = 3
        Me.Lbl_V2.Text = "V2"
        '
        'Lbl_V1
        '
        Me.Lbl_V1.AutoSize = True
        Me.Lbl_V1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_V1.Location = New System.Drawing.Point(35, 20)
        Me.Lbl_V1.Name = "Lbl_V1"
        Me.Lbl_V1.Size = New System.Drawing.Size(26, 16)
        Me.Lbl_V1.TabIndex = 2
        Me.Lbl_V1.Text = "V1"
        '
        'TxtBx_V2
        '
        Me.TxtBx_V2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx_V2.Location = New System.Drawing.Point(154, 39)
        Me.TxtBx_V2.Name = "TxtBx_V2"
        Me.TxtBx_V2.Size = New System.Drawing.Size(60, 20)
        Me.TxtBx_V2.TabIndex = 1
        '
        'TxtBx_V1
        '
        Me.TxtBx_V1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx_V1.Location = New System.Drawing.Point(21, 39)
        Me.TxtBx_V1.Name = "TxtBx_V1"
        Me.TxtBx_V1.Size = New System.Drawing.Size(60, 20)
        Me.TxtBx_V1.TabIndex = 0
        '
        'GBx_Tiempos
        '
        Me.GBx_Tiempos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBx_Tiempos.Controls.Add(Me.Lbl_Frecuencia)
        Me.GBx_Tiempos.Controls.Add(Me.TxtBx_Frecuencia)
        Me.GBx_Tiempos.Controls.Add(Me.Lbl_Tf)
        Me.GBx_Tiempos.Controls.Add(Me.Lbl_Tr)
        Me.GBx_Tiempos.Controls.Add(Me.Lbl_Pw)
        Me.GBx_Tiempos.Controls.Add(Me.Lbl_Per)
        Me.GBx_Tiempos.Controls.Add(Me.Lbl_Td)
        Me.GBx_Tiempos.Controls.Add(Me.TxtBx_Tf)
        Me.GBx_Tiempos.Controls.Add(Me.TxtBx_Tr)
        Me.GBx_Tiempos.Controls.Add(Me.TxtBx_Pw)
        Me.GBx_Tiempos.Controls.Add(Me.TxtBx_Td)
        Me.GBx_Tiempos.Controls.Add(Me.TxtBx_Per)
        Me.GBx_Tiempos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBx_Tiempos.Location = New System.Drawing.Point(425, 94)
        Me.GBx_Tiempos.Name = "GBx_Tiempos"
        Me.GBx_Tiempos.Size = New System.Drawing.Size(235, 148)
        Me.GBx_Tiempos.TabIndex = 2
        Me.GBx_Tiempos.TabStop = False
        Me.GBx_Tiempos.Text = "Tiempos (ms)"
        '
        'Lbl_Frecuencia
        '
        Me.Lbl_Frecuencia.AutoSize = True
        Me.Lbl_Frecuencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Frecuencia.Location = New System.Drawing.Point(72, 59)
        Me.Lbl_Frecuencia.Name = "Lbl_Frecuencia"
        Me.Lbl_Frecuencia.Size = New System.Drawing.Size(85, 16)
        Me.Lbl_Frecuencia.TabIndex = 12
        Me.Lbl_Frecuencia.Text = "Frecuencia"
        '
        'TxtBx_Frecuencia
        '
        Me.TxtBx_Frecuencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx_Frecuencia.Location = New System.Drawing.Point(87, 80)
        Me.TxtBx_Frecuencia.Name = "TxtBx_Frecuencia"
        Me.TxtBx_Frecuencia.Size = New System.Drawing.Size(60, 20)
        Me.TxtBx_Frecuencia.TabIndex = 11
        '
        'Lbl_Tf
        '
        Me.Lbl_Tf.AutoSize = True
        Me.Lbl_Tf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Tf.Location = New System.Drawing.Point(172, 87)
        Me.Lbl_Tf.Name = "Lbl_Tf"
        Me.Lbl_Tf.Size = New System.Drawing.Size(22, 16)
        Me.Lbl_Tf.TabIndex = 10
        Me.Lbl_Tf.Text = "Tf"
        '
        'Lbl_Tr
        '
        Me.Lbl_Tr.AutoSize = True
        Me.Lbl_Tr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Tr.Location = New System.Drawing.Point(104, 87)
        Me.Lbl_Tr.Name = "Lbl_Tr"
        Me.Lbl_Tr.Size = New System.Drawing.Size(23, 16)
        Me.Lbl_Tr.TabIndex = 9
        Me.Lbl_Tr.Text = "Tr"
        '
        'Lbl_Pw
        '
        Me.Lbl_Pw.AutoSize = True
        Me.Lbl_Pw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Pw.Location = New System.Drawing.Point(35, 87)
        Me.Lbl_Pw.Name = "Lbl_Pw"
        Me.Lbl_Pw.Size = New System.Drawing.Size(28, 16)
        Me.Lbl_Pw.TabIndex = 8
        Me.Lbl_Pw.Text = "Pw"
        '
        'Lbl_Per
        '
        Me.Lbl_Per.AutoSize = True
        Me.Lbl_Per.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Per.Location = New System.Drawing.Point(166, 18)
        Me.Lbl_Per.Name = "Lbl_Per"
        Me.Lbl_Per.Size = New System.Drawing.Size(32, 16)
        Me.Lbl_Per.TabIndex = 7
        Me.Lbl_Per.Text = "Per"
        '
        'Lbl_Td
        '
        Me.Lbl_Td.AutoSize = True
        Me.Lbl_Td.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Td.Location = New System.Drawing.Point(35, 16)
        Me.Lbl_Td.Name = "Lbl_Td"
        Me.Lbl_Td.Size = New System.Drawing.Size(27, 16)
        Me.Lbl_Td.TabIndex = 6
        Me.Lbl_Td.Text = "Td"
        '
        'TxtBx_Tf
        '
        Me.TxtBx_Tf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx_Tf.Location = New System.Drawing.Point(154, 106)
        Me.TxtBx_Tf.Name = "TxtBx_Tf"
        Me.TxtBx_Tf.Size = New System.Drawing.Size(60, 20)
        Me.TxtBx_Tf.TabIndex = 6
        '
        'TxtBx_Tr
        '
        Me.TxtBx_Tr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx_Tr.Location = New System.Drawing.Point(87, 106)
        Me.TxtBx_Tr.Name = "TxtBx_Tr"
        Me.TxtBx_Tr.Size = New System.Drawing.Size(60, 20)
        Me.TxtBx_Tr.TabIndex = 5
        '
        'TxtBx_Pw
        '
        Me.TxtBx_Pw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx_Pw.Location = New System.Drawing.Point(21, 106)
        Me.TxtBx_Pw.Name = "TxtBx_Pw"
        Me.TxtBx_Pw.Size = New System.Drawing.Size(60, 20)
        Me.TxtBx_Pw.TabIndex = 4
        '
        'TxtBx_Td
        '
        Me.TxtBx_Td.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx_Td.Location = New System.Drawing.Point(21, 37)
        Me.TxtBx_Td.Name = "TxtBx_Td"
        Me.TxtBx_Td.Size = New System.Drawing.Size(60, 20)
        Me.TxtBx_Td.TabIndex = 2
        '
        'TxtBx_Per
        '
        Me.TxtBx_Per.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx_Per.Location = New System.Drawing.Point(154, 37)
        Me.TxtBx_Per.Name = "TxtBx_Per"
        Me.TxtBx_Per.Size = New System.Drawing.Size(60, 20)
        Me.TxtBx_Per.TabIndex = 3
        '
        'GBx_Escala
        '
        Me.GBx_Escala.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBx_Escala.Controls.Add(Me.Label11)
        Me.GBx_Escala.Controls.Add(Me.Label10)
        Me.GBx_Escala.Controls.Add(Me.Lbl_Tiempo)
        Me.GBx_Escala.Controls.Add(Me.Lbl_Tension)
        Me.GBx_Escala.Controls.Add(Me.TxtBx_Tiempo)
        Me.GBx_Escala.Controls.Add(Me.TxtBx_Tension)
        Me.GBx_Escala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBx_Escala.Location = New System.Drawing.Point(425, 248)
        Me.GBx_Escala.Name = "GBx_Escala"
        Me.GBx_Escala.Size = New System.Drawing.Size(235, 76)
        Me.GBx_Escala.TabIndex = 3
        Me.GBx_Escala.TabStop = False
        Me.GBx_Escala.Text = "Escala"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(190, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "ms/c"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(87, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "V/c"
        '
        'Lbl_Tiempo
        '
        Me.Lbl_Tiempo.AutoSize = True
        Me.Lbl_Tiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Tiempo.Location = New System.Drawing.Point(123, 20)
        Me.Lbl_Tiempo.Name = "Lbl_Tiempo"
        Me.Lbl_Tiempo.Size = New System.Drawing.Size(61, 16)
        Me.Lbl_Tiempo.TabIndex = 8
        Me.Lbl_Tiempo.Text = "Tiempo"
        '
        'Lbl_Tension
        '
        Me.Lbl_Tension.AutoSize = True
        Me.Lbl_Tension.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Tension.Location = New System.Drawing.Point(18, 22)
        Me.Lbl_Tension.Name = "Lbl_Tension"
        Me.Lbl_Tension.Size = New System.Drawing.Size(64, 16)
        Me.Lbl_Tension.TabIndex = 7
        Me.Lbl_Tension.Text = "Tensión"
        '
        'TxtBx_Tiempo
        '
        Me.TxtBx_Tiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx_Tiempo.Location = New System.Drawing.Point(124, 39)
        Me.TxtBx_Tiempo.Name = "TxtBx_Tiempo"
        Me.TxtBx_Tiempo.Size = New System.Drawing.Size(60, 20)
        Me.TxtBx_Tiempo.TabIndex = 8
        '
        'TxtBx_Tension
        '
        Me.TxtBx_Tension.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx_Tension.Location = New System.Drawing.Point(21, 41)
        Me.TxtBx_Tension.Name = "TxtBx_Tension"
        Me.TxtBx_Tension.Size = New System.Drawing.Size(60, 20)
        Me.TxtBx_Tension.TabIndex = 7
        '
        'GBx_TS
        '
        Me.GBx_TS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBx_TS.Controls.Add(Me.RBtn_Senoidal)
        Me.GBx_TS.Controls.Add(Me.RBtn_Pulse)
        Me.GBx_TS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBx_TS.Location = New System.Drawing.Point(12, 385)
        Me.GBx_TS.Name = "GBx_TS"
        Me.GBx_TS.Size = New System.Drawing.Size(407, 41)
        Me.GBx_TS.TabIndex = 6
        Me.GBx_TS.TabStop = False
        Me.GBx_TS.Text = "Tipo de Señal"
        '
        'RBtn_Senoidal
        '
        Me.RBtn_Senoidal.AutoSize = True
        Me.RBtn_Senoidal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtn_Senoidal.Location = New System.Drawing.Point(244, 18)
        Me.RBtn_Senoidal.Name = "RBtn_Senoidal"
        Me.RBtn_Senoidal.Size = New System.Drawing.Size(74, 17)
        Me.RBtn_Senoidal.TabIndex = 11
        Me.RBtn_Senoidal.Text = "Senoidal"
        Me.RBtn_Senoidal.UseVisualStyleBackColor = True
        '
        'RBtn_Pulse
        '
        Me.RBtn_Pulse.AutoSize = True
        Me.RBtn_Pulse.Checked = True
        Me.RBtn_Pulse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtn_Pulse.Location = New System.Drawing.Point(72, 18)
        Me.RBtn_Pulse.Name = "RBtn_Pulse"
        Me.RBtn_Pulse.Size = New System.Drawing.Size(64, 17)
        Me.RBtn_Pulse.TabIndex = 10
        Me.RBtn_Pulse.TabStop = True
        Me.RBtn_Pulse.Text = "VPulse"
        Me.RBtn_Pulse.UseVisualStyleBackColor = True
        '
        'Btn_VPulse
        '
        Me.Btn_VPulse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_VPulse.Location = New System.Drawing.Point(17, 18)
        Me.Btn_VPulse.Name = "Btn_VPulse"
        Me.Btn_VPulse.Size = New System.Drawing.Size(75, 23)
        Me.Btn_VPulse.TabIndex = 9
        Me.Btn_VPulse.Text = "VPulse"
        Me.Btn_VPulse.UseVisualStyleBackColor = True
        '
        'Btn_Senoidal
        '
        Me.Btn_Senoidal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Senoidal.Location = New System.Drawing.Point(135, 18)
        Me.Btn_Senoidal.Name = "Btn_Senoidal"
        Me.Btn_Senoidal.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Senoidal.TabIndex = 8
        Me.Btn_Senoidal.Text = "Senoidal"
        Me.Btn_Senoidal.UseVisualStyleBackColor = True
        '
        'Btn_Ejes
        '
        Me.Btn_Ejes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Ejes.Location = New System.Drawing.Point(74, 57)
        Me.Btn_Ejes.Name = "Btn_Ejes"
        Me.Btn_Ejes.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Ejes.TabIndex = 9
        Me.Btn_Ejes.Text = "Ejes"
        Me.Btn_Ejes.UseVisualStyleBackColor = True
        '
        'Pnl_Botons
        '
        Me.Pnl_Botons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pnl_Botons.Controls.Add(Me.Btn_Ejes)
        Me.Pnl_Botons.Controls.Add(Me.Btn_Senoidal)
        Me.Pnl_Botons.Controls.Add(Me.Btn_VPulse)
        Me.Pnl_Botons.Location = New System.Drawing.Point(429, 328)
        Me.Pnl_Botons.Name = "Pnl_Botons"
        Me.Pnl_Botons.Size = New System.Drawing.Size(226, 97)
        Me.Pnl_Botons.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 438)
        Me.Controls.Add(Me.Pnl_Botons)
        Me.Controls.Add(Me.GBx_TS)
        Me.Controls.Add(Me.GBx_Escala)
        Me.Controls.Add(Me.GBx_Tiempos)
        Me.Controls.Add(Me.GBx_Tensiones)
        Me.Controls.Add(Me.Pct_Cuadricula)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Pct_Cuadricula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBx_Tensiones.ResumeLayout(False)
        Me.GBx_Tensiones.PerformLayout()
        Me.GBx_Tiempos.ResumeLayout(False)
        Me.GBx_Tiempos.PerformLayout()
        Me.GBx_Escala.ResumeLayout(False)
        Me.GBx_Escala.PerformLayout()
        Me.GBx_TS.ResumeLayout(False)
        Me.GBx_TS.PerformLayout()
        Me.Pnl_Botons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pct_Cuadricula As System.Windows.Forms.PictureBox
    Friend WithEvents GBx_Tensiones As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBx_V2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtBx_V1 As System.Windows.Forms.TextBox
    Friend WithEvents GBx_Tiempos As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBx_Tf As System.Windows.Forms.TextBox
    Friend WithEvents TxtBx_Tr As System.Windows.Forms.TextBox
    Friend WithEvents TxtBx_Pw As System.Windows.Forms.TextBox
    Friend WithEvents TxtBx_Td As System.Windows.Forms.TextBox
    Friend WithEvents TxtBx_Per As System.Windows.Forms.TextBox
    Friend WithEvents GBx_Escala As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBx_Tiempo As System.Windows.Forms.TextBox
    Friend WithEvents TxtBx_Tension As System.Windows.Forms.TextBox
    Friend WithEvents GBx_TS As System.Windows.Forms.GroupBox
    Friend WithEvents RBtn_Senoidal As System.Windows.Forms.RadioButton
    Friend WithEvents RBtn_Pulse As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_VPulse As System.Windows.Forms.Button
    Friend WithEvents Btn_Senoidal As System.Windows.Forms.Button
    Friend WithEvents Btn_Ejes As System.Windows.Forms.Button
    Friend WithEvents Lbl_V2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_V1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Tf As System.Windows.Forms.Label
    Friend WithEvents Lbl_Tr As System.Windows.Forms.Label
    Friend WithEvents Lbl_Pw As System.Windows.Forms.Label
    Friend WithEvents Lbl_Per As System.Windows.Forms.Label
    Friend WithEvents Lbl_Td As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Tiempo As System.Windows.Forms.Label
    Friend WithEvents Lbl_Tension As System.Windows.Forms.Label
    Friend WithEvents Pnl_Botons As System.Windows.Forms.Panel
    Friend WithEvents Lbl_TensioMaxima As System.Windows.Forms.Label
    Friend WithEvents TxtBx_TensionMaxima As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Frecuencia As System.Windows.Forms.Label
    Friend WithEvents TxtBx_Frecuencia As System.Windows.Forms.TextBox

End Class
