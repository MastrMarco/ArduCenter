//*****************************************************************************************************************************//
//-------------------          By  MastrMarco    Versione 4.08       ISCRIVITI AL CANALE YOUTUBE       ------------------------//
//
//                                 Per Arduino Nano ATMega 328P NEW / OLD Boot loader
//
//                                            ArduHubFanAudio 2.0 01/06/24
//
//                               https://www.youtube.com/channel/UCpQb1Iz6M229ylkyXpdJPlw
//*****************************************************************************************************************************//

//-------------------------------------Informazioni di Base Software
#define Debug 0  //false = modalità normale / 1 = modalità informazioni dati / 2 = modlaita programmazione Software
#if (Debug != 1)
String Stato_Software = "B";  //Commpatibbilità Beta-(B) Relise-(R)
#endif
#if (Debug == 1)
String Stato_Software = "D";  //Commpatibbilità-Debug (D)
#endif

byte Arduino = 1;             // Tipo di arduino   |1 = Nano OLD / 2 = Nano NEW / 3 = UNO
byte Progetto = 3;            // Progetto          |3 = HubFanAudio / 4 = HubFan_3.0 / 5 = HubFan_4.0
const float Versione = 4.08;  // Versione Software |
//
//------------------------------------- Memorizza i Dati impostati dal utente
//EEPROM interna di Arduino 1 Kbyte
#include <EEPROM.h>
//                       0  1  2  3  4  5  6  7  8
byte EEPROMaddress[] = { 0, 2, 4, 6, 8 };
int ROM_Dati = false;  // 0 = False / 1 = True / 2 = Ripristino
//
//------------------------------------- Sensore di Temperatura Esterna
//DS18B20
#include <microDS18B20.h>
#define Pin_DS 7  //Pin in cui è collegato il sensore di Temperatura  DS18B20
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
#define OV A4                    //Mosfet Protezione 5V
#define Pin_5V A6                //Pin in cui è collegato il sensore di Tensione  5V
const float R1_5V = 47000.0;     //Valore Resistore in ohm R1
const float R2_5V = 32500.0;     // Valore Resistore in ohm R2
const float ADJ_Error_5V = 0.0;  // Valore in Volt di errore da sommare
//----------------------
//12V
#define Pin_12V A7                //Pin in cui è collegato il sensore di Tensione  12V
const float R1_12V = 82000.0;     //Valore Resistore in ohm R1
const float R2_12V = 47000.0;     // Valore Resistore in ohm R2
const float ADJ_Error_12V = 0.0;  // Valore in Volt di errore da sommare
//----------------------
float V5 = 0;
float V12 = 0;

//Protezione invesione di Alimentazione
bool EN_OV = 0;  // 0 = False / 1 = True
// Stato protezione della Alimentazione 12v 5v
bool S_Pro_5V = true;   // 0 = False / 1 = True
bool S_Pro_12V = true;  // 0 = False / 1 = True
//Tensione Limite Protezione LED
bool PowerLimitLED = false;  // True = Protezione LED Attiva
bool PowerLimitLED_Stato;

//
//------------------------------------- Configurazione 4 PIN PWM
//PIN PWM
#define PWM_Fan_1 3   //PWM_Fan1
#define PWM_Fan_2 11  //PWM_Fan2
#define PWM_Fan_3 10  //PWM_Fan3
#define PWM_Fan_4 9   //PWM_Fan4
//Tiop di Controlllo
bool ControlloFan = true;  // False = Controllo PWM  // True = Controllo Analogico
int StartFanPower = 2500;  // Imposta le ventole alla massima velocità (all'avvio/Mod_attesa) del HUB per 2.5s
unsigned long DelayFanPower = 0;
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
byte Boot_SetUp;
byte DelayLoopPrimario_ON = 40;
byte DelayLoopPrimario_OFF = 80;
//
//------------------- Esecuzione animazione all'avvio
//
bool Aniamzione_Avvio;
//-------------------------------------
//
byte RGB_Mod_Fan_All = 0;

byte ModLED_Fan;
byte ModFAN_SPEED;
byte ModRGB_LED;
//
//-------------------------------------Modalità d'attesa o standby
//
bool Mod_attesa = false;  // True = PC in standby  // False = PC Attivo
//
//------------------------------------- Dati Che impostano le varie colorazioni dei LED
//
//-------------------Colore
//                   0   1   2   3   4   5   6   7   8   9  10  11  12 /0 = Fan_All / 1 = Fan_1 / 2 = Fan_2 / 3 = Fan_3 / 4 = Fan_4 / 5 = GPU / 6 = Strip / 7 = Fan_PO / 8 = Fan_PO / 9 = Pompa / 10 = Cassa Sinistra / 11 = Cassa Destra / 12 = Strisca cassa Audio // Imposta il Colore
int ColoreLED[] = { 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20 };
//-------------------Luminosità
//                 0    1    2    3    4    5    6    7    8    9    10   11   12  /0 = Fan_All / 1 = Fan_1 / 2 = Fan_2 / 3 = Fan_3 / 4 = Fan_4 / 5 = GPU / 6 = Strip / 7 = Fan_PO / 8 = Fan_PO / 9 = Pompa / 10 = Cassa Sinistra / 11 = Cassa Destra / 12 = Strisca cassa Audio // Imposta la Luminosità
byte LumLED[] = { 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128 };
byte BRIGHTNESS = 255;  // Luminosità Generale LED
byte LumLimitLED;       //Limitatore Luminosità
//-------------------Saturazione
//                      0    1    2    3    4    5    6    7    8    9    10   11   12  /0 = Fan_All / 1 = Fan_1 / 2 = Fan_2 / 3 = Fan_3 / 4 = Fan_4 / 5 = GPU / 6 = Strip / 7 = Fan_PO / 8 = Fan_PO / 9 = Pompa / 10 = Cassa Sinistra / 11 = Cassa Destra / 12 = Strisca cassa Audio // Imposta la Saturazione
byte Saturazione[] = { 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255 };
//-------------------Animazione
//                       0  1  2  3  4  5  6  7  8  9  /0 = Fan_All / 1 = Fan_1 / 2 = Fan_2 / 3 = Fan_3 / 4 = Fan_4 / 5 = GPU / 6 = Strip / 7 = Fan_PO / 8 = Fan_PO / 9 = Pompa // Imposta da dove acquisire i dati per le varie animazioni
int Animation_RGBS[] = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
//
//------------------------------------- Dati Che impostano le varie velocià delle ventole
//
//                   0    1    2    3    4   5  6    /0 = Fan_All / 1 = Fan_1 / 2 = Fan_2 / 3 = Fan_3 / 4 = Fan_4 / 5 = Fan_5 / 6 = Fan_6 // Imposta la Velocità
byte FanSpeed[] = { 128, 128, 128, 128, 128, 0, 0 };
//-------------------
//                       0  1  2  3  4  5  6   /0 = Fan_All / 1 = Fan_1 / 2 = Fan_2 / 3 = Fan_3 / 4 = Fan_4 / 5 = Fan_5 / 6 = Fan_6 // Imposta la Modalita Automatica della ventola
byte Fan_Mod_Speed[] = { 0, 0, 0, 0, 0, 0, 0 };
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
#define DATA_PIN_1 2  //PIN led Serie Ventole Fan / GPU
#define DATA_PIN_2 4  //PIN led Serie STRIP LED
#define DATA_PIN_3 8  //PIN led Serie Casse Audio

//-------------------
byte NUM_LEDS_OUT[] = {
  224,  //Numero LED Totale Max 270

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

  //***//
  10,  //Numero led Serie Cassa Audio Sinistra 10
  10,  //Numero led Serie Cassa Audio Destra 11
  24   //Numero led Serie Strisca LED 12
};

//Gestione Animazioni Sincroizzate
// byte NUM_LEDS_Fan_0_1;    // Ventola 1
// byte NUM_LEDS_Fan_1_2;    // Ventola 2
// byte NUM_LEDS_Fan_2_3;    // Ventola 3
// byte NUM_LEDS_Fan_3_4;    // Ventola 4
// byte NUM_LEDS_OUT_7_8;    // Scheda Video
// byte NUM_LEDS_OUT_8_9;    // Strisca LED
// byte NUM_LEDS_OUT_9_10;   // Cassa Audio Sinistra
// byte NUM_LEDS_OUT_10_11;  // Cassa Audio Destra
// byte NUM_LEDS_OUT_11_12;  // Strisca LED
// byte NUM_LEDS_OUT_All;    // Numero Totale

//Gestione Animazioni Sincroizzate * 24 + 10
byte NUM_LEDS_ALL[] = {
  0,  // Ventola 1 [0-24] 0
  0,  // Ventola 2 [24-48] 1
  0,  // Ventola 3 [48-72] 2
  0,  // Ventola 4 [72-96] 3

  0,  // Dissipatore 120mm [96-120] 4
  0,  // Dissipatore 120mm [120-144] 5
  0,  // Dissipatore 120mm [144-168] 6

  0,  // Scheda Video [96-120] 8
  0,  // Strisca LED [120-144] 5

  0,  // Cassa Sinistra [144-154] 6 *10
  0,  // Cassa Destra [154-164] 7 *10
  0   // Strisca LED [164-188] 8
};





//
// Adafruit_NeoPixel Strip1 = Adafruit_NeoPixel(120, DATA_PIN_1, NEO_GRB + NEO_KHZ800);
// Adafruit_NeoPixel Strip2 = Adafruit_NeoPixel(NUM_LEDS_OUT[9], DATA_PIN_2, NEO_GRB + NEO_KHZ800);
// Adafruit_NeoPixel Strip3 = Adafruit_NeoPixel(44, DATA_PIN_3, NEO_GRB + NEO_KHZ800);

//                 Nome                           Numero LED       Pin OUT    Colore   Tipo di LED
Adafruit_NeoPixel Strip[3] = { Adafruit_NeoPixel(120, DATA_PIN_1, NEO_GRB + NEO_KHZ800),
                               Adafruit_NeoPixel(NUM_LEDS_OUT[9], DATA_PIN_2, NEO_GRB + NEO_KHZ800),
                               Adafruit_NeoPixel(44, DATA_PIN_3, NEO_GRB + NEO_KHZ800) };


//-------------------------------------