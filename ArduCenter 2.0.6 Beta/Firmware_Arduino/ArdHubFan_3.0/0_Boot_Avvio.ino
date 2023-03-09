void setup() {
  //----------------------
  //Apertura Seriale
  Serial.begin(115200);
  while (!Serial) continue;
  //
  //----------------------
  if (ROM_Dati != 2) {
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
  } else if (ROM_Dati == 2) {
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

    delay(500);
    ROM_Dati = 1;
    delay(50);
    EEPROM.write(EEPROMaddress[0], ROM_Dati);
  }
  delay(50);
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
  Strip1.show();
  Strip1.setBrightness(BRIGHTNESS);
  Strip2.begin();
  Strip2.show();
  Strip2.setBrightness(BRIGHTNESS);
  //  Strip3.begin(); Strip3.show(); Strip3.setBrightness(BRIGHTNESS);
  //  Strip4.begin(); Strip4.show(); Strip4.setBrightness(BRIGHTNESS);
  //  Strip5.begin(); Strip5.show(); Strip5.setBrightness(BRIGHTNESS);
  //  Strip6.begin(); Strip6.show(); Strip6.setBrightness(BRIGHTNESS);
  //  Strip7.begin(); Strip7.show(); Strip7.setBrightness(BRIGHTNESS);
  //  Strip8.begin(); Strip8.show(); Strip8.setBrightness(BRIGHTNESS);
  //  Strip9.begin(); Strip9.show(); Strip9.setBrightness(BRIGHTNESS);
}
