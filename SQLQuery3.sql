select * FROM [Betroot].[dbo].[Persons] as Persons Where Gender = 'Male'
select*FROM [Betroot].[dbo].[Persons] Where Age between 17 and 19
select*FROM c Where Address is NULL
update [Betroot].[dbo].[Persons] set Age +=1
delete FROM [Betroot].[dbo].[Persons] where address is null
select COUNT(ID) FROM [Betroot].[dbo].[Persons]
select count(ID), Age FROM [Betroot].[dbo].[Persons] Group by Age