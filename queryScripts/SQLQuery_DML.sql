USE dbDevStore;



----------- INSERTS/PROCEDURES

INSERT INTO Category(CategoryName) VALUES ('Livros'), ('Decorações'), ('Gadgets');
EXECUTE IncluirNovoProduto 'Código Limpo: Habilidades Práticas do Agile Software', 'Mesmo um código ruim pode funcionar. Mas se ele não for limpo, pode acabar com uma empresa de desenvolvimento.',
							0x6162636465666768696A6B6C6D6E6F707172737475767778797A, 0, 87.78, 9,1;


