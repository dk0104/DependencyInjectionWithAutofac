Dependency Injection With Autofac

######################################
Grundlagen DI
######################################

Warum DI
	Dependency Injection
		Plain p = new Plain(Pilot thePilot);
		p.TakeOf() // Hofentlich mit Piloten am Bord. 
		Plain -> Pilot
	* Flugzeuge k�nnen nur mit Piloten Ezeugt werden.(100000000+++)
	* Abhangigkeitsb�ume z.B Flugzeug(Pilot(Lizenz),Navigation(Flugplatz))
	L�sung Reflection oder DI 
	Pro
		* Ezeugen von Abh�ngigkeiten Durch DI Container. -> Configuration  z.B Singelton, Lifetime, Properties, Encapsulation
	Contra
		* Container k�nnen nicht �bersichtlich sein -> Jemand initialisiert Objecte per Hand.
		* Umdenken 
		* Schwer anzuwenden auf Legacy Code 

	Inversion of Control 
		* Normal Klasse.Add(Sch�ller);
		* Invertiert Sch�ller.Add(Klasse);
		* Der Kontainer wird konfiguriert und Baut das Obbjekt.

######################################
Registrierung der Componente 
######################################
	* Regestrierung Reflection 	
	* Default Registration
	* Registrierung von Unterschiedlichen Konstruktoren
	* Lambda Expression 
	* Verwendung Eigener Instanzen (Komponente) 
	
 


