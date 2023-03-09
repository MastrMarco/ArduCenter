long RGB_RainBowA;
void RGB_RainBow() {


  if (TimerVirtuale[1] >= (ResetTimerVirtuale[5] + DelayVirtuale[5])) {
    ResetTimerVirtuale[5] = TimerVirtuale[1];

    if (RGB_RainBowA <= 327424) RGB_RainBowA += 256;
    if (RGB_RainBowA == 327424) RGB_RainBowA = 0;

    for (int i = 0; i < NUM_LEDS_OUT_All; i++) {
      int pixelHue = RGB_RainBowA + (i * 65536L / NUM_LEDS_OUT_All);

      if (i < NUM_LEDS_OUT_1) Strip1.setPixelColor(i, Strip1.gamma32(Strip1.ColorHSV(pixelHue)));
      if (i >= NUM_LEDS_Fan_0_1 and i < NUM_LEDS_Fan_1_2) Strip2.setPixelColor(i - (NUM_LEDS_Fan_0_1), Strip2.gamma32(Strip2.ColorHSV(pixelHue)));
      if (i >= NUM_LEDS_Fan_1_2 and i < NUM_LEDS_Fan_2_3) Strip3.setPixelColor(i - (NUM_LEDS_Fan_1_2), Strip3.gamma32(Strip3.ColorHSV(pixelHue)));
      if (i >= NUM_LEDS_Fan_2_3 and i < NUM_LEDS_Fan_3_4) Strip4.setPixelColor(i - (NUM_LEDS_Fan_2_3), Strip4.gamma32(Strip4.ColorHSV(pixelHue)));

      if (i >= NUM_LEDS_Fan_3_4 and i < NUM_LEDS_OUT_4_5) Strip5.setPixelColor(i - (NUM_LEDS_Fan_3_4), Strip5.gamma32(Strip5.ColorHSV(pixelHue)));
      if (i >= NUM_LEDS_OUT_4_5 and i < NUM_LEDS_OUT_5_6) Strip6.setPixelColor(i - (NUM_LEDS_OUT_4_5), Strip6.gamma32(Strip6.ColorHSV(pixelHue)));
      if (i >= NUM_LEDS_OUT_5_6 and i < NUM_LEDS_OUT_6_7) Strip7.setPixelColor(i - (NUM_LEDS_OUT_5_6), Strip7.gamma32(Strip7.ColorHSV(pixelHue)));
      if (i >= NUM_LEDS_OUT_6_7 and i < NUM_LEDS_OUT_7_8) Strip8.setPixelColor(i - (NUM_LEDS_OUT_6_7), Strip8.gamma32(Strip8.ColorHSV(pixelHue)));
      if (i >= NUM_LEDS_OUT_7_8 and i < NUM_LEDS_OUT_8_9) Strip9.setPixelColor(i - (NUM_LEDS_OUT_7_8), Strip9.gamma32(Strip9.ColorHSV(pixelHue)));
    }

    // for (int i = 0; i < Strip1.numPixels(); i++) {

    //   int pixelHue = RGB_RainBowA + (i * 65536L / Strip1.numPixels());
    //   Strip1.setPixelColor(i, Strip1.gamma32(Strip1.ColorHSV(pixelHue)));
    //   Strip2.setPixelColor(i, Strip2.gamma32(Strip2.ColorHSV(pixelHue)));
    //   Strip3.setPixelColor(i, Strip3.gamma32(Strip3.ColorHSV(pixelHue)));
    //   Strip4.setPixelColor(i, Strip4.gamma32(Strip4.ColorHSV(pixelHue)));
    // }

    // for (int i = 0; i < Strip5.numPixels(); i++) {
    //   int pixelHue = RGB_RainBowA + (i * 65536L / Strip5.numPixels());
    //   Strip5.setPixelColor(i, Strip5.gamma32(Strip5.ColorHSV(pixelHue)));
    //   Strip6.setPixelColor(i, Strip6.gamma32(Strip6.ColorHSV(pixelHue)));
    // }

    // for (int i = 0; i < Strip7.numPixels(); i++) {
    //   int pixelHue = RGB_RainBowA + (i * 65536L / Strip7.numPixels());
    //   Strip7.setPixelColor(i, Strip7.gamma32(Strip7.ColorHSV(pixelHue)));
    // }

    // for (int i = 0; i < Strip8.numPixels(); i++) {
    //   int pixelHue = RGB_RainBowA + (i * 65536L / Strip8.numPixels());
    //   Strip8.setPixelColor(i, Strip8.gamma32(Strip8.ColorHSV(pixelHue)));
    // }

    // for (int i = 0; i < Strip9.numPixels(); i++) {
    //   int pixelHue = RGB_RainBowA + (i * 65536L / Strip9.numPixels());
    //   Strip9.setPixelColor(i, Strip9.gamma32(Strip9.ColorHSV(pixelHue)));
    // }
  }
}