//*****************************************************************************************************************************//
//                                           Ver: X.07 Firmware data 12/01/24                                                  //
//*****************************************************************************************************************************//

byte H_P = 128;  // H_P = 65536 / 512 = 128

//Imposta la luminosità tra Mod_Colore e MOD_Animazione
void LumLED_Set() {
  if (ROM_Dati < 3) {
    if ((ColoreLED[ModLED_Fan] > 512) and (PowerLimitLED_Stato == false)) {
      BRIGHTNESS = LumLED[ModLED_Fan];
    } else if (RGB_Mod_Fan_All == 0) {
      BRIGHTNESS = 255;
    }
  } else {
    BRIGHTNESS = 255;
  }
}


//Spegne Tutti i LED
void Reset_LED() {
  Strip1.clear();  //Modalità  OFF //LED_1
  Strip2.clear();  //Modalità  OFF //LED_2
  Strip3.clear();  //Modalità  OFF //LED_3
  Strip4.clear();  //Modalità  OFF //LED_4
  Strip5.clear();  //Modalità  OFF //LED_5
  Strip6.clear();  //Modalità  OFF //LED_6
  Strip7.clear();  //Modalità  OFF //LED_7
  Strip8.clear();  //Modalità  OFF //LED_8
  Strip9.clear();  //Modalità  OFF //LED_9
}

//Serve a creare una strisca LED Unica pre le varie Animnazioni
void ArrayLED() {
  NUM_LEDS_Fan_0_1 = NUM_LEDS_OUT[1];                       // Ventola 1
  NUM_LEDS_Fan_1_2 = (NUM_LEDS_OUT[1] + NUM_LEDS_OUT[2]);   // Ventola 2
  NUM_LEDS_Fan_2_3 = (NUM_LEDS_Fan_1_2 + NUM_LEDS_OUT[3]);  // Ventola 3
  NUM_LEDS_Fan_3_4 = (NUM_LEDS_Fan_2_3 + NUM_LEDS_OUT[4]);  // Ventola 4
  NUM_LEDS_OUT_4_5 = (NUM_LEDS_Fan_3_4 + NUM_LEDS_OUT[5]);
  NUM_LEDS_OUT_5_6 = (NUM_LEDS_OUT_4_5 + NUM_LEDS_OUT[6]);
  NUM_LEDS_OUT_6_7 = (NUM_LEDS_OUT_5_6 + NUM_LEDS_OUT[7]);
  NUM_LEDS_OUT_7_8 = (NUM_LEDS_OUT_6_7 + NUM_LEDS_OUT[8]);  // Scheda Video 8
  NUM_LEDS_OUT_8_9 = (NUM_LEDS_OUT_7_8 + NUM_LEDS_OUT[9]);  //Striscia LED 9
  NUM_LEDS_OUT_All = NUM_LEDS_OUT_8_9;
}

//Avvio loop dove ci sono tutte le modalità LED
void Void_LED_Mod() {
  //----------------------------------------------------------------------
  if (S_Pro_5V == true) {
    Reset_LED();
  }

  if (S_Pro_5V == false) {

    if ((ModLED_Fan == 0) or (ModLED_Fan == 0 and Boot_SetUp == 0)) {

      if ((((ColoreLED[0] > 512) and (BRIGHTNESS != LumLED[ModLED_Fan])) or ((ColoreLED[ModLED_Fan] <= 512) and (BRIGHTNESS != 255))) and (Boot_SetUp == false)) {
        LumLED_Set();
      }

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
      //                                    Colore,      Saturazione,   Intensità
      Strip1.fill(Strip1.ColorHSV((ColoreLED[1] * H_P), Saturazione[1], LumLED[1]));  //Modalità RGB HSV //Fan1
      Strip2.fill(Strip2.ColorHSV((ColoreLED[2] * H_P), Saturazione[2], LumLED[2]));  //Modalità RGB HSV //Fan2
      Strip3.fill(Strip3.ColorHSV((ColoreLED[3] * H_P), Saturazione[3], LumLED[3]));  //Modalità RGB HSV //Fan3
      Strip4.fill(Strip4.ColorHSV((ColoreLED[4] * H_P), Saturazione[4], LumLED[4]));  //Modalità RGB HSV //Fan4
      Strip5.fill(Strip5.ColorHSV((ColoreLED[5] * H_P), Saturazione[5], LumLED[5]));  //Modalità RGB HSV //FAN_OP_CPU 1
      Strip6.fill(Strip6.ColorHSV((ColoreLED[6] * H_P), Saturazione[6], LumLED[6]));  //Modalità RGB HSV //FAN_OP_CPU 2
      Strip7.fill(Strip7.ColorHSV((ColoreLED[7] * H_P), Saturazione[7], LumLED[7]));  //Modalità RGB HSV //Pomp_OP_CPU
      Strip8.fill(Strip8.ColorHSV((ColoreLED[8] * H_P), Saturazione[8], LumLED[8]));  //Modalità RGB HSV //GPU
      Strip9.fill(Strip9.ColorHSV((ColoreLED[9] * H_P), Saturazione[9], LumLED[9]));  //Modalità RGB HSV //Striscia LED
    }
  }
  /******************************--------------------------------------------***********************************************/
}



void SingleStripLED(byte N, uint32_t H, byte S, byte L) {
  if (N < NUM_LEDS_OUT[1]) Strip1.setPixelColor(N, Strip1.ColorHSV(H, S, L));
  if (N >= NUM_LEDS_Fan_0_1 and N < NUM_LEDS_Fan_1_2) Strip2.setPixelColor(N - (NUM_LEDS_Fan_0_1), Strip2.ColorHSV(H, S, L));
  if (N >= NUM_LEDS_Fan_1_2 and N < NUM_LEDS_Fan_2_3) Strip3.setPixelColor(N - (NUM_LEDS_Fan_1_2), Strip3.ColorHSV(H, S, L));
  if (N >= NUM_LEDS_Fan_2_3 and N < NUM_LEDS_Fan_3_4) Strip4.setPixelColor(N - (NUM_LEDS_Fan_2_3), Strip4.ColorHSV(H, S, L));

  if (N >= NUM_LEDS_Fan_3_4 and N < NUM_LEDS_OUT_4_5) Strip5.setPixelColor(N - (NUM_LEDS_Fan_3_4), Strip5.ColorHSV(H, S, L));
  if (N >= NUM_LEDS_OUT_4_5 and N < NUM_LEDS_OUT_5_6) Strip6.setPixelColor(N - (NUM_LEDS_OUT_4_5), Strip6.ColorHSV(H, S, L));
  if (N >= NUM_LEDS_OUT_5_6 and N < NUM_LEDS_OUT_6_7) Strip7.setPixelColor(N - (NUM_LEDS_OUT_5_6), Strip7.ColorHSV(H, S, L));

  if (N >= NUM_LEDS_OUT_6_7 and N < NUM_LEDS_OUT_7_8) Strip8.setPixelColor(N - (NUM_LEDS_OUT_6_7), Strip8.ColorHSV(H, S, L));
  if (N >= NUM_LEDS_OUT_7_8 and N < NUM_LEDS_OUT_8_9) Strip9.setPixelColor(N - (NUM_LEDS_OUT_7_8), Strip9.ColorHSV(H, S, L));
}

void ParallelStripLED(uint32_t H, byte S, byte L) {
  Strip1.fill(Strip1.ColorHSV(H, S, L));
  Strip2.fill(Strip2.ColorHSV(H, S, L));
  Strip3.fill(Strip3.ColorHSV(H, S, L));
  Strip4.fill(Strip4.ColorHSV(H, S, L));
  Strip5.fill(Strip5.ColorHSV(H, S, L));
  Strip6.fill(Strip6.ColorHSV(H, S, L));
  Strip7.fill(Strip7.ColorHSV(H, S, L));
  Strip8.fill(Strip8.ColorHSV(H, S, L));
  Strip9.fill(Strip9.ColorHSV(H, S, L));
}