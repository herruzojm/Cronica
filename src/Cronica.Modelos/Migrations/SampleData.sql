
USE [Cronica]
GO

INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Cuenta], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'3591851d-dcad-46a1-9a74-e0b28ce31ee6', 0, N'aa07a1e5-1d70-4218-a55e-947233aaeeb2', 0, N'jugador@yopmail.com', 1, 1, NULL, N'JUGADOR@YOPMAIL.COM', N'JUGADOR@YOPMAIL.COM', N'AQAAAAEAACcQAAAAEDa8VrWvU1HEPVRFWLSQUD1NQHz9sRnPcDnHR2MiBoBGucBDiZnLR0/AYZYDkoaOHg==', NULL, 0, N'ade6bba3-c49a-4361-b581-3f0d3a14963e', 0, N'jugador@yopmail.com')
GO
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Cuenta], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'377784a7-d7ef-4cd7-a8d0-5ac1e86039c2', 0, N'6a584eb4-976a-4565-8e6b-c087f9955e7d', 1, N'narrador@yopmail.com', 1, 1, NULL, N'NARRADOR@YOPMAIL.COM', N'NARRADOR@YOPMAIL.COM', N'AQAAAAEAACcQAAAAEGQUinIJUJya8vCwPj5GvTuXWKhTWQRzg9/esng7EMZBPX7vrEDUvAiPDNDN9QG0/A==', NULL, 0, N'87043d95-4eec-458d-a16a-dd0e4dd12dd0', 0, N'narrador@yopmail.com')
GO
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Cuenta], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'32ad9830-b7ac-4125-954e-b41505c8eab5', 0, N'08750dce-6285-4ff6-b425-1d2d8bf655c3', 2, N'administrador@yopmail.com', 0, 1, NULL, N'ADMINISTRADOR@YOPMAIL.COM', N'ADMINISTRADOR@YOPMAIL.COM', N'AQAAAAEAACcQAAAAEKfiih7+Yohqm/682yDA19Ya1/ms+FxcpOoE/YGAT7u/m5sKyjsXV2pAJxVy5k9VOQ==', NULL, 0, N'3908af19-ddea-4460-87c2-a494b7411dc4', 0, N'administrador@yopmail.com')
GO


SET IDENTITY_INSERT [dbo].[Atributos] ON 

GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (1, N'Fuerza', 1, 0, 0)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (2, N'Destreza', 2, 0, 0)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (3, N'Resistencia', 3, 0, 0)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (4, N'Carisma', 1, 1, 0)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (5, N'Manipulación', 2, 1, 0)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (6, N'Apariencia', 3, 1, 0)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (7, N'Percepción', 1, 2, 0)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (8, N'Inteligencia', 2, 2, 0)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (9, N'Astucia', 3, 2, 0)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (10, N'Alerta', 1, 3, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (11, N'Atletismo', 2, 3, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (12, N'Callejeo', 3, 3, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (13, N'Consciencia', 4, 3, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (14, N'Empatia', 5, 3, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (15, N'Expresion', 6, 3, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (16, N'Intimidacion', 7, 3, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (17, N'Liderazgo', 8, 3, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (18, N'Pelea', 9, 3, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (19, N'Subterfugio', 10, 3, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (20, N'Armas C.C.', 1, 4, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (21, N'Armas de Fuego', 2, 4, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (22, N'Conducir', 3, 4, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (23, N'Etiqueta', 4, 4, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (24, N'Hurto', 5, 4, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (25, N'Interpretacion', 6, 4, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (26, N'Pericias', 7, 4, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (27, N'Sigilo', 8, 4, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (28, N'Supervivencia', 9, 4, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (29, N'Trato con Animales', 10, 4, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (30, N'Academicismo', 1, 5, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (31, N'Ciencia', 2, 5, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (32, N'Finanzas', 3, 5, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (33, N'Informatica', 4, 5, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (34, N'Investigacion', 5, 5, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (35, N'Leyes', 6, 5, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (36, N'Medicina', 7, 5, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (37, N'Ocultismo', 8, 5, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (38, N'Politica', 9, 5, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (39, N'Tecnologia', 10, 5, 1)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (40, N'Aliados', 10, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (41, N'Contactos: Bajos Fondos', 20, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (42, N'Contactos: Cultura Académica', 30, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (43, N'Contactos: Finanzas', 40, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (44, N'Contactos: Fuerzas del Estado', 50, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (45, N'Contactos: Informatica', 60, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (46, N'Contactos: Medios de Comunicacion', 70, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (47, N'Contactos: Ocultismo', 80, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (48, N'Contactos: Politica', 90, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (49, N'Contactos: Transporte e Infraestructuras', 100, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (50, N'Criados', 110, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (51, N'Dominio', 120, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (52, N'Fama', 130, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (53, N'Generacion', 140, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (54, N'Identidad Alternativa', 150, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (55, N'Influencia: Bajos Fondos', 160, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (56, N'Influencia: Cultura Académica', 170, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (57, N'Influencia: Finanzas', 180, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (58, N'Influencia: Fuerzas del Estado', 190, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (59, N'Influencia: Informatica', 200, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (60, N'Influencia: Medios de Comunicacion', 210, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (61, N'Influencia: Ocultismo', 220, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (62, N'Influencia: Politica', 230, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (63, N'Influencia: Transporte e Infraestructuras', 240, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (64, N'Mentor', 250, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (65, N'Rebaño', 260, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (66, N'Recursos', 270, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (67, N'Refugio: Seguridad', 280, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (68, N'Refugio: Tamaño', 290, 5, 2)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (69, N'Consciencia', 10, 5, 4)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (70, N'Conviccion', 20, 5, 4)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (71, N'Autocontrol', 30, 5, 4)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (72, N'Instinto', 40, 5, 4)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (73, N'Coraje', 50, 5, 4)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (74, N'Animalismo', 10, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (75, N'Auspex', 20, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (76, N'Celeridad', 30, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (77, N'Dementacion', 40, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (78, N'Dominacion', 50, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (79, N'Extincion', 60, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (80, N'Fortaleza', 70, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (81, N'Nigromancia: Sepulcro', 80, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (82, N'Nigromancia: Cadaver Dentro del Monstruo', 90, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (83, N'Nigromancia: Podredumbre de la Tumba', 100, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (84, N'Nigromancia: Cenizas', 110, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (85, N'Nigromancia: Cenotafio', 120, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (86, N'Nigromancia: Cuatro Humores', 130, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (87, N'Nigromancia: Osario', 140, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (88, N'Nigromancia: Vitrea', 150, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (89, N'Obtenebracion', 160, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (90, N'Ofuscacion', 170, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (91, N'Potencia', 180, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (92, N'Presencia', 190, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (93, N'Quimerismo', 200, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (94, N'Serpentis', 210, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (95, N'Taumaturgia: Sangre', 220, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (96, N'Taumaturgia: Control Atmosferico', 230, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (97, N'Taumaturgia: Dominio Elemental', 240, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (98, N'Taumaturgia: Encanto de las Llamas', 250, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (99, N'Taumaturgia: Movimiento Mental', 260, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (100, N'Taumaturgia: Conjuracion', 270, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (101, N'Taumaturgia: Marte', 280, 5, 3)
GO
INSERT [dbo].[Atributos] ([AtributoId], [Nombre], [Orden], [SubTipo], [Tipo]) VALUES (102, N'Vicisitud', 290, 5, 3)
GO
SET IDENTITY_INSERT [dbo].[Atributos] OFF
GO


--


SET IDENTITY_INSERT [dbo].[PlantillasTrama] ON 

GO
INSERT [dbo].[PlantillasTrama] ([PlantillaTramaId], [Descripcion], [Nombre], [PuntosDePresionPorTiemppo], [PuntosNecesarios], [TipoTrama]) VALUES (1, N'Aumentar Recursos', N'Aumentar Recursos', 1, 50, 0)
GO
INSERT [dbo].[PlantillasTrama] ([PlantillaTramaId], [Descripcion], [Nombre], [PuntosDePresionPorTiemppo], [PuntosNecesarios], [TipoTrama]) VALUES (2, N'Turnarse para seguir a alguien', N'Seguir a alguien', -5, 85, 1)
GO
INSERT [dbo].[PlantillasTrama] ([PlantillaTramaId], [Descripcion], [Nombre], [PuntosDePresionPorTiemppo], [PuntosNecesarios], [TipoTrama]) VALUES (3, N'Gana el pulsu a tu rival', N'Ganar el pulso', 0, 30, 2)
GO
SET IDENTITY_INSERT [dbo].[PlantillasTrama] OFF
GO


--




INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (1, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (1, 2, 2)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (1, 3, 4)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (2, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (2, 2, 2)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (2, 3, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (3, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (3, 2, 3)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (3, 3, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (4, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (4, 2, 4)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (4, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (5, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (5, 2, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (5, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (6, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (6, 2, 2)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (6, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (7, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (7, 2, 3)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (7, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (8, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (8, 2, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (8, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (9, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (9, 2, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (9, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (10, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (10, 2, 2)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (10, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (11, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (11, 2, 5)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (11, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (12, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (12, 2, 4)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (12, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (13, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (13, 2, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (13, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (14, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (14, 2, 2)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (14, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (15, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (15, 2, 3)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (15, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (16, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (16, 2, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (16, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (17, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (17, 2, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (17, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (18, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (18, 2, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (18, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (19, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (19, 2, 2)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (19, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (20, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (20, 2, 3)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (20, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (21, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (21, 2, 4)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (21, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (22, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (22, 2, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (22, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (23, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (23, 2, 2)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (23, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (24, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (24, 2, 3)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (24, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (25, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (25, 2, 4)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (25, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (26, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (26, 2, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (26, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (27, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (27, 2, 2)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (27, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (28, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (28, 2, 3)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (28, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (29, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (29, 2, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (29, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (30, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (30, 2, 4)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (30, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (31, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (31, 2, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (31, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (32, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (32, 2, 2)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (32, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (33, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (33, 2, 3)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (33, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (34, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (34, 2, 2)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (34, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (35, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (35, 2, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (35, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (36, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (36, 2, 2)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (36, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (37, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (37, 2, 3)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (37, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (38, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (38, 2, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (38, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (39, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (39, 2, 3)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (39, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (40, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (40, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (40, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (41, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (41, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (41, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (42, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (42, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (42, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (43, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (43, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (43, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (44, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (44, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (44, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (45, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (45, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (45, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (46, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (46, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (46, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (47, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (47, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (47, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (48, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (48, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (48, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (49, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (49, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (49, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (50, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (50, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (50, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (51, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (51, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (51, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (52, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (52, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (52, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (53, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (53, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (53, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (54, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (54, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (54, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (55, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (55, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (55, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (56, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (56, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (56, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (57, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (57, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (57, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (58, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (58, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (58, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (59, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (59, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (59, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (60, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (60, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (60, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (61, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (61, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (61, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (62, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (62, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (62, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (63, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (63, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (63, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (64, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (64, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (64, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (65, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (65, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (65, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (66, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (66, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (66, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (67, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (67, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (67, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (68, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (68, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (68, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (69, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (69, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (69, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (70, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (70, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (70, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (71, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (71, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (71, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (72, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (72, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (72, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (73, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (73, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (73, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (74, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (74, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (74, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (75, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (75, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (75, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (76, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (76, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (76, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (77, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (77, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (77, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (78, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (78, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (78, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (79, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (79, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (79, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (80, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (80, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (80, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (81, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (81, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (81, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (82, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (82, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (82, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (83, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (83, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (83, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (84, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (84, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (84, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (85, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (85, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (85, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (86, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (86, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (86, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (87, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (87, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (87, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (88, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (88, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (88, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (89, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (89, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (89, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (90, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (90, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (90, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (91, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (91, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (91, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (92, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (92, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (92, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (93, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (93, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (93, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (94, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (94, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (94, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (95, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (95, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (95, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (96, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (96, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (96, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (97, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (97, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (97, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (98, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (98, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (98, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (99, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (99, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (99, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (100, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (100, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (100, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (101, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (101, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (101, 3, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (102, 1, 1)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (102, 2, 0)
GO
INSERT [dbo].[AtributoPlantillaTrama] ([AtributoId], [PlantillaTramaId], [Multiplicador]) VALUES (102, 3, 0)
GO



--





SET IDENTITY_INSERT [dbo].[Personajes] ON 

GO
INSERT [dbo].[Personajes] ([PersonajeId], [Activo], [Clan], [Concepto], [Conducta], [Defectos], [Experiencia], [Generacion], [Historia], [JugadorId], [Meritos], [Naturaleza], [Nombre], [PotenciaSangre], [PuntosDeSangre], [Senda], [ValorSenda]) VALUES (1, 1, 0, NULL, NULL, NULL, 0, 0, NULL, N'377784a7-d7ef-4cd7-a8d0-5ac1e86039c2', NULL, NULL, N'Uno', 0, 0, 0, 0)
GO
INSERT [dbo].[Personajes] ([PersonajeId], [Activo], [Clan], [Concepto], [Conducta], [Defectos], [Experiencia], [Generacion], [Historia], [JugadorId], [Meritos], [Naturaleza], [Nombre], [PotenciaSangre], [PuntosDeSangre], [Senda], [ValorSenda]) VALUES (2, 1, 9, NULL, NULL, NULL, 0, 0, NULL, N'377784a7-d7ef-4cd7-a8d0-5ac1e86039c2', NULL, NULL, N'Dos', 0, 0, 0, 0)
GO
INSERT [dbo].[Personajes] ([PersonajeId], [Activo], [Clan], [Concepto], [Conducta], [Defectos], [Experiencia], [Generacion], [Historia], [JugadorId], [Meritos], [Naturaleza], [Nombre], [PotenciaSangre], [PuntosDeSangre], [Senda], [ValorSenda]) VALUES (3, 1, 18, NULL, NULL, NULL, 0, 0, NULL, N'3591851d-dcad-46a1-9a74-e0b28ce31ee6', NULL, NULL, N'Tres', 0, 0, 0, 0)
GO
INSERT [dbo].[Personajes] ([PersonajeId], [Activo], [Clan], [Concepto], [Conducta], [Defectos], [Experiencia], [Generacion], [Historia], [JugadorId], [Meritos], [Naturaleza], [Nombre], [PotenciaSangre], [PuntosDeSangre], [Senda], [ValorSenda]) VALUES (4, 0, 26, NULL, NULL, NULL, 0, 0, NULL, N'377784a7-d7ef-4cd7-a8d0-5ac1e86039c2', NULL, NULL, N'Cuatro', 0, 0, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[Personajes] OFF
GO




--



INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (1, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (1, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (1, 3, NULL, 2, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (1, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (2, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (2, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (2, 3, NULL, 3, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (2, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (3, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (3, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (3, 3, NULL, 2, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (3, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (4, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (4, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (4, 3, NULL, 1, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (4, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (5, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (5, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (5, 3, NULL, 4, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (5, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (6, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (6, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (6, 3, NULL, 2, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (6, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (7, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (7, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (7, 3, NULL, 3, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (7, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (8, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (8, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (8, 3, NULL, 4, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (8, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (9, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (9, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (9, 3, NULL, 1, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (9, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (10, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (10, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (10, 3, NULL, 2, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (10, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (11, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (11, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (11, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (11, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (12, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (12, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (12, 3, NULL, 1, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (12, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (13, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (13, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (13, 3, NULL, 3, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (13, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (14, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (14, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (14, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (14, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (15, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (15, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (15, 3, NULL, 7, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (15, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (16, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (16, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (16, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (16, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (17, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (17, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (17, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (17, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (18, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (18, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (18, 3, NULL, 4, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (18, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (19, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (19, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (19, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (19, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (20, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (20, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (20, 3, NULL, 4, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (20, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (21, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (21, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (21, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (21, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (22, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (22, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (22, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (22, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (23, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (23, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (23, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (23, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (24, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (24, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (24, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (24, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (25, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (25, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (25, 3, NULL, 2, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (25, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (26, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (26, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (26, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (26, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (27, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (27, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (27, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (27, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (28, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (28, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (28, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (28, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (29, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (29, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (29, 3, NULL, 2, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (29, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (30, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (30, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (30, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (30, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (31, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (31, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (31, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (31, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (32, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (32, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (32, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (32, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (33, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (33, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (33, 3, NULL, 3, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (33, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (34, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (34, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (34, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (34, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (35, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (35, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (35, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (35, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (36, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (36, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (36, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (36, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (37, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (37, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (37, 3, NULL, 1, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (37, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (38, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (38, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (38, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (38, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (39, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (39, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (39, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (39, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (40, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (40, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (40, 3, NULL, 4, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (40, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (41, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (41, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (41, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (41, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (42, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (42, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (42, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (42, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (43, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (43, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (43, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (43, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (44, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (44, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (44, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (44, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (45, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (45, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (45, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (45, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (46, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (46, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (46, 3, NULL, 3, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (46, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (47, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (47, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (47, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (47, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (48, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (48, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (48, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (48, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (49, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (49, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (49, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (49, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (50, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (50, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (50, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (50, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (51, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (51, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (51, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (51, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (52, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (52, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (52, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (52, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (53, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (53, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (53, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (53, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (54, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (54, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (54, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (54, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (55, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (55, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (55, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (55, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (56, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (56, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (56, 3, NULL, 2, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (56, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (57, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (57, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (57, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (57, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (58, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (58, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (58, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (58, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (59, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (59, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (59, 3, NULL, 1, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (59, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (60, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (60, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (60, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (60, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (61, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (61, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (61, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (61, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (62, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (62, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (62, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (62, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (63, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (63, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (63, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (63, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (64, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (64, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (64, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (64, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (65, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (65, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (65, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (65, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (66, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (66, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (66, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (66, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (67, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (67, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (67, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (67, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (68, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (68, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (68, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (68, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (69, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (69, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (69, 3, NULL, 3, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (69, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (70, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (70, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (70, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (70, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (71, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (71, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (71, 3, NULL, 2, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (71, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (72, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (72, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (72, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (72, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (73, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (73, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (73, 3, NULL, 2, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (73, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (74, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (74, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (74, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (74, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (75, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (75, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (75, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (75, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (76, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (76, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (76, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (76, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (77, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (77, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (77, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (77, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (78, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (78, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (78, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (78, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (79, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (79, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (79, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (79, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (80, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (80, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (80, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (80, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (81, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (81, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (81, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (81, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (82, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (82, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (82, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (82, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (83, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (83, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (83, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (83, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (84, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (84, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (84, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (84, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (85, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (85, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (85, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (85, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (86, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (86, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (86, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (86, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (87, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (87, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (87, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (87, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (88, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (88, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (88, 3, NULL, 1, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (88, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (89, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (89, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (89, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (89, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (90, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (90, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (90, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (90, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (91, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (91, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (91, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (91, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (92, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (92, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (92, 3, NULL, 2, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (92, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (93, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (93, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (93, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (93, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (94, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (94, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (94, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (94, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (95, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (95, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (95, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (95, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (96, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (96, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (96, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (96, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (97, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (97, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (97, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (97, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (98, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (98, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (98, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (98, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (99, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (99, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (99, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (99, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (100, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (100, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (100, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (100, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (101, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (101, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (101, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (101, 4, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (102, 1, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (102, 2, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (102, 3, NULL, 0, 0)
GO
INSERT [dbo].[AtributoPersonaje] ([AtributoId], [PersonajeId], [Descripcion], [Valor], [ValorEnTrama]) VALUES (102, 4, NULL, 0, 0)
GO



---



INSERT [dbo].[Seguidores] ([PersonajeJugadorId], [TrasfondoRelacionadoId], [TipoRelacion]) VALUES (3, 1, 1)
GO
INSERT [dbo].[Seguidores] ([PersonajeJugadorId], [TrasfondoRelacionadoId], [TipoRelacion]) VALUES (3, 2, 2)
GO
INSERT [dbo].[Seguidores] ([PersonajeJugadorId], [TrasfondoRelacionadoId], [TipoRelacion]) VALUES (4, 1, 0)
GO


update Cronica.dbo.AtributoPersonaje set ValorEnTrama = Valor
GO


SET IDENTITY_INSERT [dbo].PostPartidas ON
GO
insert into PostPartidas
(PostPartidaId, Cerrada, FechaFin, FechaInicio)
values
(1, 0, '30-05-2016', '01-05-2016'),
(2, 0, '30-06-2016', '01-06-2016')
GO
insert into PostPartidas
(PostPartidaId, Cerrada, FechaFin, FechaInicio)
values
(1, 0, '05-30-2016', '05-01-2016'),
(2, 0, '06-30-2016', '06-01-2016')
GO
SET IDENTITY_INSERT [dbo].PostPartidas OFF
GO


SET IDENTITY_INSERT [dbo].PasaTramas ON
GO
insert into PasaTramas
(PasaTramaId, FechaPrevista, FechaResolucion, PostPartidaId, Resuelto)
values
(1, '20/05/2016', '21/05/2016', 1, 1),
(2, '20/06/2016', null, 2, 0)
GO
insert into PasaTramas
(PasaTramaId, FechaPrevista, FechaResolucion, PostPartidaId, Resuelto)
values
(1, '05/20/2016', '05/21/2016', 1, 1),
(2, '06/20/2016', null, 2, 0)
GO
SET IDENTITY_INSERT [dbo].PasaTramas OFF
GO


SET IDENTITY_INSERT [dbo].[Tramas] ON 

GO
INSERT [dbo].[Tramas] ([TramaId], [Cerrada], [Descripcion], [Nombre], [PlantillaId], [PostPartidaId], [PuntosActuales], [PuntosDePresionPorTiemppo], [PuntosNecesarios], [TextoResolucion], [TipoTrama]) VALUES (1, 0, N'Aumentar Recursos', N'Aumentar Recursos', 1, NULL, 0, 1, 50, NULL, 0)
GO
INSERT [dbo].[Tramas] ([TramaId], [Cerrada], [Descripcion], [Nombre], [PlantillaId], [PostPartidaId], [PuntosActuales], [PuntosDePresionPorTiemppo], [PuntosNecesarios], [TextoResolucion], [TipoTrama]) VALUES (3, 0, N'Gana el pulso a tu rival', N'Ganar el pulso', 3, NULL, 0, 0, 30, NULL, 2)
GO
SET IDENTITY_INSERT [dbo].[Tramas] OFF
GO

insert into PuntosPasaTrama
(TramaId, PasaTramaId, PersonajeId, Descripcion, PuntosObtenidos)
values
(3, 2, 3, 'De segundas no contribuyes tanto', 6),
(3, 1, 3, 'Puntos para personaje tres', 10),
(3, 1, 5, 'Personaje cinco tambien contribuye', 30)
GO


SET IDENTITY_INSERT [dbo].[AspNetUserClaims] ON 

GO
INSERT [dbo].[AspNetUserClaims] ([Id], [ClaimType], [ClaimValue], [UserId]) VALUES (1, N'http://schemas.microsoft.com/ws/2008/06/identity/claims/role', N'Narrador', N'377784a7-d7ef-4cd7-a8d0-5ac1e86039c2')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [ClaimType], [ClaimValue], [UserId]) VALUES (2, N'http://schemas.microsoft.com/ws/2008/06/identity/claims/role', N'Jugador', N'3591851d-dcad-46a1-9a74-e0b28ce31ee6')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [ClaimType], [ClaimValue], [UserId]) VALUES (3, N'http://schemas.microsoft.com/ws/2008/06/identity/claims/role', N'Administrador', N'32ad9830-b7ac-4125-954e-b41505c8eab5')
GO
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] OFF
GO


insert into AtributoTrama
select AtributoId, TramaId, 1 from Atributos, Tramas
GO


insert into ParticipantesTrama
(TramaId, PersonajeId, Equipo)
values
(1, 3, 0),
(3, 3, 0)
GO


SET IDENTITY_INSERT [dbo].[Asignaciones] ON 
GO
insert into Asignaciones
(AsignacionId, PersonajeId, PasaTramaId)
values
(1, 3, 2)
GO
SET IDENTITY_INSERT [dbo].[Asignaciones] OFF
GO



SET IDENTITY_INSERT [dbo].[PersonajeAsignacion] ON 
GO
insert into PersonajeAsignacion
(PersonajeAsignacionId, AsignacionId, PersonajeId, PuntosParticipacion, TramaId)
values
(1,                         1,              3,           25,                1 ),
(2,                         1,              3,           75,                3 ),
(3,                         1,              1,           20,                1 ),
(4,                         1,              1,           80,                3 ),
(5,                         1,              2,           40,                1 ),
(6,                         1,              2,           60,                3 )
GO
SET IDENTITY_INSERT [dbo].[PersonajeAsignacion] OFF
GO




