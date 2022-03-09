# Valida Download by Peaky Blinders Documento di Progetto

## Stesura del progetto iniziale e realizzazione della soluzione
Per iniziare bisogna essere in grado di naviagare il filesystem dell'applicazione, dove ci saranno i file in ogni directory.
Poi bisogna eseguire il calcolo del checksum di tipo SHA 256 cosi da verificare l'integrità del file scaricato.
Poi il programma dovrà avere la chiave pubblica PGP per verificare la firma digitale e la conferma che si stia scaricando un file da una fonte attendibile.
Infine il programma dovra restituire certi output in base al tipo di controllo eseguito e risultato rispetti i paramentri dati all'inizio.

---

## Organizzazione del lavoro

Il progetto verrà suddiviso in modo equo tra i componenti del gruppo affinché tutti possano contribuire alla realizzazione, inoltre il lavoro verrà spartito anche a seconda dei gap di conoscenza di ogni membro permettendo a ognuno di colmare tali gap, in caso di necessità o di gap in comune si lavorerà assieme. Il lavoro verrà suddiviso nelle fasi seguenti:

  1. Realizzazione di una prima interfaccia WPF che verrà usata per la creazione e il debug:
      - In questa fase della realizzazione verrà creata una prima interfaccia rudimentale che servirà per la creazione e il debug dell'applicazione, non presenterà nessuna               modifica estetica e potrebbe non rappresentare tutti gli elementi e/o il design presenti nella versione finale.
  
  2.  Creazione delle strutture dati iniziali che serviranno per il funzionamento dell'app:
      - In questa fase del progetto, si realizzeranno le strutture dati necessarie al salvataggio dei dati e al funzionamento dell'app cercando di rispettare le regole di               incapsulamento.
  
  3.  Sviluppo dei sottoprogrammi necessari per completare gli obbiettivi presenti sul documento di definizione:
      - A questo punto dello sviluppo verranno creati i sottoprogrammi, che avranno il compito di:
         - Calcolo e confronto dello SHA256.
         - Verifica della firma attraverso chiave PGP.
         - Rilascio degli output.
      
  4. Debugging e refactoring del codice sorgente:
      - Questa fase della realizzazione è importante per la buona riuscita del progetto infatti inizialmente verrà eseguito il debug, un procedimento che serve a rimuovere i bug         ovvero errori presenti nel codice che potrebbero non fare funzionare alcuni sottoprogrammi o l'intero programma, Mentre invece il refactoring è allo stesso tempo un             procedimento importante ma meno visibile infatti andrà a modificare il codice affinché quest'ultimo risppetti le regole di sintassi della programmazione e che rispetti           soprattutto l'incapsulamento.
  
  5. Miglioramenti dell'interfaccia:
      - Questa fase della realizzazione porterà le modifiche più evidenti infatti verrà abbandonata l'interfaccia di debug e verrà creata una interfaccia con un design ricercato         che renda facile e immediato l'utilizzo all'utente.
  
  6. Aggiunte extra e miglioramenti della applicazione:
      - Questa fase verrà messa in atto solo dopo la realizzazione della prima versione finale dell'applicazione(Valida Download 1.0) verranno apportate modifiche estetiche e           funzionali per aumentare le capacità del programma, ogni aggiunta seguirà una fase di realizzazione, debug e refactoring per garantire un livello di qualità coerente con         l'intero progetto.
  
***Attenzione nelle fasi precedenti al rilascio della versione finale potrebbero essere presenti bug e glitch sia funzionali che grafici***
  
---

## Documentazione

Tutta la documentazione relativa alla realizzazione è visibile su github, ogni commit è accompagnato da un commento per rendere chiaro ogni passaggio eseguito durante la fase di sviluppo affinche qualsiasi utente sia in grado di vedere il codice sorgente ad ogni sua fase della realizzazione.

Documentazione per colmare i gap di conoscenza:
- [Implentazione del sistema di cifratura PGP](https://github.com/mattosaurus/PgpCore)
- [Selezione del file(docs microsoft)](https://docs.microsoft.com/it-it/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-6.0)
- [Selezione del file(wpf-tutorial)](https://www.wpf-tutorial.com/it/46/dialogs/l-openfiledialog/)
- [Calcolo SHA 256](https://docs.microsoft.com/it-it/dotnet/api/system.security.cryptography.sha256?view=net-6.0)

