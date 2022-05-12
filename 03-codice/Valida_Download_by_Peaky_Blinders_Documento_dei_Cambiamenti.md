# Valida_Download_by_Peaky_Blinders_Documento_dei_Cambiamenti

## Le motivazioni della realizzazione di questo documento 
Il documento in questione è stato realizzato per spiegare le differenze tra ciò che è stato realizzato, con le idee iniziali inserite nel documento di Progetto, inoltre verranno spiegate nel dettaglio le modifiche.

## L'organizzazione del lavoro 
### Il lavoro è stato suddiviso principalmente in due parti:

- La prima è stata l'interfaccia: Creata da Tuzza, che ha lavorato parallelamente allo sviluppo dei sottoprogrammi in una soluzione esterna a quella caricata su github. Per ottenere il risultato visibile nel progetto è stato aggiunto sul framework il supporto a Windows Form, che ha sottratto molto tempo, in modo da poter utilizzare lo splash screen in combinazione con wpf.

- La seconda invece è la creazione dei sottoprogrammi: Questa punto ha riscontrato diversi cambiamenti sotto tutti gli aspetti, ma nello specifico l'organizzazione di questa fase lavorativa ha visto aumentare il tempo di lavoro poiché sono stati riscontrati problemi nell'sottoprogramma specializzato nella verifica della chiave Pgp.
    
### le fasi di lavoro: 
il lavoro è stato ideato principalmente per permettere a entrambi i membri del gruppo di poter colmare i propri gap di conoscenza e perciò inizialmente suddiviso in fasi sequenziali ma di fronte ai problemi riscontrati si è scelta una opzione di lavoro che permettesse di lavorare simultaneamente a più fasi in modo da risolvere i problemi più facilmente. Nonostante questo cambiamento i membri del gruppo sono stati in grado di apprendere i gap di conoscenza riguardanti il progetto. 

## Documentazione
Il cambiamento principale che ha subito la documentazione è stata la fonte per la chiave Pgp che non è più rimasta la libreria PgpCore di mattosaurus ma invece verrà utilizzata la console con i comandi di GPG4WIN.

- PgpCore: PgpCore inizialmente sembrava essere la scelta migliore per verificare i file firmati ma dopo aver capito che l'algoritmo che usava per gestire le chiavi non riusciva a comprendere altre chiavi se non quelle generate dalla libreria stessa, quindi questa opzione è stata scartata.

- OpenPGP: Dopo aver cercato altre possibili soluzioni ci siamo imbattuti in questa libreria creata da didisoft che sembrava inizialmente fornire una serie di metodi utilizzabili per risolvere il nostro problema, ma infine anche quest'ultima risulta avere le stesse limitazioni della prima possibile soluzione.

- Console: Infine visto che tutte le librerie provate in precedenza non riuscivano a fornire una soluzione per il problema delle chiavi pgp abbiamo pensato di seguire l'unico metodo funzionante ovvero usare i comandi console di PGP4WIN seguendo questi materiali forniti su moodle [clicca per vedere i materiali](http://moodle.itismajo.it/mod/page/view.php?id=85187)

L'implementazione in .net del cmd è stata realizzata attraverso questa risposta di StackOverflow alla domanda [clicca per vedere la domanda](https://stackoverflow.com/questions/1469764/run-command-prompt-commands):

![Soluzione di StackOverflow](https://user-images.githubusercontent.com/85789642/168100724-e77df1f7-2075-4c89-afb1-3bb7bb35f79d.png)

Nonostante ciò l'implementazione del codice, non ha portato ad una soluzione. 

