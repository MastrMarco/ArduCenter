# ArduCenter 2.0
Software di controllo Ventole di un PC e di controllo LED A-RGB 5V.
## Video
- **Come Averlo** => https://www.youtube.com/watch?v=eZ7t1F8797c&t=1143s
- **Spiegazione GUI** => https://www.youtube.com/watch?v=uE96V2uZVlI

## !Attenzione!
Quando si prova ad aprire il software chiederà i permessi di Amministratore perché la libreria esterna per acquisire i dati del PC Es:(Temperatura CPU, GPU, ecc.…) ha bisogno di tali permessi. La libreria utilizzata si chiama Open Hardware Monitor, 
Crediti:
[
Sito Libreria: https://openhardwaremonitor.org/downloads/
Sorgente GitHub: https://github.com/LibreHardwareMonitor
]

Crediti Librerie Esterne Utilizzate per comporre il Codice per Arduino: [Adafruit NeoPixel, microDS18B20, Arduino IDE]


## - Scheda Tecnica  ArduHubFan PC
![Scheda Tecnica ArduCenter ArduHubFan PC](https://user-images.githubusercontent.com/76437833/226737330-24a8fa7b-3bab-4a28-abef-f9f00b6fa533.png)


## - Finestra di Avvio Software

![ArduCenter2 0_Avvio_Note](https://user-images.githubusercontent.com/76437833/226211964-0c023000-cbb8-48a2-afda-9a05b5a76a06.png)

- **A**=> Indica il tipo di rilascio [Prova = Beta, Stabile = Relise].
- **B**=> Mostra la Versione del Software e la Data di rilascio.
- **C**=> Mostra il nome del Creatore del Progetto.


## - Finestra di Connessione

![ArduCenter2 0_Connessione_Note](https://user-images.githubusercontent.com/76437833/226212168-6059b549-de64-47b7-a066-4598f605ec41.png)

## Seleziona Finestra
0. Bottone per andare nella finestra Impostazioni Generali del Software [Non funzionante].
1. Bottone per andare nella finestra Connessione Dispositivo [Pagina di Default all'Avvio].
2. Bottone per andare nella finestra Controllo HUB Ventole PC [Ci si può accedere solo se si e connessi al dispositivo].
3. Bottone per andare nella finestra Strumenti Debug [Ci si può accedere solo se si e connessi al dispositivo].

## Informazioni Finestra Connessione [F_Home]
- **A**=> Mostra il Nome del Dispositivo e anche lo Stato di eventuali Avvisi o Problemi con delle icone o con delle sigle [Cliccandoci sopra di essi si possono avere più informazioni].
- **B**=> Indica che il Firmware inserito dentro l'Arduino è stato progettato per quel tipo di Arduino.
- **C**=> Cliccando sulla Listbox possiamo selezionare la Porta COM del Dispositivo, è a destra di essa si trova un Bottone verde con un’immagine di una USB e cliccandoci sopra ci si può connettere o disconnettere al dispositivo.
- **D**=> Stato di Connessione con il Dispositivo.
- **E**=> Bottone per aprire in modo rapido la cartella sorgente in cui si trova il Software.
- **F**=> Mostra i Dati Seriali che vengono ricevuti e inviati.
- **G**=> Mostra la versione attuale del Firmware del Dispositivo (Arduino), mostra anche la versione Firmware di Arduino che supporta il Software [Per avere una massima Compatibilità i numeri devono coincidere tra loro].
- **H**=> Il Bottone quando Attivo serve per la connessione Automatica al Dispositivo quando si avvia il Software [Per attivarlo bisogna essere connessi prima poiché deve memorizzare la porta COM del Dispositivo, si può disattivare ripremendo sul Bottone del riquadro H o pure cliccando il Bottone Connessione/Disconnessione del riquadro C].
- **I**=> Il Bottone quando Attivo permette di andare direttamente alla Pagina in cui si trova l'elemento selezionato, questa funzione viene eseguita Solo all'avvio del Software [Si può disattivare ripremendo sul Bottone del riquadro H].
- **J**=> Bottone RX mostra i dati che riceviamo da Arduino nel riquadro F, il Bottone TX mostra i dati che inviamo all'Arduino.
- **K**=> Bottone per aprire la finestra Hardware Monitor [Progetto Droppato].
- **L**=> Bottone Riavvio Dispositivo (Arduino).
- **M**=> Indica il Nome della pagina in cui ci troviamo in quel momento con anche il nome in Codice.


## - Finestra HUB PC Home 

![ArduCenter2 0_HubPC Home_Note](https://user-images.githubusercontent.com/76437833/227233106-f7de08e1-75a1-453f-b552-78f4ea8b370f.png)

## Mostra Finestra
0. Bottone per aprire la finestra Hardware Monitor [Progetto Droppato].
1. Bottone per aprire la finestra Impostazioni Generali del Controller [Beta].

## Informazioni Finestra Controllo Hub PC Home [F_Hub_PC_Home]
- **A**=> Bottone per aprire la pagina Controllo Ventole [Manuale].
- **B**=> Bottone per aprire la pagina Controllo Dissipatore [Manuale].
- **C**=> Bottone per aprire la pagina Controllo Scheda Video [Cliccando una volta si seleziona l'elemento, cliccando una seconda volta si va nella pagina apposita].
- **D**=> Menù settaggi [Colore, Animazioni RGB, Luminosità e Velocità di rotazione Ventole].
- **E**=> Bottone per impostare la modalità sincronizzata [Imposta il colore globale e anche una velocità di rotazione ventole globale].
- **F**=> Bottone per aprire la pagina Controllo Striscia LED [Cliccando una volta si seleziona l'elemento, cliccando una seconda volta si va nella pagina apposita].

## - Menù settaggi

![ArduCenter2 0_HubPC Menù settaggi Note](https://user-images.githubusercontent.com/76437833/227326044-621606c8-b82a-44c1-b5f2-e4c41f578a80.png)

## Informazioni Menù settaggi

- **A**=> Cliccando su un Bottone colorato puoi impostare il colore di esso, (Bianco, Rosso, Verde, Blu, Arancione, Fucsia, Giallo, Celeste) [Non si possono inserire colori custom].
- **B**=> Cliccando sopra la barra di scorrimento si può regolare la velocità della rotazione della/e ventola/e, le due icone poste agli estremi sono delle scorciatoie per impostare la minima o la massima velocità [Essi funzionano solo se si è in modalità Controllo Manuale].
- **C**=> Cliccando sopra la barra di scorrimento si può regolare la Luminosità dei LED, le due icone poste agli estremi sono delle scorciatoie per impostare la minima o la massima Luminosità [La minima Luminosità non equivale allo spegnimento totale dei LED].

## Informazioni Animazioni RGB

0. Bottone per Spegnere i LED
1. Bottone per Impostare l'animazione RGB Transizione [Questa Animazione si può solo impostare all'elemento SyncMode].
2. Bottone per Impostare l'animazione RGB RainBow [Questa Animazione si può solo impostare all'elemento SyncMode].
3. Bottone per Impostare l'animazione RGB Temperatura [Questa Animazione si può solo impostare all'elemento SyncMode].
4. Bottone per Impostare l'animazione RGB Musica [Questa Animazione si può solo impostare all'elemento SyncMode].
5. Bottone per Impostare l'animazione RGB Discontinuo [Questa Animazione si può solo impostare all'elemento SyncMode].


## - Finestra Impostazioni HUB PC  

![ArduCenter2 0_HubPC_Impostazioni_Note](https://user-images.githubusercontent.com/76437833/234077988-856c5af3-4a2a-4596-80ac-464bfe2634b3.png)

## Informazioni Finestra Impostazioni Hub PC [F_Impostazioni-HUB_Fan]
- **A**=> Bottone per Attivare/Disattivare la memorizzazione dei settaggi impostati dall'utente.
- **B**=> 
- **C**=> 
- **D**=> 
- **E**=> 
- **F**=> 

## - Finestra Hardware Monitor PC 

![ArduCenter2 0_HardwareMonitor](https://user-images.githubusercontent.com/76437833/227327772-a839ccd7-8cfe-44bf-b496-0e29cda1630d.png)
