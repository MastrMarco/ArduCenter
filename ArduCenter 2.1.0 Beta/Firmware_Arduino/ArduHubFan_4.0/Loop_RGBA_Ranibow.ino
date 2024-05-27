//*****************************************************************************************************************************//
//                                           Ver: X.08 Firmware data 01/06/24                                                  //
//*****************************************************************************************************************************//

uint32_t RGB_RainBowA;
void RGB_RainBow() {


  if (millis() >= (ResetTimerVirtuale[5] + DelayVirtuale[5])) {
    ResetTimerVirtuale[5] = millis();

    if (RGB_RainBowA <= 327424) RGB_RainBowA += 256;
    if (RGB_RainBowA == 327424) RGB_RainBowA = 0;

    for (byte i = 0; i < NUM_LEDS_ALL[8]; i++) {
      uint32_t pixelHue = RGB_RainBowA + (i * 65536L / NUM_LEDS_ALL[8]);
       SingleStripLED(i, pixelHue, 255, 255);
    }
  }
}