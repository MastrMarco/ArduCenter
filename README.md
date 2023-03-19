# ArduCenter 2.0
Software di controllo Ventole di un PC e di conrollo LED A-RGB 5V.

Quando si prova ad aprire il software chiederà i premessi di Amministratore perché la libreria esterna per acquisire i dati del PC Es:(Temperatura CPU, GPU, ecc.…) ha bisogno di tali permessi. La libreria utilizzata si chiama Open Hardware Monitor, 
Crediti:
[
Sito Libreria: https://openhardwaremonitor.org/downloads/
Sorgente GitHub: https://github.com/LibreHardwareMonitor
]

Crediti Librerie Esterne Utilizate pre comporre il Codice per Arduino: [Adafruit NeoPixel, microDS18B20, Arduino IDE]


## Finestra di Avvio Software

![ArduCenter2 0_Avvio_Note](https://user-images.githubusercontent.com/76437833/226211964-0c023000-cbb8-48a2-afda-9a05b5a76a06.png)

A: Indica il tipo di rilascio [Prova = Beta, Stabile = Relise].
B: Mostra la Versione del Software e la Data di rilascio.
C: Mostra il nome del Creatore del Progetto.


## Finestra di Connessione al Dispositivo

![ArduCenter2 0_Connessione_Note](https://user-images.githubusercontent.com/76437833/226212168-6059b549-de64-47b7-a066-4598f605ec41.png)

## Seleziona Pagina
0. Bottone pre andare nelle pagina Impostazioni Generali del Software [Non funzionante].
1. Bottone per andare nella pagina Connesione Dispositivo [Pagina di Default all'Avvio].
2. Bottone per andare nella pagina Controllo HUB Ventole PC [Ci si può accedere solo se si e connessi al dispositivo].
3. Bottone per andare nella pagina Strumenti Debug [Ci si può accedere solo se si e connessi al dispositivo].


A:
B: Indica che il Firmware inserito dentro l'Arduino è stato progettato per quel tipo di Arduino.
C:
D: Stato di Connessione con il Dispositivo.
E: Bottone per aprire in modo rapido la cartella sorgente in cui si trova il Software.
F: Mostra i Dati Seriali che vengono ricevuti e inviati.
G:
H: Il Bottone quando Attivo serve per la connesione Automatica al Dispositivo quando si avvia il Software [Per attivarlo bisognia essere connessi prima, poiché deve memorizare la porta COM del Dispositivo, si può diasttivare ricliccando sul Bottone del riquadro H o pure cliccando sun Bottone Disconnesione del riquadro C].
I: Il Bottone quando Attivo permette di andare direttamente alla Pagina in cui avete l'elemento selezionato, questa funzione viene eseguita Solo all'avvio del Software [Si può diasttivare ricliccando sul Bottone del riquadro H].
J: Bottone RX mostra i dati che riceviamo da Arduino nel rigqadro F, il Bottone TX mostra i dati che inviamo all'Arduino.
K: Bottone per aprire la finestra Hardware Monitor [Perogetto Droppato].
L: Bottone Riavvio Dispositivo(Arduino).
M: Indica il Nome della pagina in cui ci troviamo in quel momento con anche il nome in Codice.
