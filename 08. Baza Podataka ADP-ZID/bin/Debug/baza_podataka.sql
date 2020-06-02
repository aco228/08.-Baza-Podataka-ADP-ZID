/*
	BAZA PODATAKA
	------------------------------
	
	ime:  adpzid_baza
	user: adpzid_user
	pass: adpzid_pass
	
	Server=192.168.1.33,1433;Network Library=DBMSSOCN;Initial Catalog=adpzid_baza;User Id=adpzid_user;Password=adpzid_pass;
*/

/*
    ADMINISTRATORI
    Svi korisnici programa
*/
IF OBJECT_ID('dbo.administratori', 'U') IS NOT NULL DROP TABLE dbo.administratori
CREATE TABLE administratori(
    idad int primary key identity,
    username varchar(20) not null,
    sifra varchar(20) not null,
	dodatne_informacije text,
	privilegije varchar(2) default 'ne'
);
INSERT INTO administratori(username, sifra, dodatne_informacije, privilegije) VALUES ('SYSTEM', 'admin', 'Bog', 'da');
INSERT INTO administratori(username, sifra, dodatne_informacije, privilegije) VALUES ('aco228', 'aco1234', 'Apostol', 'da');
INSERT INTO administratori(username, sifra, dodatne_informacije, privilegije) VALUES ('test', 'testtest', 'Bog', 'ne');

/*
    JAVNE NAPOMENE
*/
IF OBJECT_ID('dbo.javne_napomene', 'U') IS NOT NULL DROP TABLE dbo.javne_napomene;
CREATE TABLE javne_napomene(
    idjn int primary key identity,
    autor varchar(20) not null,
    tekst varchar(300) not null,
    datum datetime default CURRENT_TIMESTAMP
);
INSERT INTO javne_napomene(autor, tekst) VALUES ('SYSTEM', 'The Rolling Stones - Start Me Up');

/*
    CLAN
*/
IF OBJECT_ID('dbo.clan', 'U') IS NOT NULL DROP TABLE dbo.clan;
CREATE TABLE clan(
    /* JA SAM */
    idc int primary key identity,
    ime_prezime varchar(150) not null,
    pol varchar(8),
    datum_rodjenja varchar(150) default '',
	broj_godina int default 0,
    mjesto_rodjenja varchar(100) default '',
	adresa_stanovanja varchar(100) default '',
    kontakt_telefon varchar(30) default '',
    email varchar(80) default '',
    facebook varchar(100) default '',
    skype varchar(100) default '',
    vrijemeVolontiranja text default '',
	status_aktivnosti varchar(15),
	brojVolonterskihSati int default 0,
	datumPopunjavanjaUpitnika varchar(150) default '',
	vrijemeUnosaUBazu date default CURRENT_TIMESTAMP,
    
    /* STATUS */
    profesija varchar(150) default '',
    trenutni_status varchar(30) default '',
    pojasnjenje_statusa text default '',
    dosadanje_radno_iskustvo text default '',
    
    /* A SADA */
    trenutno_pohadjam varchar(350) default '',
    honorarni_angazman varchar(350) default '',
    hobi varchar(150) default '',
    omiljenje_stvari text default '',
    omiljeni_gradovi text default '',
    
    /* VOLONTERSKO ISKUSTVO */
    volontirao_uOrganizaciji varchar(150) default '',
    volontirao_trajanjeAngazmana varchar(250) default '',
    volontirao_opisAktivnosti text default '',
    nevolontirao_uKojimPrilikama text default '',
    nevolontirao_kojeAktivnosti text default '',
    
    /* POZNAVANJE JEZIKA */
    engleski_razumijem char default '1', engleski_pricam char default '1', engleski_pisem char default '1',    
    francuski_razumijem char default '1', francuski_pricam char default '1', francuski_pisem char default '1',
    ruski_razumijem char default '1', ruski_pricam char default '1', ruski_pisem char default '1',
    italijanski_razumijem char default '1', italijanski_pricam char default '1', italijanski_pisem char default '1',
    spanski_razumijem char default '1', spanski_pricam char default '1', spanski_pisem char default '1',
    njemacki_razumijem char default '1', njemacki_pricam char default '1', njemacki_pisem char default '1',
    drugiJezik_ime varchar(20), drugiJezik_razumijem char default '1', drugiJezik_pricam char default '1', drugiJezik_pisem char default '1',
    
    /* PODRUCJE INTERESOVANJE */
    interesovanje1 varchar(150) default '',
    interesovanje2 varchar(150) default '',
    interesovanje3 varchar(150) default '',
    
    /* VOLONTIRANJE U OBLASTIMA */
    oblasti_zastitaZdravlja char default '1',
    oblasti_akcijeNaZastitiZivotneSredine char default '1',
    oblasti_zastitaBiljakaZivotinja char default '1',
    oblasti_humanitarniProgrami char default '1',
    oblasti_razvojDemokratije char default '1',
    oblasti_ravnopravnostPolova char default '1',
    oblasti_promocijaMira char default '1',
    oblasti_internacionalniKampovi char default '1',
    oblasti_onlineVolontiranje char default '1',
    oblasti_promocijaKultureZivljenja char default '1',
    oblasti_promocijaPravaManjina char default '1',
    oblasti_pomocUcenje char default '1',
    oblasti_sportskeManifestracije char default '1',
    /* ... */
    oblasti_pomocInvalidima char default '1',
    oblasti_pomocMentalnima char default '1',
    oblasti_pomocStarima char default '1',
    oblasti_pomocDrogasima char default '1',
    oblasti_pomocKockarima char default '1',
    oblasti_istrazivackiRadovi char default '1',
    oblasti_kancelarijskiPoslovi char default '1',
    oblasti_organizacioniPoslovi char default '1',
    oblasti_prevodjenje char default '1',
    oblasti_kulturaUmjetnost char default '1',
    oblasti_arheologija char default '1',
    oblasti_obnovaRekonstrukcija char default '1',
    oblasti_informacioneTehnologije char default '1',
    oblasti_muzickeManifestacije char default '1',
	oblasti_interkulturalnoUcenje char default '1',
    
    /* DODATNE INFORMACIJE */
    angazman text default '',
    dostupnost text default '',
    obuke text default '',
    motivacijaVolontera text default '',
    dodatneInformacije text default ''
);

/*
	GRUPE
*/
IF OBJECT_ID('dbo.grupa', 'U') IS NOT NULL DROP TABLE dbo.grupa;
CREATE TABLE grupa(
	idgr int primary key identity,
	ime_grupe varchar(100) not null,
	br_sati int default 0,
	opis_grupe text
);
INSERT INTO grupa (ime_grupe, opis_grupe) VALUES ('041', 'Kad miki kaze da se boji');

/*
	PRIPADNOST GRUPI
*/
IF OBJECT_ID('dbo.pripadnosti_grupi', 'U') IS NOT NULL DROP TABLE dbo.pripadnosti_grupi;
CREATE TABLE pripadnosti_grupi(
	idpg int primary key identity,
	ime_grupe varchar(100) not null,
	idclana int not null
);

/*
	NAPOMENE ZA VOLONTERA
*/
IF OBJECT_ID('dbo.napomena_volonter', 'U') IS NOT NULL DROP TABLE dbo.napomena_volonter;
CREATE TABLE napomena_volonter(
	idnv int primary key identity,
	autor varchar(20) not null,
	idclan int not null,
	napomena text,
    datum datetime default CURRENT_TIMESTAMP
);

/*
	POMOC U VEZI PROGRAMA
*/
IF OBJECT_ID('dbo.pomoc', 'U') IS NOT NULL DROP TABLE dbo.pomoc
CREATE TABLE pomoc(
	idpom int primary key identity,
	dodatne_informacije text default '',
	grupe text default '',
	novi_volonter text default '',
	pretraga text default '',
	datum datetime default CURRENT_TIMESTAMP
);
INSERT INTO pomoc(dodatne_informacije, grupe, novi_volonter, pretraga, datum) VALUES (
	/* DODATNE INFORMACIJE */
	'U svoj senoviti gaj krocila je lepa Kamala, 
Na ulazu u gaj je stajao mrki šamana. 
Ugledavši lotosov cvet on se pokloni 
Duboko, a smešeci se otpozdravi mu Kamala. 
Mladic pomisli! 
Od prinošenja žrtvi bogovima, 
Slade je prinositi žrtve lepoj Kamali.', 

	/* GRUPE */
	'Moje carstvo je od ovoga sveta. Tamnicari,
tamnice i macevi ispunjavaju
naredenje koje se ne ponavlja. Moja poslednja rec je
od gvožda. Cak i skriveno
srce ljudi što nikad
ne cuše za moje ime u svom kraju dalekom -
poslušno je orude moje volje.
Ja koji bejah rabadan ravnice,
istakoh barjake svoje u Persepolisu
i ugasih žed konja svojih
na vodama Ganga i Oksa.
Kad se rodih, s neba pade
sablja sa talismanskim znacima.
Ja jesam i uvek bicu ta sablja.
Uneo sam pometnju medu Grke i Egipcane,
opustošio sam neumorne
prostore Rusije sa svojim strašnim Tatarima.
Podigao sam piramide od lobanja,
upregao u svoju kociju cetiri kralja
koja se ne htedoše prikloniti mome žezlu,
bacih u oganj u Alepu
Koran, Knjigu nad Knjigama
što prethodi danima i nocima.
Ja, ridi Tamerlan, stezah u narucju
beloputu Zenokratu Egipcanku
netaknutu kao sneg na planinskim vrhovima.
Secam se teških karavana
i oblaka prašine u pustinji,
ali i zadimljenog grada
i plinskih plamicaka u mehanama.
Znam sve i mogu sve. Jedna zloslutna
i još nenapisana knjiga mi je otkrila
da cu umreti kao što umiru drugi
i da cu, bled na samrtnoj postelji,
narediti da moji strelci odapnu
gvozdene strele put neprijateljskog neba
i crnim zastavama nebeski svod okite,
da ne bude coveka koji ne bi znao
da su bogovi umrli. Ja sam bogovi.
Neka se drugi obracaju mudroj
astrologiji, busoli i astrolabu
da saznaju ko su. Ja sam zvezde.
U neizvesnim zorama pitam se
zašto nikada ne izlazim iz ove odaje,
zašto ne blagoizvolim primiti podvorenje
bucnoga Istoka. Ponekad sanjam
robove, uljeze, koji drskom rukom
prljaju Tamerlana
i opominju ga da treba da spava i da ne zaboravi
da svake veceri uzme volšebne
kolacice koji donose spokoj i tišinu.
Tražim sablju krivošiju, ali je ne nalazim.
Tražim svoj lik u ogledalu; to nisam ja.
Zato ga razbih i neko me kazni.
Zašto ne prisustvujem pogubljenjima,
zašto ne gledam sekiru i glavu?
Te stvari me uznemiruju, ali ništa se
ne može dogoditi ako se Tamerlan suprotstavi
i On ih možda i ne znajuci želi.
A Tamerlan sam ja. Vladam Zapadom
i zlatnim Istokom, a ipak...', 

	/* NOVI VOLONTER */
	'Mnoge smo i mnogo voljeli 
na ovoj šarenoj cesti 
al tek usput, na cesti 
ravnodušne, po dvoje 
u cinicnoj postelji stizale su nas 
mucne radio vijesti 
brojeci poene u sportu, picu i ljubavi 
za volju caska spiskali smo snagu 
ne brini vlado, tim se više nitko ne bavi 
sad kad je sve otišlo k vragu 

nama su se objavljivala nebesa 
tek kroz rastrežnjena usta sumnjivih dama 
na zabavama puckim 
izmedju dva plesa 
kroz prozor bi nas dotaknula tama 
za razliku od svjetla 
tama je bila prava 
najgore su vijesti bile najtacnije 
dubok je san prokope, a plitka je java 
mirno spavaj slobodane, sve je mracnije 

i prije nas, doduše, mnogi su se tješili 
da je vrijeme na njih bilo suviše kivno 
ne postavljajuc pitanje, slavko, 
divno smo ga riješili: 
živjeli smo kratko 
umiruci intenzivno ', 

	/* PRETRAGA */
	'nisam spavao tri noci 
ili tri dana i 
crvenih ociju 
smejem se u 
ogledalu 
slušajuci kako sat 
otkucava 
a plin 
moje peci 
zaudara 
vrelim gustim teškim 
smradom, isprekidan 
zvucima vozila, 
nanizanih kao 
ornamenti 
u mojoj glavi, ali 
ja sam citao klasike 
i na mom kaucu 
opijena vinom spava 
kurva 
koja je prvi put 
cula 
Devetu Betovenovu 
i od dosade 
zaspala 
uctivo slušajuci. 

slušaj, matori, rekla je, 
s tvojim vijugama 
biceš možda prvi covek 
koji ce da jebe 
na Mesecu.', 
	getdate()
);

