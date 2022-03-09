# Valida Download by Peaky Blinders Documento di definizione


## Target: 
il target di questa applicazione è un utenza con una conoscenza medio-alta delle tecnologie usate per il controllo dei file, che necessita di un app che sia in grado di          svolgere controlli d'ntegrita attraverso lo SHA256 e di verificare la firma PGP della fonte del file che si vuole controllare.


## Obiettivi:

### Realizzazione di una applicazione WPF che sia in grado di:
1. Navigare il filesystem.
2. Calcolare il checksum SHA256.
3. Verificare la firma digitale con la chiave pubblica PGP.
4. Notificare all'utente il risultato dei controlli eseguiti.

1)Per essere in grado di navigare il filesystem l'applicazione deve poter accedere ai file presenti in ogni directory principale e nelle directory secondarie, del sistema utilizzato dall'utente, in modo che quest'ultimo possa selezionare un file con il quale vorrà interagire nell'applicazione e quindi che sia in grado di svolgere le richieste dei punti 2 e 3 della lista degli obiettivi.

2)Per eseguire il calcolo del checksum di tipo SHA 256 il programma dovrà essere in grado di calcolare la somma di controllo del file selezionato in modo da ottenere il checksum del file scaricato da un sito internet ad esempio, e oltre al calcolo deve essere in grado d'importare la stringa del checksum che il sito web del file offre in modo da poter confrontarla con il checksum ricavato dal programma per verificare l'integrità del file scaricato.

3)Il programma dovrà essere in grado di ricevere la chiave pubblica PGP che il sito web dal quale il file viene scaricato mette a disposizione, per verificare la firma digitale e quindi avere la conferma che l'utente stia scaricando il file da una fonte attendibile. 

4)In fine il programma dovrà offrire determinati output in base al tipo di controllo eseguito e al risultato delle verifiche eseguite, in modo da rendere chiaro all'utente se il file che viene verificato rispetta i parametri di integrità e attendibilità che viene dichiarata sul rispettivo sito web.


## Risposte tecnologiche per soddisfare gli obiettivi
Per soddisfare i requisiti necessari per il completamento degli obiettivi bisogna sia utilizzare librerie già incluse in .NET, come quella necessaria per la finestra di dialogo di windows per la selezione del file, ma anche sviluppare sottoprogrammi che siano in grado di fornire l'output richiesto, per elementi come lo SHA256 o la verifica della firma PGP o per particolari aggiuntivi alle richieste base bisogna integrare informazioni che colmino i gap di conoscenza.


## Gap di conoscenze presenti nel gruppo 

#### Mignone Fabio: 
      - Calcolo del checksum SHA 256(metodo per ricavare il checksum).
      - Funzionamento della firma e funzionamento della chiave pubblica PGP.
      - modifiche estetiche(modifiche avanzate dell'interfaccia ad es. colori,ombre,sfumature) degli elementi XAML.

#### Tuzza Simone:
      - Funzionamento delle chiavi PGP.
      - Funzionamento del checksum SHA 256 e il suo calcolo.
      - Accedere al filesystem da un'applicazione WPF.
   
   
## Informazioni e Fonti per colmare i gap di conoscenza
- [Docs Microsoft](https://docs.microsoft.com/it-it/dotnet/): documentazione completa ed esaustiva richiede un livello medio-basso di conoscenze generali per la comprensione ottimale della documentazione.
- [wpf-tutorial](https://wpf-tutorial.com): documentazione di facile comprensione con parti di codice pronte per l'implementazione, ma poco esaustiva spesso richiede ulteriori approfondimenti. 
- [Stack Overflow](https://stackoverflow.com/): piattaforma per la risoluzione di problemi legati al codice.
- [Moodle](http://moodle.itismajo.it/course/view.php?id=1853)(classe 4Di Sezione Informatica): Fonte dalla quale è possibile prelevare vecchi progetti per riutilizzare il codice e lezioni su argomenti legati alla teoria come la     chiave PGP.


***Attenzione il programma è stato sviluppato e compilato utilizzando Visual Studio 2019 con framework .NET versione 5.0 su sistema operativo Windows***
