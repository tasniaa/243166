Create Database MobileHandsetDB
use MobileHandsetDB
Create Table MobileInformations
(
 ModelName VARCHAR (100),
 IMEI VARCHAR(100),
 Price  int
)
INSERT INTO MobileInformations VALUES ('SamsungGALAXYS10+','SM-127dad2',350000)
SELECT * from MobileInformations