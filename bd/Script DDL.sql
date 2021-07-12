--DDL

--Cria o banco de dados
create database czbooks;

--Define qual banco  será usado
use czbooks;
--Cria as tabelas 
create table tiposUsuarios
(
	idTipoUsuario INT PRIMARY KEY IDENTITY,
	tituloTiposUsuario VARCHAR(50) UNIQUE NOT NULL
);

create table instituicao
(
	idInstituicao	INT PRIMARY KEY IDENTITY,
	nomeInstituicao VARCHAR(200) UNIQUE NOT NULL
);

create table categorias
(
	idCategoria INT PRIMARY KEY IDENTITY,
	nomeCategoria	VARCHAR(200) UNIQUE NOT NULL
);

create table usuarios
(
	idUsuarios	INT PRIMARY KEY IDENTITY,
	idTiposUsuarios	INT FOREIGN KEY REFERENCES tiposUsuarios(idTipoUsuario),
	nomeUsuario VARCHAR(200) UNIQUE NOT NULL,
	email VARCHAR(200) UNIQUE NOT NULL,
	senha VARCHAR(200) UNIQUE NOT NULL

);

create table autor
(
	idAutor INT PRIMARY KEY IDENTITY,
	idUsuario INT FOREIGN KEY REFERENCES usuarios(idUsuarios),
	nomeAutor VARCHAR(200) UNIQUE NOT NULL
);
	
create table livros
(
	idLivros	INT PRIMARY KEY IDENTITY,
	idCategoria INT FOREIGN KEY REFERENCES categorias(idCategoria),
	idAutor		INT FOREIGN KEY REFERENCES autor(idAutor),
	nomeLivro VARCHAR(200) UNIQUE NOT NULL,
	sinopse VARCHAR(600) UNIQUE NOT NULL,
	dataPublicacao DATE,
	preco SMALLMONEY		--consultei a documentação
);
