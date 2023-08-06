//*****************************************************************************************************************************//
//                                           Ver: X.04 Firmware data 10/05/23                                                  //
//*****************************************************************************************************************************//

float V12_Limit = 0.60;        //Tolleranza massima e minima della tensione 12V
float V5_Limit = 0.25;         //Tolleranza massima e minima della tensione 5V
float LED_Limt = 4.90;         //Tensione minima dei LED
int StartLEDPowerProt = 500;  // Delay prima di riattivare la Protezione LED dopo la Modlaità di attesa

void Voltaggio() {
  if (Debug == 2) {
    Volt_5V = 5.00;
    Volt_12V = 12.00;
  } else {
    //Serial.println(Volt_5V);
    //---------------------- Converaione in Tensione 5V
    //5V
    if (CampNum_5v < Media_5v) {
      DatiAN_5V += analogRead(Pin_5V);
      CampNum_5v++;
    } else {
      Con_5V = ((DatiAN_5V / (Media_5v + 1)) * 5.00) / 1023;
      Volt_5V = Con_5V / (R2_5V / (R1_5V + R2_5V));
      DatiAN_5V = 0;
      CampNum_5v = 0;
    }

    //
    //---------------------- Converaione in Tensione 12V
    //12V
    if (CampNum_12v < Media_12v) {
      DatiAN_12V += analogRead(Pin_12V);
      CampNum_12v++;
    } else {
      Con_12V = ((DatiAN_12V / (Media_12v + 1)) * 5.00) / 1023;
      Volt_12V = Con_12V / (R2_12V / (R1_12V + R2_12V));
      DatiAN_12V = 0;
      CampNum_12v = 0;
    }
    //
  }

  //---------------------- Protezione Alimentazione 5V [+/- 5%]
  //
  if (((Volt_5V < (5.00 - V5_Limit)) or (Volt_5V > (5.00 + V5_Limit))) and ((Aniamzione_Avvio == true) and (EN_OV == true) and (Mod_attesa == false)) or (Aniamzione_Avvio == false)) {
    S_Pro_5V = true;  //1
  }
  if ((Volt_5V <= (5.00 + V5_Limit)) and (Volt_5V >= (5.00 - V5_Limit)) and (Aniamzione_Avvio == false)) {
    S_Pro_5V = false;  //0
  }
  //
  //---------------------- Protezione Alimentazione 12V [+/- 5%]
  //
  if (((Volt_12V < (12.00 - V12_Limit)) or (Volt_12V > (12.00 + V12_Limit))) and ((Aniamzione_Avvio == true) and (EN_OV == true) and (Mod_attesa == false)) or (Aniamzione_Avvio == false)) {
    S_Pro_12V = true;  //1
  }
  if ((Volt_12V <= (12.00 + V12_Limit)) and (Volt_12V >= (12.00 - V12_Limit)) and (Aniamzione_Avvio == false)) {
    S_Pro_12V = false;  //0
  }
  //

  //----------------------PowerLimitLED
  //
   if ((PowerLimitLED == true) and (Volt_5V < LED_Limt) and ((Mod_attesa == false and Aniamzione_Avvio == true) and (millis() > (DelayFanPower + StartLEDPowerProt)))) {
    //if ((PowerLimitLED == true) and (Volt_5V < LED_Limt) and (Mod_attesa == false and Aniamzione_Avvio == true)) {
    PowerLimitLED_Stato = true;
    if (TimerVirtuale[1] >= (ResetTimerVirtuale[12] + DelayVirtuale[12])) {
      ResetTimerVirtuale[12] = TimerVirtuale[1];
      if ((BRIGHTNESS - (LumLimitLED + 20)) > 13) {
        LumLimitLED = LumLimitLED + 20;
      } else {
        if ((BRIGHTNESS - LumLimitLED) > 13) LumLimitLED = LumLimitLED + 1;
        if ((BRIGHTNESS - LumLimitLED) < 13) LumLimitLED = LumLimitLED - 1;
      }
    }
  }
  // if ((PowerLimitLED == true) and (Volt_5V >= 4.80) and (Volt_5V <= 5.20) and ((LumLED[ModLED_Fan] - LumLimitLED) == 13)) {
  //  //PowerLimitLED_Stato = false;
  // }
  if (PowerLimitLED == false) {
    PowerLimitLED_Stato = false;
    LumLimitLED = 0;
  }
  if (PowerLimitLED_Stato == false) LumLimitLED = 0;
  //
  //----------------------
  //
  if (EN_OV == false and Aniamzione_Avvio == true) {
    S_Pro_5V = false;   //0
    S_Pro_12V = false;  //0
  }

  if (TimerVirtuale[1] >= (ResetTimerVirtuale[2] + DelayVirtuale[2])) {
    ResetTimerVirtuale[2] = TimerVirtuale[1];
    //----------------------
    //
    V5 = Volt_5V, 2;
    V12 = Volt_12V, 2;
  }
}
