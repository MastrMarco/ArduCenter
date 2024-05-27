//*****************************************************************************************************************************//
//                                           Ver: X.08 Firmware data 01/06/24                                                  //
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
          case 2:
          case 3:
          case 4:
          case 8:
            PointLED(NUM_LEDS_ALL[ModLED_Fan - 2], 0);
            break;

          case 9:
            PointLED(0, 1);
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
  Strip[0].updateLength(NUM_LEDS_ALL[7]);  //Ventole *4 + GPU
  Strip[1].updateLength(NUM_LEDS_OUT[9]);
}

//Imposta i LED con il Colore Attivo Disattivo
//                  (Num_LED - ON - OFF - Colore Rosso - Colore Verde)
void AnimazioneSetLED(byte Lnum, byte S, byte N, byte CR, byte CV) {
  switch (ModLED_Fan) {
    case 1:  // Ventola 1
    case 2:  // Ventola 2
    case 3:  // Ventola 3
    case 4:  // Ventola 4
    case 8:  // Scheda Video
      Set_ON_OFF_LED(Lnum, S, N, CR, CV, NUM_LEDS_ALL[ModLED_Fan - 2], 0);
      break;

    case 9:  // Striscia LED
      Set_ON_OFF_LED(Lnum, S, N, CR, CV, 0, 1);
      break;
  }
}


void Set_ON_OFF_LED(byte Lnum, byte S, byte N, byte CR, byte CV, byte s, byte LED) {

  Strip[LED].setPixelColor(((Lnum - N) + s), Strip[LED].Color(0, 50, 50));
  Strip[LED].setPixelColor(((Lnum - S) + s), Strip[LED].Color(CR, CV, 0));
}

void PointLED(byte s, byte LED) {
  Strip[LED].setPixelColor((valLED - 1 + s), Strip[LED].Color(0, Lx, Lx));
}