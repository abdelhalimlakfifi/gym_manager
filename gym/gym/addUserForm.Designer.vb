<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addUserForm
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
        Me.components = New System.ComponentModel.Container()
        Me.nomBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.prenomBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.phoneBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.prixBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.adminBox = New System.Windows.Forms.TextBox()
        Me.sexeBox = New System.Windows.Forms.ComboBox()
        Me.dateBox = New System.Windows.Forms.DateTimePicker()
        Me.moisBox = New System.Windows.Forms.NumericUpDown()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GymdataDataSet = New gym.gymdataDataSet()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New gym.gymdataDataSetTableAdapters.userTableAdapter()
        Me.TableAdapterManager = New gym.gymdataDataSetTableAdapters.TableAdapterManager()
        CType(Me.moisBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GymdataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nomBox
        '
        Me.nomBox.Location = New System.Drawing.Point(244, 86)
        Me.nomBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nomBox.Name = "nomBox"
        Me.nomBox.Size = New System.Drawing.Size(179, 24)
        Me.nomBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(31, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(31, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Prenom"
        '
        'prenomBox
        '
        Me.prenomBox.Location = New System.Drawing.Point(244, 118)
        Me.prenomBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.prenomBox.Name = "prenomBox"
        Me.prenomBox.Size = New System.Drawing.Size(179, 24)
        Me.prenomBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(31, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sexe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(31, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Phone"
        '
        'phoneBox
        '
        Me.phoneBox.Location = New System.Drawing.Point(244, 182)
        Me.phoneBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.phoneBox.Name = "phoneBox"
        Me.phoneBox.Size = New System.Drawing.Size(179, 24)
        Me.phoneBox.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(440, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Prix d'abonnement"
        '
        'prixBox
        '
        Me.prixBox.Location = New System.Drawing.Point(650, 86)
        Me.prixBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.prixBox.Name = "prixBox"
        Me.prixBox.Size = New System.Drawing.Size(179, 24)
        Me.prixBox.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(440, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "date d'enregistrement"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(440, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Mois Payer"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(440, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Admin Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'adminBox
        '
        Me.adminBox.Location = New System.Drawing.Point(650, 187)
        Me.adminBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.adminBox.Name = "adminBox"
        Me.adminBox.Size = New System.Drawing.Size(179, 24)
        Me.adminBox.TabIndex = 14
        '
        'sexeBox
        '
        Me.sexeBox.FormattingEnabled = True
        Me.sexeBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.sexeBox.Location = New System.Drawing.Point(244, 151)
        Me.sexeBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sexeBox.Name = "sexeBox"
        Me.sexeBox.Size = New System.Drawing.Size(179, 24)
        Me.sexeBox.TabIndex = 16
        '
        'dateBox
        '
        Me.dateBox.Location = New System.Drawing.Point(650, 124)
        Me.dateBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dateBox.Name = "dateBox"
        Me.dateBox.Size = New System.Drawing.Size(179, 24)
        Me.dateBox.TabIndex = 17
        '
        'moisBox
        '
        Me.moisBox.Location = New System.Drawing.Point(650, 157)
        Me.moisBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.moisBox.Name = "moisBox"
        Me.moisBox.Size = New System.Drawing.Size(180, 24)
        Me.moisBox.TabIndex = 18
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Location = New System.Drawing.Point(319, 262)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(227, 47)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add User"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'GymdataDataSet
        '
        Me.GymdataDataSet.DataSetName = "gymdataDataSet"
        Me.GymdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.GymdataDataSet
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = gym.gymdataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Me.UserTableAdapter
        '
        'addUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(864, 437)
        Me.Controls.Add(Me.btnAdd)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "addUserForm"
        Me.Text = "addUserForm"
        CType(Me.moisBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GymdataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nomBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents prenomBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents phoneBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents prixBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents adminBox As System.Windows.Forms.TextBox
    Friend WithEvents sexeBox As System.Windows.Forms.ComboBox
    Friend WithEvents dateBox As System.Windows.Forms.DateTimePicker
    Friend WithEvents moisBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents GymdataDataSet As gym.gymdataDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As gym.gymdataDataSetTableAdapters.userTableAdapter
    Friend WithEvents TableAdapterManager As gym.gymdataDataSetTableAdapters.TableAdapterManager
End Class
