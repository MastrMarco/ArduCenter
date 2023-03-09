byte H_P = 128;  // H_P = 65536 / 512 = 128

//Avvio loop dove ci sono tutte le modalità LED
void Void_LED_Mod() {
  //----------------------------------------------------------------------
  //Funzione Delay per il corretto caricamento dei led e delle funzioni
  //if (TimerVirtuale [4] >= (ResetTimerVirtuale [4] + DelayVirtuale [4])) {
  //ResetTimerVirtuale [4] = TimerVirtuale [4];
  //}
  //----------------------------------------------------------------------
  if (S_Pro_5V == true) {
    Strip1.fill(0, 0, 0);  //Modalità  OFF //LED_1
    Strip2.fill(0, 0, 0);  //Modalità  OFF //LED_2
    Strip3.fill(0, 0, 0);  //Modalità  OFF //LED_3
    //    Strip4.fill(0,0,0);            //Modalità  OFF //LED_4
    //    Strip5.fill(0,0,0);            //Modalità  OFF //LED_5
    //    Strip6.fill(0,0,0);            //Modalità  OFF //LED_6
    //    Strip7.fill(0,0,0);            //Modalità  OFF //LED_7
    //    Strip8.fill(0,0,0);            //Modalità  OFF //LED_8
    //    Strip9.fill(0,0,0);            //Modalità  OFF //LED_9
  }

  if (S_Pro_5V == false) {

    if ((ModLED_Fan == 0) or (ModLED_Fan == 0 and OfflineLED_Fan == 1)) {

      if (ColoreLED[0] <= 512 and BRIGHTNESS == 255) {
        //Imposta la modalità dei LED
        //                          Colore,       Saturazione,  Intensità
        Strip1.fill(Strip1.ColorHSV((ColoreLED[0] * H_P), Saturazione[0], LumLED[0]));  //Modalità RGB HSV //LED_1
        Strip2.fill(Strip2.ColorHSV((ColoreLED[0] * H_P), Saturazione[0], LumLED[0]));  //Modalità RGB HSV //LED_2
        Strip3.fill(Strip3.ColorHSV((ColoreLED[0] * H_P), Saturazione[0], LumLED[0]));  //Modalità RGB HSV //LED_3
        //        Strip4.fill(Strip4.ColorHSV(H_All       , Saturazione[0], LumLED[0]));            //Modalità RGB HSV //LED_4
        //        Strip5.fill(Strip5.ColorHSV(H_All       , Saturazione[0], LumLED[0]));            //Modalità RGB HSV //LED_5
        //        Strip6.fill(Strip6.ColorHSV(H_All       , Saturazione[0], LumLED[0]));            //Modalità RGB HSV //LED_6
        //        Strip7.fill(Strip7.ColorHSV(H_All       , Saturazione[0], LumLED[0]));            //Modalità RGB HSV //LED_7
        //        Strip8.fill(Strip8.ColorHSV(H_All       , Saturazione[0], LumLED[0]));            //Modalità RGB HSV //LED_8
        //        Strip9.fill(Strip9.ColorHSV(H_All       , Saturazione[0], LumLED[0]));            //Modalità RGB HSV //LED_9
      }

      if ((ModLED_Fan == 0) and (ColoreLED[0] > 512) and (ColoreLED[0] <= 610) and (Boot_SetUp == false)) {
        BRIGHTNESS = LumLED[0];
      }
      if (BRIGHTNESS == LumLED[0]) {
        if (ColoreLED[0] == 600) {
          RGB_Mod_Fan_All = 1;  //Modalità 1 = RGB Effetto Ciclo Discontinuo
          RGB_Discontinuo();
        }
        if (ColoreLED[0] == 601) {
          RGB_Mod_Fan_All = 2;  //Modalità 2 = RGB Effetto Transizione*
          RGB_Transizione();
        }
        if (ColoreLED[0] == 602) {
          RGB_Mod_Fan_All = 3;  //Modalità 3 = RGB Effetto RainBow*
          RGB_RainBow();
        }
        if (ColoreLED[0] == 603) {
          RGB_Mod_Fan_All = 4;  //Modalità 4 = Effetto Music*
          RGB_Musica();
        }
        if (ColoreLED[0] == 604) {
          RGB_Mod_Fan_All = 5;  //Modalità 4 = Effetto Temperatura*
          RGB_Temperatura();
        }
        if ((ColoreLED[0] <= 512) or (ColoreLED[0] > 604)) {
          RGB_Mod_Fan_All = 0;  //Modalità 0 = Reset Animazioni RGB
        }
      }
    }

    if (ModLED_Fan > 0) {
      RGB_Mod_Fan_All = 0;
    }

    if ((ModLED_Fan > 0) or (ModLED_Fan == 1 and OfflineLED_Fan == true) and BRIGHTNESS == 255) {
      //                          Colore,      Saturazione,   Intensità  PixIN       PixEND
      Strip1.fill(Strip1.ColorHSV((ColoreLED[1] * H_P), Saturazione[1], LumLED[1]), 0, NUM_LEDS_Fan_0_1);  //Modalità RGB HSV //Fan1
    }

    if ((ModLED_Fan > 0) or (ModLED_Fan == 2 and OfflineLED_Fan == true) and BRIGHTNESS == 255) {
      //                          Colore,      Saturazione,   Intensità        PixIN                 PixEND
      Strip1.fill(Strip1.ColorHSV((ColoreLED[2] * H_P), Saturazione[2], LumLED[2]), NUM_LEDS_Fan_0_1, NUM_LEDS_Fan_1_2);  //Modalità RGB HSV //Fan2
    }

    if ((ModLED_Fan > 0) or (ModLED_Fan == 3 and OfflineLED_Fan == true) and BRIGHTNESS == 255) {
      //                          Colore,      Saturazione,   Intensità        PixIN                 PixEND
      Strip1.fill(Strip1.ColorHSV((ColoreLED[3] * H_P), Saturazione[3], LumLED[3]), NUM_LEDS_Fan_1_2, NUM_LEDS_Fan_2_3);  //Modalità RGB HSV //Fan3
    }

    if ((ModLED_Fan > 0) or (ModLED_Fan == 4 and OfflineLED_Fan == true) and BRIGHTNESS == 255) {
      //                          Colore,      Saturazione,   Intensità        PixIN                 PixEND
      Strip1.fill(Strip1.ColorHSV((ColoreLED[4] * H_P), Saturazione[4], LumLED[4]), NUM_LEDS_Fan_2_3, NUM_LEDS_Fan_3_4);  //Modalità RGB HSV //Fan4
    }

    //    if ((ModLED_Fan > 0) or (ModLED_Fan == 5 and OfflineLED_Fan == true)) {
    //      uint32_t H_5 = map(ColoreLED[5], 0, 255, 0, 65536);
    //      //                           Colore,     Saturazione,     Intensità
    //      //Strip5.fill(Strip5.ColorHSV(H_5       , Saturazione[5], LumLED[5]));            //Modalità RGB HSV //FAN_OP_CPU
    //    }
    //
    //    if ((ModLED_Fan > 0) or (ModLED_Fan == 6 and OfflineLED_Fan == true)) {
    //      uint32_t H_6 = map(ColoreLED[6], 0, 255, 0, 65536);
    //      //                           Colore,      Saturazione,   Intensità
    //      //Strip6.fill(Strip6.ColorHSV(H_6       , Saturazione[6], LumLED[6]));            //Modalità RGB HSV //FAN_OP_CPU
    //    }
    //
    //    if ((ModLED_Fan > 0) or (ModLED_Fan == 7 and OfflineLED_Fan == true)) {
    //      uint32_t H_7 = map(ColoreLED[7], 0, 255, 0, 65536);
    //      //                           Colore,      Saturazione,   Intensità
    //      //Strip7.fill(Strip7.ColorHSV(H_7       , Saturazione[7], LumLED[7]));            //Modalità RGB HSV //FAN_OP_CPU
    //    }

    if ((ModLED_Fan > 0) or (ModLED_Fan == 8 and OfflineLED_Fan == true) and BRIGHTNESS == 255) {
      //                          Colore,      Saturazione,   Intensità        PixIN                 PixEND
      Strip1.fill(Strip1.ColorHSV((ColoreLED[8] * H_P), Saturazione[8], LumLED[8]), NUM_LEDS_Fan_3_4, NUM_LEDS_OUT_7_8);  //Modalità RGB HSV //GPU
    }

    if ((ModLED_Fan > 0) or (ModLED_Fan == 9 and OfflineLED_Fan == true) and BRIGHTNESS == 255) {
      //                          Colore,      Saturazione,   Intensità
      Strip2.fill(Strip2.ColorHSV((ColoreLED[9] * H_P), Saturazione[9], LumLED[9]));  //Modalità RGB HSV //Striscia LED
    }

    if ((ModLED_Fan > 0) or (ModLED_Fan == 10 and OfflineLED_Fan == true) and BRIGHTNESS == 255) {
      //                          Colore,      Saturazione,   Intensità        PixIN                     PixEND
      Strip3.fill(Strip3.ColorHSV((ColoreLED[10] * H_P), Saturazione[10], LumLED[10]), 0, NUM_LEDS_OUT_10);  //Modalità RGB HSV //Cassa Audio Sinistra
    }

    if ((ModLED_Fan > 0) or (ModLED_Fan == 11 and OfflineLED_Fan == true) and BRIGHTNESS == 255) {
      //                          Colore,      Saturazione,   Intensità
      Strip3.fill(Strip3.ColorHSV((ColoreLED[11] * H_P), Saturazione[11], LumLED[11]), NUM_LEDS_OUT_10, (NUM_LEDS_OUT_10 + NUM_LEDS_OUT_11));  //Modalità RGB HSV //Cassa Audio Destra
    }

    if ((ModLED_Fan > 0) or (ModLED_Fan == 12 and OfflineLED_Fan == true) and BRIGHTNESS == 255) {
      //                          Colore,      Saturazione,   Intensità        PixIN                 PixEND
      Strip3.fill(Strip3.ColorHSV((ColoreLED[12] * H_P), Saturazione[12], LumLED[12]), (NUM_LEDS_OUT_10 + NUM_LEDS_OUT_11), NUM_LEDS_OUT_12);  //Modalità RGB HSV //Cassa Audio Strisca LED
    }
  }
  /******************************--------------------------------------------***********************************************/
}