# Valida Download by Peaky Blinders Documento di Progetto

## Stesura del progetto iniziale e realizzazione della soluzione
Per iniziare bisogna essere in grado di naviagare il filesystem dell'applicazione, dove ci saranno i file in ogni directory.
Poi bisogna eseguire il calcolo del checksum di tipo SHA 256 cosi da verificare l'integrità del file scaricato.
Poi il programma dovrà avere la chiave pubblica PGP per verificare la firma digitale e la conferma che si stia scaricando un file da una fonte attendibile.
Infine il programma dovra restituire certi output in base al tipo di controllo eseguito e risultato rispetti i paramentri dati all'inizio.

## Organizzazione del lavoro

Il progetto verrà suddiviso in modo equo tra i componenti del gruppo affinchè tutti possano contribuire alla realizzazione, inoltre il lavoro verrà spartito anche a seconda dei gap di conoscenza di ogni membro permettendo ad ognuno di colmare tali gap, in caso di necessità o di gap in comune si lavorerà assieme. Il lavoro verrà suddiviso nelle fasi seguenti:

  1. Realizzazione di una prima interfaccia WPF che verrà usata per la creazione e il debug (potrebbero non essere presenti tutti gli elementi dell'interfaccia in questa fase        della realizzazione).
  2.  Creazione delle strutture dati iniziali che serviranno per il funzionamento dell'app (l'app non è completa a questo punto della realizzazione, potrebbe non funzionare).
  3.  Sviluppo dei metodi necessari per completare gli obbiettivi presenti sul documento di definizione (potrebbero essere presenti bug a questo punto della realizzazione).
      - Calcolo dello SHA256.
      - Confronto dello SHA256.
      - Verifica della firma attraverso chiave PGP.
  4. Debugging e refactoring del codice sorgente.
  5. Miglioramenti dell'interfaccia(potrebbero presentarsi glitch grafici a questa fase dello sviluppo).
  6. Aggiunte extra e miglioramenti della applicazione(Questa fase comprende realizzazione, debug e refactoring e miglioramenti dell'interfaccia).

## Documentazione

Tutta la documentazione relativa alla realizzazione è visibile su github, ogni commit è accompagnato da un commento per rendere chiaro ogni passaggio eseguito durante la fase di sviluppo affinche qualsiasi utente sia in grado di vedere il codice sorgente ad ogni sua fase della realizzazione.

Documentazione per colmare i gap di conoscenza, i punti sono:
- [Implentazione del sistema di cifratura PGP](https://github.com/mattosaurus/PgpCore)
- [Selezione del file(docs microsoft)](https://docs.microsoft.com/it-it/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-6.0)
- [Selezione del file(wpf-tutorial)](https://www.wpf-tutorial.com/it/46/dialogs/l-openfiledialog/)
- [Calcolo SHA 256](https://docs.microsoft.com/it-it/dotnet/api/system.security.cryptography.sha256?view=net-6.0)

