USE dbDevStore;



----------- INSERTS/PROCEDURES

INSERT INTO Category(CategoryName) VALUES ('Livros'), ('Decora��es'), ('Gadgets');
EXECUTE IncluirNovoProduto 'C�digo Limpo: Habilidades Pr�ticas do Agile Software', 'Mesmo um c�digo ruim pode funcionar. Mas se ele n�o for limpo, pode acabar com uma empresa de desenvolvimento.',
							0x6162636465666768696A6B6C6D6E6F707172737475767778797A, 0, 87.78, 9,1;


