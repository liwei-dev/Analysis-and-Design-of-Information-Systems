<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.text1 = New System.Windows.Forms.Label()
        Me.text2 = New System.Windows.Forms.Label()
        Me.usernameform1 = New System.Windows.Forms.TextBox()
        Me.passwordform1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.login = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BioskopDataSet1 = New BISKOP.bioskopDataSet1()
        Me.PelangganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PelangganTableAdapter = New BISKOP.bioskopDataSet1TableAdapters.PelangganTableAdapter()
        Me.PelangganidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BioskopDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelangganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 58)
        Me.Label1.TabIndex = 1
        '
        'text1
        '
        Me.text1.AutoSize = True
        Me.text1.Font = New System.Drawing.Font("Segoe Print", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text1.Location = New System.Drawing.Point(160, 193)
        Me.text1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(169, 43)
        Me.text1.TabIndex = 2
        Me.text1.Text = "USERNAME"
        '
        'text2
        '
        Me.text2.AutoSize = True
        Me.text2.Font = New System.Drawing.Font("Segoe Print", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text2.Location = New System.Drawing.Point(160, 246)
        Me.text2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.text2.Name = "text2"
        Me.text2.Size = New System.Drawing.Size(171, 43)
        Me.text2.TabIndex = 3
        Me.text2.Text = "PASSWORD"
        '
        'usernameform1
        '
        Me.usernameform1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.usernameform1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameform1.Location = New System.Drawing.Point(341, 208)
        Me.usernameform1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.usernameform1.Name = "usernameform1"
        Me.usernameform1.Size = New System.Drawing.Size(216, 36)
        Me.usernameform1.TabIndex = 4
        '
        'passwordform1
        '
        Me.passwordform1.BackColor = System.Drawing.Color.Silver
        Me.passwordform1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordform1.Location = New System.Drawing.Point(341, 252)
        Me.passwordform1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.passwordform1.Name = "passwordform1"
        Me.passwordform1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordform1.Size = New System.Drawing.Size(216, 36)
        Me.passwordform1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BISKOP.My.Resources.Resources.logo2
        Me.PictureBox1.Location = New System.Drawing.Point(151, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(408, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Image = Global.BISKOP.My.Resources.Resources.button
        Me.Button1.Location = New System.Drawing.Point(341, 347)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 43)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "SIGN UP"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.Lime
        Me.login.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.login.Image = Global.BISKOP.My.Resources.Resources.button
        Me.login.Location = New System.Drawing.Point(341, 296)
        Me.login.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(181, 43)
        Me.login.TabIndex = 0
        Me.login.Text = "LOGIN"
        Me.login.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PelangganidDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PelangganBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(628, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(380, 150)
        Me.DataGridView1.TabIndex = 8
        '
        'BioskopDataSet1
        '
        Me.BioskopDataSet1.DataSetName = "bioskopDataSet1"
        Me.BioskopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PelangganBindingSource
        '
        Me.PelangganBindingSource.DataMember = "Pelanggan"
        Me.PelangganBindingSource.DataSource = Me.BioskopDataSet1
        '
        'PelangganTableAdapter
        '
        Me.PelangganTableAdapter.ClearBeforeFill = True
        '
        'PelangganidDataGridViewTextBoxColumn
        '
        Me.PelangganidDataGridViewTextBoxColumn.DataPropertyName = "pelanggan_id"
        Me.PelangganidDataGridViewTextBoxColumn.HeaderText = "pelanggan_id"
        Me.PelangganidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PelangganidDataGridViewTextBoxColumn.Name = "PelangganidDataGridViewTextBoxColumn"
        Me.PelangganidDataGridViewTextBoxColumn.Width = 125
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.Width = 125
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1064, 418)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.passwordform1)
        Me.Controls.Add(Me.usernameform1)
        Me.Controls.Add(Me.text2)
        Me.Controls.Add(Me.text1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.login)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BioskopDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelangganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents text1 As Label
    Friend WithEvents text2 As Label
    Friend WithEvents usernameform1 As TextBox
    Friend WithEvents passwordform1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BioskopDataSet1 As bioskopDataSet1
    Friend WithEvents PelangganBindingSource As BindingSource
    Friend WithEvents PelangganTableAdapter As bioskopDataSet1TableAdapters.PelangganTableAdapter
    Friend WithEvents PelangganidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
