CREATE DATABASE HiveData;

USE HiveData
GO
CREATE TABLE Students
(
	studentNo VARCHAR(10) PRIMARY KEY NOT NULL,
	studentName VARCHAR(50) NOT NULL, 
	studentSurname VARCHAR(50) NOT NULL, 
	studentImage VARBINARY(MAX) NOT NULL,
	studentLink VARCHAR(250) NOT NULL,
	studentDOB DATE NOT NULL, 
	studentGender VARCHAR(20) NOT NULL,
	studentPhone VARCHAR(10) NOT NULL,
	studentHomeNo VARCHAR(5) NOT NULL,
	studentHomeStreet VARCHAR(30) NOT NULL,
	studentHomeCity VARCHAR(50) NOT NULL,
	studentHomeProvince VARCHAR(50) NOT NULL,
	studentHomeZIP VARCHAR(5) NOT NULL,
	studentModuleCodes VARCHAR(250) NOT NULL,
);

USE HiveData
GO
CREATE TABLE Modules
(
	moduleCode VARCHAR(10) PRIMARY KEY NOT NULL,
	moduleName VARCHAR(50) NOT NULL, 
	moduleDescription VARCHAR(50) NOT NULL, 
	moduleLinks NVARCHAR(MAX)
);

USE HiveData
GO
CREATE TABLE Gender
(
	genderNo VARCHAR(5) PRIMARY KEY NOT NULL,
	genderDescription VARCHAR(10) NOT NULL, 
);

USE HiveData
GO
INSERT INTO Gender (genderNo,genderDescription)
VALUES 
('G1','Male'), 
('G2','Female'),
('G3','Other');

USE HiveData
GO
INSERT INTO Modules (moduleCode,moduleName,moduleDescription,moduleLinks)
VALUES 
('PRG181','Programming','C# Programming First Year','https://www.youtube.com/watch?v=GhQdlIFylQ8,https://www.youtube.com/watch?v=gfkTfcpWqAY,https://www.youtube.com/watch?v=jGD0vn-QIkg'),
('MAT181','Mathematics','Mathematics First Year','https://www.youtube.com/watch?v=dlq0oNbn_Q4,https://www.youtube.com/watch?v=M6HLKRbPkXo'),
('SWT181','Software Testing','Software Testing First Year','https://www.youtube.com/watch?v=HYrXogLj7vg'),
('INF181','Innovation and Leadership','Innovation and Leadership First Year','https://www.youtube.com/watch?v=SjeigQ0pmas,https://www.youtube.com/watch?v=fdLodOcHzY0'),
('STA181','Statistics','Statistics First Year','https://www.youtube.com/watch?v=GUQJ7zMoSCM,https://www.youtube.com/watch?v=LMSyiAJm99g'),
('RES181','Research','Research First Year','https://www.youtube.com/watch?v=nv7MOoHMM2k'),
('IOT181','Internet of Things','Internet of Things First Year','https://www.youtube.com/watch?v=LlhmzVL5bm8,https://www.youtube.com/watch?v=6mBO2vqLv38'),
('PRG281','Programming','C# Programming Second Year','https://www.youtube.com/watch?v=blkfqOYqAOs'),
('LPR281','Linear Programming','Linear Programming Second Year','https://www.youtube.com/watch?v=Bzzqx1F23a8,https://www.youtube.com/watch?v=w9BlUqa2JpI'),
('MAT281','Mathematics','Mathematics Second Year','https://www.youtube.com/c/TheOrganicChemistryTutor'),
('INF282','Innovation and Leadership','Innovation and Leadership Second Year',''),
('SWT281','Software Testing','Software Testing Second Year','https://www.youtube.com/watch?v=_JNeiGbAgL4,https://www.youtube.com/watch?v=5FUdrBq-WFo'),
('PRG381','Programming','Programming Third Year','https://www.youtube.com/watch?v=e2H15MCOvm8'),
('MIC381','Machine Learning','Machine Learning Third Year','https://www.youtube.com/watch?v=7eh4d6sabA0,https://www.youtube.com/watch?v=7eh4d6sabA0'),
('SWT381','Software Testing','Software Testing Third Year','https://www.youtube.com/watch?v=hjhu7pAEd90,https://www.youtube.com/watch?v=MMa4AVdBCZY'),
('INF381','Innovation and Leadership','Innovation and Leadership Third Year','');


USE HiveData
GO
INSERT INTO Students (studentNo,studentName,studentSurname,studentImage,studentLink,studentDOB,studentGender,
studentPhone, studentHomeNo, studentHomeStreet, studentHomeCity, studentHomeProvince, studentHomeZIP, studentModuleCodes)
VALUES 
('721758','Letitia','Elliott', (SELECT * FROM OPENROWSET(BULK N'C:\Zander\University\Term 4\PRG282\Project\Project\Images\721758.png', SINGLE_BLOB) AS T1),'C:\Zander\University\Term 4\PRG282\Project\Project\Images\721758.png',2001-10-03,'Female','0820416075','578','Green Street','Pretoria','Gauteng','0084','PRG281,LPR281,MAT281,INF281'),
('924284','Nicholas','Bailey', (SELECT * FROM OPENROWSET(BULK N'C:\Zander\University\Term 4\PRG282\Project\Project\Images\924284.png', SINGLE_BLOB) AS T2),'C:\Zander\University\Term 4\PRG282\Project\Project\Images\924284.png',2001-09-26,'Male','0717891017','027','Goosen Avenue','Pretoria','Gauteng','0084','PRG181,MAT181,SWT181'),
('702579','Daryl','Holmes', (SELECT * FROM OPENROWSET(BULK N'C:\Zander\University\Term 4\PRG282\Project\Project\Images\702579.png', SINGLE_BLOB) AS T3),'C:\Zander\University\Term 4\PRG282\Project\Project\Images\702579.png',2001-03-11,'Other','0827775741','111','Ben Viljoen Street','Pretoria','Gauteng','0084','PRG381,MIC381,SWT381,INF381'),
('349021','Tess','Russell', (SELECT * FROM OPENROWSET(BULK N'C:\Zander\University\Term 4\PRG282\Project\Project\Images\349021.png', SINGLE_BLOB) AS T4),'C:\Zander\University\Term 4\PRG282\Project\Project\Images\349021.png',2001-12-29,'Female','0698457185','012','Bourke Street','Pretoria','Gauteng','0084','PRG181,INF181,MAT181'),
('991886','Eddy','Chapman', (SELECT * FROM OPENROWSET(BULK N'C:\Zander\University\Term 4\PRG282\Project\Project\Images\991886.png', SINGLE_BLOB) AS T5),'C:\Zander\University\Term 4\PRG282\Project\Project\Images\991886.png',2001-01-13,'Male','0698457185','672','Quagga Road','Pretoria','Gauteng','0084','PRG281,INF281'),
('958106','Naomi','Carroll', (SELECT * FROM OPENROWSET(BULK N'C:\Zander\University\Term 4\PRG282\Project\Project\Images\958106.png', SINGLE_BLOB) AS T6),'C:\Zander\University\Term 4\PRG282\Project\Project\Images\958106.png',2001-03-11,'Other','0829874852','151','Stephan Road','Pretoria','Gauteng','0084','PRG381,MIC381,SWT381,INF381'),
('186825','Arianna','Montgomery', (SELECT * FROM OPENROWSET(BULK N'C:\Zander\University\Term 4\PRG282\Project\Project\Images\186825.png', SINGLE_BLOB) AS T7),'C:\Zander\University\Term 4\PRG282\Project\Project\Images\186825.png',2001-10-06,'Female','0798984152','777','Katjiepiering Avenue','Pretoria','Gauteng','0084','PRG281,LPR281'),
('633048','Luke','West', (SELECT * FROM OPENROWSET(BULK N'C:\Zander\University\Term 4\PRG282\Project\Project\Images\633048.png', SINGLE_BLOB) AS T8),'C:\Zander\University\Term 4\PRG282\Project\Project\Images\633048.png',2001-05-13,'Male','0698977488','009','Franzina Street','Pretoria','Gauteng','0084','PRG381,MIC381,SWT381'),
('088802','Richard','Ross', (SELECT * FROM OPENROWSET(BULK N'C:\Zander\University\Term 4\PRG282\Project\Project\Images\088802.png', SINGLE_BLOB) AS T9),'C:\Zander\University\Term 4\PRG282\Project\Project\Images\088802.png',2001-01-19,'Male','0697784517','013','Briekblok Place','Pretoria','Gauteng','0084','MAT281,SWT281'),
('709010','Amy','Adams', (SELECT * FROM OPENROWSET(BULK N'C:\Zander\University\Term 4\PRG282\Project\Project\Images\709010.png', SINGLE_BLOB) AS T10),'C:\Zander\University\Term 4\PRG282\Project\Project\Images\709010.png',2001-04-01,'Female','0825859649','781','Alex Avenue','Pretoria','Gauteng','0084','STA181,RES181,IOT181'),
('530693','Martin','Dixon', (SELECT * FROM OPENROWSET(BULK N'C:\Zander\University\Term 4\PRG282\Project\Project\Images\530693.png', SINGLE_BLOB) AS T11),'C:\Zander\University\Term 4\PRG282\Project\Project\Images\530693.png',2001-07-20,'Other','0826578741','901','Alter Street','Pretoria','Gauteng','0084','MAT281,INF282'),
('884378','Tess','Ryan', (SELECT * FROM OPENROWSET(BULK N'C:\Zander\University\Term 4\PRG282\Project\Project\Images\884378.png', SINGLE_BLOB) AS T12),'C:\Zander\University\Term 4\PRG282\Project\Project\Images\884378.png',2001-03-14,'Female','0798527483','071','Heddon Street','Pretoria','Gauteng','0084','MIC381,SWT381,INF381');