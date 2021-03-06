USE [ph17737444854_]
GO
/****** Object:  StoredProcedure [dbo].[SP_Payroll_Expense]    Script Date: 28-03-2019 14:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SP_Payroll_Expense]  
	-- Add the parameters for the stored procedure here
	@Emp_ID Nvarchar(50),
	@Date1 date,
	@Date2 date

AS

	
if(@Date1 != '')
BEGIN
SET NOCOUNT ON;
SELECT exp_amt as 'Amount' FROM Expense_Details WHERE [exp_emp_ID] = @Emp_ID AND exp_status='Accepted' AND [exp_date] BETWEEN @Date1 AND @Date2 ORDER BY [exp_date] desc ;
end
ELSE
BEGIN
SET NOCOUNT ON;
SELECT exp_amt as 'Amount' FROM Expense_Details WHERE [exp_emp_ID] = @Emp_ID AND exp_status='Accepted' ORDER BY [exp_date] desc ;
end;