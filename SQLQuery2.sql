--Left join
select SC.Sno,Cno,Grade,Student.Sname from dbo.SC left join dbo.Student
on SC.Sno=Student.Sno;
--Right join
select Student.Sno,Student.Ssex,SC.Cno from dbo.Student right join
dbo.SC on SC.Sno=Student.Sno;