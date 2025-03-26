USE [CMS_DB]
GO
/****** Object:  User [Admin_Moore]    Script Date: 26/03/2025 11:57:34 am ******/
CREATE USER [Admin_Moore] FOR LOGIN [Admin_Moore] WITH DEFAULT_SCHEMA=[Admin_Moore]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [Admin_Moore]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Admin_Moore]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Admin_Moore]
GO
/****** Object:  Schema [Admin_Moore]    Script Date: 26/03/2025 11:57:34 am ******/
CREATE SCHEMA [Admin_Moore]
GO
/****** Object:  Schema [CMS_admin]    Script Date: 26/03/2025 11:57:34 am ******/
CREATE SCHEMA [CMS_admin]
GO
/****** Object:  Schema [luqman]    Script Date: 26/03/2025 11:57:34 am ******/
CREATE SCHEMA [luqman]
GO
/****** Object:  Table [dbo].[tbl_complaints]    Script Date: 26/03/2025 11:57:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_complaints](
	[complaint_id] [nvarchar](50) NOT NULL,
	[complaint_number] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NULL,
	[Division] [nvarchar](50) NULL,
	[District] [nvarchar](50) NULL,
	[Tehsil] [nvarchar](50) NOT NULL,
	[Zone] [nvarchar](50) NULL,
	[Union_council] [nvarchar](50) NULL,
	[Complaint_type] [nvarchar](50) NULL,
	[PS_type] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[Reg_date] [nvarchar](50) NULL,
	[last_updated] [nvarchar](50) NULL,
	[reg_by] [nvarchar](50) NULL,
	[updated_by] [nvarchar](50) NULL,
	[remarks] [ntext] NULL,
	[Imagefile] [image] NULL,
	[Imagefileafter] [image] NULL,
	[numberofdays] [int] NULL,
 CONSTRAINT [PK_tbl_complaints] PRIMARY KEY CLUSTERED 
(
	[complaint_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_user]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[is_active] [bit] NULL,
 CONSTRAINT [PK_tbl_user] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[complaint_registration]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[complaint_registration]
      
	       @complaint_id nvarchar(50),
           @complaint_number nvarchar(50),
           @Name nvarchar(50),
           @Mobile nvarchar(50),
           @Address nvarchar(50),
           @Division nvarchar(50),
           @District nvarchar(50),
           @Tehsil nvarchar(50),
           @Zone nvarchar(50),
           @Union_council nvarchar(50),
           @Complaint_type nvarchar(50),
           @PS_type nvarchar(50),
           @Status nvarchar(50),
           @Reg_date nvarchar(50),
           @last_updated nvarchar(50),
           @reg_by nvarchar(50),
           @updated_by nvarchar(50),
           @remarks ntext
AS
BEGIN

      SET NOCOUNT ON;

INSERT INTO [dbo].[tbl_complaints]
           (complaint_id
		   ,[complaint_number]
           ,[Name]
           ,[Mobile]
           ,[Address]
           ,[Division]
           ,[District]
           ,[Tehsil]
           ,[Zone]
           ,[Union_council]
           ,[Complaint_type]
           ,[PS_type]
           ,[Status]
           ,[Reg_date]
           ,[last_updated]
           ,[reg_by]
           ,[updated_by]
           ,[remarks]
		   )
     VALUES
           (@complaint_id
		   ,@complaint_number ,
           @Name ,
           @Mobile ,
           @Address ,
           @Division ,
           @District ,
           @Tehsil ,
           @Zone ,
           @Union_council ,
           @Complaint_type ,
           @PS_type ,
           @Status ,
           @Reg_date ,
           @last_updated ,
           @reg_by ,
           @updated_by ,
           @remarks )



end
GO
/****** Object:  StoredProcedure [dbo].[Get_allcomcurrentmonth]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[Get_allcomcurrentmonth]
 @startdate date,
 @enddate date
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT count(complaint_id) as complaint_total
      
      
  FROM [CMS_DB].[dbo].[tbl_complaints] where Reg_date between @startdate and @enddate;

END
GO
/****** Object:  StoredProcedure [dbo].[Get_allcomcurrentmonthbytehsil]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[Get_allcomcurrentmonthbytehsil]
 @startdate date,
 @enddate date,
 @tehsil nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT count(complaint_id) as complaint_total
      
      
  FROM [CMS_DB].[dbo].[tbl_complaints] where Reg_date between @startdate and @enddate and Tehsil=@tehsil;

END
GO
/****** Object:  StoredProcedure [dbo].[Get_allcomplaintscount]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[Get_allcomplaintscount]
 
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT count(complaint_id) as complaint_total
      
      
  FROM [CMS_DB].[dbo].[tbl_complaints] ;

END
GO
/****** Object:  StoredProcedure [dbo].[Get_allcomplaintscountbystatus]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Get_allcomplaintscountbystatus]
 @status nvarchar(50),
 @currentmonth int
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT count(complaint_id) as complaint_total
      
      
  FROM [CMS_DB].[dbo].[tbl_complaints] where Status=@status and Month(Reg_date)=@currentmonth ;

END
GO
/****** Object:  StoredProcedure [dbo].[Get_allcomplaintscountbyTehsilandstatus]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[Get_allcomplaintscountbyTehsilandstatus]
 @status nvarchar(50),
 @currentmonth int,
 @tehsil nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT count(complaint_id) as complaint_total
      
      
  FROM [CMS_DB].[dbo].[tbl_complaints] where Status=@status and Tehsil=@tehsil and Month(Reg_date)=@currentmonth ;

END
GO
/****** Object:  StoredProcedure [dbo].[Get_allcomplaintscounttehsilwise]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Get_allcomplaintscounttehsilwise]
 @tehsil nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT count(complaint_id) as complaint_total
      
      
  FROM [tbl_complaints] where Tehsil =@tehsil;

END
GO
/****** Object:  StoredProcedure [dbo].[Get_closedcomplaintscounttehsilwise]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Get_closedcomplaintscounttehsilwise]
 @tehsil nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT count(complaint_id) as complaint_total
      
      
  FROM [CMS_DB].[dbo].[tbl_complaints] where Tehsil=@tehsil and Status='Resolved';

END
GO
/****** Object:  StoredProcedure [dbo].[Get_Complaints]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Get_Complaints]
      
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT complaint_id,[complaint_number],[Name] ,[Mobile]
      ,[Address]
      ,[Division]
      ,[District]
      ,[Tehsil]
      ,[Zone]
      ,[Union_council]
      ,[Complaint_type]
      ,[PS_type]
      ,[Status]
      ,[Reg_date]
        ,last_updated
	  ,numberofdays as Resolved_Hours, remarks
  FROM [CMS_DB].[dbo].[tbl_complaints]

END
GO
/****** Object:  StoredProcedure [dbo].[Get_Complaintsbycomplaint_number]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Get_Complaintsbycomplaint_number]
      @complaint_number nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT complaint_id,[complaint_number],[Name] ,[Mobile]
      ,[Address]
      ,[Division]
      ,[District]
      ,[Tehsil]
      ,[Zone]
      ,[Union_council]
      ,[Complaint_type]
      ,[PS_type]
      ,[Status]
      ,[Reg_date]
	    ,last_updated
	  ,numberofdays as Resolved_Days, remarks
      
  FROM [CMS_DB].[dbo].[tbl_complaints] where complaint_number=@complaint_number;

END
GO
/****** Object:  StoredProcedure [dbo].[Get_Complaintsbydate]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Get_Complaintsbydate]
      @startdate date,
	  @endate date
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT complaint_id,[complaint_number],[Name] ,[Mobile]
      ,[Address]
      ,[Division]
      ,[District]
      ,[Tehsil]
      ,[Zone]
      ,[Union_council]
      ,[Complaint_type]
      ,[PS_type]
      ,[Status]
      ,[Reg_date]
	    ,last_updated
	  ,numberofdays as Resolved_Hours, remarks
      
  FROM [CMS_DB].[dbo].[tbl_complaints] where Reg_date between @startdate and @endate;

END
GO
/****** Object:  StoredProcedure [dbo].[Get_Complaintsbymobile]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Get_Complaintsbymobile]
      @mobile nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT complaint_id,[complaint_number],[Name] ,[Mobile]
      ,[Address]
      ,[Division]
      ,[District]
      ,[Tehsil]
      ,[Zone]
      ,[Union_council]
      ,[Complaint_type]
      ,[PS_type]
      ,[Status]
      ,[Reg_date]
	    ,last_updated
	  ,numberofdays as Resolved_Days, remarks
      
  FROM [CMS_DB].[dbo].[tbl_complaints] where Mobile=@mobile;

END
GO
/****** Object:  StoredProcedure [dbo].[Get_Complaintsbyname]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Get_Complaintsbyname]
      @name nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT complaint_id,[complaint_number],[Name] ,[Mobile]
      ,[Address]
      ,[Division]
      ,[District]
      ,[Tehsil]
      ,[Zone]
      ,[Union_council]
      ,[Complaint_type]
      ,[PS_type]
      ,[Status]
      ,[Reg_date]
	    ,last_updated
	  ,numberofdays as Resolved_Hours, remarks
      
  FROM [CMS_DB].[dbo].[tbl_complaints] where Name=@name;

END
GO
/****** Object:  StoredProcedure [dbo].[Get_Complaintsbystatus]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Get_Complaintsbystatus]
      @status nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT complaint_id,[complaint_number],[Name] ,[Mobile]
      ,[Address]
      ,[Division]
      ,[District]
      ,[Tehsil]
      ,[Zone]
      ,[Union_council]
      ,[Complaint_type]
      ,[PS_type]
      ,[Status]
      ,[Reg_date]
	    ,last_updated
	  ,numberofdays as Resolved_Days, remarks
      
  FROM [CMS_DB].[dbo].[tbl_complaints] where Status=@status

END
GO
/****** Object:  StoredProcedure [dbo].[Get_Complaintsbystatuswithmonth]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Get_Complaintsbystatuswithmonth]
      @status nvarchar(50),
	  @month int
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT complaint_id,[complaint_number],[Name] ,[Mobile]
      ,[Address]
      ,[Division]
      ,[District]
      ,[Tehsil]
      ,[Zone]
      ,[Union_council]
      ,[Complaint_type]
      ,[PS_type]
      ,[Status]
      ,[Reg_date]
	    ,last_updated
	  ,numberofdays as Resolved_Days, remarks
      
  FROM [CMS_DB].[dbo].[tbl_complaints] where Status=@status and Month(Reg_date)=@month;

END
GO
/****** Object:  StoredProcedure [dbo].[Get_Complaintsdistrictwise]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Get_Complaintsdistrictwise]
      @district nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT complaint_id,[complaint_number],[Name] ,[Mobile]
      ,[Address]
      ,[Division]
      ,[District]
      ,[Tehsil]
      ,[Zone]
      ,[Union_council]
      ,[Complaint_type]
      ,[PS_type]
      ,[Status]
      ,[Reg_date]
	  ,last_updated
	  ,numberofdays as Resolved_Days, remarks
      
  FROM [CMS_DB].[dbo].[tbl_complaints] where District=@district

END
GO
/****** Object:  StoredProcedure [dbo].[Get_Complaintsswithmonth]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Get_Complaintsswithmonth]
      @status nvarchar(50),
	  @month int
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT complaint_id,[complaint_number],[Name] ,[Mobile]
      ,[Address]
      ,[Division]
      ,[District]
      ,[Tehsil]
      ,[Zone]
      ,[Union_council]
      ,[Complaint_type]
      ,[PS_type]
      ,[Status]
      ,[Reg_date]
	    ,last_updated
	  ,numberofdays as Resolved_Days, remarks
      
  FROM [CMS_DB].[dbo].[tbl_complaints] where  Month(Reg_date)=@month;

END
GO
/****** Object:  StoredProcedure [dbo].[Get_Complaintstehsilwise]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Get_Complaintstehsilwise]
      @tehsil nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT complaint_id,[complaint_number],[Name] ,[Mobile]
      ,[Address]
      ,[Division]
      ,[District]
      ,[Tehsil]
      ,[Zone]
      ,[Union_council]
      ,[Complaint_type]
      ,[PS_type]
      ,[Status]
      ,[Reg_date]
	    ,last_updated
	  ,numberofdays as Resolved_Days, remarks
      
  FROM [CMS_DB].[dbo].[tbl_complaints] where Tehsil=@tehsil

END
GO
/****** Object:  StoredProcedure [dbo].[Get_Complaintstehsilwisestatus]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Get_Complaintstehsilwisestatus]
      @tehsil nvarchar(50),
	  @status nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT complaint_id,[complaint_number],[Name] ,[Mobile]
      ,[Address]
      ,[Division]
      ,[District]
      ,[Tehsil]
      ,[Zone]
      ,[Union_council]
      ,[Complaint_type]
      ,[PS_type]
      ,[Status]
      ,[Reg_date]
	    ,last_updated
	  ,numberofdays as Resolved_Days, remarks
      
  FROM [CMS_DB].[dbo].[tbl_complaints] where Tehsil=@tehsil and Status=@status

END
GO
/****** Object:  StoredProcedure [dbo].[Get_Login]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Get_Login]
 @username nvarchar(50),
 @password nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;

	 SELECT [userid]
      ,[name]
      ,[username]
      ,[password]
      ,[is_active]
  FROM [dbo].[tbl_user] where username=@username and password=@password and is_active=1;

END
GO
/****** Object:  StoredProcedure [dbo].[Get_password]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
create PROCEDURE [dbo].[Get_password]
 @username nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;

	 SELECT [userid]
      ,[name]
      ,[username]
      ,[password]
      ,[is_active]
  FROM [dbo].[tbl_user] where username=@username ;

END
GO
/****** Object:  StoredProcedure [dbo].[Get_pendingcomplaintscounttehsilwise]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Get_pendingcomplaintscounttehsilwise]
 @tehsil nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;

	  SELECT count(complaint_id) as complaint_total
      
      
  FROM [CMS_DB].[dbo].[tbl_complaints] where Tehsil=@tehsil and Status='Pending';

END
GO
/****** Object:  StoredProcedure [dbo].[GetComplaintsPageWise]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[GetComplaintsPageWise]
      @PageIndex INT = 1
      ,@PageSize INT = 25
      ,@RecordCount INT OUTPUT
AS
BEGIN
      SET NOCOUNT ON;
      SELECT ROW_NUMBER() OVER
      (
            ORDER BY [Complaint_id] ASC
      )AS RowNumber
      ,complaint_id,[complaint_number]
	  ,[Name] 
	  ,[Mobile]
      ,[Address]
      ,[Division]
      ,[District]
      ,[Tehsil]
      ,[Zone]
      ,[Union_council]
      ,[Complaint_type]
      ,[PS_type]
      ,[Status]
      ,[Reg_date]
      ,last_updated
	  ,numberofdays as Resolved_Days, remarks
       INTO #Results
      FROM [tbl_complaints]
   
      SELECT @RecordCount = COUNT(*)
      FROM #Results
         
      SELECT complaint_id,[complaint_number]
	  ,[Name] 
	  ,[Mobile]
      ,[Address]
      ,[Division]
      ,[District]
      ,[Tehsil]
      ,[Zone]
      ,[Union_council]
      ,[Complaint_type]
      ,[PS_type]
      ,[Status]
      ,[Reg_date]
      ,last_updated
	  ,Resolved_Days
	  ,remarks
      FROM #Results
      WHERE RowNumber BETWEEN(@PageIndex -1) * @PageSize + 1 AND(((@PageIndex -1) * @PageSize + 1) + @PageSize) - 1
   
      DROP TABLE #Results
END
GO
/****** Object:  StoredProcedure [dbo].[update_complaint]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_complaint]
      
	       @complaint_id nvarchar(50),
           @complaint_number nvarchar(50),
           @Name nvarchar(50),
           @Mobile nvarchar(50),
           @Address nvarchar(50),
           @Division nvarchar(50),
           @District nvarchar(50),
           @Tehsil nvarchar(50),
           @Zone nvarchar(50),
           @Union_council nvarchar(50),
           @Complaint_type nvarchar(50),
           @PS_type nvarchar(50),
           @Status nvarchar(50),
           @last_updated nvarchar(50),
           @updated_by nvarchar(50),
           @remarks ntext
AS
BEGIN

      SET NOCOUNT ON;

UPDATE [dbo].[tbl_complaints]
   SET 
      complaint_number=@complaint_number,
      [Name] = @Name
      ,[Mobile] = @Mobile
      ,[Address] = @Address
      ,[Division] = @Division
      ,[District] = @District
      ,[Tehsil]=@Tehsil
      ,[Zone] = @Zone
      ,[Union_council] = @Union_council
      ,[Complaint_type] = @Complaint_type
      ,[PS_type] = @PS_type
      ,[Status] = @Status
      ,[last_updated] = @last_updated
      ,[updated_by] = @updated_by
      ,[remarks] = @remarks
 WHERE  complaint_id=@complaint_id 

end
GO
/****** Object:  StoredProcedure [dbo].[update_complaintbystatus]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_complaintbystatus]
           
		   
           @complaint_id nvarchar(50),
           @complaint_number nvarchar(50),
           @Status nvarchar(50),
           @last_updated nvarchar(50),
           @updated_by nvarchar(50),
		   @remarks ntext
		 
      
AS
BEGIN

      SET NOCOUNT ON;

UPDATE [dbo].[tbl_complaints]
   SET 
      [Status] = @Status
      ,[last_updated] = @last_updated
      ,[updated_by] = @updated_by
	  ,remarks=@remarks
	  
 WHERE  complaint_id=@complaint_id 

end
GO
/****** Object:  StoredProcedure [dbo].[update_complaintstatus]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_complaintstatus]
      
	        @complaint_id nvarchar(50),
           @complaint_number nvarchar(50),
           @Status nvarchar(50),
           @last_updated nvarchar(50),
           @updated_by nvarchar(50),
		   @Imagefile image,
		   @Imagefileafter image ,
		   @remarks ntext
      
AS
BEGIN

      SET NOCOUNT ON;

UPDATE [dbo].[tbl_complaints]
   SET 
      [Status] = @Status
      ,[last_updated] = @last_updated
      ,[updated_by] = @updated_by
	  ,[Imagefile]=@Imagefile
	  ,Imagefileafter=@Imagefileafter
	  ,remarks=@remarks
      
 WHERE  complaint_id=@complaint_id

end
GO
/****** Object:  StoredProcedure [dbo].[user_Registeration]    Script Date: 26/03/2025 11:57:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[user_Registeration]
  
  @name nvarchar(50),
           @username nvarchar(50),
           @password nvarchar(50),
           @is_active bit

AS
BEGIN
      SET NOCOUNT ON;

INSERT INTO [dbo].[tbl_user]
           ([name]
           ,[username]
           ,[password]
           ,[is_active])
     VALUES
           ( @name ,
           @username ,
           @password ,
           @is_active)
End


GO
