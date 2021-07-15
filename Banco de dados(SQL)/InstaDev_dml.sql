USE  InstaDev;

INSERT INTO TipoUsuario(NomeTipo)
VALUES				 ('Adm')
					 ,('Usuario');


INSERT INTO Usuario(IdTipo,NomeUsuario, Indentificacao, Email, Senha)
VALUES				 (1,'Adm','@Adm','adm@adm.com','adm')
					 ,(2,'Chris','@chris','chris@chris.com','chris')
					 ,(2,'Saulo','@saulo','saulo@saulo.com','saulo')
					 ,(2,'Caique','@caique','caique@caique.com','caique');


--INSERT INTO Publicacao(NomeInstituicao,CNPJ, Endereco)
--VALUES				 ('Institução Saulão e Caiquera','25307478001.55','Rua Quantos ossos numero 19');

