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

