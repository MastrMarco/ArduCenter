//*****************************************************************************************************************************//
//                                           Ver: X.07 Firmware data 04/02/24                                                  //
//*****************************************************************************************************************************//

void loop() {
  //----------------------------------------------------------------------

  //digitalWrite(SL, LOW);
  PORTD &= !B00000000;

  //digitalWrite(CK, LOW);
  PORTD &= !B00000000;
  
  delayMicroseconds(5);

  //digitalWrite(CK, HIGH);
  PORTD |= B00100000;

  //digitalWrite(SL, HIGH);
  PORTD |= B10000000;

  Dati74166 = shiftIn(QH, CK, MSBFIRST);

  PinA = Dati74166 & 0B00000001;
  PinB = Dati74166 & 0B00000010;
  PinC = Dati74166 & 0B00000100;
  PinD = Dati74166 & 0B00001000;

  //----------------------------------------------------------------------
  /*  millis();  //Avvia il Delay non bloccante: 
  * Seriale RX 1, Animazione Avvio HUB, 
  * Alimentazione, l'auto reset dello stato delle protezioni, 
  * Temperatura, RPM ventole, RGB M1 RainBow, RGB M2 Temperatura, 
  * RGB M3 Transiozione, RGB M4 Musica, RGB M5 Disocontinuo,
  */
  //----------------------------------------------------------------------
  Void_Fan_Mod();
  if (Aniamzione_Avvio == true or Debug == 1) {
    TimerVirtuale = millis();

    if (ROM_Dati == 3 and ModLED_Fan > 0) {
      Set_LED_Config();  //Richiama il loop per la configurazione delle periferiche
    } else {
      Void_LED_Mod();  //Richiama il loop dove ci sono tutte le modalità LED
    }
  }
  TemperaturaDS();  //Lettura srnsore Temperatura
  Voltaggio();      //Lettura Tensione 5V 12V


  //---------------------------------------------------------------------- AnimazioneAVVIO
  if (Aniamzione_Avvio == false and (V5 > 4.50 or Debug != 0)) {

    for (byte x = 0; x <= NUM_LEDS_OUT_All; x++) {
      SingleStripLED(x, (8 * 128), 255, 255);
      Set_LED();
      delay(DelayVirtuale[10]);
    }
    Aniamzione_Avvio = true;
  }
  //---------------------------------------------------------------------- Funzione Delay per l'invio dei dati al PC tramite Seriale
  if (TimerVirtuale >= (ResetTimerVirtuale[0] + DelayVirtuale[0])) {
    //----------------------
    //Invio dei dati al PC tramite Seriale
    if (Boot_SetUp != 200 or Debug == 1) {
      if (Debug == 1) {
        DelayVirtuale[0] = DelayLoopPrimario_ON;
      } else {
        DelayVirtuale[0] = DelayLoopPrimario_OFF;
      }
      //                          (0)                 (1)          (2)           (3)              (4)
      Serial.println((String)Stato_Software + "," + Arduino + "," + "" + "," + Progetto + "," + Versione + ";"  //0 Informa il software di che tipo di Arduino è: Commpatibbilità-Beta-Relise-Debug / Tipo di arduino  /     / Progetto / Versione                                                                              //0
                     //  (0)          (1)        (2)            (3)                     (4)                   (5)            (6)
                     + TempDS + "," + V5 + "," + V12 + "," + S_Pro_12V + "," + PowerLimitLED_Stato + "," + S_Pro_5V + "," + VAREF + ";"  //1
                     //  (0)             (1)               (2)
                     + ROM_Dati + "," + EN_OV + "," + PowerLimitLED + ";"  //2
                     //     (0)                      (1)                    (2)                     (3)                      (4)                     (5)                    (6)                      (7)                    (8)                     (9)
                     + NUM_LEDS_OUT[0] + "," + NUM_LEDS_OUT[1] + "," + NUM_LEDS_OUT[2] + "," + NUM_LEDS_OUT[3] + "," + NUM_LEDS_OUT[4] + "," + NUM_LEDS_OUT[5] + "," + NUM_LEDS_OUT[6] + "," + NUM_LEDS_OUT[7] + "," + NUM_LEDS_OUT[8] + "," + NUM_LEDS_OUT[9] + ";"  //3 Nummero LED
                     //   (0)              (1)                (2)              (3)                (4)               (5)              (6)                 (7)               (8)               (9)
                     + LumLED[0] + "," + LumLED[1] + "," + LumLED[2] + "," + LumLED[3] + "," + LumLED[4] + "," + LumLED[5] + "," + LumLED[6] + "," + LumLED[7] + "," + LumLED[8] + "," + LumLED[9] + ";"  //4 Luminosità
                     //    (0)                   (1)                 (2)                  (3)                  (4)                 (5)                  (6)                   (7)                  (8)                 (9)
                     + ColoreLED[0] + "," + ColoreLED[1] + "," + ColoreLED[2] + "," + ColoreLED[3] + "," + ColoreLED[4] + "," + ColoreLED[5] + "," + ColoreLED[6] + "," + ColoreLED[7] + "," + ColoreLED[8] + "," + ColoreLED[9] + ";"  //5 Colore LED
                     //    (0)                     (1)                    (2)                    (3)                   (4)                    (5)                     (6)                    (7)                    (8)                  (9)
                     + Saturazione[0] + "," + Saturazione[1] + "," + Saturazione[2] + "," + Saturazione[3] + "," + Saturazione[4] + "," + Saturazione[5] + "," + Saturazione[6] + "," + Saturazione[7] + "," + Saturazione[8] + "," + Saturazione[9] + ";"  //6 Saturazione LED
                     //    (0)                 (1)                (2)
                     + ModLED_Fan + "," + ModFAN_SPEED + "," + ModRGB_LED + ";"  //7 Modalità Sincornizata / Desinc
                     //     (0)                 (1)                 (2)                 (3)                (4)
                     + FanSpeed[0] + "," + FanSpeed[1] + "," + FanSpeed[2] + "," + FanSpeed[3] + "," + FanSpeed[4] + ";"  //8 Velocità Rotazione Ventole
                     //     (0)                       (1)                       (2)                       (3)                      (4)                       (5)
                     + Fan_Mod_Speed[0] + "," + Fan_Mod_Speed[1] + "," + Fan_Mod_Speed[2] + "," + Fan_Mod_Speed[3] + "," + Fan_Mod_Speed[4] + ";"  //9 Modalita Adatamento velocità Ventola
                     //   (0)             (1)              (2)              (3)
                     + RPM_Fan1 + "," + RPM_Fan2 + "," + RPM_Fan3 + "," + RPM_Fan4 + ";"  //10 Lettura RPM delle ventole
                     //      (0)                         (1)                      (2)                       (3)                       (4)                      (5)                      (6)
                     + Animation_RGBS[0] + "," + Animation_RGBS[1] + "," + Animation_RGBS[2] + "," + Animation_RGBS[3] + "," + Animation_RGBS[4] + "," + Animation_RGBS[5] + "," + Animation_RGBS[6] + ";");  //11 Acquisizione Animeazione LED Select
    }
    if (Boot_SetUp == 200 and Debug != 1) {
      DelayVirtuale[0] = DelayLoopPrimario_ON;
      //                            (0)                (1)
      Serial.println((String)Stato_Software + "," + Progetto + ";"  //0 Informa il software di che tipo di Arduino è: Commpatibbilità / Progetto   //0
                     //  (0)          (1)        (2)            (3)                 (4)                       (5)            (6)
                     + TempDS + "," + V5 + "," + V12 + "," + S_Pro_12V + "," + PowerLimitLED_Stato + "," + S_Pro_5V + "," + VAREF + ";"  //1
                     //  (0)             (1)               (2)
                     + ROM_Dati + "," + EN_OV + "," + PowerLimitLED + ";"  //2
                     //    (0)
                     + NUM_LEDS_OUT[0] + ";"  //3 Nummero LED
                     //   (0)
                     + LumLED[ModLED_Fan] + ";"  //4 Luminosità
                     //    (0)
                     + ColoreLED[ModLED_Fan] + ";"  //5 Colore LED
                     //    (0)
                     + Saturazione[ModLED_Fan] + ";"  //6 Saturazione LED
                     //    (0)               (1)                  (2)
                     + ModLED_Fan + "," + ModFAN_SPEED + "," + ModRGB_LED + ";"  //7 Modalità Sincornizata / Desinc
                     //     (0)
                     + FanSpeed[ModFAN_SPEED] + ";"  //8 Velocità Rotazione Ventole
                     //     (0)
                     + Fan_Mod_Speed[ModFAN_SPEED] + ";"  //9 Modalita Adatamento velocità Ventola
                     //   (0)             (1)              (2)              (3)
                     + RPM_Fan1 + "," + RPM_Fan2 + "," + RPM_Fan3 + "," + RPM_Fan4 + ";"  //10 Lettura RPM delle ventole
                     //    (0)
                     + Animation_RGBS[ModRGB_LED] + ";");  //11 Acquisizione Animeazione LED Select
    }
    ResetTimerVirtuale[0] = TimerVirtuale;
  }
  //----------------------------------------------------------------------Modalità d'attesa o standby
  //
  //if ((Volt_5V < 4.00) and (Volt_12V < 11.00) and (Boot_SetUp == 0) and ((Aniamzione_Avvio == true) or (Aniamzione_Avvio == false and Volt_12V > 11.50)) ) {
  if (Boot_SetUp == 0) {
    if ((V5 < 1.00) and (V12 < 1.00)) {
      Mod_attesa = true;
      //
      DelayFanPower = millis();
      LumLimitLED = 0;
      PowerLimitLED_Stato = false;
      //
      S_Pro_5V = false;   //0
      S_Pro_12V = false;  //0
      //
    } else {
      Mod_attesa = false;
    }
  }
  //
  //-------------------------------------Modalità Offline USB
  //
  if ((millis() >= (ResetTimerVirtuale[1] + DelayVirtuale[1])) and (Serial.available() == false)) {

    if (ROM_Dati == 3) {
      byte d = EEPROM.read(EEPROMaddress[0]);
      if (d < 3) {
        ROM_Dati = d;
      } else {
        ROM_Dati = 0;
      }
      // if (valLED >= 1 and valLED <= 30) {
      if (stDef == false) {
        Reset_LED();
        Set_LED();
        // NUM_LEDS_OUT[ModLED_Fan] = valLED;
        Set_LED_ROM();

        if (ROM_Dati == 1) {
          ModLED_Fan = EEPROM.read(EEPROMaddress[4]);
        } else {
          ModLED_Fan = 0;
        }
        stDef = true;
      }
    }

    // Salva i dati Modificati nella EEPROM
    if (ROM_Dati == 1 and Boot_SetUp != 0) {
      Dati_EEPROM();
    }

    Boot_SetUp = 0;
    Set_LED();

    ResetTimerVirtuale[1] = millis();
  }
  //-------------------------------------Modalità Oline USB
  //Funzione ricezione dati dal PC (quando riceve dei dati tramite la Seriale avvia il loop DatiRX)
  if (Serial.available()) {

    ResetTimerVirtuale[1] = (millis() + DelayVirtuale[1]);  // USB Connessione ON

    String SerialRX = Serial.readStringUntil('\n');

    if (SerialRX.length() > 0) {
      int m = 0;
      int n = SerialRX.indexOf(";");
      int indice = 0;
      while (n > 0) {
        String token = SerialRX.substring(n, m);
        m = n + 1;
        n = SerialRX.indexOf(";", n + 1);

        DatiRXloop(indice, token);
        indice++;
      }
      //applico i risultati
      if (stDef == false and (ROM_Dati < 3 or ModLED_Fan != ElementoPRE)) {
        ElementoPRE = ModLED_Fan;
        Reset_LED();
        Set_LED();
        Set_LED_ROM();
        stDef = true;
      }

      Set_LED();
    }
  }
  //-------------------------------------
}


// Applica i risultati ai LED
void Set_LED() {
  if (Strip1.getBrightness() != (BRIGHTNESS - LumLimitLED)) {

    Strip1.setBrightness(BRIGHTNESS - LumLimitLED);
    Strip2.setBrightness(BRIGHTNESS - LumLimitLED);
    Strip3.setBrightness(BRIGHTNESS - LumLimitLED);
    Strip4.setBrightness(BRIGHTNESS - LumLimitLED);
    Strip5.setBrightness(BRIGHTNESS - LumLimitLED);
    Strip6.setBrightness(BRIGHTNESS - LumLimitLED);
    Strip7.setBrightness(BRIGHTNESS - LumLimitLED);
    Strip8.setBrightness(BRIGHTNESS - LumLimitLED);
    Strip9.setBrightness(BRIGHTNESS - LumLimitLED);
  }

  Strip1.show();
  Strip2.show();
  Strip3.show();
  Strip4.show();
  Strip5.show();
  Strip6.show();
  Strip7.show();
  Strip8.show();
  Strip9.show();
}