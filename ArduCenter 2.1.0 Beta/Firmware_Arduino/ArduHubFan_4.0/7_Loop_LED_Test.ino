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
      NUM_LEDS_OUT[ModLED_Fan] = 30;
      Set_LED_ROM();
      BRIGHTNESS = 255;
      n = NUM_LEDS_OUT[ModLED_Fan];
      prex = NUM_LEDS_OUT[ModLED_Fan];
      stDef = false;
    }

    if (NUM_LEDS_OUT[ModLED_Fan] != valLED) {
      NUM_LEDS_OUT[ModLED_Fan] = valLED;
    }

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

      if (ModLED_Fan >= 1) {
        Strip[ModLED_Fan - 1].setPixelColor(valLED - 1, Strip[ModLED_Fan - 1].Color(0, Lx, Lx));
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
    ResetTimerVirtuale[14] = millis();
  }
}


//Imposta La lunghezza dei LED
void Set_LED_ROM() {
  for (byte s = 0; s <= 8; s++) {
    Strip[s].updateLength(NUM_LEDS_OUT[s + 1]);
  }
}

//Imposta i LED con il Colore Attivo Disattivo
//                  (Num_LED - ON - OFF - Colore Rosso - Colore Verde)
void AnimazioneSetLED(byte Lnum, byte S, byte N, byte CR, byte CV) {

  if (ModLED_Fan >= 1) {
    Strip[ModLED_Fan - 1].setPixelColor(Lnum - N, Strip[ModLED_Fan - 1].Color(0, 50, 50));
    Strip[ModLED_Fan - 1].setPixelColor(Lnum - S, Strip[ModLED_Fan - 1].Color(CR, CV, 0));
  }
}