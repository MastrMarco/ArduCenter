//*****************************************************************************************************************************//
//                                           Ver: X.06 Firmware data 23/10/23                                                  //
//*****************************************************************************************************************************//
byte V_Fade = 0;
byte V_FadeRand = 0;
byte H_Mix;

void RGB_Mix() {
  if (TimerVirtuale[1] >= (ResetTimerVirtuale[13] + DelayVirtuale[13])) {
    ResetTimerVirtuale[13] = TimerVirtuale[1];


    if (V_Fade == V_FadeRand) {
      V_FadeRand = random(13, 255);
      H_Mix = random(0, 14);
    }
    if (V_Fade < V_FadeRand) V_Fade++;
    if (V_Fade > V_FadeRand) V_Fade--;

    //                          Colore,  Saturazione, Intensità
    Strip1.fill(Strip1.ColorHSV(H_Mix * 128, 255, V_Fade));
    Strip2.fill(Strip2.ColorHSV(H_Mix * 128, 255, V_Fade));
  }
}