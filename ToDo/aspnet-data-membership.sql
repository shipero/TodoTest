SET IDENTITY_INSERT [dbo].[UserProfile] ON 

INSERT [dbo].[UserProfile] ([UserId], [UserName]) VALUES (2, N'shipero@gmail.com')
INSERT [dbo].[UserProfile] ([UserId], [UserName]) VALUES (1, N'shiperotweet')
SET IDENTITY_INSERT [dbo].[UserProfile] OFF
INSERT [dbo].[webpages_OAuthMembership] ([Provider], [ProviderUserId], [UserId]) VALUES (N'google', N'https://www.google.com/accounts/o8/id?id=AItOawmJ3xjSS_qTuqiQRzn75mcr1OVgDpr_Dzc', 2)
INSERT [dbo].[webpages_OAuthMembership] ([Provider], [ProviderUserId], [UserId]) VALUES (N'twitter', N'18101280', 1)
