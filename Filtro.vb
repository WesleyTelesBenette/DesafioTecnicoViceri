Imports System.Data.SqlClient

Public Class Filtro

    Private connectionString As String = "Data Source=?????;Initial Catalog=?????;Integrated Security=True"
    Private connection As SqlConnection
    Private adapter As SqlDataAdapter
    Private dt As DataTable

    ' Construtor
    ' Carrega os dados iniciais do banco de dados.
    Private Sub Filtro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New SqlConnection(connectionString)
        CarregarEstados()
    End Sub

    ' Carrega os estados
    Private Sub CarregarEstados()
        Try
            connection.Open()

            Dim query As String = "SELECT * FROM UF"
            adapter = New SqlDataAdapter(query, connection)
            dt = New DataTable()
            adapter.Fill(dt)

            estadoComboBox.DataSource = dt
            estadoComboBox.DisplayMember = "Nome"
            estadoComboBox.ValueMember = "Id"
            estadoComboBox.SelectedIndex = -1 ' exibir valor nulo como padrão
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Carrega as cidades baseado no estado
    Private Sub CarregarCidades(idEstado As Integer)
        Try
            connection.Open()

            Dim query As String = "SELECT * FROM Cidades WHERE idUF = @idEstado"
            adapter = New SqlDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@idEstado", idEstado)

            dt = New DataTable()
            adapter.Fill(dt)

            cidadeComboBox.DataSource = dt
            cidadeComboBox.DisplayMember = "Nome"
            cidadeComboBox.ValueMember = "Id"
            cidadeComboBox.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim codigoCorretor As String = txtCodigoCorretor.Text.Trim()
        Dim nomeCorretor As String = txtNomeCorretor.Text.Trim()
        Dim nomeCliente As String = txtNomeCliente.Text.Trim()
        Dim cpfCliente As String = txtCPFCliente.Text.Trim()

        Dim estado As Integer = If(estadoComboBox.SelectedIndex <> -1, Convert.ToInt32(estadoComboBox.SelectedValue), 0)
        Dim cidade As Integer = If(cidadeComboBox.SelectedIndex <> -1, Convert.ToInt32(cidadeComboBox.SelectedValue), 0)

        ' Monta a query inicial
        Dim query As String = "SELECT C.Nome AS NomeCliente, Co.Nome AS NomeCorretor, Ci.Nome AS Cidade, E.Nome AS Estado " &
                          "FROM Cliente C " &
                          "INNER JOIN ClienteCorretor CC ON C.Id = CC.IdCliente " &
                          "INNER JOIN Corretor Co ON CC.IdCorretor = Co.Id " &
                          "INNER JOIN Cidade Ci ON C.IdCidade = Ci.Id " &
                          "INNER JOIN UF E ON Ci.IdUF = E.Id " &
                          "WHERE 1=1"

        Dim parameters As New List(Of SqlParameter)()

        If Not String.IsNullOrEmpty(codigoCorretor) Then
            query &= " AND Co.Código = @CodigoCorretor"
            parameters.Add(New SqlParameter("@CodigoCorretor", codigoCorretor))
        End If

        If Not String.IsNullOrEmpty(nomeCorretor) Then
            query &= " AND Co.Nome LIKE @NomeCorretor"
            parameters.Add(New SqlParameter("@NomeCorretor", "%" & nomeCorretor & "%"))
        End If

        If Not String.IsNullOrEmpty(nomeCliente) Then
            query &= " AND C.Nome LIKE @NomeCliente"
            parameters.Add(New SqlParameter("@NomeCliente", "%" & nomeCliente & "%"))
        End If

        If Not String.IsNullOrEmpty(cpfCliente) Then
            query &= " AND C.CPF = @CPFCliente"
            parameters.Add(New SqlParameter("@CPFCliente", cpfCliente))
        End If

        If estado <> 0 Then
            query &= " AND E.Id = @EstadoID"
            parameters.Add(New SqlParameter("@EstadoID", estado))
        End If

        If cidade <> 0 Then
            query &= " AND Ci.Id = @CidadeID"
            parameters.Add(New SqlParameter("@CidadeID", cidade))
        End If

        Try
            connection.Open()
            adapter = New SqlDataAdapter(query, connection)

            For Each param In parameters
                adapter.SelectCommand.Parameters.Add(param)
            Next

            dt = New DataTable()
            adapter.Fill(dt)

            dgvDados.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Erro ao pesquisar dados: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub estadoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles estadoComboBox.SelectedIndexChanged
        If estadoComboBox.SelectedIndex <> -1 Then
            Dim valorSelecionado As Integer = Convert.ToInt32(estadoComboBox.SelectedValue)
            CarregarCidades(valorSelecionado)
        End If
    End Sub
End Class
