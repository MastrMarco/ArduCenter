//*****************************************************************************************************************************//
//                                           Ver: X.04 Firmware data 10/05/23                                                  //
//*****************************************************************************************************************************//

byte H_P = 128;  // H_P = 65536 / 512 = 128


//Imposta la luminosità tra Mod_Colore e MOD_Animazione
void LumLED_Set() {
  if ((ColoreLED[ModLED_Fan] > 512) and (PowerLimitLED_Stato == false)) {
    BRIGHTNESS = LumLED[ModLED_Fan];
  } else if (RGB_Mod_Fan_All == 0) {
    BRIGHTNESS = 255;
  }
}

//Avvio loop dove ci sono tutte le modalità LED
void Void_LED_Mod() {
  //----------------------------------------------------------------------
  if (S_Pro_5V == true) {
    Strip1.fill(0, 0, 0);  //Modalità  OFF //LED_1
    Strip2.fill(0, 0, 0);  //Modalità  OFF //LED_2
    Strip3.fill(0, 0, 0);  //Modalità  OFF //LED_3
    Strip4.fill(0, 0, 0);  //Modalità  OFF //LED_4
    Strip5.fill(0, 0, 0);  //Modalità  OFF //LED_5
    Strip6.fill(0, 0, 0);  //Modalità  OFF //LED_6
    Strip7.fill(0, 0, 0);  //Modalità  OFF //LED_7
    Strip8.fill(0, 0, 0);  //Modalità  OFF //LED_8
    Strip9.fill(0, 0, 0);  //Modalità  OFF //LED_9
  }

  if (S_Pro_5V == false) {

    if ((ModLED_Fan == 0) or (ModLED_Fan == 0 and Boot_SetUp == 0)) {

      if ((((ColoreLED[0] > 512) and (BRIGHTNESS != LumLED[ModLED_Fan])) or ((ColoreLED[ModLED_Fan] <= 512) and (BRIGHTNESS != 255))) and (Boot_SetUp == false)) {
        LumLED_Set();
      }

      if ((ColoreLED[0] <= 512) and (BRIGHTNESS == 255)) {
        //Imposta la modalità dei LED
        //                          Colore,  Saturazione,  Intensità
        Strip1.fill(Strip1.ColorHSV((ColoreLED[0] * H_P), Saturazione[0], LumLED[0]));  //Modalità RGB HSV //LED_1
        Strip2.fill(Strip2.ColorHSV((ColoreLED[0] * H_P), Saturazione[0], LumLED[0]));  //Modalità RGB HSV //LED_2
        Strip3.fill(Strip3.ColorHSV((ColoreLED[0] * H_P), Saturazione[0], LumLED[0]));  //Modalità RGB HSV //LED_3
        Strip4.fill(Strip4.ColorHSV((ColoreLED[0] * H_P), Saturazione[0], LumLED[0]));  //Modalità RGB HSV //LED_4
        Strip5.fill(Strip5.ColorHSV((ColoreLED[0] * H_P), Saturazione[0], LumLED[0]));  //Modalità RGB HSV //LED_5
        Strip6.fill(Strip6.ColorHSV((ColoreLED[0] * H_P), Saturazione[0], LumLED[0]));  //Modalità RGB HSV //LED_6
        Strip7.fill(Strip7.ColorHSV((ColoreLED[0] * H_P), Saturazione[0], LumLED[0]));  //Modalità RGB HSV //LED_7
        Strip8.fill(Strip8.ColorHSV((ColoreLED[0] * H_P), Saturazione[0], LumLED[0]));  //Modalità RGB HSV //LED_8
        Strip9.fill(Strip9.ColorHSV((ColoreLED[0] * H_P), Saturazione[0], LumLED[0]));  //Modalità RGB HSV //LED_9
      }

      if (BRIGHTNESS == LumLED[0]) {
        switch (ColoreLED[0]) {
          case 600:
            RGB_Mod_Fan_All = 1;  //Modalità 1 = RGB Effetto Ciclo Discontinuo
            RGB_Discontinuo();
            break;
          case 601:
            RGB_Mod_Fan_All = 2;  //Modalità 2 = RGB Effetto Transizione*
            RGB_Transizione();
            break;
          case 602:
            RGB_Mod_Fan_All = 3;  //Modalità 3 = RGB Effetto RainBow*
            RGB_RainBow();
            break;
          case 603:
            RGB_Mod_Fan_All = 4;  //Modalità 4 = Effetto Music*
            RGB_Musica();
            break;
          case 604:
            RGB_Mod_Fan_All = 5;  //Modalità 4 = Effetto Temperatura*
            RGB_Temperatura();
            break;
        }
      }
    }

    if ((ModLED_Fan > 0) or (ColoreLED[ModLED_Fan] <= 512)) {
      RGB_Mod_Fan_All = 0;
    }

    if (((ModLED_Fan > 0) and (ColoreLED[ModLED_Fan] <= 512)) and (BRIGHTNESS == 255)) {
      //                                    Colore,      Saturazione,   Intensità
      Strip1.fill(Strip1.ColorHSV((ColoreLED[1] * H_P), Saturazione[1], LumLED[1]));  //Modalità RGB HSV //Fan1
      Strip2.fill(Strip2.ColorHSV((ColoreLED[2] * H_P), Saturazione[2], LumLED[2]));  //Modalità RGB HSV //Fan2
      Strip3.fill(Strip3.ColorHSV((ColoreLED[3] * H_P), Saturazione[3], LumLED[3]));  //Modalità RGB HSV //Fan3
      Strip4.fill(Strip4.ColorHSV((ColoreLED[4] * H_P), Saturazione[4], LumLED[4]));  //Modalità RGB HSV //Fan4
      Strip5.fill(Strip5.ColorHSV((ColoreLED[5] * H_P), Saturazione[5], LumLED[5]));  //Modalità RGB HSV //GPU
      Strip6.fill(Strip6.ColorHSV((ColoreLED[6] * H_P), Saturazione[6], LumLED[6]));  //Modalità RGB HSV //Striscia LED
      Strip7.fill(Strip7.ColorHSV((ColoreLED[7] * H_P), Saturazione[7], LumLED[7]));  //Modalità RGB HSV //FAN_OP_CPU
      Strip8.fill(Strip8.ColorHSV((ColoreLED[8] * H_P), Saturazione[8], LumLED[8]));  //Modalità RGB HSV //FAN_OP_CPU
      Strip9.fill(Strip9.ColorHSV((ColoreLED[9] * H_P), Saturazione[9], LumLED[9]));  //Modalità RGB HSV //FAN_OP_CPU
    }
  }
  /******************************--------------------------------------------***********************************************/
}