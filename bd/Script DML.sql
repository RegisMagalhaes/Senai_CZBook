--Seleciona o banco CZBOOKS
USE czbooks;
GO

-- Insere os tipos de Usuarios

INSERT INTO tiposUsuarios(tituloTiposUsuario)
VALUES						('ADMINISRADOR'),
							('CLIENTE'),
							('AUTOR')
GO

INSERT INTO	instituicao (nomeInstituicao)
VALUES					('CZBooks'),
						('SENAI')
GO

INSERT INTO categorias (nomeCategoria)
VALUES					('Técnico'),
						('Romance'),
						('Auto-Ajuda'),
						('Manual'),
						('Culinária')
GO

INSERT INTO usuarios(idTiposUsuarios, nomeUsuario, email, senha)
VALUES				(1,'REGIS LEANDRO DA SILVA R MAGALHÃES', 'regis.expertmail@gmail.com','@123Radiano'),
					(2, 'LUANA RIBEIRO MAGALHÃES', 'lu.ribeiro@gmail.com', '2ro39fhd'),
					(3,	'DENIS W C P DA SILVA', 'pol.denis@gmail.com', '547297@ama'),
					(3, 'SERGIO BERLUSCHINI', 'sergio_amaej@bol.com.br', '123123'),
					(3, 'ANGELO ARMANDO ONISTO', 'angearm@uol.com.br', 'cobre=29')
GO

INSERT INTO livros(idCategoria, idAutor, nomeLivro, sinopse,  dataPublicacao, preco)
values			  (1,1,'Concreto Armado eu te amo', 'Projete e...','1991-11-17',43.99),
				  (1,2, 'Node JS', 'Aplicações em...','2020-02-13',87.50),
				  (1,1,'REACT Aprenda praticando','Construa...', '1993-07-14',78.00),
				  (1,2, 'Python', 'A linguagem ...','1945-04-02',65.00),
				  (1,3, 'Planejamento de obras', 'Administre...','2020-10-29',30.70)
GO

INSERT INTO autor(idUsuario, nomeAutor)
VALUES			 (3, 'Angelo Armando Onisto'),
				 (3, 'Denis W C P da Silva'),
				 (3, 'Sergio Berluschini')
GO
