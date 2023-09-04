int RGB_TransizioneA = 0;
void RGB_Transizione() {

  if (TimerVirtuale[1] >= (ResetTimerVirtuale[7] + DelayVirtuale[7])) {
    ResetTimerVirtuale[7] = TimerVirtuale[1];

    if (RGB_TransizioneA < 4024) RGB_TransizioneA++;
    if (RGB_TransizioneA >= 4024) RGB_TransizioneA = 0;


    uint32_t H_Transiozione = map(RGB_TransizioneA, 0, 4024, 0, 65536);
    //                          Colore,  Saturazione, Intensità
    Strip1.fill(Strip1.ColorHSV(H_Transiozione, 255, 255));
    Strip2.fill(Strip2.ColorHSV(H_Transiozione, 255, 255));
  }
}