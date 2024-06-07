# ArduCenter 2.0
Software di controllo Ventole di un PC e di controllo LED A-RGB 5V.

## Video
- **Come Averlo** => https://youtu.be/eZ7t1F8797c
- **Spiegazione GUI P2** => https://youtu.be/uE96V2uZVlI
- **Spiegazione GUI P3** => https://youtu.be/O1FbnbFxPTY
- **Spiegazione GUI P4** => https://youtu.be/B9y6aODZyhU
- **Aggiornamento 2.1.0 P5** => https://youtu.be/VCgzR0a5ROw
- **Aggiornamento 2.1.0 P6** => 

## Crediti Librerie Esterne 
- Utilizzate per comporre il Codice per Arduino: [Adafruit NeoPixel, microDS18B20, Arduino IDE]


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


## - Finestra HUB PC 

![ArduCenter2 1 0 F_HubPC](https://github.com/MastrMarco/ArduCenter/assets/76437833/73e1327f-68c1-423f-8d93-c90bf3326943)


## Mostra Finestra
0. Bottone per aprire la finestra Hardware Monitor [Progetto Droppato].
1. Bottone per aprire la finestra Impostazioni Generali del Controller [Beta].

## Informazioni Finestra Controllo Hub PC [F_Hub_PC]
- **A**=> Informazioni Elemento Selezionato
- **B**=> Bottone per impostare la modalità sincronizzata [Imposta il colore globale e anche una velocità di rotazione ventole globale].
- **C**=> Bottone per aprire la pagina Controllo Ventole [Manuale].
- **D**=> Bottone per aprire la pagina Controllo Dissipatore [Manuale].
- **E**=> Bottone per aprire la pagina Controllo Scheda Video [Cliccando una volta si seleziona l'elemento, cliccando una seconda volta si va nella pagina apposita].
- **F**=> Bottone per aprire la pagina Controllo Striscia LED [Cliccando una volta si seleziona l'elemento, cliccando una seconda volta si va nella pagina apposita].


# - Elementi
![ArduCenter2 1 0 F_HubPC_elementi](https://github.com/MastrMarco/ArduCenter/assets/76437833/b39e0d63-be03-4ae4-8c90-71c861c35b50)



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
- **B**=> Bottone per Attivare/Disattivare la protezione dell’alimentazione: 12v, 5v [Quando si attiverà, la scritta "Protezione Dispositivo" si colora di rosso è toglierà carico all' alimentazione che ha una anomalia; ES: azzeramento della velocità delle ventole o spegnimento totale dei LED, per ripristinare il funzionamento normale bisogna disattivare la protezione o riavviare il dispositivo dall'apposito bottone nella "Finestra di Connessione" Riquadro (L)].
- **C**=> Indicatore dello stato del dispositivo [Cliccando sulla scritta Es: "Buono", si avranno maggiori informazioni sul significato; la scritta cambierà colore in base alla gravità dell'errore. queste sigle si possono vedere anche nella "Finestra di Connessione" Riquadro (A)].
- **D**=> Bottone per Attivare/Disattivare la protezione LED [Quando si attiverà, la scritta "Protezione LED e Luminosità" si colorano di rosso è abbasserà la luminosità dei LED fino ad un livello che non abbia più l'anomalia; ES: se la tensione dei LED (+5V) non è stabile, o ha una anomalia in difetto del valore di tensione esso abbasserà la luminosità fino a quando non rileverà una tensione di tolleranza. Per ripristinare il funzionamento normale bisogna abbassare la luminosità di poco e dopo si può provare a impostare una luminosità più alta, o anche disattivando la protezione LED].
- **E**=> Non Funzionante.
- **F**=> Bottone per resettare l'HUB [Si consiglia di resettare l'HUB alla prima installazione del Firmware].



## - Finestra Impostazioni HUB Elementi  
![ArduCenter2 1 0 F_Impostazioni_Hub_NumLED](https://github.com/MastrMarco/ArduCenter/assets/76437833/6847db7f-9f02-4c38-9117-2e2af83cca43)




## - Finestra Hardware Monitor PC 

![Demo HardwareMonitor](https://github.com/MastrMarco/ArduCenter/assets/76437833/51eea762-467c-40ca-883f-b337e5ca265c)
