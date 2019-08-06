-- Restuarant Table Create SQL
CREATE TABLE Restuarant
(
    "restaurantID"    int            NOT NULL, 
    "restaurantName"  varchar(50)    NOT NULL, 
    "class"           varchar(50)    NOT NULL, 
    "star"            float          NULL, 
    "openTime"        varchar(50)    NOT NULL, 
    "closeTIme"       varchar(50)    NOT NULL, 
    "priceRange"      float          NULL, 
    CONSTRAINT PK_RESTUARANT PRIMARY KEY (restaurantID)
)

-- Restuarant Table Create SQL
CREATE TABLE Review
(
    "reviewID"            int             NOT NULL, 
    "title"               varchar(50)     NOT NULL, 
    "score"               int             NULL, 
    "reviewExplanation"   varchar(max)    NOT NULL, 
    "reviewRestaurantID"  int             NOT NULL, 
    CONSTRAINT PK_REVIEW PRIMARY KEY (reviewID)
)


ALTER TABLE Review
    ADD CONSTRAINT FK_Review_reviewRestaurantID_Restuarant_restaurantID FOREIGN KEY (reviewRestaurantID)
        REFERENCES Restuarant (restaurantID)


-- Restuarant Table Create SQL
CREATE TABLE Menu
(
    "menuName"          varchar(50)    NOT NULL, 
    "menuRestaurantID"  int            NOT NULL, 
    "price"             float          NOT NULL, 
    "menuType"          varchar(50)    NOT NULL, 
    CONSTRAINT PK_MENU PRIMARY KEY (menuName)
)


ALTER TABLE Menu
    ADD CONSTRAINT FK_Menu_menuRestaurantID_Restuarant_restaurantID FOREIGN KEY (menuRestaurantID)
        REFERENCES Restuarant (restaurantID)
GO


