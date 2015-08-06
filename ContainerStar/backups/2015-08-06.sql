USE ContainerStar;

ALTER TABLE [dbo].[Containers]
 ADD [NewContainerPrice] float NOT NULL default(0)
GO

CREATE TABLE [dbo].[OrderContainer_Equipment_Rsp](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ContainerId] [int] NOT NULL,
	[EquipmentId] [int] NOT NULL,
	[Amount] [int] NOT NULL DEFAULT ((1)),
	[CreateDate] [datetime2](2) NOT NULL,
	[ChangeDate] [datetime2](2) NOT NULL,
	[DeleteDate] [datetime2](2) NULL,
 CONSTRAINT [RK_ORDER_CONTAINER_EQUIPMENT_RSP_ID] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[OrderContainer_Equipment_Rsp]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_CONTAINER_EQUIPMENT_RSP_ORDER_ID] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[OrderContainer_Equipment_Rsp]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_CONTAINER_EQUIPMENT_RSP_CONTAINER_ID] FOREIGN KEY([ContainerId])
REFERENCES [dbo].[Containers] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[OrderContainer_Equipment_Rsp]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_CONTAINER_EQUIPMENT_RSP_EQUIPMENT_ID] FOREIGN KEY([EquipmentId])
REFERENCES [dbo].[Equipments] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[InvoiceStornos]
 ADD [FreeText] nvarchar(512) NULL
GO
