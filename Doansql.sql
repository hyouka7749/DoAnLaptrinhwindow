USE DoAnPCShop;;
GO


CREATE TABLE Users
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(10) NOT NULL,
    Password NVARCHAR(20) NOT NULL
);
DROP TABLE Users;



INSERT INTO Users (Username, Password) VALUES ('user1', '1234');
INSERT INTO Users (Username, Password) VALUES ('user2', '1234');
INSERT INTO Users (Username, Password) VALUES ('user3', '1234');
INSERT INTO Users (Username, Password) VALUES ('user4', '1234');
INSERT INTO Users (Username, Password) VALUES ('user5', '1234');
INSERT INTO Users (Username, Password) VALUES ('user6', '1234');
INSERT INTO Users (Username, Password) VALUES ('user7', '1234');
INSERT INTO Users (Username, Password) VALUES ('user8', '1234');
INSERT INTO Users (Username, Password) VALUES ('user9', '1234');
INSERT INTO Users (Username, Password) VALUES ('user10', '1234');
INSERT INTO Users (Username, Password) VALUES ('user11', '1234');
INSERT INTO Users (Username, Password) VALUES ('user12', '1234');
INSERT INTO Users (Username, Password) VALUES ('user13', '1234');
INSERT INTO Users (Username, password) VALUES ('hanguyen', '12345');
INSERT INTO Users (Username, password) VALUES('quanghuy', '12345');
INSERT INTO Users (Username, password) VALUES('khaichu', '12345');
INSERT INTO Users (Username, password) VALUES('quocdat', '12345');
INSERT INTO Users (Username, password) VALUES('quoclong', '12345');