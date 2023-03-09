void RGB_Temperatura() {

  //      TempSens
  //      TempCPU
  //      TempGPU
  //      TempC
  if (Animation_RGBS[0] == 1) TempSens = TempDS;
  if (Animation_RGBS[0] == 2) TempSens = TempCPU;
  if (Animation_RGBS[0] == 3) TempSens = TempGPU;

  if (TimerVirtuale[1] >= (ResetTimerVirtuale[6] + DelayVirtuale[6])) {
    ResetTimerVirtuale[6] = TimerVirtuale[1];


    uint32_t H_Temp = map(TempLED, 0, 255, 0, 65536);
    //                         Colore,  Saturazione, Intensità
    Strip1.fill(Strip1.ColorHSV(H_Temp, 255, 255));
    Strip2.fill(Strip2.ColorHSV(H_Temp, 255, 255));
    Strip3.fill(Strip3.ColorHSV(H_Temp, 255, 255));
    //    Strip4.fill(Strip4.ColorHSV(H_Temp      , 255, 255));
    //    Strip5.fill(Strip5.ColorHSV(H_Temp      , 255, 255));
    //    Strip6.fill(Strip6.ColorHSV(H_Temp      , 255, 255));
    //    Strip7.fill(Strip7.ColorHSV(H_Temp      , 255, 255));
    //    Strip8.fill(Strip8.ColorHSV(H_Temp      , 255, 255));
    //    Strip9.fill(Strip9.ColorHSV(H_Temp      , 255, 255));
    //Freddo
    if (TempSens <= 29 and TempLED <= 128) TempLED++;
    //Normale
    if ((TempSens >= 30 and TempSens <= 39) and (TempLED <= 96)) TempLED++;
    if ((TempSens >= 30 and TempSens <= 39) and (TempLED >= 96)) TempLED = TempLED - 1;
    //Medio
    if ((TempSens >= 40 and TempSens <= 49) and (TempLED <= 64)) TempLED++;
    if ((TempSens >= 40 and TempSens <= 49) and (TempLED >= 64)) TempLED = TempLED - 1;
    //Tiepido
    if ((TempSens >= 50 and TempSens <= 69) and (TempLED <= 24)) TempLED++;
    if ((TempSens >= 50 and TempSens <= 69) and (TempLED >= 24)) TempLED = TempLED - 1;
    //Caldo
    if ((TempSens >= 70) and (TempLED <= 0)) TempLED++;
    if ((TempSens >= 70) and (TempLED >= 0)) TempLED = TempLED - 1;
  }
}