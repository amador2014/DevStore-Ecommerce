USE dbDevStore;



----------- INSERTS/PROCEDURES

INSERT INTO Category(CategoryName) VALUES ('Livros'), ('Decora��es'), ('Gadgets');
INSERT INTO PerfilUser(PerfilType) VALUES ('Admin'), ('Client');
INSERT INTO Users (FirstName, LastName, Email, Password, CreatedAt, ProfileImage, IdPerfil)
	VALUES ('Gabriel', 'Amador', 'gabriel@amador.com', '123456', GETDATE(), 0x6162636465666768696A6B6C6D6E6F707172737475767778797A, 2)
INSERT INTO Adress (Cep, Logradouro, Complemento, Bairro, Cidade, Estado, DDD, UserId)
	VALUES	('01001000', 'Pra�a da S�', 'Pra�a da S�', 'S�', 'S�o Paulo', 'SP', '11', 1) 



EXECUTE IncluirNovoProduto 'C�digo Limpo: Habilidades Pr�ticas do Agile Software', 'Mesmo um c�digo ruim pode funcionar. Mas se ele n�o for limpo, pode acabar com uma empresa de desenvolvimento.',
							0x6162636465666768696A6B6C6D6E6F707172737475767778797A, 0, 87.78, 9,1;



