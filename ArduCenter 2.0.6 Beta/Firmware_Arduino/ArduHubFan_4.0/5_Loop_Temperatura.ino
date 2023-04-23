void TemperaturaDS() {

  if (TimerVirtuale[1] >= (ResetTimerVirtuale[3] + DelayVirtuale[3])) {
    ResetTimerVirtuale[3] = TimerVirtuale[1];

    if (TempData.readTemp()) TempDS = TempData.getTemp();
    TempData.requestTemp();
  }
}
