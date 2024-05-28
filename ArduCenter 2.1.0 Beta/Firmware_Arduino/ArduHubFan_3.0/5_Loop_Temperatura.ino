//*****************************************************************************************************************************//
//                                           Ver: X.07 Firmware data 21/02/24                                                  //
//*****************************************************************************************************************************//

void TemperaturaDS() {
  if (millis() >= (ResetTimerVirtuale[3] + DelayVirtuale[3])) {
    ResetTimerVirtuale[3] = millis();

    if (TempData.readTemp()) {
      TempDS = TempData.getTemp();
      TempData.requestTemp();
    } else {
      TempDS = 0;
    }
  }
}