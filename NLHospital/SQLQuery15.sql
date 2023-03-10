




CREATE TABLE [dbo].[AdmissionRecords](
	[AdmissionID] [nvarchar](30) NOT NULL,
	[PatientID] [nvarchar](15) NOT NULL,
	[BedNumber] [nvarchar](3) NOT NULL,
	[SurgeryScheduled] [bit] NOT NULL,
	[AdmitDate] [datetime] NULL,
	[SurgeryDate] [datetime] NULL,
	[DischargeDate] [datetime] NULL,
	[Doctor] [nvarchar](4) NULL,
 CONSTRAINT [PK_AdmissionRecords] PRIMARY KEY CLUSTERED 
(
	[AdmissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Beds]    Script Date: 2022/12/16 4:15:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Beds](
	[BedNumber] [nvarchar](3) NOT NULL,
	[BedType] [nvarchar](15) NOT NULL,
	[Occupied] [bit] NOT NULL,
	[WardName] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Beds] PRIMARY KEY CLUSTERED 
(
	[BedNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 2022/12/16 4:15:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[DoctorID] [nvarchar](4) NOT NULL,
	[LastName] [nvarchar](30) NULL,
	[FirstName] [nvarchar](30) NULL,
	[Specialty] [nvarchar](20) NULL,
 CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Extra_Rates]    Script Date: 2022/12/16 4:15:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Extra_Rates](
	[AmenityName] [nvarchar](20) NULL,
	[DailyCost] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Extras]    Script Date: 2022/12/16 4:15:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Extras](
	[PatientID] [nvarchar](15) NOT NULL,
	[AdmissionRecordID] [nvarchar](30) NOT NULL,
	[TV] [bit] NOT NULL,
	[Phone] [bit] NOT NULL,
	[SemiPrivate] [bit] NOT NULL,
	[Private] [bit] NOT NULL,
 CONSTRAINT [PK_Extras_1] PRIMARY KEY CLUSTERED 
(
	[AdmissionRecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 2022/12/16 4:15:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserID] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
	[UserType] [nvarchar](30) NOT NULL,
	[Ref] [nvarchar](30) NULL,
	[UserName] [nchar](30) NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 2022/12/16 4:15:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[HealthNumber] [nvarchar](15) NOT NULL,
	[DateOfBirth] [datetime] NULL,
	[LastName] [nvarchar](30) NULL,
	[FirstName] [nvarchar](30) NULL,
	[Address] [nvarchar](50) NULL,
	[City] [nvarchar](30) NULL,
	[Province] [nvarchar](15) NULL,
	[PostalCode] [nvarchar](7) NULL,
	[Phone] [nvarchar](14) NULL,
	[InsuranceCompany] [nvarchar](30) NULL,
	[InsuranceNumber] [nvarchar](15) NULL,
	[NextOfKin] [nvarchar](30) NULL,
	[NextOfKinRelationship] [nvarchar](10) NULL,
	[Doctor] [nvarchar](4) NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[HealthNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AdmissionRecords] ([AdmissionID], [PatientID], [BedNumber], [SurgeryScheduled], [AdmitDate], [SurgeryDate], [DischargeDate], [Doctor]) VALUES (N'1', N'2', N'P01', 0, CAST(N'2022-12-12T22:51:22.887' AS DateTime), NULL, CAST(N'2022-12-28T22:51:22.000' AS DateTime), N'1')
INSERT [dbo].[AdmissionRecords] ([AdmissionID], [PatientID], [BedNumber], [SurgeryScheduled], [AdmitDate], [SurgeryDate], [DischargeDate], [Doctor]) VALUES (N'10', N'2', N'P02', 0, CAST(N'2022-12-13T14:43:59.243' AS DateTime), NULL, NULL, N'1')
INSERT [dbo].[AdmissionRecords] ([AdmissionID], [PatientID], [BedNumber], [SurgeryScheduled], [AdmitDate], [SurgeryDate], [DischargeDate], [Doctor]) VALUES (N'2', N'2', N'P01', 0, CAST(N'2022-12-12T23:37:43.483' AS DateTime), NULL, CAST(N'2022-12-12T23:41:44.753' AS DateTime), N'1')
INSERT [dbo].[AdmissionRecords] ([AdmissionID], [PatientID], [BedNumber], [SurgeryScheduled], [AdmitDate], [SurgeryDate], [DischargeDate], [Doctor]) VALUES (N'3', N'1', N'N01', 0, CAST(N'2022-12-12T23:37:43.483' AS DateTime), NULL, CAST(N'2022-12-12T23:41:44.753' AS DateTime), N'2')
INSERT [dbo].[AdmissionRecords] ([AdmissionID], [PatientID], [BedNumber], [SurgeryScheduled], [AdmitDate], [SurgeryDate], [DischargeDate], [Doctor]) VALUES (N'4', N'1', N'N01', 0, CAST(N'2022-12-12T23:42:16.653' AS DateTime), NULL, CAST(N'2022-12-13T14:34:38.520' AS DateTime), N'1')
INSERT [dbo].[AdmissionRecords] ([AdmissionID], [PatientID], [BedNumber], [SurgeryScheduled], [AdmitDate], [SurgeryDate], [DischargeDate], [Doctor]) VALUES (N'5', N'1', N'N02', 0, CAST(N'2022-12-13T14:37:30.610' AS DateTime), NULL, CAST(N'2022-12-15T14:37:54.000' AS DateTime), N'1')
INSERT [dbo].[AdmissionRecords] ([AdmissionID], [PatientID], [BedNumber], [SurgeryScheduled], [AdmitDate], [SurgeryDate], [DischargeDate], [Doctor]) VALUES (N'6', N'2', N'S01', 1, CAST(N'2022-12-13T14:43:59.243' AS DateTime), CAST(N'2022-12-13T14:43:59.250' AS DateTime), CAST(N'2022-12-14T14:44:22.000' AS DateTime), N'1')
INSERT [dbo].[AdmissionRecords] ([AdmissionID], [PatientID], [BedNumber], [SurgeryScheduled], [AdmitDate], [SurgeryDate], [DischargeDate], [Doctor]) VALUES (N'7', N'2', N'P01', 0, CAST(N'2022-12-13T14:43:59.243' AS DateTime), NULL, CAST(N'2022-12-14T14:44:22.000' AS DateTime), N'1')
INSERT [dbo].[AdmissionRecords] ([AdmissionID], [PatientID], [BedNumber], [SurgeryScheduled], [AdmitDate], [SurgeryDate], [DischargeDate], [Doctor]) VALUES (N'8', N'2', N'P02', 0, CAST(N'2022-12-13T14:43:59.243' AS DateTime), NULL, CAST(N'2022-12-14T14:44:22.000' AS DateTime), N'1')
INSERT [dbo].[AdmissionRecords] ([AdmissionID], [PatientID], [BedNumber], [SurgeryScheduled], [AdmitDate], [SurgeryDate], [DischargeDate], [Doctor]) VALUES (N'9', N'1', N'N02', 0, CAST(N'2022-12-13T14:43:59.243' AS DateTime), NULL, NULL, N'1')
GO
INSERT [dbo].[Beds] ([BedNumber], [BedType], [Occupied], [WardName]) VALUES (N'N01', N'Normal', 0, N'Normal')
INSERT [dbo].[Beds] ([BedNumber], [BedType], [Occupied], [WardName]) VALUES (N'N02', N'Semi-Private', 1, N'Normal')
INSERT [dbo].[Beds] ([BedNumber], [BedType], [Occupied], [WardName]) VALUES (N'N03', N'Private', 0, N'Normal')
INSERT [dbo].[Beds] ([BedNumber], [BedType], [Occupied], [WardName]) VALUES (N'P01', N'Normal', 0, N'Pediatrics')
INSERT [dbo].[Beds] ([BedNumber], [BedType], [Occupied], [WardName]) VALUES (N'P02', N'Semi-Private', 1, N'Pediatrics')
INSERT [dbo].[Beds] ([BedNumber], [BedType], [Occupied], [WardName]) VALUES (N'P03', N'Private', 0, N'Pediatrics')
INSERT [dbo].[Beds] ([BedNumber], [BedType], [Occupied], [WardName]) VALUES (N'S01', N'Normal', 0, N'Surgery')
INSERT [dbo].[Beds] ([BedNumber], [BedType], [Occupied], [WardName]) VALUES (N'S03', N'Semi-Private', 0, N'Surgery')
INSERT [dbo].[Beds] ([BedNumber], [BedType], [Occupied], [WardName]) VALUES (N'S05', N'Private', 0, N'Surgery')
GO
INSERT [dbo].[Doctors] ([DoctorID], [LastName], [FirstName], [Specialty]) VALUES (N'1', N'1', N'2', N'surgery')
INSERT [dbo].[Doctors] ([DoctorID], [LastName], [FirstName], [Specialty]) VALUES (N'2   ', N'B', N'A', N'surgery')
INSERT [dbo].[Doctors] ([DoctorID], [LastName], [FirstName], [Specialty]) VALUES (N'4   ', N'1', N'2', N'pediatrics')
GO
INSERT [dbo].[Extra_Rates] ([AmenityName], [DailyCost]) VALUES (N'TV', 42.5000)
INSERT [dbo].[Extra_Rates] ([AmenityName], [DailyCost]) VALUES (N'Phone', 7.5000)
INSERT [dbo].[Extra_Rates] ([AmenityName], [DailyCost]) VALUES (N'SemiPrivate', 267.0000)
INSERT [dbo].[Extra_Rates] ([AmenityName], [DailyCost]) VALUES (N'Private', 571.0000)
GO
INSERT [dbo].[Extras] ([PatientID], [AdmissionRecordID], [TV], [Phone], [SemiPrivate], [Private]) VALUES (N'2', N'1   ', 1, 1, 0, 0)
INSERT [dbo].[Extras] ([PatientID], [AdmissionRecordID], [TV], [Phone], [SemiPrivate], [Private]) VALUES (N'2', N'10  ', 1, 1, 1, 0)
INSERT [dbo].[Extras] ([PatientID], [AdmissionRecordID], [TV], [Phone], [SemiPrivate], [Private]) VALUES (N'2', N'2   ', 0, 0, 0, 0)
INSERT [dbo].[Extras] ([PatientID], [AdmissionRecordID], [TV], [Phone], [SemiPrivate], [Private]) VALUES (N'1', N'3   ', 0, 0, 0, 0)
INSERT [dbo].[Extras] ([PatientID], [AdmissionRecordID], [TV], [Phone], [SemiPrivate], [Private]) VALUES (N'1', N'4   ', 0, 0, 0, 0)
INSERT [dbo].[Extras] ([PatientID], [AdmissionRecordID], [TV], [Phone], [SemiPrivate], [Private]) VALUES (N'1', N'5   ', 1, 1, 1, 0)
INSERT [dbo].[Extras] ([PatientID], [AdmissionRecordID], [TV], [Phone], [SemiPrivate], [Private]) VALUES (N'2', N'6   ', 0, 0, 0, 0)
INSERT [dbo].[Extras] ([PatientID], [AdmissionRecordID], [TV], [Phone], [SemiPrivate], [Private]) VALUES (N'2', N'7   ', 0, 0, 0, 0)
INSERT [dbo].[Extras] ([PatientID], [AdmissionRecordID], [TV], [Phone], [SemiPrivate], [Private]) VALUES (N'2', N'8   ', 1, 1, 1, 0)
INSERT [dbo].[Extras] ([PatientID], [AdmissionRecordID], [TV], [Phone], [SemiPrivate], [Private]) VALUES (N'1', N'9   ', 1, 1, 1, 0)
GO
INSERT [dbo].[Login] ([UserID], [Password], [UserType], [Ref], [UserName]) VALUES (N'1', N'123456', N'Admin', NULL, N'Admin1                        ')
INSERT [dbo].[Login] ([UserID], [Password], [UserType], [Ref], [UserName]) VALUES (N'2', N'123456', N'Nurse', NULL, N'Nurse1                        ')
INSERT [dbo].[Login] ([UserID], [Password], [UserType], [Ref], [UserName]) VALUES (N'3', N'123456', N'Doctor', N'1', N'Doctor1                       ')
INSERT [dbo].[Login] ([UserID], [Password], [UserType], [Ref], [UserName]) VALUES (N'4', N'123456', N'Admissions', NULL, N'Recorder1                     ')
INSERT [dbo].[Login] ([UserID], [Password], [UserType], [Ref], [UserName]) VALUES (N'5', N'12341', N'Doctor', N'2', N'A B                           ')
INSERT [dbo].[Login] ([UserID], [Password], [UserType], [Ref], [UserName]) VALUES (N'6', N'12341', N'Doctor', N'3', N'C B                           ')
INSERT [dbo].[Login] ([UserID], [Password], [UserType], [Ref], [UserName]) VALUES (N'7', N'123', N'Doctor', N'4', N'2 1                           ')
GO
INSERT [dbo].[Patients] ([HealthNumber], [DateOfBirth], [LastName], [FirstName], [Address], [City], [Province], [PostalCode], [Phone], [InsuranceCompany], [InsuranceNumber], [NextOfKin], [NextOfKinRelationship], [Doctor]) VALUES (N'1', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'B', N'A', N'unknown', N'unknown', N'unknown', N'unknown', N'unknown', N'1', N'unknown', N'unknown', N'unknown', N'1')
INSERT [dbo].[Patients] ([HealthNumber], [DateOfBirth], [LastName], [FirstName], [Address], [City], [Province], [PostalCode], [Phone], [InsuranceCompany], [InsuranceNumber], [NextOfKin], [NextOfKinRelationship], [Doctor]) VALUES (N'2', CAST(N'2022-12-12T21:21:29.880' AS DateTime), N'2', N'2', N'2', N'2', N'2', N'2', N'2', N'2', N'2', N'2', N'2', N'1')
GO
/****** Object:  StoredProcedure [dbo].[CalculatingFee]    Script Date: 2022/12/16 4:15:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CalculatingFee](
   @AdmissionRecordID nvarchar(30),@timex DateTime
) AS

CREATE TABLE #res(TV money,Phone money ,SemiPri money,Pri money,TVTotal money,PhoneTotal money ,SemiPriTotal money,PriTotal money,Daystay int,Pid nvarchar(15));
DECLARE @TVFee money,@PhoneFee money,@SemiPriFee money,@PriFee money;
DECLARE @UseTV bit,@UsePhone bit,@UseSemiPri bit,@UsePri  bit;
DECLARE @indate DateTime;
DECLARE @days int;
DECLARE @Pid nvarchar(15);

select @TVFee=DailyCost FROM Extra_Rates WHERE AmenityName='TV';
select @PhoneFee=DailyCost FROM Extra_Rates WHERE AmenityName='Phone';
select @SemiPriFee=DailyCost FROM Extra_Rates WHERE AmenityName='SemiPrivate';
select @PriFee=DailyCost FROM Extra_Rates WHERE AmenityName='Private';


select @indate=AdmitDate,@Pid=PatientID from AdmissionRecords where AdmissionID=@AdmissionRecordID;
select @days= datediff(day, @indate,@timex)
select @UseTV=TV,@UsePhone=Phone,@UseSemiPri=SemiPrivate,@UsePri =[Private]   from Extras where AdmissionRecordID= @AdmissionRecordID;


insert into #res values(@TVFee,@PhoneFee,@SemiPriFee,@PriFee,@UseTV* @TVFee* @days,@UsePhone* @PhoneFee* @days,@UseSemiPri* @SemiPriFee* @days,@UsePri*@PriFee* @days,@days,@Pid);
select* from #res;
GO
/****** Object:  StoredProcedure [dbo].[LoginP]    Script Date: 2022/12/16 4:15:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[LoginP](
	@id nvarchar(15),
	@pass nvarchar(30)
)
AS
BEGIN
	SELECT * from Login where UserID=@id and Password=@pass;
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Admissions/Admin/Nurse/Doctor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Login', @level2type=N'COLUMN',@level2name=N'UserType'
GO