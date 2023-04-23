bool LumLimit;

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
          // ---------------------------- Seleziona LED / Ventola
          if ((ModLED_Fan != DatoRX.toInt()) and (DatoRX.toInt() >= 0) and (DatoRX.toInt() <= 12)) {
            ModLED_Fan = DatoRX.toInt();
            if (ModLED_Fan < 5) ModFAN_SPEED = ModLED_Fan;
            if (ROM_Dati == true) EEPROM.write(EEPROMaddress[4], DatoRX.toInt());
          }
          break;


        case 2:
          // ---------------------------- Luminosità
          if ((LumLED[ModLED_Fan] != DatoRX.toInt()) and ((DatoRX.toInt() >= 0) and (DatoRX.toInt() <= 255))) {

            if ((DatoRX.toInt() < LumLED[ModLED_Fan]) and (PowerLimitLED == true or LumLED[ModLED_Fan] == 13)) {
              PowerLimitLED_Stato = false;
            }
            if (PowerLimitLED_Stato == false) LumLED[ModLED_Fan] = DatoRX.toInt();
            if (PowerLimitLED_Stato == true and DatoRX.toInt() < LumLED[ModLED_Fan]) LumLED[ModLED_Fan] = DatoRX.toInt();

            if (ROM_Dati == true and PowerLimitLED_Stato == false) EEPROM.put(20, LumLED);  //Memorizza il valore nella cella 10 della EEPROM
          }

          if ((ModLED_Fan == 0) and (ColoreLED[0] >= 512 and ColoreLED[0] <= 610) and (LumLED[0] == DatoRX.toInt() and PowerLimitLED_Stato == false)) {
            BRIGHTNESS = LumLED[0];
          }
          if ((ModLED_Fan == 0) and (ColoreLED[0] <= 512) and (PowerLimitLED_Stato == false)) {
            BRIGHTNESS = 255;
          }
          break;


        case 3:
          // ---------------------------- Colore
          if ((ColoreLED[ModLED_Fan] != DatoRX.toInt())) {
            PowerLimitLED_Stato = false;
            ColoreLED[ModLED_Fan] = DatoRX.toInt();
            if (ROM_Dati == true) EEPROM.put(50, ColoreLED);  //Memorizza il valore nella cella 25 della EEPROM
          }
          break;


        case 4:
          // ---------------------------- Saturazione Bianco / Nero
          if ((Saturazione[ModLED_Fan] != DatoRX.toInt()) and (DatoRX.toInt() >= 0) and (DatoRX.toInt() <= 255)) {
            Saturazione[ModLED_Fan] = DatoRX.toInt();
            if (ROM_Dati == true) EEPROM.put(80, Saturazione);  //Memorizza il valore nella cella 40 della EEPROM
          }
          break;


        case 5:
          // ---------------------------- Velocità Ventole
          if ((ModLED_Fan < 5) and (FanSpeed[ModLED_Fan] != DatoRX.toInt()) and (DatoRX.toInt() >= 0) and (DatoRX.toInt() <= 255) and (Fan_Mod_Speed[ModLED_Fan] == 0)) {
            FanSpeed[ModLED_Fan] = DatoRX.toInt();
            if (ROM_Dati == true) EEPROM.put(110, FanSpeed);  //Memorizza il valore nella cella 55 della EEPROM
          }
          break;


        case 6:
          // ---------------------------- Modalità Curva Ventole Manuale Auto
          if ((ModLED_Fan < 5) and (Fan_Mod_Speed[ModLED_Fan] != DatoRX.toInt()) and (DatoRX.toInt() >= 0) and (DatoRX.toInt() <= 255)) {
            //Fan_Mod_Speed[ModLED_Fan] = DatoRX.toInt();
            //if (ROM_Dati == true) EEPROM.put(140, Fan_Mod_Speed);  //Memorizza il valore nella cella 70 della EEPROM
          }
          break;


        case 7:
          // ---------------------------- Acquisizione Temperatura CPU dal PC
          if (TempCPU != DatoRX.toInt()) {
            TempCPU = DatoRX.toInt();
          }
          break;


        case 8:
          // ---------------------------- Acquisizione Temperatura GPU dal PC
          if (TempGPU != DatoRX.toInt()) {
            TempGPU = DatoRX.toInt();
          }
          break;


        case 9:
          if (Animation_RGBS[0] != DatoRX.toInt()) {
            Animation_RGBS[0] = DatoRX.toInt();
          }
          break;


        case 10:
          // ---------------------------- Attiva / Disattiva Memorizazzione dati utente
          if ((ROM_Dati != DatoRX.toInt()) and (DatoRX.toInt() < 3)) {
            ROM_Dati = DatoRX.toInt();
            EEPROM.write(EEPROMaddress[0], DatoRX.toInt());
          }
          break;


        case 11:
          // ---------------------------- Attiva / Disattiva protezione Alimentazione 5V - 12V
          if ((EN_OV != DatoRX.toInt()) and (DatoRX.toInt() < 3)) {
            EN_OV = DatoRX.toInt();
            if (ROM_Dati == true) EEPROM.write(EEPROMaddress[1], DatoRX.toInt());
          }
          break;


        case 12:
          // ---------------------------- Attiva / Disattiva protezione limite luminosità LED
          if ((PowerLimitLED != DatoRX.toInt()) and (DatoRX.toInt() < 3)) {
            PowerLimitLED = DatoRX.toInt();
            EEPROM.write(EEPROMaddress[2], DatoRX.toInt());
          }
          break;


        case 13:

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