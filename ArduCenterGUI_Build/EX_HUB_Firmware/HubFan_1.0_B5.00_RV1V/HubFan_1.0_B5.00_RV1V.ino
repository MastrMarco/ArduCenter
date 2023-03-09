//*****************************************************************************************************************************//
//------------------          By  MastrMarco    Versione 5.00        ISCRIVITI AL CANALE YOUTUBE       ------------------------//
//
//                                  https://www.youtube.com/channel/UCpQb1Iz6M229ylkyXpdJPlw
//*****************************************************************************************************************************//
//------------------------------------- Memorizza i Dati impostati dal utente
//Memorizza i dati impostati sulla EEPROM
#include<EEPROM.h>
//                            0  1  2  3   4   5   6   7   8   9  10  11  12  13  14  15  16  17  18  19  20  21  22  23  24
uint8_t EEPROMaddress [26] = {6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30};
int ROM_Dati = 0;
int Ripristino = 0;
//------------------------------------- Timper Viruale (Delay)
//Crea un delay non bloccante per evitare errori nell'invio dei dati al PC tramite Seriale TX 0
//Crea un delay non bloccante per evitare errori nell'invio dei dati al PC tramite Seriale RX 1
//Crea un delay non bloccante per evitare errori nell'invio dei dati al PC tramite Seriale Tensione 2
//Crea un delay non bloccante per evitare errori nell'invio dei dati al PC tramite Seriale Temperatura 3
//Crea un delay non bloccante per evitare errori quando vengono impostati i vari valori per i LED 4
//Crea un delay non bloccante per regolare la velocità Animata degli RGB Modalità 1 5
//Crea un delay non bloccante per regolare la velocità Animata degli RGB Modalità 2 6
//Crea un delay non bloccante per regolare la velocità Animata degli RGB Modalità 3 7
//Crea un delay non bloccante per regolare la velocità Animata degli RGB Modalità 4 8
unsigned long TimerVirtuale [10] =         {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
unsigned long ResetTimerVirtuale [10] =    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
int DelayVirtuale [10] =                   {40, 40, 1000, 1000, 10, 80, 1, 80, 2};
//-------------------------------------
int USB_Serial_Connessione = 0;
int USB_Serial_Ricevuto = 0;
unsigned long VerificaUSB;
unsigned long VerificaUSB_;
//------------------------------------- Dati Che verranno inviati tramite seriale
//DataTX
const int Compatibile = 2;    // 0 Verifica compatibilità tra il software e Arduino
const String Info = "01";     // 1 Informa il software di che tipo di Arduino è
const float Ver = 5.00;       // 4 Indica al software che versione del firmware ha Arduino
const int Progettro = 2;      // 5 Indica al software che tipo di progetto è

uint8_t BRIGHTNESS = 100;         // 3 Imposta ed invia la conferma della luminosità scelta

//------------------------------------- Dati che verranno ricevuti tramite seriale
//
int OfflineLED_Fan = 0;

int ModLED_Fan           = 1;
int ColorModLED_Fan_All  = 7;
int ColorModLED_Fan_1    = 7;
int ColorModLED_Fan_2    = 7;
int ColorModLED_Fan_3    = 7;
//int ColorModLED_Fan_4    = 7;
//int ColorModLED_GPU      = 7;
int RGB_Mod_Fan_All      = 0;

//int ColorModLED_StripLED = 7;

//Modalità 1 = Effetto Ciclo Discontinuo //Modalità 2 = RGB Transizione //Modalità 3 = Effetto RainBow

int ModSpeed_Fan = 1;
int FanSpeed_All = 100;
int FanSpeed_1   = 100;
int FanSpeed_2   = 100;
int FanSpeed_3   = 100;
//int FanSpeed_4   = 100;
//int FanSpeed_5   = 0;
//int FanSpeed_6   = 0;

int ModStato_Fan      = 1;
int StatoFan_Mod_All  = 1;
int StatoFan_Mod_Fan1 = 0;
int StatoFan_Mod_Fan2 = 0;
int StatoFan_Mod_Fan3 = 0;
//int StatoFan_Mod_Fan4 = 0;
//int StatoFan_Mod_Fan5 = 0;
//int StatoFan_Mod_Fan6 = 0;
//----------------------------------------------------------------------
int speedFan = 1;                        //Dati ricevuti conversi da 1000-1255 a 0 - 255 Fan_Speed
#define PWM_Fan_1 5                      //PWM_Fan1
#define PWM_Fan_2 10                     //PWM_Fan2
#define PWM_Fan_3 6                      //PWM_Fan3
//------------------------------------- Imposta tutte le risorse per i LED A-RGB WS12
//Imposta i PIN di collegamento dei LED e setta il nummero dei LED
#include <FastLED.h>                        //Libreria FastLed per gestire i LED A-RGB
int PowerLimitLED;
int PowerLimitLED_Stato;
//-------------------
#define DATA_PIN_Fan    2                   //Striscia LED PIN Connessione Ventole
//-------------------
#define NUM_LEDS_Fan  66   //Numero led Serie Ventole
uint8_t NumeroLED_Fan_1 = 22;
uint8_t NumeroLED_Fan_2 = 22;
uint8_t NumeroLED_Fan_3 = 22;

//-------------------
CRGB ledsFan[NUM_LEDS_Fan];
CRGBSet ledsFan_1(ledsFan + 0, NumeroLED_Fan_1);
CRGBSet ledsFan_2(ledsFan +    NumeroLED_Fan_1, + NumeroLED_Fan_2);
CRGBSet ledsFan_3(ledsFan +    NumeroLED_Fan_1, + NumeroLED_Fan_2,  NumeroLED_Fan_3);

//----------------------------------------------------------------------
//Modalità Animazione RGB
//int RGBMOD;      //Modalità 1 = Effetto Ciclo Discontinuo //Modalità 2 = RGB Transizione //Modalità 3 = Effetto RainBow
//----------------------------------------------------------------------
//-------------------------------------
//Modalità Animazione RGB 1 Visualizer Musica Analogico
//**//
// AUDIO INPUT
//#define Audio A5  //Pin Analogico di acquisizione
//int StatoAudio = 1;
int AudioDigital;
// STANDARD VISUALIZER VARIABLE
int k = 255;
int FrequenzaAggiornamento = 3; //Frequenza di aggornamento
int decay_check = 0;
long pre_react = 0;
long react = 0;
long Pre_Dmusic_Fan = 0;
long Dmusic_Fan = 0;
int wheel_speed = 1;
//-------------------------------------
//Modalità Animazione RGB 2 Effetto RainBow
//int j_Audio = 0;
int j_Fan = 0;
//-------------------------------------
// Modalità 3 = RGB Transizione
CRGBPalette16 currentPalette;
TBlendType    currentBlending;
extern CRGBPalette16 myRedWhiteBluePalette;
extern const TProgmemPalette16 myRedWhiteBluePalette_p PROGMEM;
//-------------------------------------
// Modalità 4 = RGB Discontinuo
#define ARRAY_SIZE(A) (sizeof(A) / sizeof((A)[0]))
int leds_done = 0;
uint16_t i = 0;
CHSV red ( 0, 255, 255);
CHSV green ( 95, 255, 255);
CHSV blue ( 160, 255, 255);
CHSV cyan ( 127, 255, 255);
CHSV magenta ( 210, 255, 255);
CHSV yellow ( 45, 255, 255);
CHSV white ( 100, 0, 255);
CHSV CHSV_array[] = {red, green, blue, cyan, magenta, yellow, white};
CRGB Array_color = CHSV_array[0];
uint8_t Array_Size = ARRAY_SIZE(CHSV_array);
//----------------------------------------------------------------------
//
int PrecisioneDecimale = 1;
int TermoresistenzaPin = A0;             //Temperatura_NTC
float PartitoreTensioneR2 = 20000;
float BValue = 3470;
float R1 = 1000;
float T1 = 298.15;
float R2 ;
float T2 ;
float a ;
float b ;
float c ;
float d ;
float e = 2.718281828 ;
float tempSampleRead  = 0;
float tempSampleSum   = 0;
float tempMean ;
float tempLastSample  = 0;
float tempSampleCount = 0;
int DigitalTemp = 0;
//--------------- ******************************************************************************************* -----------------//
//Imposta all'avvio di Arduino
void setup() {
  //----------------------
  //Apertura Seriale
  //Serial.begin(9600);
  Serial.begin(115200);
  while (!Serial)continue;
  //----------------------

  //----------------------
  //ROM_Dati = 0;
  ROM_Dati = EEPROM.read(EEPROMaddress[0]);
  PowerLimitLED = EEPROM.read(EEPROMaddress[1]);

  if (ROM_Dati == 1) {
    //EN_OV = EEPROM.read(EEPROMaddress[2]);
    BRIGHTNESS = EEPROM.read(EEPROMaddress[3]);

    ModLED_Fan = EEPROM.read(EEPROMaddress[4]);
    ColorModLED_Fan_All = EEPROM.read(EEPROMaddress[5]);
    ColorModLED_Fan_1 = EEPROM.read(EEPROMaddress[6]);
    ColorModLED_Fan_2 = EEPROM.read(EEPROMaddress[7]);
    ColorModLED_Fan_3 = EEPROM.read(EEPROMaddress[8]);
    //ColorModLED_Fan_4 = EEPROM.read(EEPROMaddress[9]);
    //ColorModLED_GPU = EEPROM.read(EEPROMaddress[10]);
    //ColorModLED_StripLED = EEPROM.read(EEPROMaddress[11]);

    FanSpeed_All = EEPROM.read(EEPROMaddress[12]);
    FanSpeed_1 = EEPROM.read(EEPROMaddress[13]);
    FanSpeed_2 = EEPROM.read(EEPROMaddress[14]);
    FanSpeed_3 = EEPROM.read(EEPROMaddress[15]);
    //FanSpeed_4 = EEPROM.read(EEPROMaddress[16]);

    StatoFan_Mod_All = EEPROM.read(EEPROMaddress[18]);
    //ColorModLED_Audio [2] = EEPROM.read(EEPROMaddress[4]);

    //StatoAudio = EEPROM.read(EEPROMaddress[30]);

  }
  //----------------------
  //Imposta è configura i PIN di Arduino
  pinMode(13, OUTPUT);
  pinMode(TermoresistenzaPin, INPUT);
  //-------------------
  //Reset dei LED e configurazione
  FastLED.addLeds<NEOPIXEL, DATA_PIN_Fan>(ledsFan, 0, NUM_LEDS_Fan);
  FastLED.setBrightness( BRIGHTNESS );
  if (PowerLimitLED == 1) {
    FastLED.setMaxPowerInVoltsAndMilliamps(5, 1000); // sets voltage and upper amperage level
    set_max_power_indicator_LED(13);
  }
  FastLED.clear();
  FastLED.show();
  //-------------------
  //TCCR2B = TCCR2B & B11111000 | B00000001; // for PWM frequency of 31372.55 Hz D3 D11
  //pinMode(PWM_Fan_6, OUTPUT);              // Modalità Pin PWM Fan1
  //pinMode(PWM_Fan_5, OUTPUT);              // Modalità Pin PWM Fan4
  //
  //TCCR1B = TCCR1B & B11111000 | B00000001; // for PWM frequency of 31372.55 Hz D9 D10
  //pinMode(PWM_Fan_4, OUTPUT);              // Modalità Pin PWM Fan2
  pinMode(PWM_Fan_2, OUTPUT);              // Modalità Pin PWM Fan3
  //*
  //TCCR0B = TCCR0B & B11111000 | B00000001; // for PWM frequency of 62500.00 Hz D5 D6
  pinMode(PWM_Fan_1, OUTPUT);              // Modalità Pin PWM Fan5 *
  pinMode(PWM_Fan_3, OUTPUT);
  //-------------------
  //Modalità 3 = RGB Transizione preimposta i valori
  currentPalette = RainbowColors_p;
  currentBlending = LINEARBLEND;
  //-------------------
}



//Configurazione Visualizer Animazione RGB rainbow
CRGB Scroll(int pos) {
  CRGB color (0, 0, 0);
  if (pos < 85) {
    color.g = 0;
    color.r = ((float)pos / 85.0f) * 255.0f;
    color.b = 255 - color.r;
  } else if (pos < 170) {
    color.g = ((float)(pos - 85) / 85.0f) * 255.0f;
    color.r = 255 - color.g;
    color.b = 0;
  } else if (pos < 256) {
    color.b = ((float)(pos - 170) / 85.0f) * 255.0f;
    color.g = 255 - color.b;
    color.r = 1;
  }
  return color;
}

//--------------- ******************************************************************************************* -----------------//
int Aniamzione_Avvio = 0;
int x = 0;

void loop() {
  //----------------------------------------------------------------------
  if (digitalRead(13) == HIGH) {
    PowerLimitLED_Stato = 1;
  } else {
    PowerLimitLED_Stato = 0;
  }
  //----------------------------------------------------------------------
  TimerVirtuale [0] = millis();    //Avvia il Delay non bloccante per evitare errori nell'invio dei dati al PC tramite Seriale TX 0
  TimerVirtuale [1] = millis();    //Avvia il Delay non bloccante per evitare errori nell'Ricevere dei dati al PC tramite Seriale RX 1
  TimerVirtuale [2] = millis();    //Avvia il Delay non bloccante per regolare la velocità di in vio dati Temperatura 2
  TimerVirtuale [3] = millis();    //Avvia il Delay non bloccante per regolare la velocità di in vio dati Temperatura 3
  TimerVirtuale [4] = millis();    //Avvia il Delay non bloccante per il corretto caricamento dei LED e delle Funzioni 4
  TimerVirtuale [5] = millis();    //Avvia il Delay non bloccante per regolare la velocità Animata degli RGB M1 5
  TimerVirtuale [6] = millis();    //Avvia il Delay non bloccante per regolare la velocità Animata degli RGB M2 6
  TimerVirtuale [7] = millis();    //Avvia il Delay non bloccante per regolare la velocità Animata degli RGB M3 7
  TimerVirtuale [8] = millis();    //Avvia il Delay non bloccante per regolare la velocità Animata degli RGB M4 8
  //----------------------------------------------------------------------
  if (Aniamzione_Avvio == 1) {
    Void_LED_Mod();   //Inizializza il loop dove ci sono tutte le modalità LED
    AnimazioniRGB();  //Loop Animazioni RGB
  }
  TemperaturaEsterna(); //Lettura srnsore Temperatura
  //-------------------------------------
  //Funzione Delay per l'invio dei dati al PC tramite Seriale
  if (TimerVirtuale [0] >= (ResetTimerVirtuale [0] + DelayVirtuale [0])) {
    ResetTimerVirtuale [0] = TimerVirtuale [0];
    //----------------------
    //AnimazioneAVVIO
    if (Aniamzione_Avvio == 0) {
      ledsFan[x].setRGB(255, 40, 0);
      FastLED.show();
      if (++x >= NUM_LEDS_Fan) Aniamzione_Avvio = 1;
    }
    //----------------------
    //Invio dei dati al PC tramite Seriale

    //                        (0)             (1)          (2)            (3)
    Serial.println((String) Compatibile + "," + Info + "," + Ver + "," + Progettro + ";"                                                                                                             //0 Tipo di proggetto 1= AudioHub1.0    2= SmartFanHub1.0    3= SmartFanHub2.0_AudioHub2.0
                   //    (0)                      (1)                   (2)            (3)                   (4)            (5)                (6)
                   + DigitalTemp + "," + PowerLimitLED_Stato + "," + Ripristino + ";"                                                                                                                //1
                   //  (0)                 (1)               (2)
                   + ROM_Dati + "," + PowerLimitLED + ";"                                                                                                                                            //2
                   //    (0)                   (1)                    (2)                     (3)                       (4)                      (5)                 (6)
                   + NUM_LEDS_Fan + "," + NumeroLED_Fan_1 + "," + NumeroLED_Fan_2 + "," + NumeroLED_Fan_3 + ";"                                                                                      //3
                   //
                   + BRIGHTNESS + ";"                                                                                                                                                                //4 Luminosità
                   //      (0)                      (1)                    (2)                       (3)                         (4)
                   + DelayVirtuale[5] + "," + DelayVirtuale[6] + "," + DelayVirtuale[7] + "," + DelayVirtuale[8] + "," + FrequenzaAggiornamento + ";"                                                //5 DelayRGB                                                                                                                                                  //5 Delay Effeti RGB
                   //   (0)                  (1)                          (2)                     (3)                         (4)                       (5)                      (6)                      (7)
                   + ModLED_Fan + "," + ColorModLED_Fan_All + "," + ColorModLED_Fan_1 + "," + ColorModLED_Fan_2 + "," + ColorModLED_Fan_3 + ";"// + ColorModLED_Fan_4 + "," + ColorModLED_GPU + "," + ColorModLED_StripLED + ";"    //6
                   //    (0)                 (1)                (2)                 (3)                  (4)                (5)                  (6)                 (7)
                   + ModSpeed_Fan + "," + FanSpeed_All + "," + FanSpeed_1 + ","  + FanSpeed_2 + ","  + FanSpeed_3 + ";" // + FanSpeed_4 + ","  + FanSpeed_5 + ","  + FanSpeed_6 + ";"                                               //7 Velocità Rotazione Ventole
                   //    (0)                     (1)                       (2)                       (3)                      (4)                       (5)                       (6)                (7)
                   + ModStato_Fan + "," + StatoFan_Mod_All + "," + StatoFan_Mod_Fan1 + "," + StatoFan_Mod_Fan2 + "," + StatoFan_Mod_Fan3 + ";");//+ StatoFan_Mod_Fan4 + "," + StatoFan_Mod_Fan5 + "," + StatoFan_Mod_Fan6 + ";");    //8 Modalita Adatamento velocità Ventola
    //     (0)                      (1)                       (2)                         (3)
    //+ NUM_LEDS_Audio + "," + NumeroLED_Audio_CS + "," + NumeroLED_Audio_CD + "," + NumeroLED_Audio_ES + ";"                                                                                                                     //9 Modalita LED
    //     (0)                        (1)                          (2)                         (3)                          (4)
    //+ ModLED_Audio + "," + ColorModLED_Audio_All + "," + ColorModLED_Audio_CS + "," + ColorModLED_Audio_CD + "," + ColorModLED_Audio_ES + ";");                                                                                 //10
  }
  //----------------------------------------------------------------------
  //
  if (TimerVirtuale [1] >= (ResetTimerVirtuale [1] + DelayVirtuale [1])) {
    ResetTimerVirtuale [1] = TimerVirtuale [1];
    //
    if (USB_Serial_Connessione == 0 and VerificaUSB <= 50) {
      USB_Serial_Connessione = 1;
      VerificaUSB++;
    }
    if (USB_Serial_Connessione == 1 and VerificaUSB <= 50) {
      VerificaUSB++;
    }
    //
    if (USB_Serial_Ricevuto == 1 and VerificaUSB <= 50) {
      USB_Serial_Connessione = 0;
      VerificaUSB++;
    }
    //
    if (VerificaUSB >= 50) {

      if (ModLED_Fan == 1 and StatoFan_Mod_All > 1) {
        StatoFan_Mod_All = 2;
      }

      OfflineLED_Fan = 1;
      if (StatoFan_Mod_All != 1) StatoFan_Mod_All = 2;
      FastLED.setBrightness( BRIGHTNESS );
      FastLED.show();
    }
  }
  //-------------------------------------
  //Funzione ricezione dati dal PC (quando riceve dei dati tramite la Seriale avvia il loop DatiRX)
  if (Serial.available()) {

    USB_Serial_Ricevuto = USB_Serial_Connessione;
    VerificaUSB = 0;

    String SerialRX = Serial.readStringUntil('\n');

    if (SerialRX.length() > 0) {
      //Serial.println(SerialRX);
      int m = 0;
      int n = SerialRX.indexOf(";");
      int indice = 0;
      while (n > 0) {
        String token = SerialRX.substring(n, m);
        //Serial.println(token);
        m = n + 1;
        n = SerialRX.indexOf(";", n + 1);

        //elaboro il token:
        DatiRXloop(indice, token);
        indice++;
      }
      //applico i risultati
      OfflineLED_Fan = 0;
      VerificaUSB = 0;
      FastLED.setBrightness( BRIGHTNESS );
      FastLED.show();
    }
  }
}
//--------------- ******************************************************************************************* -----------------//
//Avvio Sistema di lettura dati in arrivo dalla Seriale
void DatiRXloop(int i, String DatoRX) {
  switch (i) {
    case 0:
      if ((ROM_Dati != DatoRX.toInt()) and (DatoRX.toInt() < 2) and (Ripristino == 0)) {
        ROM_Dati = DatoRX.toInt();
        EEPROM.write(EEPROMaddress[0], DatoRX.toInt());
      }
      break;
    case 1:
      if ((PowerLimitLED != DatoRX.toInt()) and (DatoRX.toInt() >= 0) and (DatoRX.toInt() <= 1) and (Ripristino == 0)) {
        PowerLimitLED = DatoRX.toInt();
        EEPROM.write(EEPROMaddress[1], DatoRX.toInt());
      }
      break;
    case 2:
      //      if ((EN_OV != DatoRX.toInt()) and (DatoRX.toInt() >= 0) and (DatoRX.toInt() <= 1) and (Ripristino == 0)) {
      //        EN_OV = DatoRX.toInt();
      //        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[2], DatoRX.toInt());
      //  }
      break;
    case 3:
      if (DatoRX.toInt() == 1 and DatoRX.toInt() != 0) {
        Ripristino = 1;

        EEPROM.write(EEPROMaddress[0],       0);  //ROM_Dati
        ROM_Dati = 1;
        EEPROM.write(EEPROMaddress[1],       0);  //PowerLimitLED
        PowerLimitLED = 0;
        //EEPROM.write(EEPROMaddress[2],       1);  //EN_OV
        //EN_OV = 1;
        EEPROM.write(EEPROMaddress[3],       100);//BRIGHTNESS
        BRIGHTNESS = 100;
        EEPROM.write(EEPROMaddress[4],       1);  //ModLED_Fan
        ModLED_Fan = 1;
        EEPROM.write(EEPROMaddress[5],       7);  //ColorModLED_Fan_All
        ColorModLED_Fan_All = 7;
        EEPROM.write(EEPROMaddress[6],       7);  //ColorModLED_Fan_1
        ColorModLED_Fan_1 = 7;
        EEPROM.write(EEPROMaddress[7],       7);  //ColorModLED_Fan_2
        ColorModLED_Fan_2 = 7;
        EEPROM.write(EEPROMaddress[8],       7);  //ColorModLED_Fan_3
        ColorModLED_Fan_3 = 7;
        //EEPROM.write(EEPROMaddress[9],       7);  //ColorModLED_Fan_4
        //ColorModLED_Fan_4 = 7;
        //EEPROM.write(EEPROMaddress[10],      7);  //ColorModLED_GPU
        //ColorModLED_GPU = 7;
        //EEPROM.write(EEPROMaddress[11],      7);  //ColorModLED_StripLED
        //ColorModLED_StripLED = 7;
        EEPROM.write(EEPROMaddress[12],      100);//FanSpeed_All
        FanSpeed_All = 100;
        EEPROM.write(EEPROMaddress[13],      100);//FanSpeed_1
        FanSpeed_1 = 100;
        EEPROM.write(EEPROMaddress[14],      100);//FanSpeed_2
        FanSpeed_2 = 100;
        EEPROM.write(EEPROMaddress[15],      100);//FanSpeed_3
        FanSpeed_3 = 100;
        EEPROM.write(EEPROMaddress[16],      100);//FanSpeed_4
        //FanSpeed_4 = 100;
        //EEPROM.write(EEPROMaddress[18],      1);  //StatoFan_Mod_All
        StatoFan_Mod_All = 1;
        //EEPROM.write(EEPROMaddress[4]);           //ColorModLED_Audio
        //EEPROM.write(EEPROMaddress[30],      1);  //StatoAudio
        //StatoAudio = 1;

      }
      else {
        Ripristino = 0;
      }
      break;
    case 4:

      break;
    case 5:

      break;
    case 6:
      AudioDigital = DatoRX.toInt();
      break;
    case 7:
      if ((BRIGHTNESS != DatoRX.toInt()) and (DatoRX.toInt() > 4) and (DatoRX.toInt() < 256) and (Ripristino == 0)) {
        BRIGHTNESS = DatoRX.toInt();
        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[3], DatoRX.toInt());
      }
      break;
    case 8:
      if ((ModLED_Fan != DatoRX.toInt()) and (DatoRX.toInt() > 0) and (DatoRX.toInt() < 8) and (Ripristino == 0)) {
        ModLED_Fan = DatoRX.toInt();
        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[4], DatoRX.toInt());
      }
      //      else if (DatoRX.toInt() == 0) {
      //        ColorModLED_Fan_All = DatoRX.toInt();
      //        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[5], DatoRX.toInt());  //Memorizza il valore nella cella 0 della EEPROM
      //        ColorModLED_Fan_1 = DatoRX.toInt();
      //        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[6], DatoRX.toInt());  //Memorizza il valore nella cella 0 della EEPROM
      //        ColorModLED_Fan_2 = DatoRX.toInt();
      //        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[7], DatoRX.toInt());  //Memorizza il valore nella cella 0 della EEPROM
      //        ColorModLED_Fan_3 = DatoRX.toInt();
      //        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[8], DatoRX.toInt());  //Memorizza il valore nella cella 0 della EEPROM
      //        ColorModLED_Fan_4 = DatoRX.toInt();
      //        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[9], DatoRX.toInt());  //Memorizza il valore nella cella 0 della EEPROM
      //        ColorModLED_GPU = DatoRX.toInt();
      //        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[10], DatoRX.toInt());  //Memorizza il valore nella cella 0 della EEPROM
      //      }
      break;
    case 9:
      if ((ModLED_Fan == 1) and (ColorModLED_Fan_All != DatoRX.toInt()) and (DatoRX.toInt() > 0) and (DatoRX.toInt() < 14) and (Ripristino == 0)) {
        ColorModLED_Fan_All = DatoRX.toInt();
        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[5], DatoRX.toInt());  //Memorizza il valore nella cella 0 della EEPROM
      }
      else if ((ModLED_Fan == 2) and (ColorModLED_Fan_1 != DatoRX.toInt()) and (DatoRX.toInt() > 0) and (DatoRX.toInt() < 10) and (Ripristino == 0)) {
        ColorModLED_Fan_1 = DatoRX.toInt();
        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[6], DatoRX.toInt());  //Memorizza il valore nella cella 0 della EEPROM
      }
      else if ((ModLED_Fan == 3) and (ColorModLED_Fan_2 != DatoRX.toInt()) and (DatoRX.toInt() > 0) and (DatoRX.toInt() < 10) and (Ripristino == 0)) {
        ColorModLED_Fan_2 = DatoRX.toInt();
        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[7], DatoRX.toInt());  //Memorizza il valore nella cella 0 della EEPROM
      }
      else if ((ModLED_Fan == 4) and (ColorModLED_Fan_3 != DatoRX.toInt()) and (DatoRX.toInt() > 0) and (DatoRX.toInt() < 10) and (Ripristino == 0)) {
        ColorModLED_Fan_3 = DatoRX.toInt();
        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[8], DatoRX.toInt());  //Memorizza il valore nella cella 0 della EEPROM
      }
      //      else if ((ModLED_Fan == 5) and (ColorModLED_Fan_4 != DatoRX.toInt()) and (DatoRX.toInt() > 0) and (DatoRX.toInt() < 10) and (Ripristino == 0)) {
      //        ColorModLED_Fan_4 = DatoRX.toInt();
      //        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[9], DatoRX.toInt());  //Memorizza il valore nella cella 0 della EEPROM
      //      }
      //      else if ((ModLED_Fan == 6) and (ColorModLED_GPU != DatoRX.toInt()) and (DatoRX.toInt() > 0) and (DatoRX.toInt() < 10) and (Ripristino == 0)) {
      //        ColorModLED_GPU = DatoRX.toInt();
      //        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[10], DatoRX.toInt());  //Memorizza il valore nella cella 0 della EEPROM
      //      }
      //      else if ((ModLED_Fan == 7) and (ColorModLED_StripLED != DatoRX.toInt()) and (DatoRX.toInt() > 0) and (DatoRX.toInt() < 10) and (Ripristino == 0)) {
      //        ColorModLED_StripLED = DatoRX.toInt();
      //        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[11], DatoRX.toInt());  //Memorizza il valore nella cella 0 della EEPROM
      //      }
      break;
    case 10:
      //      if ((ModLED_Fan == 1) and (ColorModLED_Fan_All == 10) and (ColorModLED_Fan_All != DatoRX.toInt())) {
      //        DelayVirtuale[5] = DatoRX.toInt();
      //      }
      //      else if ((ModLED_Fan == 1) and (ColorModLED_Fan_All == 11) and (ColorModLED_Fan_All != DatoRX.toInt())) {
      //        DelayVirtuale[6] = DatoRX.toInt();
      //      }
      //      else if ((ModLED_Fan == 1) and (ColorModLED_Fan_All == 12) and (ColorModLED_Fan_All != DatoRX.toInt())) {
      //        DelayVirtuale[7] = DatoRX.toInt();
      //      }
      //      else if ((ModLED_Fan == 1) and (ColorModLED_Fan_All == 13) and (ColorModLED_Fan_All != DatoRX.toInt()) and (DatoRX.toInt() > 10) and (DatoRX.toInt() <= 155)) {
      //        DelayVirtuale[8] = DatoRX.toInt();
      //      }
      //      else if ((ModLED_Fan == 1) and (ColorModLED_Fan_All == 13) and (ColorModLED_Fan_All != DatoRX.toInt()) and (DatoRX.toInt() >= 0) and (DatoRX.toInt() <= 10)) {
      //        FrequenzaAggiornamento = DatoRX.toInt();
      //      }
      //DelayVirtuale[8] + "," + FrequenzaAggiornamento + "
      break;
    case 11:
      if ((ModLED_Fan == 1) and (FanSpeed_All != DatoRX.toInt()) and (DatoRX.toInt() >= 0) and (DatoRX.toInt() < 256) and (Ripristino == 0)) {
        FanSpeed_All = DatoRX.toInt();
        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[12], DatoRX.toInt());
      }
      else if ((ModLED_Fan == 2) and (FanSpeed_1 != DatoRX.toInt()) and (DatoRX.toInt() >= 0) and (DatoRX.toInt() < 256) and (Ripristino == 0)) {
        FanSpeed_1 = DatoRX.toInt();
        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[13], DatoRX.toInt());
      }
      else if ((ModLED_Fan == 3) and (FanSpeed_2 != DatoRX.toInt()) and (DatoRX.toInt() >= 0) and (DatoRX.toInt() < 256) and (Ripristino == 0)) {
        FanSpeed_2 = DatoRX.toInt();
        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[14], DatoRX.toInt());
      }
      else if ((ModLED_Fan == 4) and (FanSpeed_3 != DatoRX.toInt()) and (DatoRX.toInt() >= 0) and (DatoRX.toInt() < 256) and (Ripristino == 0)) {
        FanSpeed_3 = DatoRX.toInt();
        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[15], DatoRX.toInt());
      }
      //      else if ((ModLED_Fan == 5) and (FanSpeed_4 != DatoRX.toInt()) and (DatoRX.toInt() >= 0) and (DatoRX.toInt() < 256) and (Ripristino == 0)) {
      //        FanSpeed_4 = DatoRX.toInt();
      //        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[16], DatoRX.toInt());
      //      }
      break;
    case 12:
      if ((StatoFan_Mod_All != DatoRX.toInt()) and (DatoRX.toInt() > 0) and (DatoRX.toInt() < 5) and (Ripristino == 0)) {
        StatoFan_Mod_All = DatoRX.toInt();
        if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[18], DatoRX.toInt());
      }
      break;
    case 13:

      break;
    case 14:
      //  if ((StatoAudio != DatoRX.toInt()) and (DatoRX.toInt() > 0) and (DatoRX.toInt() < 3) and (Ripristino == 0)) {
      //    StatoAudio = DatoRX.toInt();
      //    if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[30], DatoRX.toInt());
      //  }
      break;
    case 15:

      break;
    case 16:
      //if ((ColorModLED_Audio_All != DatoRX.toInt()) and (DatoRX.toInt() > 0) and (DatoRX.toInt() < 14) and (Ripristino == 0)) {
      //ColorModLED_Audio_All = DatoRX.toInt();
      //if (ROM_Dati == 1)EEPROM.write(EEPROMaddress[4], DatoRX.toInt());
      //}
      break;
  }
}
//--------------- ******************************************************************************************* -----------------//
//Avvio loop dove ci sono tutte le modalità LED
void Void_LED_Mod() {
  //----------------------------------------------------------------------
  //Funzione Delay per il corretto caricamento dei led e delle funzioni
  //if (TimerVirtuale [4] >= (ResetTimerVirtuale [4] + DelayVirtuale [4])) {
  //ResetTimerVirtuale [4] = TimerVirtuale [4];
  //----------------------------Controllo Speed Fan-----------------------
  //digitalWrite(PWM_Fan_6, HIGH);
  //digitalWrite(PWM_Fan_5, HIGH);

  //if (ModStato_Fan == 1) {
  //Imposta la modalità dei LED
  if ((StatoFan_Mod_All == 1 or StatoFan_Mod_All == 3 or StatoFan_Mod_All == 4) and (ModLED_Fan == 1)) {
    analogWrite(PWM_Fan_1, FanSpeed_All);
    analogWrite(PWM_Fan_2, FanSpeed_All);
    analogWrite(PWM_Fan_3, FanSpeed_All);
    //analogWrite(PWM_Fan_4, FanSpeed_All);
    //analogWrite(PWM_Fan_5, FanSpeed);
    //analogWrite(PWM_Fan_6, FanSpeed);
  }
  else if ((StatoFan_Mod_All == 2 and DigitalTemp < 31) and (ModLED_Fan == 1)) {
    analogWrite(PWM_Fan_1, 0);
    analogWrite(PWM_Fan_2, 0);
    analogWrite(PWM_Fan_3, 0);
    //analogWrite(PWM_Fan_4, 0);
  } if ((StatoFan_Mod_All == 2 and DigitalTemp > 32 and DigitalTemp < 35) and (ModLED_Fan == 1)) {
    analogWrite(PWM_Fan_1, 90);
    analogWrite(PWM_Fan_2, 90);
    analogWrite(PWM_Fan_3, 90);
    //analogWrite(PWM_Fan_4, 90);
  } if ((StatoFan_Mod_All == 2 and DigitalTemp > 36 and DigitalTemp < 40) and (ModLED_Fan == 1)) {
    analogWrite(PWM_Fan_1, 160);
    analogWrite(PWM_Fan_2, 160);
    analogWrite(PWM_Fan_3, 160);
    //analogWrite(PWM_Fan_4, 160);
  } if ((StatoFan_Mod_All == 2 and DigitalTemp > 41) and (ModLED_Fan == 1)) {
    analogWrite(PWM_Fan_1, 255);
    analogWrite(PWM_Fan_2, 255);
    analogWrite(PWM_Fan_3, 255);
    //analogWrite(PWM_Fan_4, 255);
  }

  if ((ModLED_Fan != 1)) { //and (StatoFan_Mod_All == 1)
    analogWrite(PWM_Fan_1, FanSpeed_1);
    analogWrite(PWM_Fan_2, FanSpeed_2);
    analogWrite(PWM_Fan_3, FanSpeed_3);
    //analogWrite(PWM_Fan_4, FanSpeed_4);
  }
  //----------------------------------------------------------------------
  //Imposta la modalità dei LED
  if ((ModLED_Fan == 1) or (ModLED_Fan == 1 and OfflineLED_Fan == 1)) {



    //Imposta la modalità dei LED
    if (ColorModLED_Fan_All == 1) {
      fill_solid(ledsFan, NUM_LEDS_Fan, CRGB(0, 0, 0));              //Modalità Spento
    }  if (ColorModLED_Fan_All == 2) {
      fill_solid(ledsFan, NUM_LEDS_Fan, CRGB(255, 255, 255));        //Modalità Bianco/Luce
    }  if (ColorModLED_Fan_All == 3) {
      fill_solid(ledsFan, NUM_LEDS_Fan, CRGB(255, 0, 0));            //Modalità Rosso
    }  if (ColorModLED_Fan_All == 4) {
      fill_solid(ledsFan, NUM_LEDS_Fan, CRGB(0, 255, 0));            //Modalità Verde
    }  if (ColorModLED_Fan_All == 5) {
      fill_solid(ledsFan, NUM_LEDS_Fan, CRGB(0, 0, 255));            //Modalità Blu
    }  if (ColorModLED_Fan_All == 6) {
      fill_solid(ledsFan, NUM_LEDS_Fan, CRGB(30, 155, 255));         //Modalità Azzurro
    }  if (ColorModLED_Fan_All == 7) {
      fill_solid(ledsFan, NUM_LEDS_Fan, CRGB(255, 40, 0));           //Modalità Arancio
    }  if (ColorModLED_Fan_All == 8) {
      fill_solid(ledsFan, NUM_LEDS_Fan, CRGB(255, 0, 255));          //Modalità Viola
    }  if (ColorModLED_Fan_All == 9) {
      fill_solid(ledsFan, NUM_LEDS_Fan, CRGB(255, 140, 0));          //Modalità Giallo
    }  if (ColorModLED_Fan_All == 10) {
      RGB_Mod_Fan_All = 1;                                               //Modalità 1 = RGB Effetto Ciclo Discontinuo
    }  if (ColorModLED_Fan_All == 11) {
      RGB_Mod_Fan_All = 2;                                               //Modalità 2 = RGB Effetto Transizione*
    } if (ColorModLED_Fan_All == 12) {
      RGB_Mod_Fan_All = 3;                                               //Modalità 3 = RGB Effetto RainBow*
    } if (ColorModLED_Fan_All == 13) {
      RGB_Mod_Fan_All = 4;                                               //Modalità 4 = Effetto Music*
    }
    if ((ColorModLED_Fan_All < 10) or (ColorModLED_Fan_All > 13)) {
      RGB_Mod_Fan_All = 0;                                               //Modalità 0 = Reset Animazioni RGB
    }
  }

  if (ModLED_Fan > 1) {
    RGB_Mod_Fan_All = 0;
  }

  if ((ModLED_Fan > 1) or (ModLED_Fan == 2 and OfflineLED_Fan == 1)) {
    //Fan1
    if (ColorModLED_Fan_1 == 1 ) {
      fill_solid(ledsFan_1, NumeroLED_Fan_1, CRGB(0, 0, 0));              //Modalità Spento
    }  if (ColorModLED_Fan_1 == 2) {
      fill_solid(ledsFan_1, NumeroLED_Fan_1, CRGB(255, 255, 255));        //Modalità Bianco/Luce
    }  if (ColorModLED_Fan_1 == 3) {
      fill_solid(ledsFan_1, NumeroLED_Fan_1, CRGB(255, 0, 0));            //Modalità Rosso
    }  if (ColorModLED_Fan_1 == 4) {
      fill_solid(ledsFan_1, NumeroLED_Fan_1, CRGB(0, 255, 0));            //Modalità Verde
    }  if (ColorModLED_Fan_1 == 5) {
      fill_solid(ledsFan_1, NumeroLED_Fan_1, CRGB(0, 0, 255));            //Modalità Blu
    }  if (ColorModLED_Fan_1 == 6) {
      fill_solid(ledsFan_1, NumeroLED_Fan_1, CRGB(30, 155, 255));         //Modalità Azzurro
    }  if (ColorModLED_Fan_1 == 7) {
      fill_solid(ledsFan_1, NumeroLED_Fan_1, CRGB(255, 40, 0));           //Modalità Arancio
    }  if (ColorModLED_Fan_1 == 8) {
      fill_solid(ledsFan_1, NumeroLED_Fan_1, CRGB(255, 0, 255));          //Modalità Viola
    }  if (ColorModLED_Fan_1 == 9) {
      fill_solid(ledsFan_1, NumeroLED_Fan_1, CRGB(255, 140, 0));          //Modalità Giallo
    }
  }

  if ((ModLED_Fan > 1) or (ModLED_Fan == 3 and OfflineLED_Fan == 1)) {
    //Fan2
    if (ColorModLED_Fan_2 == 1 ) {
      fill_solid(ledsFan_2, NumeroLED_Fan_2, CRGB(0, 0, 0));              //Modalità Spento
    }  if (ColorModLED_Fan_2 == 2) {
      fill_solid(ledsFan_2, NumeroLED_Fan_2, CRGB(255, 255, 255));        //Modalità Bianco/Luce
    }  if (ColorModLED_Fan_2 == 3) {
      fill_solid(ledsFan_2, NumeroLED_Fan_2, CRGB(255, 0, 0));            //Modalità Rosso
    }  if (ColorModLED_Fan_2 == 4) {
      fill_solid(ledsFan_2, NumeroLED_Fan_2, CRGB(0, 255, 0));            //Modalità Verde
    }  if (ColorModLED_Fan_2 == 5) {
      fill_solid(ledsFan_2, NumeroLED_Fan_2, CRGB(0, 0, 255));            //Modalità Blu
    }  if (ColorModLED_Fan_2 == 6) {
      fill_solid(ledsFan_2, NumeroLED_Fan_2, CRGB(30, 155, 255));         //Modalità Azzurro
    }  if (ColorModLED_Fan_2 == 7) {
      fill_solid(ledsFan_2, NumeroLED_Fan_2, CRGB(255, 40, 0));           //Modalità Arancio
    }  if (ColorModLED_Fan_2 == 8) {
      fill_solid(ledsFan_2, NumeroLED_Fan_2, CRGB(255, 0, 255));          //Modalità Viola
    }  if (ColorModLED_Fan_2 == 9) {
      fill_solid(ledsFan_2, NumeroLED_Fan_2, CRGB(255, 140, 0));          //Modalità Giallo
    }
  }

  if ((ModLED_Fan > 1) or (ModLED_Fan == 4 and OfflineLED_Fan == 1)) {
    //Fan3
    if (ColorModLED_Fan_3 == 1 ) {
      fill_solid(ledsFan_3, NumeroLED_Fan_3, CRGB(0, 0, 0));              //Modalità Spento
    }  if (ColorModLED_Fan_3 == 2) {
      fill_solid(ledsFan_3, NumeroLED_Fan_3, CRGB(255, 255, 255));        //Modalità Bianco/Luce
    }  if (ColorModLED_Fan_3 == 3) {
      fill_solid(ledsFan_3, NumeroLED_Fan_3, CRGB(255, 0, 0));            //Modalità Rosso
    }  if (ColorModLED_Fan_3 == 4) {
      fill_solid(ledsFan_3, NumeroLED_Fan_3, CRGB(0, 255, 0));            //Modalità Verde
    }  if (ColorModLED_Fan_3 == 5) {
      fill_solid(ledsFan_3, NumeroLED_Fan_3, CRGB(0, 0, 255));            //Modalità Blu
    }  if (ColorModLED_Fan_3 == 6) {
      fill_solid(ledsFan_3, NumeroLED_Fan_3, CRGB(30, 155, 255));         //Modalità Azzurro
    }  if (ColorModLED_Fan_3 == 7) {
      fill_solid(ledsFan_3, NumeroLED_Fan_3, CRGB(255, 40, 0));           //Modalità Arancio
    }  if (ColorModLED_Fan_3 == 8) {
      fill_solid(ledsFan_3, NumeroLED_Fan_3, CRGB(255, 0, 255));          //Modalità Viola
    }  if (ColorModLED_Fan_3 == 9) {
      fill_solid(ledsFan_3, NumeroLED_Fan_3, CRGB(255, 140, 0));          //Modalità Giallo
    }
  }
  //Imposta i LED con i settaggi selezionati
  //FastLED.setBrightness( BRIGHTNESS );
  //FastLED.show();
  //}
}
//--------------- ******************************************************************************************* -----------------//
int audio_input;
void AnimazioniRGB() {
  //***//Effetto Musica Fan Casse
  if (RGB_Mod_Fan_All == 4) {
    //
    if (TimerVirtuale [8] >= (ResetTimerVirtuale [8] + DelayVirtuale [8])) {
      ResetTimerVirtuale [8] = TimerVirtuale [8];

      audio_input = AudioDigital;

      if (audio_input > 0) {

        if (RGB_Mod_Fan_All == 4) {
          Pre_Dmusic_Fan = ((long)NumeroLED_Fan_1    * (long)audio_input) / 1023L;
          if (Pre_Dmusic_Fan > Dmusic_Fan) // ONLY ADJUST LEVEL OF LED IF LEVEL HIGHER THAN CURRENT LEVEL
            Dmusic_Fan = Pre_Dmusic_Fan;
        }

      }
      rainbow(); // APPLY COLOR
      k = k - wheel_speed; // SPEED OF COLOR WHEEL
      if (k < 0) // RESET COLOR WHEEL
        k = 255;
      // REMOVE LEDs
      decay_check++;
      if (decay_check > FrequenzaAggiornamento) {
        decay_check = 0;
        if (react > 0)
          react--;

        if (Dmusic_Fan > 0 and RGB_Mod_Fan_All == 4)
          Dmusic_Fan--;
      }
    }
  }
  //----------------------------------------------------------------------
  if (TimerVirtuale [6] >= (ResetTimerVirtuale [6] + DelayVirtuale [6])) {
    ResetTimerVirtuale [6] = TimerVirtuale [6];

    //***//Effetto Ranibow Fan
    if (RGB_Mod_Fan_All == 3) {
      if (j_Fan < 256) j_Fan++;
      if (j_Fan == 256) j_Fan = 0;
      for (int NF = 0; NF < NUM_LEDS_Fan; NF++) {
        ledsFan[NF] = Scroll((NF * 256 / NUM_LEDS_Fan + j_Fan) % 256);
      }
    }
  }

  //Effeto Transiozione Casse Fan
  if (RGB_Mod_Fan_All == 2) {
    //
    if (TimerVirtuale [7] >= (ResetTimerVirtuale [7] + DelayVirtuale [7])) {
      ResetTimerVirtuale [7] = TimerVirtuale [7];
      //
      static uint8_t startIndex = 0;
      startIndex = startIndex + 1;
      FillLEDsFromPaletteColors( startIndex);
    }
  }

  //**//Effeto Discontinuo Casse Fan
  if ( RGB_Mod_Fan_All == 1) {
    if (TimerVirtuale [5] >= (ResetTimerVirtuale [5] + DelayVirtuale [5])) {
      ResetTimerVirtuale [5] = TimerVirtuale [5];
      CD77_chase_array_color_symet(500, 2000 , 3 );
    }
  }

}
//--------------- ******************************************************************************************* -----------------//
void rainbow() {
  if (RGB_Mod_Fan_All == 4) {
    for (int i = NumeroLED_Fan_1 - 1; i >= 0; i--) {
      if (i < Dmusic_Fan) {
        ledsFan_1[i] = Scroll((i * 256 / 50 + k) % 256);
        ledsFan_2[i] = ledsFan_1[i];
        ledsFan_3[i] = ledsFan_1[i];
        //ledsFan_4[i] = ledsFan_1[i];
        //ledsGPU[i] = ledsFan_1[i];
      }
      else {
        ledsFan_1[i] = CRGB(0, 0, 0);
        ledsFan_2[i] = CRGB(0, 0, 0);
        ledsFan_3[i] = CRGB(0, 0, 0);
        //ledsFan_4[i] = CRGB(0, 0, 0);
        //ledsGPU[i] = CRGB(0, 0, 0);
      }
    }
  }
  //FastLED.show();
}
//--------------- ******************************************************************************************* -----------------//
//Avvio Loop Modalità 3 = RGB Transizione
void FillLEDsFromPaletteColors( uint8_t colorIndex) {

  if (RGB_Mod_Fan_All == 2) {
    for ( int i = 0; i < NumeroLED_Fan_1; i++) {
      ledsFan_1[i] = ColorFromPalette( currentPalette, colorIndex, BRIGHTNESS, currentBlending);
      ledsFan_2[i] = ledsFan_1[i];
      ledsFan_3[i] = ledsFan_1[i];
      //ledsFan_4[i] = ledsFan_1[i];
      //ledsGPU[i] = ledsFan_1[i];
      colorIndex += 3;
    }
  }
}
//--------------- ******************************************************************************************* -----------------//
//Avvio Loop Modalità 4 = RGB Discontinuo
void CD77_chase_array_color_symet(uint16_t wait1, uint16_t wait_Array , uint8_t dots ) {
  //shift pixels
  EVERY_N_MILLIS_I( Array_time, 500) {
    Array_time.setPeriod( wait_Array );
    i++;
    if (i > Array_Size - 1) {
      i = 0;
    }
    Array_color = CHSV_array[i];
  }

  if (RGB_Mod_Fan_All == 1) {
    for (int i =  NUM_LEDS_Fan - 1; i > 0; i--) {
      ledsFan[i] = ledsFan[i - 1];
    }
  }

  //reset
  EVERY_N_MILLIS_I( Dot_time, 500) {
    Dot_time.setPeriod( wait1 );
    leds_done = 0;
  }

  if (leds_done < dots) {
    if (RGB_Mod_Fan_All == 1) {
      ledsFan[0] = Array_color;
    }
    leds_done = leds_done + 1;
  } else {
    if (RGB_Mod_Fan_All == 1) {
      ledsFan[0] = CRGB::Black;
    }
  }
}
//--------------- ******************************************************************************************* -----------------//
void TemperaturaEsterna() {
  //
  //------------------------  /* Misura della temperatura  */-------------
  if (millis() >= tempLastSample + 1) {
    tempSampleRead = analogRead(TermoresistenzaPin);
    tempSampleSum = tempSampleSum + tempSampleRead;
    tempSampleCount = tempSampleCount + 1;
    tempLastSample = millis();
  }
  if (tempSampleCount == 1000) {
    tempMean = tempSampleSum / tempSampleCount;
    R2 = (PartitoreTensioneR2 * tempMean) / (1023 - tempMean);
    a = 1 / T1;
    b = log10(R1 / R2);
    c = b / log10(e);
    d = c / BValue ;
    T2 = 1 / (a - d);
    DigitalTemp = (T2 - 273.15);
    //DigitalTemp = 15;
    tempSampleSum = 0;
    tempSampleCount = 0;
  }
}
