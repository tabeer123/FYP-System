USE [ProjectA]
GO
/****** Object:  Table [dbo].[Advisor]    Script Date: 5/3/2019 2:58:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advisor](
	[Id] [int] NOT NULL,
	[Designation] [int] NOT NULL,
	[Salary] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evaluation]    Script Date: 5/3/2019 2:58:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[TotalMarks] [int] NOT NULL,
	[TotalWeightage] [int] NOT NULL,
 CONSTRAINT [PK_Evaluation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 5/3/2019 2:58:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Created_On] [date] NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupEvaluation]    Script Date: 5/3/2019 2:58:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupEvaluation](
	[GroupId] [int] NOT NULL,
	[EvaluationId] [int] NOT NULL,
	[ObtainedMarks] [int] NOT NULL,
	[EvaluationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupEvaluation] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC,
	[EvaluationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupProject]    Script Date: 5/3/2019 2:58:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupProject](
	[ProjectId] [int] NOT NULL,
	[GroupId] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupProject] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC,
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupStudent]    Script Date: 5/3/2019 2:58:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupStudent](
	[GroupId] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupStudent] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC,
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lookup]    Script Date: 5/3/2019 2:58:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lookup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Value] [varchar](100) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Lookup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 5/3/2019 2:58:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NULL,
	[Contact] [varchar](20) NULL,
	[Email] [varchar](30) NOT NULL,
	[DateOfBirth] [datetime] NULL,
	[Gender] [int] NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 5/3/2019 2:58:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](max) NULL,
	[Title] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectAdvisor]    Script Date: 5/3/2019 2:58:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectAdvisor](
	[AdvisorId] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[AdvisorRole] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ProjectAdvisor] PRIMARY KEY CLUSTERED 
(
	[AdvisorId] ASC,
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 5/3/2019 2:58:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] NOT NULL,
	[RegistrationNo] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (2, 6, CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (3, 7, CAST(400000000 AS Decimal(18, 0)))
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (4, 7, CAST(20000000 AS Decimal(18, 0)))
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (8, 7, CAST(198000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Evaluation] ON 

INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (2004, N'DS', 100, 60)
INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (2006, N'tab', 100, 100)
INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (3005, N'HELLO', 100, 100)
INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (4005, N'OOD', 100, 100)
INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (4006, N'db', 100, 100)
SET IDENTITY_INSERT [dbo].[Evaluation] OFF
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (2005, CAST(N'2019-03-06' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (3002, CAST(N'2019-04-03' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (3003, CAST(N'2019-04-01' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (4004, CAST(N'2019-04-03' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (4005, CAST(N'2019-04-03' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (4006, CAST(N'2019-04-03' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (4007, CAST(N'2019-04-26' AS Date))
SET IDENTITY_INSERT [dbo].[Group] OFF
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (2005, 2004, 80, CAST(N'2019-04-01T00:21:07.000' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (3003, 3005, 60, CAST(N'2019-04-03T20:52:06.000' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (4004, 3005, 70, CAST(N'2019-04-03T20:51:40.000' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (4005, 2006, 80, CAST(N'2019-04-03T20:51:52.000' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (4005, 4005, 50, CAST(N'2019-04-03T20:52:18.000' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (4006, 4005, 60, CAST(N'2019-04-03T20:52:30.000' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (4007, 2004, 40, CAST(N'2019-04-26T09:41:08.000' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (4, 4006, CAST(N'2019-04-03T20:40:51.000' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (5, 3002, CAST(N'2019-04-03T20:50:36.000' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (5, 4004, CAST(N'2019-04-03T20:51:08.000' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (7, 2005, CAST(N'2019-04-03T20:50:27.000' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (7, 3002, CAST(N'2019-04-01T17:33:25.000' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (7, 4005, CAST(N'2019-04-03T20:40:43.000' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (8, 3003, CAST(N'2019-04-01T17:33:36.000' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (8, 4004, CAST(N'2019-04-03T20:50:45.000' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (1006, 3002, CAST(N'2019-04-03T20:50:16.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (4004, 2015, 3, CAST(N'2019-04-03T00:00:00.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (4004, 2016, 3, CAST(N'2019-04-03T00:00:00.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (4004, 4015, 3, CAST(N'2019-04-03T00:00:00.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (4005, 2016, 4, CAST(N'2019-04-03T00:00:00.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (4005, 4015, 4, CAST(N'2019-04-03T00:00:00.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (4006, 2016, 4, CAST(N'2019-04-03T00:00:00.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (4007, 2016, 4, CAST(N'2019-04-26T00:00:00.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (4007, 4015, 4, CAST(N'2019-04-26T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Lookup] ON 

INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (1, N'Male', N'GENDER')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (2, N'Female', N'GENDER')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (3, N'Active', N'STATUS')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (4, N'InActive', N'STATUS')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (6, N'Professor', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (7, N'Associate Professor', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (8, N'Assisstant Professor', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (9, N'Lecturer', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (10, N'Industry Professional', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (11, N'Main Advisor', N'ADVISOR_ROLE')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (12, N'Co-Advisror', N'ADVISOR_ROLE')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (14, N'Industry Advisor', N'ADVISOR_ROLE')
SET IDENTITY_INSERT [dbo].[Lookup] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (2003, N'Ali', N'Ahmed', N'1234567891', N'ali@gmail.com', CAST(N'2019-03-14T23:36:07.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (2004, N'Akbar', N'Wazeer', N'4562345673', N'akbar@gmail.com', CAST(N'2019-03-14T23:37:43.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (2005, N'Fahad', N'Ali', N'1236542434', N'fahad@gmail.com', CAST(N'2019-03-14T23:40:27.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (2008, N'Zaryab', N'Fatima', N'3252533512', N'zaryab@gmail.com', CAST(N'2019-03-15T02:09:01.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (2009, N'Zuha', N'Junaid', N'1234568765', N'zuha@gmail.com', CAST(N'2019-03-15T02:09:40.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (2010, N'Fatima', N'Ali', N'3463636231', N'fatima@gmail.com', CAST(N'2019-03-15T02:10:33.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (2015, N'Naim', N'Haq', N'3455122522', N'Naim@gmail.com', CAST(N'2019-04-01T00:18:35.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (2016, N'Noor', N'Waqas', N'5673534223', N'Noor@gmail.com', CAST(N'2019-04-01T00:18:54.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (4015, N'Hina', N'Faraz', N'1232546346', N'asd@gmail.com', CAST(N'2019-04-03T20:06:08.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Project] ON 

INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (4, N'Its all about synamic things', N'Dynamic')
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (5, N'About health ', N'Medical Health')
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (7, N'Very interesting pro', N'Interest')
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (8, N'what a life', N'Worth Living')
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (1006, N'All info of Lenses Project', N'Lenses Project')
SET IDENTITY_INSERT [dbo].[Project] OFF
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (2, 4, 11, CAST(N'2019-04-26T09:29:33.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (2, 5, 11, CAST(N'2019-04-26T09:29:33.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (3, 4, 11, CAST(N'2019-04-03T20:47:50.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (3, 5, 11, CAST(N'2019-04-03T20:47:50.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (3, 8, 11, CAST(N'2019-04-03T20:47:50.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (4, 4, 12, CAST(N'2019-04-03T20:47:50.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (4, 5, 12, CAST(N'2019-04-03T20:47:50.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (4, 8, 12, CAST(N'2019-04-03T20:47:50.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (4, 1006, 11, CAST(N'2019-04-03T20:47:50.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (8, 4, 14, CAST(N'2019-04-03T20:47:50.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (2015, N'2016cs345')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (2016, N'2017cd56')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (4015, N'2016cs344')
ALTER TABLE [dbo].[Advisor]  WITH CHECK ADD  CONSTRAINT [FK_Advisor_Lookup] FOREIGN KEY([Designation])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[Advisor] CHECK CONSTRAINT [FK_Advisor_Lookup]
GO
ALTER TABLE [dbo].[GroupEvaluation]  WITH CHECK ADD  CONSTRAINT [FK_GroupEvaluation_Evaluation] FOREIGN KEY([EvaluationId])
REFERENCES [dbo].[Evaluation] ([Id])
GO
ALTER TABLE [dbo].[GroupEvaluation] CHECK CONSTRAINT [FK_GroupEvaluation_Evaluation]
GO
ALTER TABLE [dbo].[GroupEvaluation]  WITH CHECK ADD  CONSTRAINT [FK_GroupEvaluation_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupEvaluation] CHECK CONSTRAINT [FK_GroupEvaluation_Group]
GO
ALTER TABLE [dbo].[GroupProject]  WITH CHECK ADD  CONSTRAINT [FK_GroupProject_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupProject] CHECK CONSTRAINT [FK_GroupProject_Group]
GO
ALTER TABLE [dbo].[GroupProject]  WITH CHECK ADD  CONSTRAINT [FK_GroupProject_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[GroupProject] CHECK CONSTRAINT [FK_GroupProject_Project]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_GroupStudents_Lookup] FOREIGN KEY([Status])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_GroupStudents_Lookup]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_ProjectStudents_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_ProjectStudents_Group]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_ProjectStudents_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_ProjectStudents_Student]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Lookup] FOREIGN KEY([Gender])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Lookup]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAdvisor_Lookup] FOREIGN KEY([AdvisorRole])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectAdvisor_Lookup]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAdvisor_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectAdvisor_Project]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTeachers_Teacher] FOREIGN KEY([AdvisorId])
REFERENCES [dbo].[Advisor] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectTeachers_Teacher]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Person] FOREIGN KEY([Id])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Person]
GO
