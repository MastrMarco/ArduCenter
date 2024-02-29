//*****************************************************************************************************************************//
//                                           Ver: X.07 Firmware data 23/02/24                                                  //
//*****************************************************************************************************************************//

int audio_input;
long RGB_MusicaA;
byte FrequenzaAggiornamento = 2;  //Frequenza di aggornamento LED


byte decay_check = 0;

int Audio_pre_react[] = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
int Audio_react[] =     { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};


const int numCampionamenti = 2;  // Numero di campionamenti da effettuare
int media;
int MaxValueAudio = 1023;  // Valore fondo scala LED
//
void RGB_Musica() {

  // if ((millis() - ResetTimerVirtuale[8]) >= DelayVirtuale[8]) {
  //   ResetTimerVirtuale[8] = millis();

  /**/
  if (Boot_SetUp != 0) {
    audio_input = Animation_RGBS[0];                   // Leggi il valore dal sensore
                                                       //--
    static int campionamenti[numCampionamenti];        // Array per memorizzare i campioni
    static int indiceCampionamento = 0;                // Indice per tenere traccia dei campioni
    static int sommaCampioni = 0;                      // Variabile per tenere traccia della somma dei campioni
    campionamenti[indiceCampionamento] = audio_input;  // Salva il campionamento nell'array
    sommaCampioni += audio_input;                      // Aggiungi il valore alla somma totale
    indiceCampionamento++;                             // Incrementa l'indice
    // Se abbiamo effettuato tutti i campionamenti
    if (indiceCampionamento >= numCampionamenti) {
      media = sommaCampioni / numCampionamenti;  // Calcola la media
      if (media > 50) {
        media -= 50;
      }
      sommaCampioni = 0;        // Resetta la somma
      indiceCampionamento = 0;  // Resetta l'indice
    }
    //--

    if (audio_input > MaxValueAudio) {
      MaxValueAudio = audio_input;
    }
    if (media < MaxValueAudio - 25) {
      MaxValueAudio--;
    }

  } else {
    audio_input = 2;
    media = 0;
    MaxValueAudio = 1;
  }

  /**/
  if (RGB_MusicaA <= 327424) RGB_MusicaA += 256;
  if (RGB_MusicaA == 327424) RGB_MusicaA = 0;
  /**/

  {
    Audio_pre_react[0] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[1]);
    Audio_pre_react[1] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[2]);
    Audio_pre_react[2] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[3]);
    Audio_pre_react[3] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[4]);
    // Audio_pre_react[4] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[5]);
    // Audio_pre_react[5] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[6]);
    // Audio_pre_react[6] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[7]);
    Audio_pre_react[7] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[8]);
    Audio_pre_react[8] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[9]);
    Audio_pre_react[9] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[10]);
    Audio_pre_react[10] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[11]);
    Audio_pre_react[11] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[12]);


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
  for (int A = NUM_LEDS_OUT[1] - 1; A >= 0; A--) {
    if (A < Audio_react[0]) {
      int pixelHue_1 = RGB_MusicaA + (A * 65536L / NUM_LEDS_OUT[1]);
      Strip1.setPixelColor(A, Strip1.gamma32(Strip1.ColorHSV(pixelHue_1)));
    } else {
      Strip1.setPixelColor(A, 0, 0, 0);
    }
  }
  //**/2
  for (int B = NUM_LEDS_OUT[2] - 1; B >= 0; B--) {
    if (B < Audio_react[1]) {
      int pixelHue_2 = RGB_MusicaA + (B * 65536L / NUM_LEDS_OUT[2]);
      Strip1.setPixelColor(B + NUM_LEDS_Fan_0_1, Strip1.gamma32(Strip1.ColorHSV(pixelHue_2)));
    } else {
      Strip1.setPixelColor(B + NUM_LEDS_Fan_0_1, 0, 0, 0);
    }
  }
  // //**/3
  for (int C = NUM_LEDS_OUT[3] - 1; C >= 0; C--) {
    if (C < Audio_react[2]) {
      int pixelHue_3 = RGB_MusicaA + (C * 65536L / NUM_LEDS_OUT[3]);
      Strip1.setPixelColor(C + NUM_LEDS_Fan_1_2, Strip1.gamma32(Strip1.ColorHSV(pixelHue_3)));
    } else {
      Strip1.setPixelColor(C + NUM_LEDS_Fan_1_2, 0, 0, 0);
    }
  }
  //**/4
  for (int D = NUM_LEDS_OUT[4] - 1; D >= 0; D--) {
    if (D < Audio_react[3]) {
      int pixelHue_4 = RGB_MusicaA + (D * 65536L / NUM_LEDS_OUT[4]);
      Strip1.setPixelColor(D + NUM_LEDS_Fan_2_3, Strip1.gamma32(Strip1.ColorHSV(pixelHue_4)));
    } else {
      Strip1.setPixelColor(D + NUM_LEDS_Fan_2_3, 0, 0, 0);
    }
  }

  //**/8
  for (int H = NUM_LEDS_OUT[8] - 1; H >= 0; H--) {
    if (H < Audio_react[7]) {
      int pixelHue_8 = RGB_MusicaA + (H * 65536L / NUM_LEDS_OUT[8]);
      Strip1.setPixelColor(H + NUM_LEDS_Fan_3_4, Strip1.gamma32(Strip1.ColorHSV(pixelHue_8)));
    } else {
      Strip1.setPixelColor(H + NUM_LEDS_Fan_3_4, 0, 0, 0);
    }
  }
  //**/9
  for (int I = NUM_LEDS_OUT[9] - 1; I >= 0; I--) {
    if (I < Audio_react[8]) {
      int pixelHue_9 = RGB_MusicaA + (I * 65536L / NUM_LEDS_OUT[9]);
      Strip2.setPixelColor(I, Strip2.gamma32(Strip2.ColorHSV(pixelHue_9)));
    } else {
      Strip2.setPixelColor(I, 0, 0, 0);
    }
  }


  //**/10
  for (int J = NUM_LEDS_OUT[10] - 1; J >= 0; J--) {
    if (J < Audio_react[9]) {
      int pixelHue_10 = RGB_MusicaA + (J * 65536L / NUM_LEDS_OUT[10]);
      Strip3.setPixelColor(J, Strip3.gamma32(Strip3.ColorHSV(pixelHue_10)));
    } else {
      Strip3.setPixelColor(J, 0, 0, 0);
    }
  }
  //**/11
  for (int K = NUM_LEDS_OUT[11] - 1; K >= 0; K--) {
    if (K < Audio_react[10]) {
      int pixelHue_11 = RGB_MusicaA + (K * 65536L / NUM_LEDS_OUT[11]);
      Strip3.setPixelColor(K + NUM_LEDS_OUT[10], Strip3.gamma32(Strip3.ColorHSV(pixelHue_11)));
    } else {
      Strip3.setPixelColor(K + NUM_LEDS_OUT[10], 0, 0, 0);
    }
  }
  //**/12
  for (int L = NUM_LEDS_OUT[12] - 1; L >= 0; L--) {
    if (L < Audio_react[11]) {
      int pixelHue_12 = RGB_MusicaA + (L * 65536L / NUM_LEDS_OUT[12]);
      Strip3.setPixelColor(L + NUM_LEDS_OUT[10] + NUM_LEDS_OUT[11], Strip3.gamma32(Strip3.ColorHSV(pixelHue_12)));
    } else {
      Strip3.setPixelColor(L + NUM_LEDS_OUT[10] + NUM_LEDS_OUT[11], 0, 0, 0);
    }
  }
}
