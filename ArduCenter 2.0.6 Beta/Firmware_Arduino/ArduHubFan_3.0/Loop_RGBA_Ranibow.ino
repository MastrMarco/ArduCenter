long RGB_RainBowA;
void RGB_RainBow() {


  if (TimerVirtuale[1] >= (ResetTimerVirtuale[5] + DelayVirtuale[5])) {
    ResetTimerVirtuale[5] = TimerVirtuale[1];

    if (RGB_RainBowA <= 327424) RGB_RainBowA += 256;
    if (RGB_RainBowA == 327424) RGB_RainBowA = 0;

    //for (int i = 0; i < Strip1.numPixels(); i++) {
    for (int i = 0; i < NUM_LEDS_OUT_All; i++) {

      int pixelHue = RGB_RainBowA + (i * 65536L / NUM_LEDS_OUT_All);


      //Strip1.setPixelColor(i, Strip1.gamma32(Strip1.ColorHSV(pixelHue)));
      if (i < NUM_LEDS_ALL) Strip1.setPixelColor(i, Strip1.gamma32(Strip1.ColorHSV(pixelHue)));
      if ((i >= NUM_LEDS_ALL) and (i < NUM_LEDS_OUT_All)) Strip2.setPixelColor(i - NUM_LEDS_ALL, Strip2.gamma32(Strip2.ColorHSV(pixelHue)));
    }
  }
}