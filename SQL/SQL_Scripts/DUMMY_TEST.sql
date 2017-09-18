use dummy
CREATE TABLE dummyTest
(
   dummyTest_ID int IDENTITY(1,1) PRIMARY KEY,
   dum_Fname varchar(100),
   dum_Dateorder datetime not null DEFAULT GETDATE()


)-- experiment area 