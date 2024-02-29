//*****************************************************************************************************************************//
//                                           Ver: X.07 Firmware data 25/02/24                                                  //
//*****************************************************************************************************************************//

byte n;
byte prex;
byte Lx;

void Set_LED_Config() {

  if (millis() >= (ResetTimerVirtuale[14] + DelayVirtuale[14])) {
    //**//
    if (stDef == true) {
      Reset_LED();

      if (ModLED_Fan == 9) {
        NUM_LEDS_OUT[9] = 30;
      }

      NUM_LEDS_OUT[ModLED_Fan] = 30;
      ArrayLED();
      Set_LED_ROM();
      BRIGHTNESS = 255;

      n = 30;    //
      prex = n;  //

      stDef = false;
    }


    if (NUM_LEDS_OUT[ModLED_Fan] != valLED) {
      NUM_LEDS_OUT[ModLED_Fan] = valLED;
    }


    if (valLED == 0) {
      NUM_LEDS_OUT[ModLED_Fan] = valLED;
      Reset_LED();
      n = 30;    //
      prex = n;  //
    } else {
      if (prex != valLED and valLED == n) {
        prex = valLED;
      }
      if (n < valLED and n < 30) {
        // (Num_LED - ON - OFF - Colore Rosso - Colore Verde)
        AnimazioneSetLED(n, 1, 0, 0, 5);
        n++;
      }
      if (prex > valLED and n <= 30) {
        n--;
        prex--;
        // (Num_LED - ON - OFF - Colore Rosso - Colore Verde)
        AnimazioneSetLED(n, 0, 1, 5, 0);
      }


      if (prex == valLED) {
        DelayVirtuale[14] = 300;
        switch (ModLED_Fan) {
          case 1:
            Strip1.setPixelColor(valLED - 1, Strip1.Color(0, Lx, Lx));  // Ventola 1
            break;
          case 2:
            Strip1.setPixelColor(((valLED - 1) + NUM_LEDS_Fan_0_1), Strip1.Color(0, Lx, Lx));  // Ventola 2
            break;
          case 3:
            Strip1.setPixelColor(((valLED - 1) + NUM_LEDS_Fan_1_2), Strip1.Color(0, Lx, Lx));  // Ventola 3
            break;
          case 4:
            Strip1.setPixelColor(((valLED - 1) + NUM_LEDS_Fan_2_3), Strip1.Color(0, Lx, Lx));  // Ventola 4
            break;
          case 8:
            Strip1.setPixelColor(((valLED - 1) + NUM_LEDS_Fan_3_4), Strip1.Color(0, Lx, Lx));  // Scheda Video
            break;

          case 9:
            Strip2.setPixelColor(valLED - 1, Strip2.Color(0, Lx, Lx));  // Striscia LED
            break;

          case 10:
            Strip3.setPixelColor(valLED - 1, Strip3.Color(0, Lx, Lx));
            break;
          case 11:
            Strip3.setPixelColor(((valLED - 1) + NUM_LEDS_OUT[10]), Strip3.Color(0, Lx, Lx));
            break;
          case 12:
            Strip3.setPixelColor(((valLED - 1) + (NUM_LEDS_OUT[10] + NUM_LEDS_OUT[11])), Strip3.Color(0, Lx, Lx));
            break;
        }
        if (Lx == 0) {
          Lx = 255;
        } else {
          Lx = 0;
        }
      } else {
        DelayVirtuale[14] = 30;
      }
      //**//
    }
    ResetTimerVirtuale[14] = millis();
  }
}


//Imposta La lunghezza dei LED
void Set_LED_ROM() {
  Strip1.updateLength(NUM_LEDS_OUT_7_8);  //Ventole *4 + GPU
  Strip2.updateLength(NUM_LEDS_OUT[9]);
  Strip3.updateLength(NUM_LEDS_OUT[10] + NUM_LEDS_OUT[11] + NUM_LEDS_OUT[12]);
}

//Imposta i LED con il Colore Attivo Disattivo
//                  (Num_LED - ON - OFF - Colore Rosso - Colore Verde)
void AnimazioneSetLED(byte Lnum, byte S, byte N, byte CR, byte CV) {
  switch (ModLED_Fan) {
    case 1:  // Ventola 1
      Strip1.setPixelColor(Lnum - N, Strip1.Color(0, 50, 50));
      Strip1.setPixelColor(Lnum - S, Strip1.Color(CR, CV, 0));
      break;
    case 2:  // Ventola 2
      Strip1.setPixelColor(((Lnum - N) + NUM_LEDS_Fan_0_1), Strip1.Color(0, 50, 50));
      Strip1.setPixelColor(((Lnum - S) + NUM_LEDS_Fan_0_1), Strip1.Color(CR, CV, 0));
      break;
    case 3:  // Ventola 3
      Strip1.setPixelColor(((Lnum - N) + NUM_LEDS_Fan_1_2), Strip1.Color(0, 50, 50));
      Strip1.setPixelColor(((Lnum - S) + NUM_LEDS_Fan_1_2), Strip1.Color(CR, CV, 0));
      break;
    case 4:  // Ventola 4
      Strip1.setPixelColor(((Lnum - N) + NUM_LEDS_Fan_2_3), Strip1.Color(0, 50, 50));
      Strip1.setPixelColor(((Lnum - S) + NUM_LEDS_Fan_2_3), Strip1.Color(CR, CV, 0));
      break;
    case 8:  // Scheda Video
      Strip1.setPixelColor(((Lnum - N) + NUM_LEDS_Fan_3_4), Strip1.Color(0, 50, 50));
      Strip1.setPixelColor(((Lnum - S) + NUM_LEDS_Fan_3_4), Strip1.Color(CR, CV, 0));
      break;

    case 9:  // Striscia LED
      Strip2.setPixelColor(Lnum - N, Strip2.Color(0, 50, 50));
      Strip2.setPixelColor(Lnum - S, Strip2.Color(CR, CV, 0));
      break;

    case 10:  //Cassa Audio Sinistra
      Strip3.setPixelColor(Lnum - N, Strip3.Color(0, 50, 50));
      Strip3.setPixelColor(Lnum - S, Strip3.Color(CR, CV, 0));
      break;
    case 11:  //Cassa Audio Destra
      Strip3.setPixelColor(((Lnum - N) + NUM_LEDS_OUT[10]), Strip3.Color(0, 50, 50));
      Strip3.setPixelColor(((Lnum - S) + NUM_LEDS_OUT[10]), Strip3.Color(CR, CV, 0));
      break;
    case 12:  // Striscia LED
      Strip3.setPixelColor(((Lnum - N) + (NUM_LEDS_OUT[10] + NUM_LEDS_OUT[11])), Strip3.Color(0, 50, 50));
      Strip3.setPixelColor(((Lnum - S) + (NUM_LEDS_OUT[10] + NUM_LEDS_OUT[11])), Strip3.Color(CR, CV, 0));
      break;
  }
}