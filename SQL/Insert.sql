
select * from dbo.RoomReservations;
declare @StartTime datetime,@EndTime datetime;
set @StartTime = GETDATE();
set @EndTime=GETDATE();
insert into dbo.RoomReservations(Id,RoomName,StartDate,EndDate,Contact) 
values (1009,'TestTimeDate',@StartTime,@EndTime,'test');
select * from dbo.RoomReservations;