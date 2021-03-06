USE [Loc]
GO
/****** Object:  Table [dbo].[Contatos]    Script Date: 14/09/2020 08:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contatos](
	[contatoId] [int] IDENTITY(1,1) NOT NULL,
	[grupoCadastroId] [int] NOT NULL,
	[identificacaoId] [int] NOT NULL,
 CONSTRAINT [PK_Contatos] PRIMARY KEY CLUSTERED 
(
	[contatoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Emails]    Script Date: 14/09/2020 08:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emails](
	[emailId] [int] IDENTITY(1,1) NOT NULL,
	[LocId] [int] NOT NULL,
	[contatoId] [int] NOT NULL,
	[grupoEmailId] [int] NOT NULL,
	[Descricao] [varchar](100) NOT NULL,
	[Ativo] [bit] NULL,
 CONSTRAINT [PK_Email] PRIMARY KEY CLUSTERED 
(
	[emailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enderecos]    Script Date: 14/09/2020 08:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enderecos](
	[enderecoId] [int] IDENTITY(1,1) NOT NULL,
	[LocId] [int] NOT NULL,
	[contatoId] [int] NOT NULL,
	[grupoCadastroId] [int] NOT NULL,
	[grupoEnderecoId] [int] NOT NULL,
	[Logradouro] [varchar](100) NOT NULL,
	[Numero] [varchar](20) NOT NULL,
	[Complemento] [varchar](50) NULL,
	[Bairro] [varchar](50) NULL,
	[Cidade] [varchar](50) NOT NULL,
	[Estado] [varchar](2) NOT NULL,
	[Latitude] [varchar](100) NULL,
	[Longitude] [varchar](100) NULL,
	[Ativo] [bit] NULL,
 CONSTRAINT [PK_Endereco] PRIMARY KEY CLUSTERED 
(
	[enderecoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grupoCadastro]    Script Date: 14/09/2020 08:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupoCadastro](
	[grupoCadastroId] [int] IDENTITY(1,1) NOT NULL,
	[LocId] [int] NOT NULL,
	[Descricao] [varchar](100) NOT NULL,
	[Ativo] [bit] NULL,
 CONSTRAINT [PK_GrpLoc] PRIMARY KEY CLUSTERED 
(
	[grupoCadastroId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grupoEmailFone]    Script Date: 14/09/2020 08:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupoEmailFone](
	[grupoEmailId] [int] IDENTITY(1,1) NOT NULL,
	[LocId] [int] NOT NULL,
	[Descricao] [varchar](100) NOT NULL,
	[Ativo] [bit] NULL,
 CONSTRAINT [PK_GrupoEmail] PRIMARY KEY CLUSTERED 
(
	[grupoEmailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grupoEndereco]    Script Date: 14/09/2020 08:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupoEndereco](
	[grupoEnderecoId] [int] IDENTITY(1,1) NOT NULL,
	[LocId] [int] NOT NULL,
	[Descricao] [varchar](100) NOT NULL,
	[Ativo] [bit] NULL,
 CONSTRAINT [PK_GrpEndereco] PRIMARY KEY CLUSTERED 
(
	[grupoEnderecoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locadora]    Script Date: 14/09/2020 08:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locadora](
	[LocId] [int] IDENTITY(1,1) NOT NULL,
	[NomeFantasia] [varchar](200) NOT NULL,
	[RazaoSocial] [varchar](200) NOT NULL,
	[CNPJ] [varchar](14) NOT NULL,
	[LojaNro] [int] NOT NULL,
	[Ativo] [bit] NULL,
 CONSTRAINT [PK_Locadora] PRIMARY KEY CLUSTERED 
(
	[LocId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Emails] ADD  DEFAULT ((1)) FOR [Ativo]
GO
ALTER TABLE [dbo].[Enderecos] ADD  DEFAULT ((1)) FOR [Ativo]
GO
ALTER TABLE [dbo].[grupoCadastro] ADD  DEFAULT ((1)) FOR [Ativo]
GO
ALTER TABLE [dbo].[grupoEmailFone] ADD  DEFAULT ((1)) FOR [Ativo]
GO
ALTER TABLE [dbo].[grupoEndereco] ADD  DEFAULT ((1)) FOR [Ativo]
GO
ALTER TABLE [dbo].[Locadora] ADD  DEFAULT ((1)) FOR [Ativo]
GO
ALTER TABLE [dbo].[Contatos]  WITH CHECK ADD  CONSTRAINT [FK_ContatoGrpContato] FOREIGN KEY([grupoCadastroId])
REFERENCES [dbo].[grupoCadastro] ([grupoCadastroId])
GO
ALTER TABLE [dbo].[Contatos] CHECK CONSTRAINT [FK_ContatoGrpContato]
GO
ALTER TABLE [dbo].[Emails]  WITH CHECK ADD  CONSTRAINT [FK_EmailContato] FOREIGN KEY([contatoId])
REFERENCES [dbo].[Contatos] ([contatoId])
GO
ALTER TABLE [dbo].[Emails] CHECK CONSTRAINT [FK_EmailContato]
GO
ALTER TABLE [dbo].[Emails]  WITH CHECK ADD  CONSTRAINT [FK_EmailLoc] FOREIGN KEY([LocId])
REFERENCES [dbo].[Locadora] ([LocId])
GO
ALTER TABLE [dbo].[Emails] CHECK CONSTRAINT [FK_EmailLoc]
GO
ALTER TABLE [dbo].[Enderecos]  WITH CHECK ADD  CONSTRAINT [FK_EnderContato] FOREIGN KEY([contatoId])
REFERENCES [dbo].[Contatos] ([contatoId])
GO
ALTER TABLE [dbo].[Enderecos] CHECK CONSTRAINT [FK_EnderContato]
GO
ALTER TABLE [dbo].[Enderecos]  WITH CHECK ADD  CONSTRAINT [FK_EnderGrpCad] FOREIGN KEY([grupoCadastroId])
REFERENCES [dbo].[grupoCadastro] ([grupoCadastroId])
GO
ALTER TABLE [dbo].[Enderecos] CHECK CONSTRAINT [FK_EnderGrpCad]
GO
ALTER TABLE [dbo].[Enderecos]  WITH CHECK ADD  CONSTRAINT [FK_EnderLoc] FOREIGN KEY([LocId])
REFERENCES [dbo].[Locadora] ([LocId])
GO
ALTER TABLE [dbo].[Enderecos] CHECK CONSTRAINT [FK_EnderLoc]
GO
ALTER TABLE [dbo].[grupoCadastro]  WITH CHECK ADD  CONSTRAINT [FK_GrpLocLoc] FOREIGN KEY([LocId])
REFERENCES [dbo].[Locadora] ([LocId])
GO
ALTER TABLE [dbo].[grupoCadastro] CHECK CONSTRAINT [FK_GrpLocLoc]
GO
ALTER TABLE [dbo].[grupoEmailFone]  WITH CHECK ADD  CONSTRAINT [FK_GrpEmailLoc] FOREIGN KEY([LocId])
REFERENCES [dbo].[Locadora] ([LocId])
GO
ALTER TABLE [dbo].[grupoEmailFone] CHECK CONSTRAINT [FK_GrpEmailLoc]
GO
ALTER TABLE [dbo].[grupoEndereco]  WITH CHECK ADD  CONSTRAINT [FK_GrpEnderLoc] FOREIGN KEY([LocId])
REFERENCES [dbo].[Locadora] ([LocId])
GO
ALTER TABLE [dbo].[grupoEndereco] CHECK CONSTRAINT [FK_GrpEnderLoc]
GO
