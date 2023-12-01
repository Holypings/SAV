#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: USER
#------------------------------------------------------------

CREATE TABLE USER(
        ID_USER   Int  Auto_increment  NOT NULL ,
        prenom    Varchar (50) NOT NULL ,
        nom       Varchar (50) NOT NULL ,
        mail      Varchar (50) NOT NULL ,
        telephone Varchar (15) NOT NULL
	,CONSTRAINT USER_PK PRIMARY KEY (ID_USER)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: PRODUIT
#------------------------------------------------------------

CREATE TABLE PRODUIT(
        ID_PRODUIT Int  Auto_increment  NOT NULL ,
        nomProd    Varchar (50) NOT NULL ,
        reference  Varchar (9) NOT NULL ,
        reparable  Bool NOT NULL ,
        etatRepare Varchar (5) NOT NULL
	,CONSTRAINT PRODUIT_PK PRIMARY KEY (ID_PRODUIT)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: REQUETE
#------------------------------------------------------------

CREATE TABLE REQUETE(
        ID_REQUETE  Int  Auto_increment  NOT NULL ,
        sujet       Varchar (50) NOT NULL ,
        commentaire Varchar (750) NOT NULL ,
        date        Date NOT NULL ,
        ID_USER     Int NOT NULL ,
        ID_PRODUIT  Int NOT NULL
	,CONSTRAINT REQUETE_PK PRIMARY KEY (ID_REQUETE)

	,CONSTRAINT REQUETE_USER_FK FOREIGN KEY (ID_USER) REFERENCES USER(ID_USER)
	,CONSTRAINT REQUETE_PRODUIT0_FK FOREIGN KEY (ID_PRODUIT) REFERENCES PRODUIT(ID_PRODUIT)
)ENGINE=InnoDB;

