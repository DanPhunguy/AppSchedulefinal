USE [eSchedule]
GO


CREATE TABLE [dbo].[SCHEDULE] (
    [ScheduleID]      INT       IDENTITY (9000, 1) NOT NULL,
    [First_Name]      CHAR (30) NOT NULL,
    [Last_Name]       CHAR (30) NOT NULL,
    [Phone_Number]    INT       NOT NULL,
    [Number_Of_Guest] INT       NOT NULL,
    [Calender_Date]   DATE      NOT NULL,
    [Time_Start]	  Time NOT NULL, 
	[Time_End]		  Time NOT NULL
);
ALTER TABLE [SCHEDULE]
ALTER COLUMN [Phone_Number] varchar (10)

