//*****************************************************************************************************************************//
//                                           Ver: X.08 Firmware data 01/06/24                                                  //
//*****************************************************************************************************************************//

byte Pix;
byte H_Discontinuo = 255;

void RGB_Discontinuo() {
  if (millis() >= (ResetTimerVirtuale[9] + DelayVirtuale[9])) {
    ResetTimerVirtuale[9] = millis();


    if (Pix <= NUM_LEDS_ALL[8]) Pix++;
    if (Pix == NUM_LEDS_ALL[8]) {
      Pix = 0;
      H_Discontinuo = random(0, 255);
    }

    uint32_t H = map(H_Discontinuo, 0, 255, 0, 65536);
   SingleStripLED(Pix, H, 255, 255);
   }
}