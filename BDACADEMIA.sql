create database academia
use academia
go
create table T_fonction(  
	id int primary key identity(1,1),
	libelle varchar(20)
)

create table T_grade(
	id int primary key identity(1,1),
	libelle varchar(25)
)

create table T_personnel(
	mat varchar(10) primary key,
	nom varchar(25),
	prenom varchar(25),
	adresse varchar(30),
	telephone varchar(10),
	fonction int ,
	grade int,
	pwd varchar(20),
	constraint fkfonction foreign key(fonction) references T_fonction(id),
	constraint fkgrade foreign key(grade) references T_grade(id)
)
create table T_ecole(
	id int primary key identity(1,1),
	designation varchar(50)
)

create table T_palmares(
	id int primary key identity(1,1),
	pourcentage float,
	dossier varchar(500) 
)

create table T_candidat(
	id int primary key identity(1,1),
	nom varchar(25),
	prenom varchar(25),
	adresse varchar(30),
	telephone varchar(10),
	dob date,
	ecole int,
	palmares int,
	constraint fkecole foreign key(ecole) references T_ecole(id),
	constraint fkpalmares foreign key(palmares) references T_palmares(id),
)
create table T_promotion(
	id int primary key identity(1,1),
	nom varchar(10)
)
create table T_annee(
	id int primary key identity(1,1),
	libelle varchar(20)
)
create table T_faculte(
	id int primary key identity(1,1),
	nom varchar(50)
)
create table T_option(
	id int primary key identity(1,1),
	designation varchar(50),
	faculte int,
	constraint fkfaculte foreign key(faculte) references T_faculte(id),
)
create table T_inscription(
	mat varchar(10) primary key,
	candidat int,
	options int,
	promotion int,
	annee int,
	etat varchar(25) not null default'En cours',
	constraint fkcandidat foreign key(candidat) references T_candidat(id), 
	constraint fkoptions foreign key(options) references T_option(id),
	constraint fkpromotion foreign key(promotion) references T_promotion(id),
	constraint fkannee foreign key(annee) references T_annee(id)
)
create table T_frais(
	id int primary key identity(1,1),
	montantFixe float,
	devise varchar(20),
	motif varchar(25) 
)

create table T_paiement(
	id int primary key identity(1,1),
	montantAPayer float,
	datePaiement date not null default getdate(),
	frais int,
	inscription varchar(50),
	candidat int ,
	personnel varchar(10),
	constraint fkfraispaiement foreign key(frais) references T_frais(id),
	constraint fkinscription foreign key(inscription) references T_inscription(mat),
	constraint fkcandidatpaiement foreign key(candidat) references T_candidat(id),
	constraint fkpersonnelpaiement foreign key(personnel) references T_personnel(mat)	
		
)
create table T_cours(
	code varchar(10) primary key,
	intitule varchar(30)
)

create table T_programmation(
	id int primary key identity(1,1),
	heure int,
	credit int,
	annee int,
	promotion int,
	cours varchar(10),
	personnel varchar(10),
	constraint fkpersonnelprogrammation foreign key(personnel) references T_personnel(mat),  
	constraint fkpromotionprogrammation foreign key(promotion) references T_promotion(id),
	constraint fkanneeprogrammation foreign key(annee) references T_annee(id),
	constraint fkcoursprogrammation foreign key(cours) references T_cours(code) 
)
create table T_cotation(
	id int primary key identity(1,1),
	pointOpt float, 
	programmation int,
	inscription varchar(50),
	constraint fkprogrammationcotation foreign key(programmation) references T_programmation(id),
	constraint fkinscriptioncotation foreign key(inscription) references T_inscription(mat)
)

create table T_poste(
	id int primary key identity(1,1),
	designation varchar(50),
	inscription varchar(50),
	constraint fkinscriptionposte foreign key(inscription) references T_inscription(mat) 
)

create table T_postuler(
	id int primary key identity(1,1),
	mandat int,
	poste int,
	inscription varchar(50),
	constraint fkinscriptionpostuler foreign key(inscription) references T_inscription(mat),
	constraint fkpostepostuler foreign key(poste) references T_poste(id)
)
create table T_vote(
	id int primary key identity(1,1),
	number int,
	postuler int,
	inscription varchar(50),
	constraint fkinscriptionvote foreign key(inscription) references T_inscription(mat),
	constraint fkpostulervote foreign key(postuler) references T_postuler(id)
)
-----------------------------------------------------------------
insert into T_fonction(libelle)values('Professeur')
insert into T_fonction(libelle)values('SecFac')
insert into T_fonction(libelle)values('Assistant')
insert into T_fonction(libelle)values('Chef de travaux')
insert into T_grade(libelle)values('General')
insert into T_grade(libelle)values('Professeur')
insert into T_grade(libelle)values('Professeur associé')
insert into T_personnel values(
'PA001','Lugger','Lugger',
'Avkananga41',
'+24399966',
(select id from T_fonction where libelle='SecFac');
(select id from T_grade where libelle='General'),
'1234'
)
--------------------------------------------------------------------------
select * from T_fonction