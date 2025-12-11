- [ ] **Clean Code & Code Smells**

  - [ ] **Duplicated Code:** Der Code ist frei von Duplizierungen (DRY-Prinzip) und identische Logik wurde an einer zentralen Stelle zusammengeführt.
  - [ ] **Long Method:** Methoden sind kurzgehalten, erfüllen genau eine Aufgabe und lassen sich ohne Scrollen erfassen.
  - [ ] **Large Class:** Klassen besitzen eine hohe Kohäsion und vermeiden eine übermässige Anzahl an Instanzvariablen oder Verantwortlichkeiten.
  - [ ] **Long Parameter List:** Die Parameterlisten von Methoden sind kurz; zusammengehörige Parameter wurden in eigene Objekte oder Strukturen gekapselt.
  - [ ] **Feature Envy:** Methoden greifen primär auf Daten der eigenen Klasse zu und operieren nicht überwiegend auf Daten fremder Objekte.
  - [ ] **Primitive Obsession:** Fachliche Konzepte werden durch spezifische Klassen oder Value Objects repräsentiert, statt primitive Datentypen (wie int oder string) zu missbrauchen.
  - [ ] **Switch Statements:** Komplexe switch- oder if-else-Ketten sind, wo sinnvoll, durch Polymorphismus oder Strategie-Pattern ersetzt worden.
  - [ ] **Dead Code:** Unbenutzte Methoden, Variablen, Parameter oder auskommentierter Code ("Speculative Generality") wurden restlos entfernt.
  - [ ] **Comments:** Der Code ist so ausdrucksstark geschrieben ("Self Documenting Code"), dass Kommentare nur das "Warum" erklären, nicht das offensichtliche "Was".
  - [ ] **Magic Numbers/Strings:** Es werden keine fest kodierten Zahlen oder Strings im Code verwendet; stattdessen kommen benannte Konstanten oder Enums zum Einsatz.

- [ ] **SOLID Prinzipien**

  - [ ] **Single Responsibility (SRP):** Jede Klasse hat nur eine einzige Verantwortlichkeit und somit nur einen Grund für eine Änderung.
  - [ ] **Open/Closed (OCP):** Software-Entitäten sind offen für Erweiterungen durch Vererbung oder Interfaces, aber geschlossen für Modifikationen am bestehenden Code.
  - [ ] **Dependency Inversion (DIP):** Module hängen von Abstraktionen (Interfaces) ab, statt von konkreten Implementierungen (Loose Coupling).

- [ ] **C#**

  - [ ] **Naming Conventions:** Die Benennung entspricht den C# Standards (PascalCase für Methoden/Klassen/Properties, camelCase für lokale Variablen/Parameter).
  - [ ] **Properties vs. Fields:** Der Zugriff auf Daten erfolgt über Properties (Getter/Setter) und nicht über öffentliche Felder.
  - [ ] **LINQ Usage:** Iterationen und Datenfilterung werden, wo es die Lesbarkeit verbessert, durch LINQ-Ausdrücke statt durch verschachtelte Schleifen gelöst.

- [ ] **Unit Tests**

  - [ ] **Test Structure (AAA):** Die Unit Tests folgen klar dem AAA-Muster (Arrange, Act, Assert) zur Trennung von Vorbereitung, Ausführung und Überprüfung.
  - [ ] **Test Independence:** Jeder Test ist isoliert ausführbar und hängt nicht von Nebenwirkungen oder dem Zustand anderer Tests ab.
  - [ ] **Naming:** Testmethoden sind aussagekräftig benannt (z.B. MethodName_ExpectedBehavior), sodass im Fehlerfall die Ursache sofort erkennbar ist.
  - [ ] **Assertions:** Jeder Test verifiziert das Ergebnis mit mindestens einer klaren Assertion und testet keine Implementierungsdetails (White-Box), sondern Verhalten (Black-Box).
