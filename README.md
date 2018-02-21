Dependency Injection With Autofac

######################################
Grundlagen DI
######################################

Warum DI
	Dependency Injection
		Plain p = new Plain(Pilot thePilot);
		p.TakeOf() // Hofentlich mit Piloten am Bord. 
		Plain -> Pilot
	* Flugzeuge können nur mit Piloten Ezeugt werden.(100000000+++)
	* Abhangigkeitsbäume z.B Flugzeug(Pilot(Lizenz),Navigation(Flugplatz))
	Lösung Reflection oder DI 
	Pro
		* Ezeugen von Abhängigkeiten Durch DI Container. -> Configuration  z.B Singelton, Lifetime, Properties, Encapsulation
	Contra
		* Container können nicht übersichtlich sein -> Jemand initialisiert Objecte per Hand.
		* Umdenken 
		* Schwer anzuwenden auf Legacy Code 

	Inversion of Control 
		* Normal Klasse.Add(Schüller);
		* Invertiert Schüller.Add(Klasse);
		* Der Kontainer wird konfiguriert und Baut das Obbjekt.

######################################
Registrierung der Componente 
######################################
	* Regestrierung Reflection 	
	* Default Registration
	* Registrierung von Unterschiedlichen Konstruktoren
	* Lambda Expression 
	* Verwendung Eigener Instanzen (Komponente) 
	
 


