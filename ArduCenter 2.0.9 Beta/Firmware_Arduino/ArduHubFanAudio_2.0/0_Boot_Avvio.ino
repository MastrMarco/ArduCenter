//*****************************************************************************************************************************//
//    Modifica Modalità Ripristino,   Modifica Tempi di Caricamento setup           Ver: X.05 Firmware data 05/09/23          //
//*****************************************************************************************************************************//

void setup() {
  //----------------------
  //Apertura Seriale
  Serial.begin(115200);
  while (!Serial) continue;
  //
  //----------------------
  if ((ROM_Dati != 2) and (EEPROM.read(EEPROMaddress[0]) != 2)) {
    ROM_Dati = EEPROM.read(EEPROMaddress[0]);
  }

  if (ROM_Dati == 1) {

    PowerLimitLED = EEPROM.read(EEPROMaddress[2]);
    EN_OV = EEPROM.read(EEPROMaddress[1]);
    ModLED_Fan = EEPROM.read(EEPROMaddress[4]);

    EEPROM.get(20, LumLED);       //15val
    EEPROM.get(50, ColoreLED);    //15val
    EEPROM.get(80, Saturazione);  //15val

    EEPROM.get(110, FanSpeed);       //15val
    EEPROM.get(140, Fan_Mod_Speed);  //15val
  } else if ((ROM_Dati == 2) or (EEPROM.read(EEPROMaddress[0]) == 2)) {
    EEPROM.write(EEPROMaddress[0], ROM_Dati);

    EEPROM.write(EEPROMaddress[2], PowerLimitLED);
    EEPROM.write(EEPROMaddress[1], EN_OV);
    EEPROM.write(EEPROMaddress[4], ModLED_Fan);

    EEPROM.write(EEPROMaddress[1], EN_OV);
    EEPROM.write(EEPROMaddress[4], ModLED_Fan);

    EEPROM.put(20, LumLED);       //15val
    EEPROM.put(50, ColoreLED);    //15val
    EEPROM.put(80, Saturazione);  //15val

    EEPROM.put(110, FanSpeed);       //15val
    EEPROM.put(140, Fan_Mod_Speed);  //15val

    delay(50);
    ROM_Dati = 1;
    delay(50);
    EEPROM.write(EEPROMaddress[0], ROM_Dati);
  }
  delay(20);
  //----------------------
  //Imposta PIN PWM
  TCCR2B = TCCR2B & B11111000 | B00000001;  // for PWM frequency of 31372.55 Hz D3 D11
  TCCR1B = TCCR1B & B11111000 | B00000001;  // for PWM frequency of 31372.55 Hz D9 D10
  pinMode(PWM_Fan_1, OUTPUT);               // Modalità Pin PWM Fan1
  pinMode(PWM_Fan_2, OUTPUT);               // Modalità Pin PWM Fan2
  //
  pinMode(PWM_Fan_3, OUTPUT);  // Modalità Pin PWM Fan3
  pinMode(PWM_Fan_4, OUTPUT);  // Modalità Pin PWM Fan4
  //Imposta PIN Che leggono la tensione 12V 5V
  pinMode(Pin_5V, INPUT);
  pinMode(Pin_12V, INPUT);
  //Protezione Attiva 5V
  pinMode(OV, OUTPUT);
  //----------------------
  //Reset dei LED e configurazione
  Strip1.begin();
  Strip1.show();
  Strip1.setBrightness(BRIGHTNESS);
  Strip2.begin();
  Strip2.show();
  Strip2.setBrightness(BRIGHTNESS);
  Strip3.begin();
  Strip3.show();
  Strip3.setBrightness(BRIGHTNESS);

  //Imposta in modalità Set l'elemento Ventola selezionato prima del Riavvio
  if (ModLED_Fan < 5) ModFAN_SPEED = ModLED_Fan;
}