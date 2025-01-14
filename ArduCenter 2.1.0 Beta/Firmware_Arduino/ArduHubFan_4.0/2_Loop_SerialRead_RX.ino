//*****************************************************************************************************************************//
//                                           Ver: X.08 Firmware data 01/06/24                                                  //
//*****************************************************************************************************************************//

//Avvio Sistema di lettura dati in arrivo dalla Seriale
void DatiRXloop(int i, String DatoRX) {
  switch (i) {
    case 0:
      // ---------------------------- Boot di avvio / verifica connesione seriale
      if (DatoRX.toInt() == 200) {
        if (Debug != 1) {
          Boot_SetUp = DatoRX.toInt();
        }
      }
      break;
      //
      if (Boot_SetUp == 200) {


        case 1:
          // ---------------------------- Seleziona Elemento
          if ((ModLED_Fan != DatoRX.toInt()) and (DatoRX.toInt() >= 0) and (DatoRX.toInt() <= 9)) {
            PowerLimitLED_Stato = false;
            ModLED_Fan = DatoRX.toInt();
            if (ModLED_Fan < 5) ModFAN_SPEED = ModLED_Fan;
          }
          break;


        case 2:
          // ---------------------------- Luminosità
          if (LumLED[ModLED_Fan] != DatoRX.toInt()) {
            LumLED[ModLED_Fan] = DatoRX.toInt();
            TimerVAREF = millis();  // Ricalcola  Tensione AREF
          }
          break;


        case 3:
          // ---------------------------- Colore
          if ((ColoreLED[ModLED_Fan] != DatoRX.toInt()) and (DatoRX.toInt() < 700)) {
            PowerLimitLED_Stato = false;
            ColoreLED[ModLED_Fan] = DatoRX.toInt();
            TimerVAREF = millis();  // Ricalcola  Tensione AREF
          }
          break;


        case 4:
          // ---------------------------- Saturazione Bianco / Nero
          if ((Saturazione[ModLED_Fan] != DatoRX.toInt()) and (DatoRX.toInt() >= 0) and (DatoRX.toInt() <= 255)) {
            PowerLimitLED_Stato = false;
            Saturazione[ModLED_Fan] = DatoRX.toInt();
          }
          break;


        case 5:
          // ---------------------------- Velocità Ventole
          if ((ModLED_Fan < 5) and (FanSpeed[ModLED_Fan] != DatoRX.toInt()) and (DatoRX.toInt() >= 0) and (DatoRX.toInt() <= 255) and (Fan_Mod_Speed[ModLED_Fan] == 0)) {
            FanSpeed[ModLED_Fan] = DatoRX.toInt();
            TimerVAREF = millis();  // Ricalcola  Tensione AREF
          }
          break;


        case 6:
          // ----------------------------
          break;


        case 7:
          // ----------------------------
          break;


        case 8:
          // ----------------------------
          break;


        case 9:
          // if (Animation_RGBS[0] != DatoRX.toInt()) {
          Animation_RGBS[0] = DatoRX.toInt();
          //  }
          break;


        case 10:
          // ---------------------------- Attiva / Disattiva Memorizazzione dati utente O Configura HUB
          if ((ROM_Dati != DatoRX.toInt()) and (DatoRX.toInt() < 4)) {
            ROM_Dati = DatoRX.toInt();
            if (DatoRX.toInt() < 3) EEPROM.update(EEPROMaddress[0], DatoRX.toInt());
          }
          break;


        case 11:
          // ---------------------------- Attiva / Disattiva protezione Alimentazione 5V - 12V
          if ((EN_OV != DatoRX.toInt()) and (DatoRX.toInt() < 3)) {
            EN_OV = DatoRX.toInt();
          }
          break;


        case 12:
          // ---------------------------- Attiva / Disattiva protezione limite luminosità LED
          if ((PowerLimitLED != DatoRX.toInt()) and (DatoRX.toInt() < 3)) {
            PowerLimitLED = DatoRX.toInt();
          }
          break;


        case 13:
          // ---------------------------- Configura i Dispositivi connessi
          if (DatoRX.toInt() > 0 and valLED != DatoRX.toInt()) {
            valLED = DatoRX.toInt();
          }
          break;


        case 14:

          break;
        case 15:

          break;
        case 16:

          break;
      }
  }
}
