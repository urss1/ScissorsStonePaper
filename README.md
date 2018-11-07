# ScissorsStonePaper
sumali - Urs Sommerhalder
Schere, Stein, Papier - Spiel mit C# für Schüler.

Erweitert mit Echse und Spock.


## Projektbeschrieb
Dies ist eine kleine Applikation, die fertig Progmmiert werden kann.
Es sind diverse offene Punkte die gelöst werden müssen (sind mit ToDo markiert), das Grundgerüst und die Logik der Oberfläche sind fertig programmiert.

Entstanden ist die Applikation für den Zukunftstag vom 08.11.2018.

## Aufgaben
### Spiellogik überlegen
- [ ] Wer schlägt wen?
	- Mögliches Vorgehen (Zeichnen)
		- Zeichne alle Symbole (Schere, Stein, Papier, Echse und Spock) im Kreis auf
		- Zeichne nun die Linien von den Sysmbolen, wer gewinnt gegen wen.
		- Beispiel: Schere schneidet Papier
- [ ] Was passiert, wenn beide dasselbe Symbol wählen?
	- Beispiel: beide wählen Schere - wer gewinnt?

### Spiel fertig Programmieren
- [ ] Wer schlägt wen:
	- Klasse: EvaluateWinnerController
	- Konstruktor ergänzen mit den Möglichkeiten für den Gewinn
- [ ] Gewinner ermitteln:
	- Klasse: EvaluateWinnerController
	- Methode EvaluateHumanWins ergänzen.

## Möglichkeit zur Erweiterung
### Ausgabe beim Auswerten des Gewinners mit einem Satz
- Beispiel: Schere schneidet Papier
- Ausgabe in der Box "Systemmeldungen"
- [ ] Erweitere die Methode "ShowWinnerInfo(string winnerName)" (MainWindowModel)
	- [ ] neuer Aufruf mit string winnerName und string winnerInfo
	- [ ] Ausgabe der "winnerInfo" als neue Zeile in der Box
- [ ] Erweitere die Klasse "EvaluateWinnerController"
	- [ ] Erstelle eine weitere Liste mit den Sätzen
	- [ ] Schreibe die Liste mit wer Schlägt wen für die Überprüfung an
- [ ] Erweitere die Methode "EvaluateHumanWins"
	- [ ] Der Rückgabewert muss allenfalls überdenckt werden
	- [ ] Die Auswertung muss neu auch den Satz für die Rückgabe bestimmen

## Hinweise
### Oberfläche
- Die Applikation ist mit WPF aufgebaut.
- Im MainWindowModel sind die Methoden für das Benachrichtigen der Oberfläche (OnPropertyChande) impelementiert.

### EvaluatedWinner
- Hier ist die Liste mit den möglichen Gewinner.
### SelectedImage
- Hier ist die Liste mit den möglichen Auswahlen:
	- Schere (Scissors)
	- Stein (Stone)
	- Papier (Paper)
	- Echse (Lizad)
	- Spock (Spock)

## Was ist wo?
### Fertige Appliaktion oder Musterlösung
https://github.com/urss1/ScissorsStonePaper/tree/master
### Vorlage für den Schüler
https://github.com/urss1/ScissorsStonePaper/tree/templateToDo

# Regeln
Die Regeln für Schere, Stein, Papier, Echse und Spock lauten:
- Papier bedeck Stein
- Papier widerlegt Spock
- Schere schneidet Papier
- Schere köpft Echse
- Stein schleift Schere
- Stein zerqutscht Echse
- Echse frisst Papier
- Echse vergigtet Spock
- Spock zertrümmert Schere
- Spock verdampft Stein
