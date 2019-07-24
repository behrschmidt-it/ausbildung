# Installation

Installationsmedium herstellen mit Rufus

ISO Dateien exportieren

# Verwendete Befehle - Archlinux:

cd  
ls  
cat  
cp  
nano - Texteditor
ip  
ping  
netctl  
cfdisk  

wlp4s0 - TessyKWH


# Linux Aufgaben:


## AUFGABE 1: Bringe folgende Schritte in die richtige Reihenfolge:

X. Root password setzen
X. Root Filesytem mounten
X. Festplatte partionieren
X. In Rootfilesystem chrooten
X. Bootloader konfigurieren
X. "Bootstrap" des Systems
X. Keyboard Layout ändern & initiales setup
X. fstab erstellen
X. BIOS Einstellungen ändern
X. Linux USB Installationsmedium herstellen
X. Netzwerk Konfiguration
X. Partitionen formatieren

### AUFGABE 1 Sortiert:

Schritte:

1. Linux USB Installationsmedium herstellen - Verwendete Software Rufus, um den USB-Stick bootfähig zu machen.

2. BIOS Einstellungen ändern - Dort können wir bestimmen, von welchem Speichermedium das System booten soll (mit wlechem Betriesbsystem und wo die Daten dafür liegen).

3. Keyboard und Layout ändern & initiales Setup - (Linux) Betriebssysteme starten immer mit dem Tastaturlayout der Amerikanischen Norm, wir können es aber auf die Deutsche Norm ändern. - 'loadkeys' - 'timedatectl'.

4. Netzwerk Konfiguration - Auf verfügbare Netzwerke oder PC-Systeme zugreifen/verwalten.

5. Festplatte partitionieren - Dadurch lässt sich die Festplatte in Speicherzonen aufteilen, um strukturiert an bestimmten stellen Daten abzuspeichern.

6. Patitionen formatieren - Angelegte Speicherzonen Speichern.

7.  Root Filesystem mounten - Admin-User(root) Daten hinzufügen. - 'cp' - 'ip' - 'ls'

8. „Bootstrap“ des Systems - Initiale Daten einbinden.

9. fstab erstellen - Dort sehen wir die Systemkonfigurationen Festplatten Patitionen etc..

10. In Rootfilesystem chrooten - "change root" Damit lässt sich das Rootverzeichnis verändern. - 'ip'.

11.  Root password setzen - Admin-User Passwort festlegen, Kontopassword setzen. - 'ip' - 'ls'.

12. Bootloader konfigurieren - Dort wählen wir, was das System als Primär Betriebssystem benutzen soll beim starten des Systems.


## AUFGABE 2: Zuordnen von Befehlen

Versuche folgende Befehle den einzelnen Punkten zu zuordnen, mehrfach Zuweisung ist möglich. 

Und beschreibe deren Funktion und Handhabung:

cd = gehe zu, einem bestimmten Pfad.

cp = Datei Kopieren "Copy".

ls ([-l] [-a] [-la])= Zeigt alle Inhalte/Dateien in dem  Verzeichnis, in dem man sich befindet (ohne Pfadangabe wird das akutelle Verzeichnis gelistet). Festplatte partitionieren.
nano = Texteditor.

netctl = Der Befehl automatisiert das verbinden von Profilen oder Lan/Wlan Verbindungen mit einer gegenseitigen abhängigkeit. CLI Manager Arch-Linux Befehl.

loadkeys = Damit lässt sich das Tastaturlayout verändern "loadkeys de" für das QWERTZ Layout.

cat = Mit dem 'cat' Befehl lassen sich Dateien kopieren oder es gibt den Inhalt einer Datei mit Zeilennummern aus.

ip = Zeigt die Benutzerkennung und die Gruppenkennung an (Informationen zu Benutzer "Admin" usw.).

less = Interaktives betrachten einer Datei, macht die Datei "Scollfähig".

ping = Damit lässt sich eine Verbindung zum Internet, Netzwerk oder anderen PC-Systemen prüfen.

timedatectl = Damit kann man für das Bootsystem Zeit- und Datumeinstellungen bearbeiten.

Welche Befehle hier funktionieren nur auf Arch Linux und welche auch auf anderen Distributionen

## Arch-Linux Befehle:

netctl - CLI Manager von Arch-Linux.

pacman - Programm mittels pacman installieren für Arch-Linux.

## Sonstige: 

## AUFGABE 3: Recherche-Aufgabe:

   Linux hat eine eingebaute Dokumentation für Befehle. 
   Wie lautet der Befehl um Hilfe zu einem Befehl zu bekommen?

   ANTWORT: Mit dem Befehl 'man' wird eine Handbuchseite zu dem jeweiligem Befehl geöffnet, mit dem Befehl whatis wird eine Kurinfo zu dem jeweiligem Befehl geöffnet und mit dem Befehl apropos kann man die whatis-Datenbank nach einem Befehl durchsuchen.

## AUFGABE 4: Beschreibe jeden Punkt aus Aufgabe 1 ausführlich


## AUFGABE 5: Beantworte folgende Fragen (Ergänze hier deine Beschreibungen aus Aufgabe 4 wenn nötig):

1. Welche BIOS/UEFI Einstellungen waren notwendig?
   
Wir mussten die Bios einstellung für das "main-Booten" auf unseren USB Stick einstellen, wo wir das Arch-Linux Betriebssystem zum Booten auswählen können.

Für das BIOS-Einstellungs Menü wurde ein Kennwort gesetzt.


2. Wie bekommt man Zugriff auf BIOS/UEFI?
   
* Über einen Tastenbefehl beim Starten des PC-Systems, um in das BIOS/UEFI Menü zu gelangen.

3. Was gibt es beim Partionieren zu beachten?
   
* Das man keine Daten die bereits auf dem Speichermedium vorhanden sind, durch die Patitionsaufteilung überschrieben wird. Sonst wird der vorhandene Speicerstand beschädigt.

4.  Welche Linux Distribution haben wir verwendet, was ist eine Linux Distribution?
    
* Wir haben die Arch-Linux Distribution "Version" benutzt.

* Eine Linux Distribution ist ein Betriebssystem, das schon mit mehreren Software upgrades ausgestattet ist um z.B. das Betriebssystem auf eine Spezielle Anwendung zu Spezialisieren.

5.  Was bedeutet mounten eigentlich?
    
* 'mounten' bedeutet soviel wie anhängen oder hinzufügen. z.B. eine Datei anhängen/hinzufügen.

6.  Wie funktioniert das mit Festplatten, USB Sticks & Co unter Linux im Vergleich zu Windows?  
Bei Linux ist das benutzen von verschlüsselten externen Festplatten, USB-Sticks oder Speicherkarten am einfachsten gelöst.

* Datenträger anschließen
* Passwortabfrage richtig beantworten
* Verschlüsselten Datenträger nutzen

1.  Welche besonderen Ordner hast du unter Linux kennen gelernt? 

* /boot Ordner mit benötigten Dateien um das System zu booten.
  
* /bin Ordner mit Programmen für Linux, die für den Systemstart benötigt werden.


   Fallen dir besondere Ordner auch für Windows ein?

   * system32

   * C:\User


   Wo liegen zum Beispiel User-Daten unter Windows und wo unter Linux?

   * C:\User

   * /root

1. Finde heraus was in der Linux Dokumentationen bedeutet wenn steht:
    
   -> $ Befehl 

   -> # Befehl



   Was ist der Unterschied


2. Wie heist der Admin-User unter Linux?
   
* Der Admin-User hat unter Linux den Accountname 'root'.