byte Pix;
byte y;

void RGB_Discontinuo() {
  if (TimerVirtuale[1] >= (ResetTimerVirtuale[9] + DelayVirtuale[9])) {
    ResetTimerVirtuale[9] = TimerVirtuale[1];


    if (Pix <= NUM_LEDS_OUT_All) Pix++;
    if (Pix == NUM_LEDS_OUT_All) {
      Pix = 0;
      if (y < 255) y = y + 25;
      if (y == 255 or y > 255) y = 0;
    }


    uint32_t H = map(y, 0, 255, 0, 65536);
    if (Pix < NUM_LEDS_OUT_1) Strip1.setPixelColor(Pix, Strip1.ColorHSV(H, 255, 255));
    if (Pix >= NUM_LEDS_Fan_0_1 and Pix < NUM_LEDS_Fan_1_2) Strip2.setPixelColor(Pix - (NUM_LEDS_Fan_0_1), Strip2.ColorHSV(H, 255, 255));
    if (Pix >= NUM_LEDS_Fan_1_2 and Pix < NUM_LEDS_Fan_2_3) Strip3.setPixelColor(Pix - (NUM_LEDS_Fan_1_2), Strip3.ColorHSV(H, 255, 255));
    if (Pix >= NUM_LEDS_Fan_2_3 and Pix < NUM_LEDS_Fan_3_4) Strip4.setPixelColor(Pix - (NUM_LEDS_Fan_2_3), Strip4.ColorHSV(H, 255, 255));

    if (Pix >= NUM_LEDS_Fan_3_4 and Pix < NUM_LEDS_OUT_4_5) Strip5.setPixelColor(Pix - (NUM_LEDS_Fan_3_4), Strip5.ColorHSV(H, 255, 255));
    if (Pix >= NUM_LEDS_OUT_4_5 and Pix < NUM_LEDS_OUT_5_6) Strip6.setPixelColor(Pix - (NUM_LEDS_OUT_4_5), Strip6.ColorHSV(H, 255, 255));
    if (Pix >= NUM_LEDS_OUT_5_6 and Pix < NUM_LEDS_OUT_6_7) Strip7.setPixelColor(Pix - (NUM_LEDS_OUT_5_6), Strip7.ColorHSV(H, 255, 255));
    if (Pix >= NUM_LEDS_OUT_6_7 and Pix < NUM_LEDS_OUT_7_8) Strip8.setPixelColor(Pix - (NUM_LEDS_OUT_6_7), Strip8.ColorHSV(H, 255, 255));
    if (Pix >= NUM_LEDS_OUT_7_8 and Pix < NUM_LEDS_OUT_8_9) Strip9.setPixelColor(Pix - (NUM_LEDS_OUT_7_8), Strip9.ColorHSV(H, 255, 255));

  }
}