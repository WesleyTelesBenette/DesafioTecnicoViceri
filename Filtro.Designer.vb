<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Filtro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCadastrarCliente = New System.Windows.Forms.Button()
        Me.btnCadastrarCorretor = New System.Windows.Forms.Button()
        Me.cidadeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.estadoComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCPFCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.txtNomeCorretor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoCorretor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDados
        '
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(57, 219)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(697, 215)
        Me.dgvDados.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCadastrarCliente)
        Me.GroupBox1.Controls.Add(Me.btnCadastrarCorretor)
        Me.GroupBox1.Controls.Add(Me.cidadeComboBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.estadoComboBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCPFCliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNomeCliente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnPesquisar)
        Me.GroupBox1.Controls.Add(Me.txtNomeCorretor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodigoCorretor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(697, 177)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entradas"
        '
        'btnCadastrarCliente
        '
        Me.btnCadastrarCliente.Location = New System.Drawing.Point(527, 53)
        Me.btnCadastrarCliente.Name = "btnCadastrarCliente"
        Me.btnCadastrarCliente.Size = New System.Drawing.Size(140, 23)
        Me.btnCadastrarCliente.TabIndex = 16
        Me.btnCadastrarCliente.Text = "Cadastrar Cliente"
        Me.btnCadastrarCliente.UseVisualStyleBackColor = True
        '
        'btnCadastrarCorretor
        '
        Me.btnCadastrarCorretor.Location = New System.Drawing.Point(527, 22)
        Me.btnCadastrarCorretor.Name = "btnCadastrarCorretor"
        Me.btnCadastrarCorretor.Size = New System.Drawing.Size(140, 23)
        Me.btnCadastrarCorretor.TabIndex = 15
        Me.btnCadastrarCorretor.Text = "Cadastrar Corretor"
        Me.btnCadastrarCorretor.UseVisualStyleBackColor = True
        '
        'cidadeComboBox
        '
        Me.cidadeComboBox.FormattingEnabled = True
        Me.cidadeComboBox.Location = New System.Drawing.Point(320, 82)
        Me.cidadeComboBox.Name = "cidadeComboBox"
        Me.cidadeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.cidadeComboBox.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(277, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cidade"
        '
        'estadoComboBox
        '
        Me.estadoComboBox.FormattingEnabled = True
        Me.estadoComboBox.Location = New System.Drawing.Point(320, 54)
        Me.estadoComboBox.Name = "estadoComboBox"
        Me.estadoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.estadoComboBox.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(277, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Estado"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(320, 27)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(277, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Ativo?"
        '
        'txtCPFCliente
        '
        Me.txtCPFCliente.Location = New System.Drawing.Point(102, 117)
        Me.txtCPFCliente.Name = "txtCPFCliente"
        Me.txtCPFCliente.Size = New System.Drawing.Size(118, 20)
        Me.txtCPFCliente.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CPF Cliente"
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Location = New System.Drawing.Point(102, 87)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(118, 20)
        Me.txtNomeCliente.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nome Cliente"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(280, 115)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(161, 23)
        Me.btnPesquisar.TabIndex = 4
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'txtNomeCorretor
        '
        Me.txtNomeCorretor.Location = New System.Drawing.Point(102, 56)
        Me.txtNomeCorretor.Name = "txtNomeCorretor"
        Me.txtNomeCorretor.Size = New System.Drawing.Size(118, 20)
        Me.txtNomeCorretor.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome Corretor"
        '
        'txtCodigoCorretor
        '
        Me.txtCodigoCorretor.Location = New System.Drawing.Point(102, 27)
        Me.txtCodigoCorretor.Name = "txtCodigoCorretor"
        Me.txtCodigoCorretor.Size = New System.Drawing.Size(118, 20)
        Me.txtCodigoCorretor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Corretor"
        '
        'Filtro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvDados)
        Me.Name = "Filtro"
        Me.Text = "Form1"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents txtNomeCorretor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigoCorretor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCPFCliente As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents estadoComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cidadeComboBox As ComboBox
    Friend WithEvents btnCadastrarCliente As Button
    Friend WithEvents btnCadastrarCorretor As Button
End Class
