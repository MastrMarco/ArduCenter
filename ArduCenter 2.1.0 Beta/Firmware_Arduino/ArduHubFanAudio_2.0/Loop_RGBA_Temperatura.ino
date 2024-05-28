//*****************************************************************************************************************************//
//                                           Ver: X.07 Firmware data 12/01/24                                                  //
//*****************************************************************************************************************************//

byte TempLED = 128;

void RGB_Temperatura() {

  if (millis() >= (ResetTimerVirtuale[6] + DelayVirtuale[6])) {
    ResetTimerVirtuale[6] = millis();


    uint32_t H_Temp = map(TempLED, 0, 255, 0, 65536);
    //           Colore,  Saturazione, Intensità
    ParallelStripLED(H_Temp, 255, 255);
    //Freddo
    if (TempDS <= 29 and TempLED <= 128) TempLED++;
    //Normale
    if ((TempDS >= 30 and TempDS <= 39) and (TempLED <= 96)) TempLED++;
    if ((TempDS >= 30 and TempDS <= 39) and (TempLED >= 96)) TempLED = TempLED - 1;
    //Medio
    if ((TempDS >= 40 and TempDS <= 49) and (TempLED <= 64)) TempLED++;
    if ((TempDS >= 40 and TempDS <= 49) and (TempLED >= 64)) TempLED = TempLED - 1;
    //Tiepido
    if ((TempDS >= 50 and TempDS <= 69) and (TempLED <= 24)) TempLED++;
    if ((TempDS >= 50 and TempDS <= 69) and (TempLED >= 24)) TempLED = TempLED - 1;
    //Caldo
    if ((TempDS >= 70) and (TempLED <= 0)) TempLED++;
    if ((TempDS >= 70) and (TempLED >= 0)) TempLED = TempLED - 1;

    //           Colore,  Saturazione, Intensità
    ParallelStripLED(H_Temp, 255, 255);
  }
}