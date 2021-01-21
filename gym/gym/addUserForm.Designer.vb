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
        Dim ID_usersLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim Last_nameLabel As System.Windows.Forms.Label
        Dim SexeLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Prix_d_abonnementLabel As System.Windows.Forms.Label
        Dim Registration_dateLabel As System.Windows.Forms.Label
        Dim Mois_payerLabel As System.Windows.Forms.Label
        Dim UnameLabel As System.Windows.Forms.Label
        Me.GymdataDataSet = New gym.gymdataDataSet()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New gym.gymdataDataSetTableAdapters.userTableAdapter()
        Me.TableAdapterManager = New gym.gymdataDataSetTableAdapters.TableAdapterManager()
        Me.ID_usersTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.SexeTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Prix_d_abonnementTextBox = New System.Windows.Forms.TextBox()
        Me.Registration_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Mois_payerTextBox = New System.Windows.Forms.TextBox()
        Me.UnameTextBox = New System.Windows.Forms.TextBox()
        ID_usersLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        Last_nameLabel = New System.Windows.Forms.Label()
        SexeLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Prix_d_abonnementLabel = New System.Windows.Forms.Label()
        Registration_dateLabel = New System.Windows.Forms.Label()
        Mois_payerLabel = New System.Windows.Forms.Label()
        UnameLabel = New System.Windows.Forms.Label()
        CType(Me.GymdataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ID_usersLabel
        '
        ID_usersLabel.AutoSize = True
        ID_usersLabel.Location = New System.Drawing.Point(117, 61)
        ID_usersLabel.Name = "ID_usersLabel"
        ID_usersLabel.Size = New System.Drawing.Size(49, 13)
        ID_usersLabel.TabIndex = 1
        ID_usersLabel.Text = "ID users:"
        '
        'ID_usersTextBox
        '
        Me.ID_usersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "ID_users", True))
        Me.ID_usersTextBox.Location = New System.Drawing.Point(219, 58)
        Me.ID_usersTextBox.Name = "ID_usersTextBox"
        Me.ID_usersTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_usersTextBox.TabIndex = 2
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.Location = New System.Drawing.Point(117, 87)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(55, 13)
        First_nameLabel.TabIndex = 3
        First_nameLabel.Text = "first name:"
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "first_name", True))
        Me.First_nameTextBox.Location = New System.Drawing.Point(219, 84)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.First_nameTextBox.TabIndex = 4
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.Location = New System.Drawing.Point(117, 113)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(55, 13)
        Last_nameLabel.TabIndex = 5
        Last_nameLabel.Text = "last name:"
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "last_name", True))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(219, 110)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Last_nameTextBox.TabIndex = 6
        '
        'SexeLabel
        '
        SexeLabel.AutoSize = True
        SexeLabel.Location = New System.Drawing.Point(117, 139)
        SexeLabel.Name = "SexeLabel"
        SexeLabel.Size = New System.Drawing.Size(32, 13)
        SexeLabel.TabIndex = 7
        SexeLabel.Text = "sexe:"
        '
        'SexeTextBox
        '
        Me.SexeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "sexe", True))
        Me.SexeTextBox.Location = New System.Drawing.Point(219, 136)
        Me.SexeTextBox.Name = "SexeTextBox"
        Me.SexeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SexeTextBox.TabIndex = 8
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(117, 165)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(40, 13)
        PhoneLabel.TabIndex = 9
        PhoneLabel.Text = "phone:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(219, 162)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneTextBox.TabIndex = 10
        '
        'Prix_d_abonnementLabel
        '
        Prix_d_abonnementLabel.AutoSize = True
        Prix_d_abonnementLabel.Location = New System.Drawing.Point(117, 191)
        Prix_d_abonnementLabel.Name = "Prix_d_abonnementLabel"
        Prix_d_abonnementLabel.Size = New System.Drawing.Size(96, 13)
        Prix_d_abonnementLabel.TabIndex = 11
        Prix_d_abonnementLabel.Text = "prix d'abonnement:"
        '
        'Prix_d_abonnementTextBox
        '
        Me.Prix_d_abonnementTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "prix_d'abonnement", True))
        Me.Prix_d_abonnementTextBox.Location = New System.Drawing.Point(219, 188)
        Me.Prix_d_abonnementTextBox.Name = "Prix_d_abonnementTextBox"
        Me.Prix_d_abonnementTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Prix_d_abonnementTextBox.TabIndex = 12
        '
        'Registration_dateLabel
        '
        Registration_dateLabel.AutoSize = True
        Registration_dateLabel.Location = New System.Drawing.Point(117, 218)
        Registration_dateLabel.Name = "Registration_dateLabel"
        Registration_dateLabel.Size = New System.Drawing.Size(85, 13)
        Registration_dateLabel.TabIndex = 13
        Registration_dateLabel.Text = "registration date:"
        '
        'Registration_dateDateTimePicker
        '
        Me.Registration_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UserBindingSource, "registration_date", True))
        Me.Registration_dateDateTimePicker.Location = New System.Drawing.Point(219, 214)
        Me.Registration_dateDateTimePicker.Name = "Registration_dateDateTimePicker"
        Me.Registration_dateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Registration_dateDateTimePicker.TabIndex = 14
        '
        'Mois_payerLabel
        '
        Mois_payerLabel.AutoSize = True
        Mois_payerLabel.Location = New System.Drawing.Point(117, 243)
        Mois_payerLabel.Name = "Mois_payerLabel"
        Mois_payerLabel.Size = New System.Drawing.Size(60, 13)
        Mois_payerLabel.TabIndex = 15
        Mois_payerLabel.Text = "mois payer:"
        '
        'Mois_payerTextBox
        '
        Me.Mois_payerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "mois_payer", True))
        Me.Mois_payerTextBox.Location = New System.Drawing.Point(219, 240)
        Me.Mois_payerTextBox.Name = "Mois_payerTextBox"
        Me.Mois_payerTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Mois_payerTextBox.TabIndex = 16
        '
        'UnameLabel
        '
        UnameLabel.AutoSize = True
        UnameLabel.Location = New System.Drawing.Point(117, 269)
        UnameLabel.Name = "UnameLabel"
        UnameLabel.Size = New System.Drawing.Size(44, 13)
        UnameLabel.TabIndex = 17
        UnameLabel.Text = "Uname:"
        '
        'UnameTextBox
        '
        Me.UnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "Uname", True))
        Me.UnameTextBox.Location = New System.Drawing.Point(219, 266)
        Me.UnameTextBox.Name = "UnameTextBox"
        Me.UnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UnameTextBox.TabIndex = 18
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 322)
        Me.Controls.Add(ID_usersLabel)
        Me.Controls.Add(Me.ID_usersTextBox)
        Me.Controls.Add(First_nameLabel)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(Last_nameLabel)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(SexeLabel)
        Me.Controls.Add(Me.SexeTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Prix_d_abonnementLabel)
        Me.Controls.Add(Me.Prix_d_abonnementTextBox)
        Me.Controls.Add(Registration_dateLabel)
        Me.Controls.Add(Me.Registration_dateDateTimePicker)
        Me.Controls.Add(Mois_payerLabel)
        Me.Controls.Add(Me.Mois_payerTextBox)
        Me.Controls.Add(UnameLabel)
        Me.Controls.Add(Me.UnameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.GymdataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GymdataDataSet As gym.gymdataDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As gym.gymdataDataSetTableAdapters.userTableAdapter
    Friend WithEvents TableAdapterManager As gym.gymdataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ID_usersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SexeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Prix_d_abonnementTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Registration_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Mois_payerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnameTextBox As System.Windows.Forms.TextBox
End Class
