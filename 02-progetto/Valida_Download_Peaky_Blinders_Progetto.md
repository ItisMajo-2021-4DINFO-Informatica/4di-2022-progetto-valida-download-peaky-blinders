# Valida Download by Peaky Blinders Documento di Progetto

## Stesura del progetto iniziale 
L'applicazione verrà realizzata in modo da permettere all'utente di poter verificare la firma digitale PGP, in modo da assicurasi che il file provenga da una fonte attendibile, calcolare la somma di controllo di tipo SHA256 del file inserito e confrontarla con quella fornita per verificare l'integrità del file. L'utente sarà in grado di selezionare un file, di quest'ultimo verificarne la firma PGP, calcolare lo SHA256 e verificare che corrisponda con quello inserito(fornito da chi rilascia il file) e una volta completate queste operazione, l'utente deve poter leggere chiaramente gli output. Lo sviluppo seguirà diverse fasi presentate nella sezione sottostante.

---

## Organizzazione del lavoro

Il progetto verrà suddiviso in modo equo tra i componenti del gruppo affinché tutti possano contribuire alla realizzazione, inoltre il lavoro verrà spartito anche a seconda dei gap di conoscenza di ogni membro permettendo a ognuno di colmare tali gap, in caso di necessità o di gap in comune si lavorerà assieme. Il lavoro verrà suddiviso nelle fasi seguenti:

  1. Realizzazione di una prima interfaccia WPF che verrà usata per la creazione e il debug:
      - In questa fase della realizzazione verrà creata una prima interfaccia rudimentale che servirà per la creazione e il debug dell'applicazione, non presenterà nessuna modifica estetica e potrebbe non rappresentare tutti gli elementi e/o il design presenti nella versione finale.
  
  2.  Creazione delle strutture dati iniziali che serviranno per il funzionamento dell'app:
      - In questa fase del progetto, si realizzeranno le strutture dati necessarie al salvataggio dei dati e al funzionamento dell'app cercando di rispettare le regole di incapsulamento.
  
  3.  Sviluppo dei sottoprogrammi necessari per completare gli obbiettivi presenti sul documento di definizione:
      - A questo punto dello sviluppo verranno creati i sottoprogrammi, che avranno il compito di:
         - Calcolo e confronto dello SHA256.
         - Verifica della firma attraverso chiave PGP.
         - Rilascio degli output.
      
  4. Debugging e refactoring del codice sorgente:
      - Questa fase della realizzazione è importante per la buona riuscita del progetto infatti inizialmente verrà eseguito il debug, un procedimento che serve a rimuovere i bug ovvero errori presenti nel codice che potrebbero non fare funzionare alcuni sottoprogrammi o l'intero programma, Mentre invece il refactoring è allo stesso tempo un procedimento importante ma meno visibile infatti andrà a modificare il codice affinché quest'ultimo rispetti le regole di sintassi della programmazione e che rispetti  soprattutto l'incapsulamento.
  
  5. Miglioramenti dell'interfaccia:
      - Questa fase della realizzazione porterà le modifiche più evidenti infatti verrà abbandonata l'interfaccia di debug e verrà creata una interfaccia con un design ricercato che renda facile e immediato l'utilizzo all'utente.
  
  6. Aggiunte extra e miglioramenti della applicazione:
      - Questa fase verrà messa in atto solo dopo la realizzazione della prima versione finale dell'applicazione(Valida Download 1.0) verranno apportate modifiche estetiche e funzionali per aumentare le capacità del programma, ogni aggiunta seguirà una fase di realizzazione, debug e refactoring per garantire un livello di qualità coerente con l'intero progetto.

Tempi di sviluppo 
- Fase 1: 4 ore
- Fase 2: 6 ore
- Fase 3: 10/12 ore
- Fase 4: 4/6 ore
- Fase 5: 6 ore
- Fase 6: tempo rimanente fino alla scadenza della consegna

*I tempi di sviluppo sono indicativi e si riferiscono alle ore di laboratorio, lo sviluppo continuerà anche nelle ore extrascolastiche quindi i tempi potrebbero essere anticipati.*
  
***Attenzione nelle fasi precedenti al rilascio della versione finale potrebbero essere presenti bug e glitch sia funzionali che grafici***
  
---

## Documentazione

Tutta la documentazione relativa alla realizzazione è visibile su github, ogni commit è accompagnato da un commento per rendere chiaro ogni passaggio eseguito durante la fase di sviluppo affinché qualsiasi utente sia in grado di vedere il codice sorgente ad ogni sua fase della realizzazione.

Collegamenti con la Teoria: 
- Incapsulamento: lezione di teoria relativa all'incapsulamento.
- Controllo firma digitale PGP: lezione teorica sul controllo della firma e sul funzionamento delle chiavi PGP.
- Funzionamento dello SHA256: lezione di teoria sul funzionamento delle somme di controllo e nello specifico quella di tipo SHA256.

Documentazione per la realizzazione del progetto:
- [Implementazione del sistema di cifratura PGP](https://github.com/mattosaurus/PgpCore)
- [Selezione del file(docs microsoft)](https://docs.microsoft.com/it-it/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-6.0)
- [Selezione del file(wpf-tutorial)](https://www.wpf-tutorial.com/it/46/dialogs/l-openfiledialog/)
- [Calcolo SHA 256](https://docs.microsoft.com/it-it/dotnet/api/system.security.cryptography.sha256?view=net-6.0)
* Altri elementi sono presenti su moodle e sono stati aggiunti dal professore come materiale d'esempio per realizzare la soluzione. [Moodle(corso di informatica)](http://moodle.itismajo.it/course/view.php?id=1853#section-2)*



*Il documento potrebbe subire variazioni a seconda dei possibili problemi riscontrabili nel corso della realizzazione, in tal caso verrà stilato un documento aggiuntivo che raccoglierà tali modifiche al fine di avere un documento preciso e articolato, verrà inserito e aggiornato nella [cartella codice](https://github.com/ItisMajo-2021-4DINFO-Informatica/4di-2022-progetto-valida-download-peaky-blinders/tree/main/03-codice)*
