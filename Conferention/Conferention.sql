USE [007a1_shonhorov]
GO
/****** Object:  Schema [conferention]    Script Date: 01.04.2023 12:19:42 ******/
CREATE SCHEMA [conferention]
GO
/****** Object:  Table [conferention].[Активности]    Script Date: 01.04.2023 12:19:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [conferention].[Активности](
	[№ Активности] [int] NOT NULL,
	[Активность] [nvarchar](255) NOT NULL,
	[День] [tinyint] NOT NULL,
	[Время начала] [time](7) NOT NULL,
	[Модератор] [int] NOT NULL,
	[Жюри 1] [int] NOT NULL,
	[Жюри 2] [int] NOT NULL,
	[Жюри 3] [int] NOT NULL,
	[Жюри 4] [int] NOT NULL,
	[Жюри 5] [int] NOT NULL,
	[№ Мероприятия] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[№ Активности] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [conferention].[Город]    Script Date: 01.04.2023 12:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [conferention].[Город](
	[Номер_города] [smallint] NOT NULL,
	[Название] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Номер_города] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [conferention].[График мероприятий]    Script Date: 01.04.2023 12:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [conferention].[График мероприятий](
	[№ Мероприятия] [int] NOT NULL,
	[Победитель] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[№ Мероприятия] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [conferention].[Жюри]    Script Date: 01.04.2023 12:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [conferention].[Жюри](
	[ФИО] [nvarchar](255) NULL,
	[пол] [nvarchar](255) NULL,
	[почта] [nvarchar](255) NULL,
	[дата рождения] [nvarchar](255) NULL,
	[страна] [int] NOT NULL,
	[телефон] [nvarchar](255) NULL,
	[направление] [nvarchar](255) NULL,
	[пароль] [nvarchar](255) NULL,
	[фото] [nvarchar](255) NULL,
	[Номер жюри] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Номер жюри] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [conferention].[Модераторы]    Script Date: 01.04.2023 12:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [conferention].[Модераторы](
	[ФИО] [nvarchar](255) NULL,
	[пол] [nvarchar](255) NULL,
	[почта] [nvarchar](255) NULL,
	[дата рождения] [datetime] NULL,
	[страна] [int] NOT NULL,
	[телефон] [nvarchar](255) NULL,
	[направление] [nvarchar](255) NULL,
	[мероприятие] [nvarchar](255) NULL,
	[пароль] [nvarchar](255) NULL,
	[фото] [nvarchar](255) NULL,
	[Номер модератора] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Номер модератора] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [conferention].[Организаторы]    Script Date: 01.04.2023 12:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [conferention].[Организаторы](
	[ФИО] [nvarchar](255) NULL,
	[Почта] [nvarchar](255) NULL,
	[Дата рождения] [date] NULL,
	[страна] [int] NOT NULL,
	[телефон] [nvarchar](255) NULL,
	[пароль] [nvarchar](255) NULL,
	[фото] [nvarchar](255) NULL,
	[пол] [nvarchar](255) NULL,
	[Номер организатора] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Номер организатора] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [conferention].[План мероприятий]    Script Date: 01.04.2023 12:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [conferention].[План мероприятий](
	[Номер события] [int] NOT NULL,
	[Событие] [nvarchar](255) NULL,
	[Дата] [datetime] NULL,
	[Дни] [float] NULL,
	[Город] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Номер события] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [conferention].[Страны]    Script Date: 01.04.2023 12:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [conferention].[Страны](
	[Название страны] [nvarchar](255) NULL,
	[Английское название] [nvarchar](255) NULL,
	[Код] [nvarchar](255) NULL,
	[Идентификатор] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Идентификатор] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [conferention].[Участники]    Script Date: 01.04.2023 12:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [conferention].[Участники](
	[ФИО] [nvarchar](50) NOT NULL,
	[Почта] [nvarchar](255) NOT NULL,
	[дата_рождения] [date] NOT NULL,
	[страна] [int] NOT NULL,
	[телефон] [nvarchar](50) NOT NULL,
	[пароль] [nvarchar](255) NOT NULL,
	[фото] [nvarchar](50) NOT NULL,
	[пол] [nvarchar](50) NOT NULL,
	[Номер Участника] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Номер Участника] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [conferention].[Активности]  WITH CHECK ADD FOREIGN KEY([№ Мероприятия])
REFERENCES [conferention].[План мероприятий] ([Номер события])
GO
ALTER TABLE [conferention].[Активности]  WITH CHECK ADD FOREIGN KEY([Жюри 1])
REFERENCES [conferention].[Жюри] ([Номер жюри])
GO
ALTER TABLE [conferention].[Активности]  WITH CHECK ADD FOREIGN KEY([Жюри 2])
REFERENCES [conferention].[Жюри] ([Номер жюри])
GO
ALTER TABLE [conferention].[Активности]  WITH CHECK ADD FOREIGN KEY([Жюри 3])
REFERENCES [conferention].[Жюри] ([Номер жюри])
GO
ALTER TABLE [conferention].[Активности]  WITH CHECK ADD FOREIGN KEY([Жюри 4])
REFERENCES [conferention].[Жюри] ([Номер жюри])
GO
ALTER TABLE [conferention].[Активности]  WITH CHECK ADD FOREIGN KEY([Жюри 5])
REFERENCES [conferention].[Жюри] ([Номер жюри])
GO
ALTER TABLE [conferention].[Активности]  WITH CHECK ADD FOREIGN KEY([Модератор])
REFERENCES [conferention].[Модераторы] ([Номер модератора])
GO
ALTER TABLE [conferention].[График мероприятий]  WITH CHECK ADD  CONSTRAINT [FK_id_meet] FOREIGN KEY([№ Мероприятия])
REFERENCES [conferention].[План мероприятий] ([Номер события])
GO
ALTER TABLE [conferention].[График мероприятий] CHECK CONSTRAINT [FK_id_meet]
GO
ALTER TABLE [conferention].[График мероприятий]  WITH CHECK ADD  CONSTRAINT [FK_id_user] FOREIGN KEY([Победитель])
REFERENCES [conferention].[Участники] ([Номер Участника])
GO
ALTER TABLE [conferention].[График мероприятий] CHECK CONSTRAINT [FK_id_user]
GO
ALTER TABLE [conferention].[Жюри]  WITH CHECK ADD FOREIGN KEY([страна])
REFERENCES [conferention].[Страны] ([Идентификатор])
GO
ALTER TABLE [conferention].[Модераторы]  WITH CHECK ADD FOREIGN KEY([страна])
REFERENCES [conferention].[Страны] ([Идентификатор])
GO
ALTER TABLE [conferention].[Организаторы]  WITH CHECK ADD FOREIGN KEY([страна])
REFERENCES [conferention].[Страны] ([Идентификатор])
GO
ALTER TABLE [conferention].[План мероприятий]  WITH CHECK ADD FOREIGN KEY([Город])
REFERENCES [conferention].[Город] ([Номер_города])
GO
ALTER TABLE [conferention].[Участники]  WITH CHECK ADD FOREIGN KEY([страна])
REFERENCES [conferention].[Страны] ([Идентификатор])
GO
