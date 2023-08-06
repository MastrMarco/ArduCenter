int RGB_TransizioneA;
void RGB_Transizione() {

  if (TimerVirtuale[1] >= (ResetTimerVirtuale[7] + DelayVirtuale[7])) {
    ResetTimerVirtuale[7] = TimerVirtuale[1];

    if (RGB_TransizioneA < 4024) RGB_TransizioneA++;
    if (RGB_TransizioneA >= 4024) RGB_TransizioneA = 0;


    uint32_t H_Transiozione = map(RGB_TransizioneA, 0, 4024, 0, 65536);
    //                          Colore,  Saturazione, Intensità
    Strip1.fill(Strip1.ColorHSV(H_Transiozione, 255, 255));
    Strip2.fill(Strip2.ColorHSV(H_Transiozione, 255, 255));
    Strip3.fill(Strip3.ColorHSV(H_Transiozione, 255, 255));
    //    Strip3.fill(Strip3.ColorHSV(H_Transiozione      , 255, 255));
    //    Strip4.fill(Strip4.ColorHSV(H_Transiozione      , 255, 255));
    //    Strip5.fill(Strip5.ColorHSV(H_Transiozione      , 255, 255));
    //    Strip6.fill(Strip6.ColorHSV(H_Transiozione      , 255, 255));
    //    Strip7.fill(Strip7.ColorHSV(H_Transiozione      , 255, 255));
    //    Strip8.fill(Strip8.ColorHSV(H_Transiozione      , 255, 255));
    //    Strip9.fill(Strip9.ColorHSV(H_Transiozione      , 255, 255));
  }
}