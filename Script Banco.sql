CREATE TABLE Locadora (
    LocId			int not null identity,
    NomeFantasia	VARCHAR(200) not null,
    RazaoSocial		varchar(200) not null,
	CNPJ			varchar(14) not null,
	LojaNro			int not null,
	Ativo			bit default 1,
	constraint PK_Locadora primary key(LocId)
);

go;


create Table grupoCadastro (
	grupoCadastroId int not null identity,
	LocId			int not null,
	Descricao		varchar(100) not null,
	Ativo			bit default 1,
	constraint PK_GrpLoc primary key(grupoCadastroId),
	constraint FK_GrpLocLoc foreign key(LocId) references Locadora(LocId)
);
go;
insert into grupoCadastro values(1,'Locadora',1);
insert into grupoCadastro values(1,'Cliente',1);
insert into grupoCadastro values(1,'Fornecedor',1);
insert into grupoCadastro values(1,'Usuario',1);

go;

create Table grupoEmailFone(
	grupoEmailId	int not null identity,
	LocId			int not null,
	Descricao		varchar(100) not null,
	Ativo			bit default 1,
	constraint PK_GrupoEmail primary key(grupoEmailId),
	constraint FK_GrpEmailLoc foreign key(LocId) references Locadora(LocId)
)
go;
insert into grupoEmailFone values(1,'Particular',1);
insert into grupoEmailFone values(1,'Empresarial',1);
go;

create Table grupoEndereco(
	grupoEnderecoId int not null identity,
	LocId			int not null,
	Descricao		varchar(100) not null,
	Ativo			bit default 1,
	constraint PK_GrpEndereco primary key(grupoEnderecoId),
	constraint FK_GrpEnderLoc foreign key(LocId) references Locadora(LocId)
)
go;

insert into grupoEndereco values(0,1,'Residencial',1);
insert into grupoEndereco values(0,1,'Trabalho',1);
insert into grupoEndereco values(0,1,'Cobrança',1);

go;


create table Contatos(
	contatoId int not null identity,
	grupoCadastroId int not null,
	identificacaoId int not null,
	constraint PK_Contatos primary key(contatoId),
	constraint FK_ContatoGrpContato foreign key(grupoCadastroId) references grupoCadastro(grupoCadastroId)
)
insert into Contatos values(1,1)


create table Emails(
	emailId		int not null identity,
	LocId		int not null,
	contatoId	int not null,
	grupoEmailId int not null,
	Descricao	varchar(100) not null,
	Ativo		bit default 1,
	constraint PK_Email primary key(emailId),
	constraint FK_EmailLoc foreign key(LocId) references Locadora(LocId),
	constraint FK_EmailContato foreign key(contatoId) references Contatos(contatoId)
)
insert into Emails values(1,1,2,'teste@teste.com.br',1)
insert into Emails values(1,1,1,'teste@gmail.com',1)


CREATE TABLE Enderecos(
	enderecoId int IDENTITY(1,1) NOT NULL,
	LocId			int not null,
	contatoId	int not null,
	grupoCadastroId int NOT NULL,
	grupoEnderecoId int not null,
	Endereco varchar(100) NOT NULL,
	Numero varchar(20) NOT NULL,
	Complemento varchar(50) NULL,
	Bairro varchar(50) NULL,
	Cidade varchar(50) NOT NULL,
	Estado varchar(2) NOT NULL,
	Latitude varchar(100) NULL,
	Longitude varchar(100) NULL,
	Ativo	bit default 1,
	CONSTRAINT PK_Endereco PRIMARY KEY(enderecoId),
	constraint FK_EnderGrpCad foreign key(grupoCadastroId) references grupoCadastro(grupoCadastroId),
	constraint FK_EnderLoc foreign key(LocId) references Locadora(LocId),
	constraint FK_EnderContato foreign key(contatoId) references Contatos(contatoId)
)
go;

