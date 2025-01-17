//*****************************************************************************************************************************//
//                                           Ver: X.08 Firmware data 01/06/24                                                  //
//*****************************************************************************************************************************//

int audio_input;
long RGB_MusicaA;
byte FrequenzaAggiornamento = 2;  //Frequenza di aggornamento LED


byte decay_check = 0;

int Audio_pre_react[] = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
int Audio_react[] = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };


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
    // Audio_pre_react[0] = ((long)Strip1.numPixels() * (long)audio_input) / 350L; // TRANSLATE AUDIO LEVEL TO NUMBER OF LEDs
    // Audio_pre_react[0] = (NUM_LEDS_OUT[1] * audio_input) / MaxValueAudio;  // TRANSLATE AUDIO LEVEL TO NUMBER OF LEDs
    Audio_pre_react[0] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[1]);
    Audio_pre_react[1] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[2]);
    Audio_pre_react[2] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[3]);
    Audio_pre_react[3] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[4]);
    Audio_pre_react[4] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[5]);
    Audio_pre_react[5] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[6]);
    Audio_pre_react[6] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[7]);
    Audio_pre_react[7] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[8]);
    Audio_pre_react[8] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[9]);


    if (Audio_pre_react[0] > Audio_react[0])  // ONLY ADJUST LEVEL OF LED IF LEVEL HIGHER THAN CURRENT LEVEL
      Audio_react[0] = Audio_pre_react[0];

    if (Audio_pre_react[1] > Audio_react[1])  //
      Audio_react[1] = Audio_pre_react[1];

    if (Audio_pre_react[2] > Audio_react[2])  //
      Audio_react[2] = Audio_pre_react[2];

    if (Audio_pre_react[3] > Audio_react[3])  //
      Audio_react[3] = Audio_pre_react[3];

    if (Audio_pre_react[4] > Audio_react[4])  //
      Audio_react[4] = Audio_pre_react[4];

    if (Audio_pre_react[5] > Audio_react[5])  //
      Audio_react[5] = Audio_pre_react[5];

    if (Audio_pre_react[6] > Audio_react[6])  //
      Audio_react[6] = Audio_pre_react[6];

    if (Audio_pre_react[7] > Audio_react[7])  //
      Audio_react[7] = Audio_pre_react[7];

    if (Audio_pre_react[8] > Audio_react[8])  //
      Audio_react[8] = Audio_pre_react[8];
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

    if (Audio_react[4] > 0)
      Audio_react[4]--;

    if (Audio_react[5] > 0)
      Audio_react[5]--;

    if (Audio_react[6] > 0)
      Audio_react[6]--;

    if (Audio_react[7] > 0)
      Audio_react[7]--;

    if (Audio_react[8] > 0)
      Audio_react[8]--;
  }
  /**/


  //**/1
  for (int A = NUM_LEDS_OUT[1] - 1; A >= 0; A--) {
    if (A < Audio_react[0]) {
      int pixelHue_1 = RGB_MusicaA + (A * 65536L / NUM_LEDS_OUT[1]);
      Strip[0].setPixelColor(A, Strip[0].gamma32(Strip[0].ColorHSV(pixelHue_1)));
    } else {
      Strip[0].setPixelColor(A, 0, 0, 0);
    }
  }
  //**/ 2
  for (int B = NUM_LEDS_OUT[2] - 1; B >= 0; B--) {
    if (B < Audio_react[1]) {
      int pixelHue_2 = RGB_MusicaA + (B * 65536L / NUM_LEDS_OUT[2]);
      Strip[1].setPixelColor(B, Strip[1].gamma32(Strip[1].ColorHSV(pixelHue_2)));
    } else {
      Strip[1].setPixelColor(B, 0, 0, 0);
    }
  }
  //**/3
  for (int C = NUM_LEDS_OUT[3] - 1; C >= 0; C--) {
    if (C < Audio_react[2]) {
      int pixelHue_3 = RGB_MusicaA + (C * 65536L / NUM_LEDS_OUT[3]);
      Strip[2].setPixelColor(C, Strip[2].gamma32(Strip[2].ColorHSV(pixelHue_3)));
    } else {
      Strip[2].setPixelColor(C, 0, 0, 0);
    }
  }
  //**/4
  for (int D = NUM_LEDS_OUT[4] - 1; D >= 0; D--) {
    if (D < Audio_react[3]) {
      int pixelHue_4 = RGB_MusicaA + (D * 65536L / NUM_LEDS_OUT[4]);
      Strip[3].setPixelColor(D, Strip[3].gamma32(Strip[3].ColorHSV(pixelHue_4)));
    } else {
      Strip[3].setPixelColor(D, 0, 0, 0);
    }
  }
  //**/5
  for (int E = NUM_LEDS_OUT[5] - 1; E >= 0; E--) {
    if (E < Audio_react[4]) {
      int pixelHue_5 = RGB_MusicaA + (E * 65536L / NUM_LEDS_OUT[5]);
      Strip[4].setPixelColor(E, Strip[4].gamma32(Strip[4].ColorHSV(pixelHue_5)));
    } else {
      Strip[4].setPixelColor(E, 0, 0, 0);
    }
  }
  //**/6
  for (int F = NUM_LEDS_OUT[6] - 1; F >= 0; F--) {
    if (F < Audio_react[5]) {
      int pixelHue_6 = RGB_MusicaA + (F * 65536L / NUM_LEDS_OUT[6]);
      Strip[5].setPixelColor(F, Strip[5].gamma32(Strip[5].ColorHSV(pixelHue_6)));
    } else {
      Strip[5].setPixelColor(F, 0, 0, 0);
    }
  }
  //**/7
  for (int G = NUM_LEDS_OUT[7] - 1; G >= 0; G--) {
    if (G < Audio_react[6]) {
      int pixelHue_7 = RGB_MusicaA + (G * 65536L / NUM_LEDS_OUT[7]);
      Strip[6].setPixelColor(G, Strip[6].gamma32(Strip[6].ColorHSV(pixelHue_7)));
    } else {
      Strip[6].setPixelColor(G, 0, 0, 0);
    }
  }
  //**/8
  for (int H = NUM_LEDS_OUT[8] - 1; H >= 0; H--) {
    if (H < Audio_react[7]) {
      int pixelHue_8 = RGB_MusicaA + (H * 65536L / NUM_LEDS_OUT[8]);
      Strip[7].setPixelColor(H, Strip[7].gamma32(Strip[7].ColorHSV(pixelHue_8)));
    } else {
      Strip[7].setPixelColor(H, 0, 0, 0);
    }
  }
  //**/9
  for (int I = NUM_LEDS_OUT[9] - 1; I >= 0; I--) {
    if (I < Audio_react[8]) {
      int pixelHue_9 = RGB_MusicaA + (I * 65536L / NUM_LEDS_OUT[9]);
      Strip[8].setPixelColor(I, Strip[8].gamma32(Strip[8].ColorHSV(pixelHue_9)));
    } else {
      Strip[8].setPixelColor(I, 0, 0, 0);
    }
  }



  // for (byte s = 0; s <= 8; s++) {
  //   // Audio_pre_react[s] = map(audio_input, media, MaxValueAudio, 0, NUM_LEDS_OUT[s + 1]);

  //   // if (Audio_pre_react[s] > Audio_react[s])  //
  //   //   Audio_react[s] = Audio_pre_react[s];

  //   // if (decay_check > FrequenzaAggiornamento) {
  //   //   decay_check = 0;
  //   //   if (Audio_react[s] > 0)
  //   //     Audio_react[s]--;
  //   // }

  //   for (int I = NUM_LEDS_OUT[s + 1] - 1; I >= 0; I--) {
  //     if (I < Audio_react[s]) {
  //       int pixelHue_s = RGB_MusicaA + (I * 65536L / NUM_LEDS_OUT[s + 1]);
  //       Strip[s].setPixelColor(I, Strip[s].gamma32(Strip[s].ColorHSV(pixelHue_s)));
  //     } else {
  //       Strip[s].setPixelColor(I, 0, 0, 0);
  //     }
  //   }
  // }



}