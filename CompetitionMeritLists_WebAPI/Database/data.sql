SET IDENTITY_INSERT [dbo].[Students] ON
INSERT INTO [dbo].[Students] ([Id], [Student_Name], [Student_age], [School_Name], [Subject_Name], [Subject_Code], [Marks_Obtained]) VALUES (1, N'Avneet Singh', 25, N'ATC', N'Programming', N'5898', N'96')
INSERT INTO [dbo].[Students] ([Id], [Student_Name], [Student_age], [School_Name], [Subject_Name], [Subject_Code], [Marks_Obtained]) VALUES (2, N'Dilpreet Singh', 23, N'ATC', N'Database', N'5965', N'86')
SET IDENTITY_INSERT [dbo].[Students] OFF