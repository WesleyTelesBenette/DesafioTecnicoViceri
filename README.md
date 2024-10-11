# Desafio Tecnico Viceri

> [!WARNING]  
> Não consegui completar o projeto. Foi o meu primeiro contato com VB.

# ✨ Como Utilizar?
- Baixe o projeto.
- Crie seu banco de dados com o SQL do abaixo.
- Altere o valor da variável connectionString da tela Filtro para os dados do seu banco.

# 🎲 Banco de Dados
SQL de criação do banco de dados.
```sql
create Database DesafioTecnicoViceri;

use DesafioTecnicoViceri;

CREATE TABLE Corretor (
    Id INT PRIMARY KEY IDENTITY(1,1),
	Código VARCHAR(255) NOT NULL,
	Nome VARCHAR(255) NOT NULL,
	CPF VARCHAR(14) NOT NULL
);

CREATE TABLE UF (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(255) NOT NULL
);

CREATE TABLE Cidade (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(255) NOT NULL,
	IdUF INT NOT NULL,

	FOREIGN KEY (IdUF) REFERENCES UF(Id)
);

CREATE TABLE Cliente (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(255) NOT NULL,
	CPF VARCHAR(14) NOT NULL,
	Endereço VARCHAR(255) NOT NULL,
	IdUF INT NOT NULL,
	IdCidade INT NOT NULL,
	Ativo BIT NOT NULL,

	FOREIGN KEY (IdUF) REFERENCES UF(Id),
	FOREIGN KEY (IdCidade) REFERENCES Cidade(Id)
);

CREATE TABLE ClienteCorretor (
	IdCliente INT NOT NULL,
	IdCorretor INT NOT NULL,

	FOREIGN KEY (IdCliente) REFERENCES Cliente(Id),
	FOREIGN KEY (IdCorretor) REFERENCES Corretor(Id)
);
```
