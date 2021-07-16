CREATE DATABASE InstaDev;

USE InstaDev;

CREATE TABLE TipoUsuario(
 IdTipo INT PRIMARY KEY IDENTITY,
 NomeTipo VARCHAR(50)
);
CREATE TABLE Usuario
(
 IdUsuario INT PRIMARY KEY IDENTITY
 ,IdTipo INT FOREIGN KEY  REFERENCES TipoUsuario(IdTipo)
 ,NomeUsuario VARCHAR (200) NOT NULL
 ,Indentificacao VARCHAR (200) NOT NULL UNIQUE
 ,Email VARCHAR (200) NOT NULL UNIQUE
 ,Senha VARCHAR (24)NOT NULL
 ,fotoPerfil image
 ,Seguidores INT
);
CREATE TABLE Publicacao
(
 IdPublicacao INT PRIMARY KEY IDENTITY
 ,IdUsuario INT FOREIGN KEY  REFERENCES Usuario(IdUsuario)
 ,ImagemPub IMAGE
 ,descricao VARCHAR(200)
);

DROP DATABASE InstaDev


 UPDATE Usuario SET fotoPerfil = 'user.png' WHERE idUsuario > 0;