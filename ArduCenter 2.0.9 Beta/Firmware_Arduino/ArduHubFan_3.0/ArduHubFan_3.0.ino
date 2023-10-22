//*****************************************************************************************************************************//
//-------------------          By  MastrMarco    Versione 2.06       ISCRIVITI AL CANALE YOUTUBE       ------------------------//
//
//                                 Per Arduino Nano ATMega 328P NEW / OLD Boot loader
//
//                                              ArduHubFan 3.0 23/10/23
//
//                               https://www.youtube.com/channel/UCpQb1Iz6M229ylkyXpdJPlw
//*****************************************************************************************************************************//



// #if defined(__AVR_ATmega328P__)
// char BOARD[] = { "UNO" };
// #elif defined(__AVR_ATmega2560__)
// char BOARD[] = { "Mega" };
// #elif defined(__AVR_ATmega168__)
// char BOARD[] = { "Mini 168" };
// #else
// #warning "device type not defined"
// #endif

//-------------------------------------Informazioni di Base Software
#define Debug 0  //0 = modalità normale / 1 = modalità informazioni dati / 2 = modlaita programmazione Software OFF Protezioni
#if (Debug != 1)
String Stato_Software = "B";  //Commpatibbilità Beta-(B) Relise-(R)
#endif
#if (Debug == 1)
String Stato_Software = "D";  //Commpatibbilità-Debug (D)
#endif

byte Arduino = 2;       // Tipo di arduino   |1 = Nano OLD / 2 = Nano NEW / 3 = UNO
byte Progetto = 4;      // Progetto          |3 = HubFanAudio / 4 = HubFan_3.0 / 5 = HubFan_4.0
float Versione = 2.06;  // Versione Software |
//
//------------------------------------- Memorizza i Dati impostati dal utente
//EEPROM interna di Arduino 1 Kbyte
#include <EEPROM.h>
//                       0  1  2  3  4  5  6  7  8
byte EEPROMaddress[] = { 0, 2, 4, 6, 8 };
byte ROM_Dati = 0;  // 0 = False / 1 = True / 2 = Ripristino
//bool Ripristino = false;  // 0 = False / 1 = True
//
//------------------------------------- Sensore di Temperatura Esterna
//DS18B20
#include <microDS18B20.h>
#define Pin_DS 12  //Pin in cui è collegato il sensore di Temperatura  DS18B20
MicroDS18B20<Pin_DS> TempData;
byte TempDS = 0;
byte TempCPU;
byte TempGPU;
//void TemperaturaDS();
int TempLED = 128;
int TempSens = 0;
//
//------------------------------------- Verifica Tensioni 12V 5V DC
//5V
#define OV A0
#define Pin_5V A6  //Pin in cui è collegato il sensore di Tensione  5V
float Con_5V = 0.0;
float Volt_5V = 0.0;

float R1_5V = 32700.0;  //
float R2_5V = 47000.0;  //
// float R1_5V = 32000;
// float R2_5V = 7500;

int DatiAN_5V = 0;
byte Media_5v = 20;
int CampNum_5v;
//----------------------
//12V
#define Pin_12V A7  //Pin in cui è collegato il sensore di Tensione  12V
float Con_12V = 0.0;
float Volt_12V = 0.0;

float R1_12V = 32700.0;  //
float R2_12V = 9100.0;   //
//float R1_12V = 135000;
//float R2_12V = 7500;

int DatiAN_12V = 0;
byte Media_12v = 20;
int CampNum_12v;
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
int Count_RPM_1;
int RPM_Fan1;

bool PinB;
bool PinB_pre;
int Count_RPM_2;
int RPM_Fan2;

bool PinC;
bool PinC_pre;
int Count_RPM_3;
int RPM_Fan3;

bool PinD;
bool PinD_pre;
int Count_RPM_4;
int RPM_Fan4;
//
//------------------------------------- Timper Viruale (Delay)
//Funzione millis
//Crea un delay non bloccante per evitare errori nell'invio dei dati al PC tramite Seriale TX 0
//Crea un delay non bloccante per la Modalità Offline USB 1
//Crea un delay non bloccante per evitare errori nell'invio dei dati al PC tramite Seriale Tensione 2
//Crea un delay non bloccante per evitare errori nell'invio dei dati al PC tramite Seriale Temperatura 3
//Crea un delay non bloccante per evitare errori quando vengono impostati i vari valori per i LED 4
//Crea un delay non bloccante per regolare la velocità Animata degli RGB Modalità 1 5 RainBow
//Crea un delay non bloccante per regolare la velocità Animata degli RGB Modalità 2 6 Temperatura
//Crea un delay non bloccante per regolare la velocità Animata degli RGB Modalità 3 7 Transiozione
//Crea un delay non bloccante per regolare la velocità Animata degli RGB Modalità 4 8 Musica
//Crea un delay non bloccante per regolare la velocità Animata degli RGB Modalità 5 9 Discontinuo
//Crea un delay non bloccante per regolare la velocità Animata Avvio Arduino 10
//Crea un delay non bloccante per calcolare gli RPM delle varie ventole 11
//Crea un delay non bloccante per l'auto reset dello stato delle protezioni 12
//Crea un delay non bloccante per regolare la velocità Animata degli RGB Modalità 6 13 Mix_Festività
//
//                                0  1
unsigned long TimerVirtuale[] = { 0, 0 };
//                                     0  1  2  3  4  5  6  7  8  9  10 11 12 13
unsigned long ResetTimerVirtuale[] = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
//                       0   1    2     3    4   5  6    7   8   9  10   11   12  13
int DelayVirtuale[] = { 40, 40, 1000, 1000, 40, 10, 20, 200, 2, 70, 50, 1000, 40, 15 };
//
//------------------------------------- Seriale di avvio
//
byte Boot_SetUp;                  // Collegamento seriale
byte DelayLoopPrimario_ON = 40;   //Delay Seriale Connesso
byte DelayLoopPrimario_OFF = 80;  //Delay Seriale non Connesso
//------------------- Verifica collegamento Seriale
//
//int USB_Serial_Connessione = 0;
//int USB_Serial_Ricevuto = 0;
//unsigned long VerificaUSB;
//unsigned long VerificaUSB_;
//------------------- Esecuzione animazione all'avvio
//
bool Aniamzione_Avvio;
int x;
//-------------------------------------
//
//bool OfflineLED_Fan = 0;  // 0 = False / 1 = True
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
byte FanSpeed[] = { 127, 127, 127, 127, 127 };
//-------------------
//                       0  1  2  3  4  5  6   /0 = Fan_All / 1 = Fan_1 / 2 = Fan_2 / 3 = Fan_3 / 4 = Fan_4 / 5 = Fan_5 / 6 = Fan_6 // Imposta la Modalita Automatica della ventola
byte Fan_Mod_Speed[] = { 0, 0, 0, 0, 0, 0, 0 };
//-------------------
//
//------------------------------------- Imposta tutte le risorse per i LED A-RGB WS12
//Imposta i PIN di collegamento dei LED e setta il nummero dei LED
#include <Adafruit_NeoPixel.h>
//-------------------
//Striscia LED PIN Connessione
#define DATA_PIN_1 7  //PIN led Serie Ventole Fan / GPU
#define DATA_PIN_2 8  //PIN led Serie Ventole Striscia LED

//#define DATA_PIN_3         4  //PIN led Serie Ventole Fan 3
//#define DATA_PIN_4        A5  //PIN led Serie Ventole Fan 4
//#define DATA_PIN_5        A3  //PIN led Serie Dissipatore 120mm
//#define DATA_PIN_6        A2  //PIN led Serie Dissipatore 120mm
//#define DATA_PIN_7        A4  //PIN led Serie Dissipatore 120mm
//#define DATA_PIN_8        A1  //PIN led Serie STRIP
//#define DATA_PIN_9        A0  //PIN led Serie GPU

//-------------------
#define NUM_LEDS_ALL (NUM_LEDS_OUT_1 + NUM_LEDS_OUT_2 + NUM_LEDS_OUT_3 + NUM_LEDS_OUT_4 + NUM_LEDS_OUT_5 + NUM_LEDS_OUT_6 + NUM_LEDS_OUT_7 + NUM_LEDS_OUT_8)  //Numero led Totale
#define NUM_LEDS_OUT_1 22                                                                                                                                     //Numero led Serie Ventole Fan 1
#define NUM_LEDS_OUT_2 22                                                                                                                                     //Numero led Serie Ventole Fan 2
#define NUM_LEDS_OUT_3 22                                                                                                                                     //Numero led Serie Ventole Fan 3
#define NUM_LEDS_OUT_4 22                                                                                                                                     //Numero led Serie Ventole Fan 4

#define NUM_LEDS_OUT_5 0  //Numero led Serie Dissipatore 120mm
#define NUM_LEDS_OUT_6 0  //Numero led Serie Dissipatore 120mm
#define NUM_LEDS_OUT_7 0  //Numero led Serie Dissipatore 120mm

#define NUM_LEDS_OUT_8 30  //Numero led Serie GPU

#define NUM_LEDS_OUT_9 30  //Numero led Serie Striscia a LED

//Gestione Animazioni Sincroizzate
#define NUM_LEDS_OUT_All (NUM_LEDS_ALL + NUM_LEDS_OUT_9)
#define NUM_LEDS_Fan_0_1 (NUM_LEDS_OUT_1)
#define NUM_LEDS_Fan_1_2 (NUM_LEDS_OUT_1 + NUM_LEDS_OUT_2)
#define NUM_LEDS_Fan_2_3 (NUM_LEDS_OUT_1 + NUM_LEDS_OUT_2 + NUM_LEDS_OUT_3)
#define NUM_LEDS_Fan_3_4 (NUM_LEDS_OUT_1 + NUM_LEDS_OUT_2 + NUM_LEDS_OUT_3 + NUM_LEDS_OUT_4)
//#define NUM_LEDS_OUT_4_5 (NUM_LEDS_OUT_1 + NUM_LEDS_OUT_2 + NUM_LEDS_OUT_3 + NUM_LEDS_OUT_4 + NUM_LEDS_OUT_5)
//#define NUM_LEDS_OUT_5_6 (NUM_LEDS_OUT_1 + NUM_LEDS_OUT_2 + NUM_LEDS_OUT_3 + NUM_LEDS_OUT_4 + NUM_LEDS_OUT_5 + NUM_LEDS_OUT_6)
//#define NUM_LEDS_OUT_6_7 (NUM_LEDS_OUT_1 + NUM_LEDS_OUT_2 + NUM_LEDS_OUT_3 + NUM_LEDS_OUT_4 + NUM_LEDS_OUT_5 + NUM_LEDS_OUT_6 + NUM_LEDS_OUT_7)
#define NUM_LEDS_OUT_7_8 (NUM_LEDS_OUT_1 + NUM_LEDS_OUT_2 + NUM_LEDS_OUT_3 + NUM_LEDS_OUT_4 + NUM_LEDS_OUT_8)
#define NUM_LEDS_OUT_8_9 (NUM_LEDS_OUT_1 + NUM_LEDS_OUT_2 + NUM_LEDS_OUT_3 + NUM_LEDS_OUT_4 + NUM_LEDS_OUT_8 + NUM_LEDS_OUT_9)

//
Adafruit_NeoPixel Strip1 = Adafruit_NeoPixel(NUM_LEDS_ALL, DATA_PIN_1, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel Strip2 = Adafruit_NeoPixel(NUM_LEDS_OUT_9, DATA_PIN_2, NEO_GRB + NEO_KHZ800);

//Adafruit_NeoPixel Strip3 = Adafruit_NeoPixel(NUM_LEDS_OUT_1, DATA_PIN_3, NEO_GRB + NEO_KHZ800);
//Adafruit_NeoPixel Strip4 = Adafruit_NeoPixel(NUM_LEDS_OUT_1, DATA_PIN_4, NEO_GRB + NEO_KHZ800);
//
//Adafruit_NeoPixel Strip5 = Adafruit_NeoPixel(NUM_LEDS_OUT_5, DATA_PIN_5, NEO_GRB + NEO_KHZ800);
//Adafruit_NeoPixel Strip6 = Adafruit_NeoPixel(NUM_LEDS_OUT_6, DATA_PIN_6, NEO_GRB + NEO_KHZ800);
//Adafruit_NeoPixel Strip7 = Adafruit_NeoPixel(NUM_LEDS_OUT_7, DATA_PIN_7, NEO_GRB + NEO_KHZ800);
//
//Adafruit_NeoPixel Strip8 = Adafruit_NeoPixel(NUM_LEDS_OUT_8, DATA_PIN_8, NEO_GRB + NEO_KHZ800);
//Adafruit_NeoPixel Strip9 = Adafruit_NeoPixel(NUM_LEDS_OUT_9, DATA_PIN_9, NEO_GRB + NEO_KHZ800);

//-------------------------------------
