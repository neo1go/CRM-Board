# in progress
- Struktur der Site allgemein 
- Design des UI planen
- Login jetzt, Auth später (JWT ?)
- Welche CRM Daten erheben oder bearbeiten ? -> (Kunden mit Name, Firma , E-Mail    TelefonNummer, Adresse,status(aktiv/inaktiv))
- Dashboard erstellen
- Unterpunkt  'Notizen' (mit Freitext) erstellen
-  Unterpunkt 'Aufgaben' erstellen
- Logout erstellen

# done
-  grobe Projektstruktur erstellt
- Routen etabliert. da es sich um die Standalone handelt, gibt es kleine Abweichungen beim Erstellen. Die app.module.ts existiert nicht, dafür aber app.routes.ts 
- Routerlink hat etwas Probleme bereitet, funktioniert aber jetzt.
- Repo wurde wieder global gemacht, da ich wohl ein repo in einem repo erstellt habe mittels ng new.
- Backend erstellt. Jetzt sollte entschieden werden, ob ich mit dem Design oder weiteren Kundenattributen für eine eventuelle Charterstellung weitermache, die dann im Dashboard angezeigt wird.

# pushed back
- Design und kleine Layoutfeatures erstelle ich am Ende, nachdem alle Elemente implementiert wurden.


# hurdles und/oder lessons learned
- angular standalone hat eine leicht andere Strukturierung als die classic Version
- chatgpt ist strunzdoof. Es wurde bestimmt 30 mal erwähnt,das wegen standalone keine module.ts Datei existiert. das kostet Zeit und Nerven
