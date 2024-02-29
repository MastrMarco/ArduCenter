//*****************************************************************************************************************************//
//                                           Ver: X.07 Firmware data 12/01/24                                                  //
//*****************************************************************************************************************************//

// Aggiorna Dati Salvati EEPROM
void Dati_EEPROM() {
  EEPROM.update(EEPROMaddress[4], ModLED_Fan);
  if (PowerLimitLED_Stato == false) EEPROM.put(20, LumLED);  //Memorizza il valore nella cella 10 della EEPROM
  EEPROM.put(50, ColoreLED);                                 //Memorizza il valore nella cella 25 della EEPROM
  EEPROM.put(80, Saturazione);                               //Memorizza il valore nella cella 40 della EEPROM
  EEPROM.put(110, FanSpeed);                                 //Memorizza il valore nella cella 55 della EEPROM
  // EEPROM.put(140, Fan_Mod_Speed);                            //15val
  EEPROM.update(EEPROMaddress[1], EN_OV);
  EEPROM.update(EEPROMaddress[2], PowerLimitLED);
  EEPROM.put(200, NUM_LEDS_OUT);  //20val
}

void setup() {
  //----------------------
  //Apertura Seriale
  Serial.begin(115200);
  while (!Serial) continue;
  //
  //----------------------
  if (((ROM_Dati != 2) and (ROM_Dati != 3)) and (EEPROM.read(EEPROMaddress[0]) != 2)) {
    ROM_Dati = EEPROM.read(EEPROMaddress[0]);
  }

  if (ROM_Dati == 1) {

    PowerLimitLED = EEPROM.read(EEPROMaddress[2]);
    EN_OV = EEPROM.read(EEPROMaddress[1]);
    ModLED_Fan = EEPROM.read(EEPROMaddress[4]);

    EEPROM.get(20, LumLED);       //15val
    EEPROM.get(50, ColoreLED);    //15val
    EEPROM.get(80, Saturazione);  //15val

    EEPROM.get(110, FanSpeed);  //15val
    // EEPROM.get(140, Fan_Mod_Speed);  //15val

    EEPROM.get(200, NUM_LEDS_OUT);  //20val

  } else if ((ROM_Dati == 2) or (EEPROM.read(EEPROMaddress[0]) == 2)) {
    Dati_EEPROM();
    ROM_Dati = 1;
    EEPROM.update(EEPROMaddress[0], ROM_Dati);
  }
  delay(20);
  //----------------------
  //Imposta PIN, 74LS166
  pinMode(SL, OUTPUT);
  pinMode(CK, OUTPUT);
  pinMode(QH, INPUT);
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
  //Imposta PIN LED limite
  //pinMode(13, OUTPUT);
  //Protezione Attiva 5V
  pinMode(OV, OUTPUT);
  //
  //----------------------
  //Reset dei LED e configurazione
  Strip1.begin();
  Strip2.begin();
  //
  ArrayLED();     //Loop3
  Set_LED_ROM();  //Loop_7

  //Imposta in modalità Set l'elemento Ventola selezionato prima del Riavvio
  if (ModLED_Fan < 5) ModFAN_SPEED = ModLED_Fan;
}
