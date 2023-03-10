USE BD_SUPERLIST_GARDEN

--CREATE TABLE USUARIO(
--	IDUSUARIO INT PRIMARY KEY IDENTITY,
--	NOME VARCHAR(150),
--	EMAIL VARCHAR(250),
--	PASSWORD VA
--	ID_LISTA INT
--)
--GO

CREATE TABLE LISTA_COMPRA(
	IDLISTA_COMPRA INT PRIMARY KEY IDENTITY,
	NOME VARCHAR(100) NOT NULL,
	DESCRICAO VARCHAR(250),
	TAMANHO DECIMAL(14,2) NOT NULL,
	DATA_CRIACAO DATETIME DEFAULT GETDATE() NOT NULL,
	ID_PRODUTO INT NOT NULL
)
GO

CREATE TABLE PRODUTO(
	IDPRODUTO INT PRIMARY KEY IDENTITY,
	NOME VARCHAR(100) NOT NULL,
	IS_PRODUTO_DESTAQUE BIT NOT NULL,
	ID_CATEGORIA INT NOT NULL
)
GO

CREATE TABLE CATEGORIA(
	IDCATEGORIA INT PRIMARY KEY IDENTITY,
	NOME VARCHAR(100) NOT NULL,
	DESCRICAO VARCHAR(250),
	IMAGEM_URL VARCHAR(200)
)
GO

ALTER TABLE LISTA_COMPRA
ADD FOREIGN KEY(ID_PRODUTO)
REFERENCES PRODUTO(IDPRODUTO)
GO

ALTER TABLE PRODUTO
ADD FOREIGN KEY(ID_CATEGORIA)
REFERENCES CATEGORIA(IDCATEGORIA)
GO

/* INSERINDO IMAGEM URL TABLE CATEGORIA */

--ALTER TABLE CATEGORIA
--ADD IMAGEM_URL VARCHAR(200)
--GO

/* REMODELANDO BANCO */

DROP TABLE LISTA_PRODUTO
DROP TABLE CATEGORIA
DROP TABLE PRODUTO
GO

