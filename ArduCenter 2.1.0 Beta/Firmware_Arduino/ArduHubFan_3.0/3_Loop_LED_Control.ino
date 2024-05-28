//*****************************************************************************************************************************//
//                                           Ver: X.08 Firmware data 27/05/24                                                  //
//*****************************************************************************************************************************//

byte H_P = 128;  // H_P = 65536 / 512 = 128


//Imposta la luminosità tra Mod_Colore e MOD_Animazione
void LumLED_Set() {
  if (ROM_Dati < 3) {
    // if ((ColoreLED[ModLED_Fan] > 512) and (PowerLimitLED_Stato == false)) {
    if (ColoreLED[ModLED_Fan] > 512 and BRIGHTNESS != LumLED[ModLED_Fan]) {
      BRIGHTNESS = LumLED[ModLED_Fan];
    } else if (ColoreLED[ModLED_Fan] <= 512 and BRIGHTNESS != 255) {
      BRIGHTNESS = 255;
    }
  } else {
    BRIGHTNESS = 255;
  }
}


//Spegne Tutti i LED
void Reset_LED() {
  for (byte s = 0; s <= 1; s++) {
    Strip[s].clear();
  }
}

//Serve a creare una strisca LED Unica pre le varie Animnazioni
void ArrayLED() {
  //Reset_Array
  for (byte s = 1; s <= 9; s++) {
    NUM_LEDS_ALL[s] = 0;
  }
  for (byte s = 1; s <= 9; s++) {
    NUM_LEDS_ALL[s] = NUM_LEDS_ALL[s] + NUM_LEDS_OUT[s];
    if (s < 9) {
      NUM_LEDS_ALL[s + 1] = NUM_LEDS_ALL[s];
    }
  }
}

//Avvio loop dove ci sono tutte le modalità LED
void Void_LED_Mod() {
  //----------------------------------------------------------------------
  if (S_Pro_5V == true) {
    Reset_LED();
  } else {

    LumLED_Set();

    if ((ModLED_Fan == 0) or (ModLED_Fan == 0 and Boot_SetUp == 0)) {

      if ((ColoreLED[0] <= 512) and (BRIGHTNESS == 255)) {
        //Imposta la modalità dei LED
        //                      Colore,  Saturazione,  Intensità
        ParallelStripLED((ColoreLED[0] * H_P), Saturazione[0], LumLED[0]);
      }

      if (BRIGHTNESS == LumLED[0]) {
        switch (ColoreLED[0]) {
          case 600:
            RGB_Mod_Fan_All = 1;  //Modalità 1 = RGB Effetto Ciclo Discontinuo
            RGB_Discontinuo();
            break;
          case 601:
            RGB_Mod_Fan_All = 2;  //Modalità 2 = RGB Effetto Transizione*
            RGB_Transizione();
            break;
          case 602:
            RGB_Mod_Fan_All = 3;  //Modalità 3 = RGB Effetto RainBow*
            RGB_RainBow();
            break;
          case 603:
            RGB_Mod_Fan_All = 4;  //Modalità 4 = Effetto Music*
            RGB_Musica();
            break;
          case 604:
            RGB_Mod_Fan_All = 5;  //Modalità 5 = Effetto Temperatura*
            RGB_Temperatura();
            break;
          case 605:
            RGB_Mod_Fan_All = 6;  //Modalità 6 = Effetto Festività*
            RGB_Mix();
            break;
        }
      }
    }

    if ((ModLED_Fan > 0) or (ColoreLED[ModLED_Fan] <= 512)) {
      RGB_Mod_Fan_All = 0;
    }

    if (((ModLED_Fan > 0) and (ColoreLED[ModLED_Fan] <= 512)) and (BRIGHTNESS == 255)) {
      for (byte e = 1; e <= 9; e++) {
        //                                       LED,  Colore, S_IN, S_Fin
        if (e >= 1 and (e < 5 or e == 8)) SplitLED(0, e, (NUM_LEDS_ALL[e - 1]), NUM_LEDS_ALL[e]);
        if (e == 9) SplitLED(1, (e), 0, (NUM_LEDS_ALL[e] - NUM_LEDS_ALL[e - 1]));
      }
    }
  }
  /******************************--------------------------------------------***********************************************/
}

void SplitLED(byte s, byte c, byte L0, byte L1) {
  Strip[s].fill(Strip[s].ColorHSV((ColoreLED[c] * H_P), Saturazione[c], LumLED[c]), L0, L1);
}

void SingleStripLED(byte N, uint32_t H, byte S, byte L) {
  if (N <= NUM_LEDS_ALL[8]) {
    Strip[0].setPixelColor(N, Strip[0].ColorHSV(H, S, L));
  } else if (N > NUM_LEDS_ALL[8]) {
    Strip[1].setPixelColor((N - NUM_LEDS_ALL[8]), Strip[1].ColorHSV(H, S, L));
  }
}

void ParallelStripLED(uint32_t H, byte S, byte L) {
  Strip[0].fill(Strip[0].ColorHSV(H, S, L));
  Strip[1].fill(Strip[1].ColorHSV(H, S, L));
}