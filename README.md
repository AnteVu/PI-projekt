# Inicijalne upute za prijavu projekta iz Programskog inženjerstva

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Programsko inženjerstvo, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak, ukoliko niste odabrali da želite raditi na projektu sa nastavnicima ili u sklopu WBL-a je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).
Sav programski kod potrebno je verzionirati u glavnoj **master** grani i **obvezno** smjestiti u mapu Software. Sve artefakte (npr. slike) koje ćete koristiti u vašoj dokumentaciju obvezno verzionirati u posebnoj grani koja je već kreirana i koja se naziva **master-docs** i smjestiti u mapu Documentation.

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# Naziv projekta
Movieasy

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Tonino Hodak | thodak@foi.hr | 0016142992 | Reflexbull
Petar Kordić | pkordic@foi.hr | 0016143797 | pkordic
Ante Vučić | avucic@foi.hr | 0055493113 | AnteVu

## Opis domene
Rad u kinu je kompliciran bez prikladnog softvera. Ova aplikacija će omogućiti lakše upravljanje i lakšu rasporedbu sredstava zaposlenicima kina, ali i korisnicima.

## Specifikacija projekta
Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Registracija i login |Za pristup aplikaciji korisnik se treba registrirati/prijavit. Uz prijavu korisnik može odabrati želi li primati novosti o filmovima na e-mail | Tonino Hodak
F02 | Katalog filmova | Korisnici mogu pretraživati filmove uz filtriranja(po danu i vremenu prikazivanju filmova) i korisnici mogu vidjeti koliko svaki termin ima slobodnih mjesta | Ante Vučić
F03 | Upravljanje katalogom filmova | Admin stavlja nove filmove u katalog i uređuje ponudu. Ako je film prikazan više od 100 puta film će pocrveniti i admin će biti obaviješten. Ako film nije prikazivan više od godinu dana admin će isto dobiti obavijest kako bi razmotrio opciju njegovog brisanja iz kataloga. | Ante Vučić
F04 | Rezervacija mjesta | Korisnik može rezervirat mjesto/a sjedenja u kinu i hranu. Može birati plaćanje karticom ili gotovinom te ima li karticu lojalnosti koja donosi 5% popusta. Račun se šalje korisniku na e-mail u obliku PDF-a. | Tonino Hodak
F05 | Upravljanje dvoranama | Admin može upravljati dvoranama i rezervirati ih. Dvoranu je potrebno rezervirati najmanje tjedan dana unaprijed. Istovremeno mogu biti rezervirane najviše dvije dvorane. Dvorana može biti rezervirana maksimalno 3 sata, nakon toga je potrebno napraviti novu rezervaciju. | Petar Kordić
F06 | Upravljanje kinima | Admin može dodavati i uređivati ponude raznih kina | Ante Vučić
F07 | Upravljanje resursima | Admin može vidjeti koliko resursa(kao što su hrana i piče) zahtjeva korisnici i može uređivati ponude. Ukoliko zalihe padnu ispod prosječne tjedne potrošnje, adminu se prikazuje poruka s informacijama o artiklu kojeg je potrebno naručiti. | Tonino Hodak
F08 | Statistika članova i filmova | Admin mora imati uvid u statističke podatke o filmovima i korisnicima, ovisno o odabranom filteru. | Petar Kordić
F09 | Novosti o filmovima | Admin ima mogućnost kreirati novosti o filmovima te novosti se šalju korisnicima koji su odabrali prilikom registracije da žele primati novosti. | Petar Kordić

## Tehnologije i oprema
GitHub, GitHub Classroom, Visual Paradigm CE, .NET(Visual Studio), Word, Microsoft SQL Server, Draw.io.
