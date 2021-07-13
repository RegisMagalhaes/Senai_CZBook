--Seleciona o banco CZBOOKS
USE senai_czbooks;
GO

-- Insere os tipos de Usuarios

INSERT INTO tiposUsuarios(tituloTiposUsuario)
VALUES						('ADMINISRADOR'),
							('CLIENTE'),
							('AUTOR')
GO

INSERT INTO	instituicao (idTiposUsuarios, nomeInstituicao)
VALUES					(1,'CZBooks'),
						(1,'SENAI')
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

INSERT INTO livros(idCategoria,idInstituicao, idAutor, nomeLivro, sinopse,  dataPublicacao, preco)
VALUES			  (1,1,1,'Concreto Armado eu te amo', 'Projete e...','17/11/1991',78.93),
				  (1,2,2, 'Node JS', 'Aplicações em...','13/02/2020',87.50),
				  (1,1,1,'REACT Aprenda praticando','Construa...', '14/07/1993',78.99),
				  (1,2,2, 'Python', 'A linguagem ...','02/04/2002',65.00),
				  (1,2,3, 'Planejamento de obras', 'Administre...','29/10/2015',307.80)
GO

INSERT INTO autor(idUsuario, nomeAutor)
VALUES			 (3, 'Angelo Armando Onisto'),
				 (3, 'Denis W C P da Silva'),
				 (3, 'Sergio Berluschini')
GO

