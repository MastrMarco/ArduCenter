//*****************************************************************************************************************************//
//    Modifica aquisizione Tensione,   Modifica Tempi                       Ver: 2.03 Firmware data 23/04/23                   //
//*****************************************************************************************************************************//


bool SetOFF;

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

  //
  //---------------------- Protezione invesione di Alimentazione 5V
  //
  if ((Volt_5V < 4.75) and (EN_OV == true) and (Aniamzione_Avvio == true)) {
    S_Pro_5V = true;  //0
    digitalWrite(OV, LOW);
  }
  if (Volt_5V > 5.60 and (EN_OV == true) and (Aniamzione_Avvio == true)) {
    S_Pro_5V = true;  //1
    digitalWrite(OV, LOW);
  }
  if ((Volt_5V <= 5.60) and (Volt_5V >= 4.75) and (Aniamzione_Avvio == false)) {
    S_Pro_5V = false;  //0
    digitalWrite(OV, HIGH);
  } else if ((Volt_5V > 5.60 or Volt_5V < 4.75) and (Aniamzione_Avvio == false)) {
    S_Pro_5V = true;
    digitalWrite(OV, LOW);
  }
  //
  //---------------------- Protezione invesione di Alimentazione 12V
  //
  if ((Volt_12V <= 11.75) and (EN_OV == true) and (Aniamzione_Avvio == true)) {
    S_Pro_12V = true;  //1
  }
  if ((Volt_12V >= 12.40) and (EN_OV == true) and (Aniamzione_Avvio == true)) {
    S_Pro_12V = true;  //1
  }

  if ((Volt_12V <= 12.40) and (Volt_12V >= 11.75) and (Aniamzione_Avvio == false)) {
    S_Pro_12V = false;  //0
  } else if ((Volt_12V > 12.40 or Volt_12V < 11.75) and (Aniamzione_Avvio == false)) {
    S_Pro_12V = true;  //1
  }
  //

  //----------------------PowerLimitLED
  //
  if ((PowerLimitLED == true) and (Volt_5V <= 4.80)) {

    if (TimerVirtuale[1] >= (ResetTimerVirtuale[12] + DelayVirtuale[12])) {
      ResetTimerVirtuale[12] = TimerVirtuale[1];

      if (LumLED[ModLED_Fan] > 13) LumLED[ModLED_Fan] = LumLED[ModLED_Fan] - 20;
    }
    PowerLimitLED_Stato = true;
  }
  if ((PowerLimitLED == true) and (Volt_5V >= 4.90) and (Volt_5V <= 5.60)) {
    if (LumLED[ModLED_Fan] < 13 and LumLED[ModLED_Fan] > 0) LumLED[ModLED_Fan] = 13;
  }
  if (PowerLimitLED == false) {
    PowerLimitLED_Stato = false;
  }
  //
  //----------------------
  //
  if (EN_OV == false and Aniamzione_Avvio == true) {
    digitalWrite(OV, HIGH);
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