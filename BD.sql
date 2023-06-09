USE [TastyDinner]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 21.06.2022 0:57:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Weight] [int] NULL,
	[Price] [int] NULL,
	[Descriptoin] [nvarchar](150) NULL,
	[Image] [nvarchar](50) NULL,
	[Type] [int] NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeMenu]    Script Date: 21.06.2022 0:57:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeMenu](
	[IdMenu] [int] IDENTITY(1,1) NOT NULL,
	[Menu] [nvarchar](50) NULL,
 CONSTRAINT [PK_TypeMenu] PRIMARY KEY CLUSTERED 
(
	[IdMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeUser]    Script Date: 21.06.2022 0:57:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeUser](
	[IdType] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NULL,
	[Image] [nvarchar](50) NULL,
 CONSTRAINT [PK_TypeUser] PRIMARY KEY CLUSTERED 
(
	[IdType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 21.06.2022 0:57:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Type] [int] NULL,
	[Login] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Passport] [nvarchar](50) NULL,
	[Residence] [nvarchar](50) NULL,
	[Birthday] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (1, N'Салат Витаминный', 120, 35, N'Капуста, морковь, соль, сахар, зелень', N'/Image/1.jpg', 1)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (2, N'Салат Овощной', 120, 25, N'Помидор, огурец, зелень, масло подсолнечное, соль', N'/Image/2.jpg', 1)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (3, N'Салат Крабовый', 120, 46, N'Крабовые палочки, рис, лук, кукуруза, огурец, майонез', N'/Image/3.jpg', 1)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (4, N'Салат свекольный с грецким орехом', 120, 63, N'Свекла, майонез, сыр, чеснок, грецкий орех', N'/Image/4.jpg', 1)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (5, N'Борщ Классический', 350, 70, N'Бульон, картофель, капуста свежая, свёкла, лук, томатная паста, морковь, уксус, соль, сахар', N'/Image/5.jpg', 2)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (6, N'Суп Гороховый с копченостями', 350, 76, N'Бульон куриный, горох отварной, картофель, морковь, копчёности, соль, перец', N'/Image/6.jpg', 2)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (7, N'Суп сырный', 350, 100, N'Бульон куриный, сыр плавленый, картофель, лук, морковка, зелень', N'/Image/7.jpg', 2)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (8, N'Щи', 350, 78, N'Бульон куриный, картофель, капуста, лук, зклень, морковь', N'/Image/8.jpg', 2)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (9, N'Поджарка из свинины', 120, 124, N'Свинина (окорок), овощи, соус', N'/Image/9.jpg', 3)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (10, N'Домашние котлеты', 60, 40, N'Свинина, курица, лук, соль, перец, хлеб, молоко, яйцо', N'/Image/10.jpg', 3)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (11, N'Столичные тефтели', 60, 50, N'Свинина, курица, лук, хлеб, молоко, яйцо, мука, соус томатный', N'/Image/11.jpg', 3)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (12, N'Азу', 150, 87, N'Говядина, овощи', N'/Image/12.jpg', 3)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (13, N'Котлета пожарская', 120, 135, N'Фарш куриный, хлеб, лук, зелень', N'/Image/13.jpg', 3)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (14, N'Котлета рубленая', 120, 139, N'Филе куриное, майонез, мука, яйцо, зелень', N'/Image/14.jpg', 3)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (15, N'Курица жареная', 120, 140, N'Бедро куриное, голень', N'/Image/15.jpg', 3)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (16, N'Котлета рыбная', 120, 150, N'Треска, лук, яйцо, хлеб, молоко', N'/Image/16.jpg', 3)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (17, N'Шницель куриный', 120, 200, N'Куриное филе, планировка, соль, перец', N'/Image/17.jpg', 3)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (18, N'Рис отварной', 150, 59, N'Рис отварной, соль', N'/Image/18.jpg', 4)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (19, N'Картофельное пюре', 150, 66, N'Картофель, молоко, сливочное масло, соль', N'/Image/19.jpg', 4)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (20, N'Гречневая каша', 150, 64, N'Гречка отварная, соль', N'/Image/20.jpg', 4)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (21, N'Макароны', 150, 57, N'Макароны, соль, масло', N'/Image/21.jpg', 4)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (22, N'Ризотто', 150, 78, N'Рис отварной, овощи', N'/Image/22.jpg', 4)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (23, N'Хлеб черный', 12, 4, NULL, N'/Image/23.jpg', 5)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (24, N'Хлеб белый', 12, 4, NULL, N'/Image/24.jpg', 5)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (25, N'Морс Ленинградский', 500, 72, N'Вода, свежие ягоды ассорти. Собственное производство', N'/Image/25.jpg', 6)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (26, N'Сок яблочный', 500, 72, N'Сок яблочный осветленный. Собственное производство', N'/Image/26.jpg', 6)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (27, N'Сок вишневый', 500, 72, N'Собственное производство', N'/Image/27.jpg', 6)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (28, N'Минеральная вода газированная Сенежская', 500, 60, N'Россия', N'/Image/28.jpg', 6)
INSERT [dbo].[Menu] ([Id], [Name], [Weight], [Price], [Descriptoin], [Image], [Type]) VALUES (29, N'Минеральная вода негазированная Сенежская', 500, 60, N'Россия', N'/Image/28.jpg', 6)
SET IDENTITY_INSERT [dbo].[Menu] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeMenu] ON 

INSERT [dbo].[TypeMenu] ([IdMenu], [Menu]) VALUES (1, N'Салаты')
INSERT [dbo].[TypeMenu] ([IdMenu], [Menu]) VALUES (2, N'Супы')
INSERT [dbo].[TypeMenu] ([IdMenu], [Menu]) VALUES (3, N'Горячие блюда')
INSERT [dbo].[TypeMenu] ([IdMenu], [Menu]) VALUES (4, N'Гарниры')
INSERT [dbo].[TypeMenu] ([IdMenu], [Menu]) VALUES (5, N'Хлеб')
INSERT [dbo].[TypeMenu] ([IdMenu], [Menu]) VALUES (6, N'Напитки')
SET IDENTITY_INSERT [dbo].[TypeMenu] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeUser] ON 

INSERT [dbo].[TypeUser] ([IdType], [Type], [Image]) VALUES (1, N'Продавец', NULL)
INSERT [dbo].[TypeUser] ([IdType], [Type], [Image]) VALUES (2, N'Директор', NULL)
SET IDENTITY_INSERT [dbo].[TypeUser] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([IdUser], [Name], [Type], [Login], [Password], [Passport], [Residence], [Birthday]) VALUES (38, N'Юлдашева Алевтина Николаевна', 2, N'Director', N'Director123', NULL, NULL, NULL)
INSERT [dbo].[User] ([IdUser], [Name], [Type], [Login], [Password], [Passport], [Residence], [Birthday]) VALUES (39, N'Петровна Татьяна Сергеевна', 1, N'Petr', N'Petr123', NULL, NULL, NULL)
INSERT [dbo].[User] ([IdUser], [Name], [Type], [Login], [Password], [Passport], [Residence], [Birthday]) VALUES (40, N'Кочевникова Наталья Васильевна', 1, N'Vas', N'Vas123', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_Type]  DEFAULT ((1)) FOR [Type]
GO
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_TypeMenu] FOREIGN KEY([Type])
REFERENCES [dbo].[TypeMenu] ([IdMenu])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_TypeMenu]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_TypeUser] FOREIGN KEY([Type])
REFERENCES [dbo].[TypeUser] ([IdType])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_TypeUser]
GO
