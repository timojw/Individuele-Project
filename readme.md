# PROJECTBESCHRIJVING

De applicatie die ik wil gaan maken dit semester is een soort bestelsysteem voor restaurants. Het is de bedoeling dat de gebruiker een bestelling kan plaatsen van het eten wat hij wilt bestellen. Maar deze app draait niet om het webshop gedeelte. Ik wil me vooral focussen op hoe de restaurants de bestellingen binnen krijgen en toewijzen aan bezorgers. Voor meer verijsten waaraan deze app moet voldoen kijk bij de functionele requirements. 


# FUNCTIONELE REQUIREMENTS

### MUST

__FR-01__ Een gebruiker kan producten bestellen van een webshop.

	K.01.01 Er word een foutmelding weergegeven wanneer er foute input is.  
	B.01.01 Een gebruiker moet een bezorglocatie invullen.  

__FR-02__ Een restaurant kan informatie van een bestelling inzien.

__FR-03__ Een bezorger kan de status van een bestelling veranderen.

__FR-04__ Het restaurant kan de status van een bestelling veranderen.

__FR-05__ Een bezorger kan informatie over bestellingen inzien.

__FR-06__ Een restaurant kan bezorgers toevoegen.

	K.06.01 Er word een foutmelding weergegeven wanneer er foute input is.  
	B.06.01 Er moet een naam worden ingevuld.  

__FR-07__ Een restaurant kan bestellingen toewijzen aan bezorgers.

	K.07.01 De bezorger krijgt een melding wanneer hij een nieuwe bezorging heeft gekregen.  


### SHOULD

__FR-08__ Een restaurant kan bezorgers verwijderen.

	K.08.01 De gebruiker krijgt eerst een melding of hij/zij het zeker weet of hij/zij de bezorger wilt verwijderen .  

__FR-09__ Een restaurant kan het assortiment in de webshop weizigen.

	K.09.01 De gebruiker krijgt eerst een melding of hij/zij het zeker weet of hij/zij de weizigingen wil doorvoeren.  
	B.09.01 Een product in de webshop moet een naam en een prijs bevatten.  


### COULD

__FR-10__ Een bezorger ziet een kaart waarop staat aangegeven waar hij heen moet.


### WONT


# USECASES
__Naam__		Een gebruiker kan bestelling plaatsen
Requirement		FR-01			
Samenvatting	Een gebruiker kan via de website een bestelling met producten plaatsen.
Scenario		1. Actor gaat naar website
				2. Actor logt in op een customer account
				3. Actor kiest een product uit de lijst
				4. Actor kiest product kopen
Uitzonderingen	
Resultaat		Er is een bezorging geplaatst en die staat opgeslagen op de database.

__Naam__		Een restaurant kan informatie van een bestelling inzien.
Requirement		FR-02			
Samenvatting	Een restaurant kan op de website over alle bezorgingen informatie inzien.
Scenario		1. Actor gaat naar de website
				2. Actor logt in op een restaurant account
				3. Actor kiest een bezorging in de lijst
				4. Nieuwe pagina opent met meer informatie over die bezorging
Uitzonderingen	
Resultaat		Een werknemer van het restaurant heeft meer informatie over een bezorging.

__Naam__		Een bezorger kan de status van een bestelling veranderen.
Requirement		FR-03			
Samenvatting	Een bezorger moet de status van een bezorging kunnen aanpassen.
Scenario		1. Actor gaat naar de website
				1. Actor logt in op een bezorger account
				3. Actor kiest status weizigen en kiest daarna waarnaar
					(opties: word bereid, bezorger onderweg, bezorgd)
Uitzonderingen	
Resultaat		Een bezorger heeft de status van de bezorging aangepast.

__Naam__		Het restaurant kan de status van een bestelling veranderen.
Requirement		FR-04			
Samenvatting	Een restaurant medewerker moet de status van een bezorging kunnen aanpassen.
Scenario		1. Actor gaat naar de website
				2. Actor logt in op een restaurant account
				3. Actor kiest een bezorging in de lijst
				4. Actor kiest status weizigen en kiest daarna waarnaar
					(opties: word bereid, bezorger onderweg, bezorgd)
Uitzonderingen	
Resultaat		Een bezorger heeft de status van de bezorging aangepast.

__Naam__		Een bezorger kan informatie over bestellingen inzien.
Requirement		FR-05			
Samenvatting	Het is belangrijk dat een bezorger alle informatie van zijn huidige bezorging kan bekijken.
Scenario		1. Actor gaat naar de website
				2. Actor logt in op een bezorger account
				3. Website laat informatie zien van huidige bezorging
Uitzonderingen	
Resultaat		Een bezorger heeft alle informatie van de bestelling

__Naam__		Een restaurant kan bezorgers toevoegen.
Requirement		FR-06			
Samenvatting	Een restaurant medewerker moet de mogelijkheid hebben om een nieuwe bezorger toe te voegen.
Scenario		1. Actor gaat naar de website
				2. Actor logt in op een restaurant account
				3. Actor kiest bezorger toevoegen
				4. Actor vult informatie over de bezorger
				5. Actor kiest opslaan
Uitzonderingen	De informatie die de actor heeft ingevuld is niet correct.
Resultaat		Een bezorger heeft de status van de bezorging aangepast.

__Naam__		Een restaurant kan bestellingen toewijzen aan bezorgers.
Requirement		FR-07			
Samenvatting	Een restaurant medewerker moet de nieuwe bezorgingen handmatig kunnen toewijzen aan een bezorger.
Scenario		1. Actor gaat naar de website
				2. Actor logt in op een restaurant account
				3. Actor kiest een bezorging in de lijst
				4. Actor kiest bezorger weizigen en kiest daarna naar welke bezorger uit de lijst.
Uitzonderingen	
Resultaat		Een bezorging is toegewezen aan een bezorger.