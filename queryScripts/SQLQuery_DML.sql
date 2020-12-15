USE dbDevStore;



----------- INSERTS/PROCEDURES

INSERT INTO Category(CategoryName) VALUES ('Livros'), ('Decorações'), ('Gadgets');
INSERT INTO PerfilUser(PerfilType) VALUES ('Admin'), ('Client');
INSERT INTO Users (FirstName, LastName, Email, Password, CreatedAt, ProfileImage, IdPerfil)
	VALUES ('Gabriel', 'Amador', 'gabriel@amador.com', '123456', GETDATE(), 0x6162636465666768696A6B6C6D6E6F707172737475767778797A, 2)
INSERT INTO Adress (Cep, Logradouro, Complemento, Bairro, Cidade, Estado, DDD, UserId)
	VALUES	('01001000', 'Praça da Sé', 'Praça da Sé', 'Sé', 'São Paulo', 'SP', '11', 1) 



EXECUTE IncluirNovoProduto 'Código Limpo: Habilidades Práticas do Agile Software', 'Mesmo um código ruim pode funcionar. Mas se ele não for limpo, pode acabar com uma empresa de desenvolvimento.',
							0x6162636465666768696A6B6C6D6E6F707172737475767778797A, 0, 87.78, 9,1;



