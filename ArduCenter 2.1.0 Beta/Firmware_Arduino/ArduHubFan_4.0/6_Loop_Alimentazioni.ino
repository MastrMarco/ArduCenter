//*****************************************************************************************************************************//
//                                           Ver: X.08 Firmware data 28/05/24                                                  //
//*****************************************************************************************************************************//

//AREF
byte CampNum_AREF;
float VoltMedia_AREF = 0;  // Valore converito in tensione Media

//
float V12_Limit = 0.60;       //Tolleranza massima e minima della tensione 12V
float V5_Limit = 0.25;        //Tolleranza massima e minima della tensione 5V Def 0.25
float LED_Limt = 4.80;        //Tensione minima dei LED Def 4.90
int StartLEDPowerProt = 500;  // Delay prima di riattivare la Protezione LED dopo la Modlaità di attesa



//Lettura Tensione Arduino 5V PIN [VCC] Riferimento Analogico di Tensione
float ReadVref() {
  // Legge il riferimento 1.1V rispetto ad Pin 5V [VCC]
  // Imposta il riferimento su VCC e la misurazione sul riferimento interno di 1,1 V
  ADMUX = _BV(REFS0) | _BV(MUX3) | _BV(MUX2) | _BV(MUX1);
  delayMicroseconds(350);               // Aspetta che Vref si stabilizzi
  ADCSRA |= _BV(ADSC);                  // Avvio l'acquisizione dati
  while (bit_is_set(ADCSRA, ADSC)) {};  // misurazione
  float Vref = 1.1 * 1024.0 / ADC;
  Vref -= VoltRef;
  return Vref;
}



//Lettura Tensione Arduino 5V  12V PIN
int Analog_Data;
float Voltmetro(int Pin, float R1, float R2, float ADJ_Error) {
  Analog_Data = analogRead(Pin);
  float DataCon = ((Analog_Data + 0.5) * VAREF) / 1024.0;
  DataCon = DataCon / (R2 / (R1 + R2));
  return (DataCon + ADJ_Error);
}


void Voltaggio() {
  // if (Debug == 2) {
  //   V5 = 5.00;
  //   V12 = 12.00;
  //   S_Pro_5V = false;  //0
  //   S_Pro_12V = false;  //0
  // } else {

  //---------------------- Calcolo Media Analog Reference
  //VAREF
  if (millis() < (TimerVAREF + 15000)) {
    if (CampNum_AREF < Campionamento) {
      CampNum_AREF++;
      VoltMedia_AREF += ReadVref();
    } else {
      VAREF = VoltMedia_AREF / CampNum_AREF;
      VoltMedia_AREF = 0;
      CampNum_AREF = 0;
    }
  }

  if (millis() >= (ResetTimerVirtuale[2] + DelayVirtuale[2])) {
    ResetTimerVirtuale[2] = millis();
    //---------------------- Converaione in Tensione 5V
    //5V
    V5 = Voltmetro(Pin_5V, R1_5V, R2_5V, ADJ_Error_5V);
    //
    //---------------------- Converaione in Tensione 12V
    //12V
    V12 = Voltmetro(Pin_12V, R1_12V, R2_12V, ADJ_Error_12V);
    //
  }
  //Debug
  if (Debug == 2) {
    V5 = 5.00;
    V12 = 12.00;
  }

  //------------------------------------------------------
  if ((EN_OV == true) and (Mod_attesa == false)) {
    //---------------------- Protezione Alimentazione 5V [+/- 5%]
    //
    if (((V5 < (5.00 - V5_Limit)) or (V5 > (5.00 + V5_Limit))) and (Aniamzione_Avvio == true) and (PowerLimitLED == false or LumLimitLED > 240)) {
      S_Pro_5V = true;  //1
    }
    if ((V5 <= (5.00 + V5_Limit)) and (V5 >= (5.00 - V5_Limit)) and (Aniamzione_Avvio == false)) {
      S_Pro_5V = false;  //0
    }
    //
    //---------------------- Protezione Alimentazione 12V [+/- 5%]
    //
    if (((V12 < (12.00 - V12_Limit)) or (V12 > (12.00 + V12_Limit))) and (Aniamzione_Avvio == true)) {
      S_Pro_12V = true;  //1
    }
    if ((V12 <= (12.00 + V12_Limit)) and (V12 >= (12.00 - V12_Limit)) and (Aniamzione_Avvio == false)) {
      S_Pro_12V = false;  //0
    }
  }
  // }
  //
  //----------------------PowerLimitLED
  //
  if ((PowerLimitLED == true) and (V5 < LED_Limt) and ((Mod_attesa == false and Aniamzione_Avvio == true) and (millis() > (DelayFanPower + StartLEDPowerProt)))) {
    PowerLimitLED_Stato = true;
    if (millis() >= (ResetTimerVirtuale[12] + DelayVirtuale[12])) {
      ResetTimerVirtuale[12] = millis();
      if ((BRIGHTNESS - (LumLimitLED + 20)) > 13) {
        LumLimitLED = LumLimitLED + 20;
      } else {
        if ((BRIGHTNESS - LumLimitLED) > 13) LumLimitLED = LumLimitLED + 1;
        if ((BRIGHTNESS - LumLimitLED) < 13) LumLimitLED = LumLimitLED - 1;
      }
    }
  }

  if (PowerLimitLED == false) {
    PowerLimitLED_Stato = false;
    LumLimitLED = 0;
  }
  if (PowerLimitLED_Stato == false) LumLimitLED = 0;
  //
  //----------------------Protezioni Disabilitate
  //
  if (EN_OV == false and Aniamzione_Avvio == true) {
    S_Pro_5V = false;   //0
    S_Pro_12V = false;  //0
  }
}
