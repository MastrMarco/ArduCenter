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
      switch (ModLED_Fan) {
        case 1:
          Strip1.setPixelColor(valLED - 1, Strip1.Color(0, Lx, Lx));
          break;
        case 2:
          Strip2.setPixelColor(valLED - 1, Strip2.Color(0, Lx, Lx));
          break;
        case 3:
          Strip3.setPixelColor(valLED - 1, Strip3.Color(0, Lx, Lx));
          break;
        case 4:
          Strip4.setPixelColor(valLED - 1, Strip4.Color(0, Lx, Lx));
          break;
        case 5:
          Strip5.setPixelColor(valLED - 1, Strip5.Color(0, Lx, Lx));
          break;
        case 6:
          Strip6.setPixelColor(valLED - 1, Strip6.Color(0, Lx, Lx));
          break;
        case 7:
          Strip7.setPixelColor(valLED - 1, Strip7.Color(0, Lx, Lx));
          break;
        case 8:
          Strip8.setPixelColor(valLED - 1, Strip8.Color(0, Lx, Lx));
          break;
        case 9:
          Strip9.setPixelColor(valLED - 1, Strip9.Color(0, Lx, Lx));
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
    ResetTimerVirtuale[14] = millis();
  }
}


//Imposta La lunghezza dei LED
void Set_LED_ROM() {
  Strip1.updateLength(NUM_LEDS_OUT[1]);
  Strip2.updateLength(NUM_LEDS_OUT[2]);
  Strip3.updateLength(NUM_LEDS_OUT[3]);
  Strip4.updateLength(NUM_LEDS_OUT[4]);
  Strip5.updateLength(NUM_LEDS_OUT[5]);
  Strip6.updateLength(NUM_LEDS_OUT[6]);
  Strip7.updateLength(NUM_LEDS_OUT[7]);
  Strip8.updateLength(NUM_LEDS_OUT[8]);
  Strip9.updateLength(NUM_LEDS_OUT[9]);
}

//Imposta i LED con il Colore Attivo Disattivo
//                  (Num_LED - ON - OFF - Colore Rosso - Colore Verde)
void AnimazioneSetLED(byte Lnum, byte S, byte N, byte CR, byte CV) {
  switch (ModLED_Fan) {
    case 1:
      Strip1.setPixelColor(Lnum - N, Strip1.Color(0, 50, 50));
      Strip1.setPixelColor(Lnum - S, Strip1.Color(CR, CV, 0));
      break;
    case 2:
      Strip2.setPixelColor(Lnum - N, Strip2.Color(0, 50, 50));
      Strip2.setPixelColor(Lnum - S, Strip2.Color(CR, CV, 0));
      break;
    case 3:
      Strip3.setPixelColor(Lnum - N, Strip3.Color(0, 50, 50));
      Strip3.setPixelColor(Lnum - S, Strip3.Color(CR, CV, 0));
      break;
    case 4:
      Strip4.setPixelColor(Lnum - N, Strip4.Color(0, 50, 50));
      Strip4.setPixelColor(Lnum - S, Strip4.Color(CR, CV, 0));
      break;
    case 5:
      Strip5.setPixelColor(Lnum - N, Strip5.Color(0, 50, 50));
      Strip5.setPixelColor(Lnum - S, Strip5.Color(CR, CV, 0));
      break;
    case 6:
      Strip6.setPixelColor(Lnum - N, Strip6.Color(0, 50, 50));
      Strip6.setPixelColor(Lnum - S, Strip6.Color(CR, CV, 0));
      break;
    case 7:
      Strip7.setPixelColor(Lnum - N, Strip7.Color(0, 50, 50));
      Strip7.setPixelColor(Lnum - S, Strip7.Color(CR, CV, 0));
      break;
    case 8:
      Strip8.setPixelColor(Lnum - N, Strip8.Color(0, 50, 50));
      Strip8.setPixelColor(Lnum - S, Strip8.Color(CR, CV, 0));
      break;
    case 9:
      Strip9.setPixelColor(Lnum - N, Strip9.Color(0, 50, 50));
      Strip9.setPixelColor(Lnum - S, Strip9.Color(CR, CV, 0));
      break;
  }
}