//*****************************************************************************************************************************//
//                                           Ver: X.04 Firmware data 10/05/23                                                  //
//*****************************************************************************************************************************//

void loop() {
  //----------------------------------------------------------------------
  TimerVirtuale[1] = millis();  //Avvia il Delay non bloccante per evitare errori nell'Ricevere dei dati al PC tramite Seriale RX 1

  //----------------------------------------------------------------------
  Void_Fan_Mod();
  if (Aniamzione_Avvio == true or Debug == true) {
    TimerVirtuale[0] = millis();
    Void_LED_Mod();  //Inizializza il loop dove ci sono tutte le modalità LED
    //AnimazioniRGB();  //Loop Animazioni RGB
  }
  TemperaturaDS();  //Lettura srnsore Temperatura
  Voltaggio();      //Lettura Tensione 5V 12V


  //---------------------------------------------------------------------- AnimazioneAVVIO
  if (TimerVirtuale[1] >= (ResetTimerVirtuale[10] + DelayVirtuale[10])) {
    ResetTimerVirtuale[10] = TimerVirtuale[1];
    if (Aniamzione_Avvio == false and (S_Pro_5V == false or Debug != 0)) {
      digitalWrite(OV, HIGH);


      Strip1.setPixelColor(x, 255, 25, 0);

      if (x < NUM_LEDS_ALL) Strip1.setPixelColor(x, 255, 25, 0);
      if ((x >= NUM_LEDS_ALL) and (x < NUM_LEDS_OUT_All)) Strip2.setPixelColor(x - NUM_LEDS_ALL, 255, 25, 0);
      if ((x >= NUM_LEDS_ALL + NUM_LEDS_OUT_9) and (x < NUM_LEDS_OUT_All)) Strip3.setPixelColor(x - (NUM_LEDS_ALL + NUM_LEDS_OUT_9), 255, 25, 0);

      Strip1.show();
      Strip2.show();
      Strip3.show();

      if (++x >= NUM_LEDS_OUT_All and x <= NUM_LEDS_OUT_All) {
        Aniamzione_Avvio = true;
      }
    }
  }
  //---------------------------------------------------------------------- Funzione Delay per l'invio dei dati al PC tramite Seriale
  if (TimerVirtuale[0] >= (ResetTimerVirtuale[0] + DelayVirtuale[0])) {
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
                     //  (0)         (1)        (2)            (3)                        (4)                 (5)                (6)
                     + TempDS + "," + V5 + "," + V12 + "," + S_Pro_12V + "," + PowerLimitLED_Stato + ";"  //1
                     //  (0)             (1)               (2)
                     + ROM_Dati + "," + EN_OV + "," + PowerLimitLED + ";"  //2
                     //    (0)                   (1)                    (2)                     (3)                       (4)                      (5)                 (6)                     (7)                    (8)                    (9)                    (10)                    (11)                    (12)
                     + NUM_LEDS_OUT_All + "," + NUM_LEDS_OUT_1 + "," + NUM_LEDS_OUT_1 + "," + NUM_LEDS_OUT_1 + "," + NUM_LEDS_OUT_1 + "," + NUM_LEDS_OUT_5 + "," + NUM_LEDS_OUT_6 + "," + NUM_LEDS_OUT_7 + "," + NUM_LEDS_OUT_8 + "," + NUM_LEDS_OUT_9 + "," + NUM_LEDS_OUT_10 + "," + NUM_LEDS_OUT_11 + "," + NUM_LEDS_OUT_12 + ";"  //3 Nummero LED
                     //   (0)              (1)                (2)              (3)                (4)               (5)              (6)                 (7)               (8)               (9)                (10)             (11)                (12)
                     + LumLED[0] + "," + LumLED[1] + "," + LumLED[2] + "," + LumLED[3] + "," + LumLED[4] + "," + LumLED[5] + "," + LumLED[6] + "," + LumLED[7] + "," + LumLED[8] + "," + LumLED[9] + "," + LumLED[10] + "," + LumLED[11] + "," + LumLED[12] + ";"  //4 Luminosità
                     //    (0)                   (1)                 (2)                  (3)                  (4)                 (5)                  (6)                   (7)                  (8)                 (9)                   (10)                  (11)                  (12)
                     + ColoreLED[0] + "," + ColoreLED[1] + "," + ColoreLED[2] + "," + ColoreLED[3] + "," + ColoreLED[4] + "," + ColoreLED[5] + "," + ColoreLED[6] + "," + ColoreLED[7] + "," + ColoreLED[8] + "," + ColoreLED[9] + "," + ColoreLED[10] + "," + ColoreLED[11] + "," + ColoreLED[12] + ";"  //5 Colore LED
                     //    (0)                     (1)                    (2)                    (3)                   (4)                    (5)                     (6)                    (7)                    (8)                    (9)                     (10)                   (11)                    (12)
                     + Saturazione[0] + "," + Saturazione[1] + "," + Saturazione[2] + "," + Saturazione[3] + "," + Saturazione[4] + "," + Saturazione[5] + "," + Saturazione[6] + "," + Saturazione[7] + "," + Saturazione[8] + "," + Saturazione[9] + "," + Saturazione[10] + "," + Saturazione[11] + "," + Saturazione[12] + ";"  //6 Saturazione LED
                     //    (0)                 (1)                (2)
                     + ModLED_Fan + "," + ModFAN_SPEED + "," + ModRGB_LED + ";"  //7 Modalità Sincornizata / Desinc
                     //     (0)                 (1)                 (2)                 (3)                (4)
                     + FanSpeed[0] + "," + FanSpeed[1] + "," + FanSpeed[2] + "," + FanSpeed[3] + "," + FanSpeed[4] + ";"  //8 Velocità Rotazione Ventole
                     //     (0)                       (1)                       (2)                       (3)                      (4)                       (5)
                     + Fan_Mod_Speed[0] + "," + Fan_Mod_Speed[1] + "," + Fan_Mod_Speed[2] + "," + Fan_Mod_Speed[3] + "," + Fan_Mod_Speed[4] + ";"  //9 Modalita Adatamento velocità Ventola
                     //
                     + "0" + "," + "0" + "," + "0" + "," + "0" + ";"  //10 Lettura RPM delle ventole
                     //      (0)                         (1)                      (2)                       (3)                       (4)                      (5)                      (6)
                     + Animation_RGBS[0] + "," + Animation_RGBS[1] + "," + Animation_RGBS[2] + "," + Animation_RGBS[3] + "," + Animation_RGBS[4] + "," + Animation_RGBS[5] + "," + Animation_RGBS[6] + ";");  //11 Acquisizione Animeazione LED Select
    }
    if (Boot_SetUp == 200 and Debug != 1) {
      DelayVirtuale[0] = DelayLoopPrimario_ON;
      //                            (0)                (1)
      Serial.println((String)Stato_Software + "," + Progetto + ";"  //0 Informa il software di che tipo di Arduino è: Commpatibbilità / Progetto   //0
                     //  (0)         (1)        (2)            (3)                 (4)
                     + TempDS + "," + V5 + "," + V12 + "," + S_Pro_12V + "," + PowerLimitLED_Stato + ";"  //1
                     //  (0)             (1)               (2)
                     + ROM_Dati + "," + EN_OV + "," + PowerLimitLED + ";"  //2
                     //    (0)
                     + NUM_LEDS_OUT_All + ";"  //3 Nummero LED
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
                     //(0)      (1)       (2)       (3)
                     + 0 + "," + 0 + "," + 0 + "," + 0 + ";"  //10 Lettura RPM delle ventole
                     //    (0)
                     + Animation_RGBS[ModRGB_LED] + ";");  //11 Acquisizione Animeazione LED Select
    }
    ResetTimerVirtuale[0] = TimerVirtuale[0];
  }
  //----------------------------------------------------------------------Modalità d'attesa o standby
  //
  if ((Volt_5V < 4.00) and (Volt_12V < 11.00) and (Boot_SetUp == 0) and (Aniamzione_Avvio == true)) {
    Mod_attesa = true;
    //
    DelayFanPower = millis();
    LumLimitLED = 0;
    PowerLimitLED_Stato = false;
    //
    digitalWrite(OV, HIGH);
    S_Pro_5V = false;   //0
    S_Pro_12V = false;  //0
    //
  } else {
    Mod_attesa = false;
  }
  //
  //-------------------------------------Modalità Offline
  //
  if (TimerVirtuale[1] >= (ResetTimerVirtuale[1] + DelayVirtuale[1])) {
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
      Boot_SetUp = 0;

      Strip1.show();
      Strip1.setBrightness(BRIGHTNESS - LumLimitLED);
      Strip2.show();
      Strip2.setBrightness(BRIGHTNESS - LumLimitLED);
      Strip3.show();
      Strip3.setBrightness(BRIGHTNESS - LumLimitLED);
    }
    ResetTimerVirtuale[1] = TimerVirtuale[1];
  }
  //-------------------------------------
  //Funzione ricezione dati dal PC (quando riceve dei dati tramite la Seriale avvia il loop DatiRX)
  if (Serial.available()) {

    USB_Serial_Ricevuto = USB_Serial_Connessione;
    VerificaUSB = 0;

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
      VerificaUSB = 0;

      Strip1.show();
      Strip1.setBrightness(BRIGHTNESS - LumLimitLED);
      Strip2.show();
      Strip2.setBrightness(BRIGHTNESS - LumLimitLED);
      Strip3.show();
      Strip3.setBrightness(BRIGHTNESS - LumLimitLED);
    }
  }
  //-------------------------------------
}