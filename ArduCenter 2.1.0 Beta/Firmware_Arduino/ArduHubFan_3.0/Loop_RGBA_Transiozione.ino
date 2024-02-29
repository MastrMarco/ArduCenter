//*****************************************************************************************************************************//
//                                           Ver: X.07 Firmware data 12/01/24                                                  //
//*****************************************************************************************************************************//

int RGB_TransizioneA;
void RGB_Transizione() {

  if (millis() >= (ResetTimerVirtuale[7] + DelayVirtuale[7])) {
    ResetTimerVirtuale[7] = millis();

    if (RGB_TransizioneA < 4024) RGB_TransizioneA++;
    if (RGB_TransizioneA >= 4024) RGB_TransizioneA = 0;


    uint32_t H_Transiozione = map(RGB_TransizioneA, 0, 4024, 0, 65536);
    //                  Colore,  Saturazione, Intensità
    ParallelStripLED(H_Transiozione, 255, 255);
  }
}