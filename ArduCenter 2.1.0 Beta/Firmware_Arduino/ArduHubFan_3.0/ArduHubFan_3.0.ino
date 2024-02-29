//*****************************************************************************************************************************//
//-------------------          By  MastrMarco    Versione 2.07       ISCRIVITI AL CANALE YOUTUBE       ------------------------//
//
//                                 Per Arduino Nano ATMega 328P NEW / OLD Boot loader
//
//                                              ArduHubFan 3.0 01/03/24
//
//                               https://www.youtube.com/channel/UCpQb1Iz6M229ylkyXpdJPlw
//*****************************************************************************************************************************//

//-------------------------------------Informazioni di Base Software
#define Debug 2  //0 = modalità normale / 1 = modalità informazioni dati / 2 = modlaita programmazione Software OFF Protezioni
#if (Debug != 1)
String Stato_Software = "B";  //Commpatibbilità Beta-(B) Relise-(R)
#endif
#if (Debug == 1)
String Stato_Software = "D";  //Commpatibbilità-Debug (D)
#endif

byte Arduino = 2;       // Tipo di arduino   |1 = Nano OLD / 2 = Nano NEW / 3 = UNO
byte Progetto = 4;      // Progetto          |3 = HubFanAudio / 4 = HubFan_3.0 / 5 = HubFan_4.0
float Versione = 2.07;  // Versione Software |
//
//------------------------------------- Memorizza i Dati impostati dal utente
//EEPROM interna di Arduino 1 Kbyte
#include <EEPROM.h>
//                       0  1  2  3  4  5  6  7  8
byte EEPROMaddress[] = { 0, 2, 4, 6, 8 };
byte ROM_Dati = 0;  // 0 = False / 1 = True / 2 = Ripristino
//
//------------------------------------- Sensore di Temperatura Esterna
//DS18B20
#include <microDS18B20.h>
#define Pin_DS 12  //Pin in cui è collegato il sensore di Temperatura  DS18B20
MicroDS18B20<Pin_DS> TempData;
byte TempDS = 0;
//
//------------------------------------- Verifica Tensioni 12V 5V DC
//VAREF
const float VoltRef = 0.05;  // Valore di Correzione VCC Pin 5V [Letto da Arduino - Misurato da Multimetro] ES: 4.88 - 4.75 = 0.13
float VAREF;
const byte Campionamento = 30;  // Numero di Campionamenti per fare una Media del Voltaggio
unsigned long TimerVAREF;       // Timer Calcolo Tensione AREF
//----------------------
//5V
#define OV A0
#define Pin_5V A6                //Pin in cui è collegato il sensore di Tensione  5V
float R1_5V = 32700.0;           //
float R2_5V = 47000.0;           //
const float ADJ_Error_5V = 0.0;  // Valore in Volt di errore da sommare
//----------------------
//12V
#define Pin_12V A7                //Pin in cui è collegato il sensore di Tensione  12V
float R1_12V = 32700.0;           //
float R2_12V = 9100.0;            //
const float ADJ_Error_12V = 0.0;  // Valore in Volt di errore da sommare
//----------------------
float V5 = 0;
float V12 = 0;

//Protezione invesione di Alimentazione
bool EN_OV = 0;  // 0 = False / 1 = True
// Stato protezione della Alimentazione 12v 5v
bool S_Pro_5V;   // 0 = False / 1 = True
bool S_Pro_12V;  // 0 = False / 1 = True
//Tensione Limite Protezione LED
bool PowerLimitLED = false;  // True = Protezione LED Attiva
bool PowerLimitLED_Stato;


//void Voltaggio();
//
//------------------------------------- Configurazione 4 PIN PWM
//PIN PWM
#define PWM_Fan_1 11  //PWM_Fan1
#define PWM_Fan_2 3   //PWM_Fan2
#define PWM_Fan_3 10  //PWM_Fan3
#define PWM_Fan_4 9   //PWM_Fan4
//Tiop di Controlllo
bool ControlloFan = true;  // False = Controllo PWM  // True = Controllo Analogico
int StartFanPower = 2500;  // Imposta le ventole alla massima velocità (all'avvio/Mod_attesa) del HUB per 2.5s
unsigned long DelayFanPower = 0;
//
//------------------------------------- Configurazione ShiftRegister in modalità Imput + 8 PIN
//74LS166
#define SL 6  //Pin in cui è collegato il ShiftRegister 74LS166 pin Shift/Load
#define QH 4  //Pin in cui è collegato il ShiftRegister 74LS166 pin Output QH
#define CK 5  //Pin in cui è collegato il ShiftRegister 74LS166 pin Clock
byte Dati74166;

bool PinA;
bool PinA_pre;
volatile byte Count_RPM_1;
byte RPM_Fan1;

bool PinB;
bool PinB_pre;
volatile byte Count_RPM_2;
byte RPM_Fan2;

bool PinC;
bool PinC_pre;
volatile byte Count_RPM_3;
byte RPM_Fan3;

bool PinD;
bool PinD_pre;
volatile byte Count_RPM_4;
byte RPM_Fan4;
//
//------------------------------------- Timper Viruale (Delay)
//Funzione millis
//Crea un delay non bloccante per evitare errori nell'invio dei dati al PC tramite Seriale TX           0
//Crea un delay non bloccante per la Modalità Offline USB                                               1
//Crea un delay non bloccante per evitare errori nell'invio dei dati al PC tramite Seriale Tensione     2 Lettura Tensione
//Crea un delay non bloccante per evitare errori nell'invio dei dati al PC tramite Seriale Temperatura  3
//Crea un delay non bloccante per evitare errori quando vengono impostati i vari valori per i LED       4
//Crea un delay non bloccante per regolare la velocità Animata degli RGB Modalità 1                     5 RainBow
//Crea un delay non bloccante per regolare la velocità Animata degli RGB Modalità 2                     6 Temperatura
//Crea un delay non bloccante per regolare la velocità Animata degli RGB Modalità 3                     7 Transiozione
//Crea un delay non bloccante per regolare la velocità Animata degli RGB Modalità 4                     8 Musica OFF
//Crea un delay non bloccante per regolare la velocità Animata degli RGB Modalità 5                     9 Discontinuo
//Crea un delay non bloccante per regolare la velocità Animata Avvio Arduino                            10
//Crea un delay non bloccante per calcolare gli RPM delle varie ventole                                 11
//Crea un delay non bloccante per l'auto reset dello stato delle protezioni                             12
//Crea un delay non bloccante per regolare la velocità Animata degli RGB Modalità 6                     13 Mix_Festività
//Crea un delay non bloccante per regolare la velocità Animata degli RGB LED_Test                       14 Configutazione LED
//
//
//                            0
unsigned long TimerVirtuale = 0;  // Aniamzione Avvio millis()
//                                       0  1  2  3  4  5  6  7  8  9  10 11 12 13 14
unsigned long ResetTimerVirtuale[15] = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
//                         0   1    2     3    4   5  6    7   8   9  10   11   12  13  14
int DelayVirtuale[15] = { 40, 40, 1000, 1000, 40, 10, 20, 200, 1, 50, 30, 1000, 60, 15, 30 };
//
//------------------------------------- Seriale di avvio
//
byte Boot_SetUp;                  // Collegamento seriale
byte DelayLoopPrimario_ON = 40;   //Delay Seriale Connesso
byte DelayLoopPrimario_OFF = 80;  //Delay Seriale non Connesso
//
//------------------- Esecuzione animazione all'avvio
//
bool Aniamzione_Avvio;
//-------------------------------------
//
int RGB_Mod_Fan_All = 0;

byte ModLED_Fan;
byte ModFAN_SPEED;
byte ModRGB_LED;
//
//-------------------------------------Modalità d'attesa o standby
//
bool Mod_attesa;  // True = PC in standby  // False = PC Attivo
//
//------------------------------------- Dati Che impostano le varie colorazioni dei LED
//
//-------------------Colore
//                  0  1  2  3  4  5  6  7  8  9  /0 = Fan_All / 1 = Fan_1 / 2 = Fan_2 / 3 = Fan_3 / 4 = Fan_4 / 5 = GPU / 6 = Strip / 7 = Fan_PO / 8 = Fan_PO / 9 = Pompa // Imposta il Colore
int ColoreLED[] = { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 };
//-------------------Luminosità
//                 0    1    2    3    4    5    6    7    8    9   /0 = Fan_All / 1 = Fan_1 / 2 = Fan_2 / 3 = Fan_3 / 4 = Fan_4 / 5 = GPU / 6 = Strip / 7 = Fan_PO / 8 = Fan_PO / 9 = Pompa // Imposta la Luminosità
byte LumLED[] = { 128, 128, 128, 128, 128, 128, 128, 128, 128, 128 };
byte BRIGHTNESS = 255;  // Luminosità Generale LED
byte LumLimitLED;       //Limitatore Luminosità
//-------------------Saturazione
//                      0    1    2    3    4    5    6    7    8    9   /0 = Fan_All / 1 = Fan_1 / 2 = Fan_2 / 3 = Fan_3 / 4 = Fan_4 / 5 = GPU / 6 = Strip / 7 = Fan_PO / 8 = Fan_PO / 9 = Pompa // Imposta la Saturazione
byte Saturazione[] = { 255, 255, 255, 255, 255, 255, 255, 255, 255, 255 };
//-------------------Animazione
//                       0  1  2  3  4  5  6  7  8  9  /0 = Fan_All / 1 = Fan_1 / 2 = Fan_2 / 3 = Fan_3 / 4 = Fan_4 / 5 = GPU / 6 = Strip / 7 = Fan_PO / 8 = Fan_PO / 9 = Pompa // Imposta da dove acquisire i dati per le varie animazioni
int Animation_RGBS[] = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
//
//------------------------------------- Dati Che impostano le varie velocià delle ventole
//
//                   0    1    2    3    4    /0 = Fan_All / 1 = Fan_1 / 2 = Fan_2 / 3 = Fan_3 / 4 = Fan_4 / 5 = Fan_5 / 6 = Fan_6 // Imposta la Velocità
byte FanSpeed[] = { 128, 128, 128, 128, 128 };
//-------------------
//                       0  1  2  3  4  /0 = Fan_All / 1 = Fan_1 / 2 = Fan_2 / 3 = Fan_3 / 4 = Fan_4 // Imposta la Modalita Automatica della ventola
byte Fan_Mod_Speed[] = { 0, 0, 0, 0, 0 };
//-------------------
//
//------------------------------------- Imposta tutte le risorse / Dati dell'Hub
bool ConfigMode = false;  //Attiva / Disattiva la modlità Configurazione
bool stDef = true;        //Set Max Value LED per la Configurazione
byte valLED = 1;          //variabbile di partenza Animazione LED per il settaggio
byte ElementoPRE;         // Salva l'ultimo Elemento Selezionato
//
//------------------------------------- Imposta tutte le risorse per i LED A-RGB WS12
//Imposta i PIN di collegamento dei LED e setta il nummero dei LED
#include <Adafruit_NeoPixel.h>
//-------------------
//Striscia LED PIN Connessione
#define DATA_PIN_1 7  //PIN led Serie Ventole Fan / GPU
#define DATA_PIN_2 8  //PIN led Serie Ventole Striscia LED

//-------------------
byte NUM_LEDS_OUT[] = {
  200,  //Numero LED Totale 0

  //***//
  24,  //Numero led Serie Ventole Fan 1
  24,  //Numero led Serie Ventole Fan 2
  24,  //Numero led Serie Ventole Fan 3
  24,  //Numero led Serie Ventole Fan 4

  0,  //Numero led Serie Dissipatore 120mm Fan 5
  0,  //Numero led Serie Dissipatore 120mm Fan 6
  0,  //Numero led Serie Dissipatore 120mm CPU 7

  24,  //Numero led Serie GPU 8

  //***//
  24,  //Numero led Totale Striscia a LED 9
};

//Gestione Animazioni Sincroizzate
byte NUM_LEDS_Fan_0_1;  // Ventola 1
byte NUM_LEDS_Fan_1_2;  // Ventola 2
byte NUM_LEDS_Fan_2_3;  // Ventola 3
byte NUM_LEDS_Fan_3_4;  // Ventola 4
byte NUM_LEDS_OUT_7_8;  // Scheda Video
byte NUM_LEDS_OUT_8_9;  // Strisca LED
byte NUM_LEDS_OUT_All;  // Numero Totale

//
Adafruit_NeoPixel Strip1 = Adafruit_NeoPixel(120, DATA_PIN_1, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel Strip2 = Adafruit_NeoPixel(NUM_LEDS_OUT[9], DATA_PIN_2, NEO_GRB + NEO_KHZ800);

//-------------------------------------
