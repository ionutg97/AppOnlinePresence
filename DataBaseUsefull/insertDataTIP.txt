insert into dbo.Students(Id,Name) values('45f78efa-451c-462a-85cf-b9fd82666d9b','Galan');

insert into dbo.Years(Id,Name) values ('91c318e6-0278-440f-802f-d4f5210ecc5c','IV');
insert into dbo.Courses(Id,Name) values ('aaac8542-72ad-49ee-acfc-6529b02b923c','Programare Web');
insert into dbo.Groups(Id,Name,CoursId) values ('8a3c7139-4fd1-4125-af23-7ae8ee3f86c4', '1310A','aaac8542-72ad-49ee-acfc-6529b02b923c');

insert into dbo.Students(Id,Name,GroupId,StudiesYearId) values('75f78efa-451c-462a-85cf-b9fd82666d9b','Galan','8a3c7139-4fd1-4125-af23-7ae8ee3f86c4','91c318e6-0278-440f-802f-d4f5210ecc5c');

select * from dbo.Students;

insert into dbo.Classrooms (Id,Name) values ('466a9bf4-195f-425d-bac1-8d654395a2fb','AC02');
insert into dbo.Classrooms (Id,Name) values ('465a9bf4-195f-425d-bac1-8d654395a2fb','AC01');

 insert into dbo.Courses(Id,Name) values ('A1AC8542-72AD-49EE-ACFC-6529B02B923C','Sisteme de prelucrare grafica');
  insert into dbo.Courses(Id,Name) values ('A1AC8542-72AD-49EE-ACFC-6529B02B923C','Sisteme de prelucrare grafica');

insert into dbo.Laboratories(Id,Name,GroupId) values ('f6191b8b-1cd9-46ca-b582-e5c0cf065037','TIP_laborator','8A3C7139-4FD1-4125-AF23-7AE8EE3F86C4');
insert into dbo.TeacherAccounts(Id,TeacherAccountName,Password,TeacherFullName) values ('f6191b8b-1cd9-46ca-b582-e5c0cf065037','aadrian','qwe123','Alexandrescu Adrian');

insert into dbo.Timetables(Id,HourStart,HourEnd,TeacherAccountId,CoursId,ClassroomId)
	values('c0882f64-97f9-407f-be84-1f831879f3c3','20190418 10:00:00 AM','20190418 12:00:00 PM',
	'f6191b8b-1cd9-46ca-b582-e5c0cf065037','A1AC8542-72AD-49EE-ACFC-6529B02B923C',
	'466a9bf4-195f-425d-bac1-8d654395a2fb');

insert into dbo.Timetables(Id,HourStart,HourEnd,TeacherAccountId,CoursId,ClassroomId)
	values('c1882f64-97f9-407f-be84-1f831879f3c3','20190418 12:00:00 PM','20190418 14:00:00 PM',
	'f6191b8b-1cd9-46ca-b582-e5c0cf065037','A1AC8542-72AD-49EE-ACFC-6529B02B923C',
	'466a9bf4-195f-425d-bac1-8d654395a2fb');

insert into dbo.Users (Id,Password,UserName) values ('b1c8d6e7-eebd-4e2f-954f-e0f8bbe70fd1','qwerty','ionutg');

insert into dbo.ListAttendances (Id,Name) values ('e770e13a-d98a-4662-9e3d-316ee31d69bc','Prezenta curs tehnologii web');

insert into dbo.Attendances(Id,StudentId,Nota,TeacherNotification,StudentNotification,ListAttendancesId)
	values('b161facb-5d4a-4556-8bfe-6b72f4bf2a2a','75f78efa-451c-462a-85cf-b9fd82666d9b','7','plus 2','','e770e13a-d98a-4662-9e3d-316ee31d69bc') ;