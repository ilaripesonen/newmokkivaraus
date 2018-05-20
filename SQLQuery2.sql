﻿CREATE table Toimipiste(
	toimipiste_id INT PRIMARY KEY,
	nimi VARCHAR(40),
	lahiosoite VARCHAR(40),
	postitoimipaikka VARCHAR(30),
	postinro CHAR(5),
	email VARCHAR(50),
	puhelinnro VARCHAR(15));
CREATE table Asiakas(
	asiakas_id INT PRIMARY KEY,
	etunimi VARCHAR(20),
	sukunimi VARCHAR(40),
	lahiosoite VARCHAR(40),
	postitoimipaikka VARCHAR(30),
	postinro CHAR(5),
	email VARCHAR(50),
	puhelinnro VARCHAR(15));
CREATE table Varaus(
	varaus_id INT PRIMARY KEY,
	asiakas_id INT,
	toimipiste_id INT,
	varattu_pvm DATETIME,
	vahvistus_pvm DATETIME,
	varattu_alkupvm DATETIME,
	varattu_loppupvm DATETIME,
	FOREIGN KEY(toimipiste_id) REFERENCES Toimipiste(toimipiste_id) ON DELETE CASCADE,
	FOREIGN KEY(asiakas_id) REFERENCES Asiakas(asiakas_id) ON DELETE CASCADE
);
CREATE table Lasku(
	lasku_id INT PRIMARY KEY,
	varaus_id INT,
	asiakas_id INT,
	nimi VARCHAR(60),
	lahiosoite VARCHAR(40),
	postitoimipaikka VARCHAR(30),
	postinro CHAR(5),
	summa decimal(8,2) NOT NULL,
	alv decimal(8,2) NOT NULL,
	FOREIGN KEY(varaus_id) REFERENCES Varaus(varaus_id),
	FOREIGN KEY(asiakas_id) REFERENCES Asiakas(asiakas_id) ON DELETE CASCADE
 	);
CREATE table Palvelu(
	palvelu_id INT PRIMARY KEY,
	toimipiste_id INT,
	nimi VARCHAR(40),
	tyyppi INT,
	kuvaus VARCHAR(255),
	hinta decimal(8,2) NOT NULL,
	alv decimal(8,2) NOT NULL,
	FOREIGN KEY(toimipiste_id) REFERENCES Toimipiste(toimipiste_id) ON DELETE CASCADE
	);
CREATE table Varauksen_palvelut(
	varaus_id INT,
	palvelu_id INT,
	lkm INT NOT NULL,
	PRIMARY KEY(palvelu_id, varaus_id),
	FOREIGN KEY(varaus_id) REFERENCES Varaus(varaus_id),
	FOREIGN KEY(palvelu_id) REFERENCES Palvelu(palvelu_id) ON DELETE CASCADE
	 );

CREATE index Toimipiste_nimi_index
 ON Toimipiste(nimi);

CREATE index Asiakas_sukunimi_index
 ON Asiakas(sukunimi); 
 
CREATE index Asiakas_etunimi_index
 ON Asiakas(etunimi); 

CREATE index Lasku_nimi_index
 ON Lasku(nimi); 

CREATE UNIQUE index Lasku_varaus_id_index
 ON Lasku(varaus_id); 
 
CREATE index Palvelu_nimi_index
 ON Palvelu(nimi);

CREATE index vp_varaus_id_index
 ON Varauksen_palvelut(varaus_id);
 
CREATE index vp_palvelu_id_index
 ON Varauksen_palvelut(palvelu_id);
 
CREATE index palvelu_toimipiste_id_index
 ON Palvelu(toimipiste_id);
 
CREATE index Lasku_asiakas_id_index
 ON Lasku(asiakas_id);
 
CREATE index varaus_toimipiste_id_index
 ON Varaus(toimipiste_id);
 
CREATE index varaus_asiakas_id_index
 ON Varaus(asiakas_id);