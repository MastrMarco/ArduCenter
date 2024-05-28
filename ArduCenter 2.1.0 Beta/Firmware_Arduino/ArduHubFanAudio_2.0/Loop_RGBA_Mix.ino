//*****************************************************************************************************************************//
//                                           Ver: X.07 Firmware data 12/01/24                                                  //
//*****************************************************************************************************************************//

byte V_Fade = 0;
byte V_FadeRand = 0;
byte H_Mix;

void RGB_Mix() {
  if (millis() >= (ResetTimerVirtuale[13] + DelayVirtuale[13])) {
    ResetTimerVirtuale[13] = millis();


    if (V_Fade == V_FadeRand) {
      V_FadeRand = random(13, 255);
      H_Mix = random(0, 14);
    }
    if (V_Fade < V_FadeRand) V_Fade++;
    if (V_Fade > V_FadeRand) V_Fade--;

    //         Colore,  Saturazione, Intensità
    ParallelStripLED(H_Mix, 255, V_Fade);
  }
}