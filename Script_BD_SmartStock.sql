CREATE DATABASE SmartStock;
Use SmartStock;


CREATE TABLE Empresa(
idEmpresa int not null primary key,
nomeEmpresa varchar(200),
email varchar(200),
senha varchar(50),
cnpj varchar(18),
telefone varchar(16)
);

CREATE TABLE Endereco(
idEndereco int not null primary key,
pais varchar(50),
uf char(2),
idEmpresa int,
cep varchar(9),
logradouro varchar(100),
numero int,
complemento varchar(50),
bairro varchar(100),
cidade varchar(100),
FOREIGN KEY (idEmpresa) REFERENCES Empresa(idEmpresa)
);

CREATE TABLE Produto(
idProduto int not null primary key,
quantidadeAtual int,
ativo bit,
nome varchar(200),
validade date,
estoqueIdeal int,
preco decimal(10,2),
status char(1), -- N-Normal , V-Vencido
estoqueMinimo decimal(10,2),
descricao varchar(500),
idEmpresa int,
FOREIGN KEY (idEmpresa) REFERENCES Empresa(idEmpresa)
);

CREATE TABLE Movimentacao(
idMovimentacao int not null primary key,
dataMovimento date,
tipo varchar(50),
observacao varchar(400),
idProduto int,
quantidade int,
FOREIGN KEY (idProduto) REFERENCES Produto(idProduto)
);

CREATE TABLE Doacao(
idDoacao int not null primary key,
nomeInstituicao varchar(200),
quantidade int,
dataDoacao date,
status char(1), -- E-Entregue , A-Em Andamento , C-Cancelado
idProduto int,
FOREIGN KEY (idProduto) REFERENCES Produto(idProduto)
);