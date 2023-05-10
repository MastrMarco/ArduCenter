//*****************************************************************************************************************************//
//                                           Ver: X.04 Firmware data 10/05/23                                                  //
//*****************************************************************************************************************************//

byte Pix;
byte H_Discontinuo = 255;

void RGB_Discontinuo() {
  if (TimerVirtuale[1] >= (ResetTimerVirtuale[9] + DelayVirtuale[9])) {
    ResetTimerVirtuale[9] = TimerVirtuale[1];


    if (Pix <= NUM_LEDS_OUT_All) Pix++;
    if (Pix == NUM_LEDS_OUT_All) {
      Pix = 0;
      H_Discontinuo = random(0, 255);
    }

    uint32_t H = map(H_Discontinuo, 0, 255, 0, 65536);
    if (Pix < NUM_LEDS_ALL) Strip1.setPixelColor(Pix, Strip1.ColorHSV(H, 255, 255));
    if ((Pix >= NUM_LEDS_ALL) and (Pix < NUM_LEDS_OUT_8_9)) Strip2.setPixelColor(Pix - NUM_LEDS_ALL, Strip2.ColorHSV(H, 255, 255));
    if ((Pix >= NUM_LEDS_OUT_8_9) and (Pix < NUM_LEDS_OUT_All)) Strip3.setPixelColor(Pix - (NUM_LEDS_ALL + NUM_LEDS_OUT_9), Strip2.ColorHSV(H, 255, 255));
  }
}