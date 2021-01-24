<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Validation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.moisBox = New System.Windows.Forms.NumericUpDown()
        Me.dateBox = New System.Windows.Forms.DateTimePicker()
        Me.sexeBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.adminBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.prixBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.phoneBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.prenomBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nomBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.moisBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(785, 256)
        Me.DataGridView1.TabIndex = 0
        '
        'moisBox
        '
        Me.moisBox.Location = New System.Drawing.Point(442, 361)
        Me.moisBox.Name = "moisBox"
        Me.moisBox.Size = New System.Drawing.Size(154, 20)
        Me.moisBox.TabIndex = 34
        '
        'dateBox
        '
        Me.dateBox.Location = New System.Drawing.Point(442, 335)
        Me.dateBox.Name = "dateBox"
        Me.dateBox.Size = New System.Drawing.Size(154, 20)
        Me.dateBox.TabIndex = 33
        '
        'sexeBox
        '
        Me.sexeBox.Enabled = False
        Me.sexeBox.FormattingEnabled = True
        Me.sexeBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.sexeBox.Location = New System.Drawing.Point(138, 360)
        Me.sexeBox.Name = "sexeBox"
        Me.sexeBox.Size = New System.Drawing.Size(154, 21)
        Me.sexeBox.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(326, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Admin Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'adminBox
        '
        Me.adminBox.Location = New System.Drawing.Point(442, 385)
        Me.adminBox.Name = "adminBox"
        Me.adminBox.Size = New System.Drawing.Size(154, 20)
        Me.adminBox.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(326, 362)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Mois Payer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(326, 337)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "date de validation"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(326, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Prix d'abonnement"
        '
        'prixBox
        '
        Me.prixBox.Enabled = False
        Me.prixBox.Location = New System.Drawing.Point(442, 307)
        Me.prixBox.Name = "prixBox"
        Me.prixBox.Size = New System.Drawing.Size(154, 20)
        Me.prixBox.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 392)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Phone"
        '
        'phoneBox
        '
        Me.phoneBox.Enabled = False
        Me.phoneBox.Location = New System.Drawing.Point(138, 385)
        Me.phoneBox.Name = "phoneBox"
        Me.phoneBox.Size = New System.Drawing.Size(154, 20)
        Me.phoneBox.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Sexe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Prenom"
        '
        'prenomBox
        '
        Me.prenomBox.Enabled = False
        Me.prenomBox.Location = New System.Drawing.Point(138, 333)
        Me.prenomBox.Name = "prenomBox"
        Me.prenomBox.Size = New System.Drawing.Size(154, 20)
        Me.prenomBox.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nom"
        '
        'nomBox
        '
        Me.nomBox.Enabled = False
        Me.nomBox.Location = New System.Drawing.Point(138, 307)
        Me.nomBox.Name = "nomBox"
        Me.nomBox.Size = New System.Drawing.Size(154, 20)
        Me.nomBox.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(650, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 36)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Valide"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(254, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(331, 20)
        Me.TextBox1.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(201, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Search: "
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(650, 362)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 36)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Validation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 417)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.moisBox)
        Me.Controls.Add(Me.dateBox)
        Me.Controls.Add(Me.sexeBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.adminBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.prixBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.phoneBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.prenomBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nomBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Validation"
        Me.Text = "Validation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.moisBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents moisBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents dateBox As System.Windows.Forms.DateTimePicker
    Friend WithEvents sexeBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents adminBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents prixBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents phoneBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents prenomBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nomBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
