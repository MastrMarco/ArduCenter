# ArduCenter 2.0
Software di controllo Ventole di un PC e di controllo LED A-RGB 5V.

## !Attenzione!
Quando si prova ad aprire il software chiederà i permessi di Amministratore perché la libreria esterna per acquisire i dati del PC Es:(Temperatura CPU, GPU, ecc.…) ha bisogno di tali permessi. La libreria utilizzata si chiama Open Hardware Monitor, 
Crediti:
[
Sito Libreria: https://openhardwaremonitor.org/downloads/
Sorgente GitHub: https://github.com/LibreHardwareMonitor
]

Crediti Librerie Esterne Utilizzate per comporre il Codice per Arduino: [Adafruit NeoPixel, microDS18B20, Arduino IDE]


## - Scheda Tecnica  ArduHubFan PC
![Scheda Tecnica ArduCenter ArduHubFan PC](https://user-images.githubusercontent.com/76437833/226718185-8d4918ae-d49a-4cf9-ae0b-74cc83c8687c.png)


## - Finestra di Avvio Software

![ArduCenter2 0_Avvio_Note](https://user-images.githubusercontent.com/76437833/226211964-0c023000-cbb8-48a2-afda-9a05b5a76a06.png)

- **A**=> Indica il tipo di rilascio [Prova = Beta, Stabile = Relise].
- **B**=> Mostra la Versione del Software e la Data di rilascio.
- **C**=> Mostra il nome del Creatore del Progetto.


## - Finestra di Connessione

![ArduCenter2 0_Connessione_Note](https://user-images.githubusercontent.com/76437833/226212168-6059b549-de64-47b7-a066-4598f605ec41.png)

## Seleziona Pagina
0. Bottone per andare nella pagina Impostazioni Generali del Software [Non funzionante].
1. Bottone per andare nella pagina Connessione Dispositivo [Pagina di Default all'Avvio].
2. Bottone per andare nella pagina Controllo HUB Ventole PC [Ci si può accedere solo se si e connessi al dispositivo].
3. Bottone per andare nella pagina Strumenti Debug [Ci si può accedere solo se si e connessi al dispositivo].

## Informazioni Pagina Connessione [F_Home]
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

![ArduCenter2 0_HubPC Home](https://user-images.githubusercontent.com/76437833/226214790-2b835f7d-31f5-41b2-a15c-4178cf5c40fe.png)

## Info non **Disponibili**

