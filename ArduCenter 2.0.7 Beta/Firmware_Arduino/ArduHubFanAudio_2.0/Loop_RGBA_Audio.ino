int audio_input;
long RGB_MusicaA;
int FrequenzaAggiornamento = 5;  //Frequenza di aggornamento

int decay_check = 0;
//long pre_react = 0;
//long react = 0;

int Audio_decay_check[] = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
long Audio_pre_react[] = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
long Audio_react[] = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

void RGB_Musica() {

  if (TimerVirtuale[1] >= (ResetTimerVirtuale[8] + DelayVirtuale[8])) {
    ResetTimerVirtuale[8] = TimerVirtuale[1];

    /**/
    audio_input = Animation_RGBS[0];
    /**/
    if (RGB_MusicaA <= 327424) RGB_MusicaA += 256;
    if (RGB_MusicaA == 327424) RGB_MusicaA = 0;
    /**/

    {
      //pre_react = ((long)Strip1.numPixels() * (long)audio_input) / 1023L; // TRANSLATE AUDIO LEVEL TO NUMBER OF LEDs
      Audio_pre_react[0] = ((long)NUM_LEDS_OUT_1 * (long)audio_input) / 1023L;  //Fan_1
      Audio_pre_react[1] = ((long)NUM_LEDS_OUT_2 * (long)audio_input) / 1023L;  //Fan_2
      Audio_pre_react[2] = ((long)NUM_LEDS_OUT_3 * (long)audio_input) / 1023L;  //Fan_3
      Audio_pre_react[3] = ((long)NUM_LEDS_OUT_4 * (long)audio_input) / 1023L;  //Fan_4
      //Audio_pre_react[4] = ((long)NUM_LEDS_OUT_5 * (long)audio_input) / 1023L; //Dis
      //Audio_pre_react[5] = ((long)NUM_LEDS_OUT_6 * (long)audio_input) / 1023L; //Dis
      //Audio_pre_react[6] = ((long)NUM_LEDS_OUT_7 * (long)audio_input) / 1023L; //Dis
      Audio_pre_react[7] = ((long)NUM_LEDS_OUT_8 * (long)audio_input) / 1023L;  //GPU
      Audio_pre_react[8] = ((long)NUM_LEDS_OUT_9 * (long)audio_input) / 1023L;  //Strip
      Audio_pre_react[9] = ((long)NUM_LEDS_OUT_10 * (long)audio_input) / 1023L;   //Cassa Audio S
      Audio_pre_react[10] = ((long)NUM_LEDS_OUT_11 * (long)audio_input) / 1023L;  //Cassa Audio D
      Audio_pre_react[11] = ((long)NUM_LEDS_OUT_12 * (long)audio_input) / 1023L;  //Strip Audio
      

      if (Audio_pre_react[0] > Audio_react[0])  // ONLY ADJUST LEVEL OF LED IF LEVEL HIGHER THAN CURRENT LEVEL
        Audio_react[0] = Audio_pre_react[0];

      if (Audio_pre_react[1] > Audio_react[1])  //
        Audio_react[1] = Audio_pre_react[1];

      if (Audio_pre_react[2] > Audio_react[2])  //
        Audio_react[2] = Audio_pre_react[2];

      if (Audio_pre_react[3] > Audio_react[3])  //
        Audio_react[3] = Audio_pre_react[3];

      // if (Audio_pre_react[4] > Audio_react[4])  //
      //   Audio_react[4] = Audio_pre_react[4];

      // if (Audio_pre_react[5] > Audio_react[5])  //
      //   Audio_react[5] = Audio_pre_react[5];

      // if (Audio_pre_react[6] > Audio_react[6])  //
      //   Audio_react[6] = Audio_pre_react[6];

      if (Audio_pre_react[7] > Audio_react[7])  //
        Audio_react[7] = Audio_pre_react[7];

      if (Audio_pre_react[8] > Audio_react[8])  //
        Audio_react[8] = Audio_pre_react[8];

      if (Audio_pre_react[9] > Audio_react[9])  //
        Audio_react[9] = Audio_pre_react[9];

      if (Audio_pre_react[10] > Audio_react[10])  //
        Audio_react[10] = Audio_pre_react[10];

      if (Audio_pre_react[11] > Audio_react[11])  //
        Audio_react[11] = Audio_pre_react[11];
    }
    // REMOVE LEDs
    decay_check++;
    if (decay_check > FrequenzaAggiornamento) {
      decay_check = 0;

      if (Audio_react[0] > 0)
        Audio_react[0]--;

      if (Audio_react[1] > 0)
        Audio_react[1]--;

      if (Audio_react[2] > 0)
        Audio_react[2]--;

      if (Audio_react[3] > 0)
        Audio_react[3]--;

      // if (Audio_react[4] > 0)
      //   Audio_react[4]--;

      // if (Audio_react[5] > 0)
      //   Audio_react[5]--;

      // if (Audio_react[6] > 0)
      //   Audio_react[6]--;

      if (Audio_react[7] > 0)
        Audio_react[7]--;

      if (Audio_react[8] > 0)
        Audio_react[8]--;

      if (Audio_react[9] > 0)
        Audio_react[9]--;

      if (Audio_react[10] > 0)
        Audio_react[10]--;

      if (Audio_react[11] > 0)
        Audio_react[11]--;
    }
    /**/

    //**/1
    for (int A = NUM_LEDS_OUT_1 - 1; A >= 0; A--) {
      if (A < Audio_react[0]) {
        int pixelHue_1 = RGB_MusicaA + (A * 65536L / NUM_LEDS_OUT_1);
        Strip1.setPixelColor(A, Strip1.gamma32(Strip1.ColorHSV(pixelHue_1)));
      } else {
        Strip1.setPixelColor(A, 0, 0, 0);
      }
    }
    //**/2
    for (int B = NUM_LEDS_OUT_2 - 1; B >= 0; B--) {
      if (B < Audio_react[1]) {
        int pixelHue_2 = RGB_MusicaA + (B * 65536L / NUM_LEDS_OUT_2);
        //Strip2.setPixelColor(B, Strip2.gamma32(Strip2.ColorHSV(pixelHue_2)));
        Strip1.setPixelColor(B + NUM_LEDS_Fan_0_1, Strip1.gamma32(Strip1.ColorHSV(pixelHue_2)));
      } else {
        Strip1.setPixelColor(B + NUM_LEDS_Fan_0_1, 0, 0, 0);
      }
    }
    //**/3
    for (int C = NUM_LEDS_OUT_3 - 1; C >= 0; C--) {
      if (C < Audio_react[2]) {
        int pixelHue_3 = RGB_MusicaA + (C * 65536L / NUM_LEDS_OUT_3);
        Strip1.setPixelColor(C + NUM_LEDS_Fan_1_2, Strip1.gamma32(Strip1.ColorHSV(pixelHue_3)));
      } else {
        Strip1.setPixelColor(C + NUM_LEDS_Fan_1_2, 0, 0, 0);
      }
    }
    //**/4
    for (int D = NUM_LEDS_OUT_4 - 1; D >= 0; D--) {
      if (D < Audio_react[3]) {
        int pixelHue_4 = RGB_MusicaA + (D * 65536L / NUM_LEDS_OUT_4);
        Strip1.setPixelColor(D + NUM_LEDS_Fan_2_3, Strip1.gamma32(Strip1.ColorHSV(pixelHue_4)));
      } else {
        Strip1.setPixelColor(D + NUM_LEDS_Fan_2_3, 0, 0, 0);
      }
    }


    //**/5
    // for (int E = NUM_LEDS_OUT_5 - 1; E >= 0; E--) {
    //   if (E < Audio_react[4]) {
    //     int pixelHue_5 = RGB_MusicaA + (E * 65536L / NUM_LEDS_OUT_5);
    //     Strip5.setPixelColor(E, Strip5.gamma32(Strip5.ColorHSV(pixelHue_5)));
    //   } else {
    //     Strip5.setPixelColor(E, 0, 0, 0);
    //   }
    // }
    // //**/6
    // for (int F = NUM_LEDS_OUT_6 - 1; F >= 0; F--) {
    //   if (F < Audio_react[5]) {
    //     int pixelHue_6 = RGB_MusicaA + (F * 65536L / NUM_LEDS_OUT_6);
    //     Strip6.setPixelColor(F, Strip6.gamma32(Strip6.ColorHSV(pixelHue_6)));
    //   } else {
    //     Strip6.setPixelColor(F, 0, 0, 0);
    //   }
    // }
    // //**/7
    // for (int G = NUM_LEDS_OUT_7 - 1; G >= 0; G--) {
    //   if (G < Audio_react[6]) {
    //     int pixelHue_7 = RGB_MusicaA + (G * 65536L / NUM_LEDS_OUT_7);
    //     Strip7.setPixelColor(G, Strip7.gamma32(Strip7.ColorHSV(pixelHue_7)));
    //   } else {
    //     Strip7.setPixelColor(G, 0, 0, 0);
    //   }
    // }


    //**/8
    for (int H = NUM_LEDS_OUT_8 - 1; H >= 0; H--) {
      if (H < Audio_react[7]) {
        int pixelHue_8 = RGB_MusicaA + (H * 65536L / NUM_LEDS_OUT_8);
        Strip1.setPixelColor(H + NUM_LEDS_Fan_3_4, Strip1.gamma32(Strip1.ColorHSV(pixelHue_8)));
      } else {
        Strip1.setPixelColor(H + NUM_LEDS_Fan_3_4, 0, 0, 0);
      }
    }
    //**/9
    for (int I = NUM_LEDS_OUT_9 - 1; I >= 0; I--) {
      if (I < Audio_react[8]) {
        int pixelHue_9 = RGB_MusicaA + (I * 65536L / NUM_LEDS_OUT_9);
        Strip2.setPixelColor(I, Strip2.gamma32(Strip2.ColorHSV(pixelHue_9)));
      } else {
        Strip2.setPixelColor(I, 0, 0, 0);
      }
    }


    //**/10
    for (int J = NUM_LEDS_OUT_10 - 1; J >= 0; J--) {
      if (J < Audio_react[9]) {
        int pixelHue_10 = RGB_MusicaA + (J * 65536L / NUM_LEDS_OUT_10);
        Strip3.setPixelColor(J, Strip3.gamma32(Strip3.ColorHSV(pixelHue_10)));
      } else {
        Strip3.setPixelColor(J, 0, 0, 0);
      }
    }
    //**/11
    for (int K = NUM_LEDS_OUT_11 - 1; K >= 0; K--) {
      if (K < Audio_react[10]) {
        int pixelHue_11 = RGB_MusicaA + (K * 65536L / NUM_LEDS_OUT_11);
        Strip3.setPixelColor(K + NUM_LEDS_OUT_11, Strip3.gamma32(Strip3.ColorHSV(pixelHue_11)));
      } else {
        Strip3.setPixelColor(K + NUM_LEDS_OUT_11, 0, 0, 0);
      }
    }
    //**/12
    for (int L = NUM_LEDS_OUT_12 - 1; L >= 0; L--) {
      if (L < Audio_react[11]) {
        int pixelHue_12 = RGB_MusicaA + (L * 65536L / NUM_LEDS_OUT_12);
        Strip3.setPixelColor(L + NUM_LEDS_OUT_10 + NUM_LEDS_OUT_11, Strip3.gamma32(Strip3.ColorHSV(pixelHue_12)));
      } else {
        Strip3.setPixelColor(L + NUM_LEDS_OUT_10 + NUM_LEDS_OUT_11, 0, 0, 0);
      }
    }
  }
}