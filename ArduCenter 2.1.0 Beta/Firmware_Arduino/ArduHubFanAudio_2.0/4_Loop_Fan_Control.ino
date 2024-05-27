//*****************************************************************************************************************************//
//                                           Ver: X.08 Firmware data 01/06/24                                                  //
//*****************************************************************************************************************************//

void Void_Fan_Mod() {
  //----------------------------Controllo Speed Fan-----------------------

  if (S_Pro_12V == true) {
    SetAllVentola(0);
  } else {

    if ((millis() < (StartFanPower + DelayFanPower)) and (ControlloFan == true)) {
      SetAllVentola(255);
    } else {

      if (ModLED_Fan == 0 and Fan_Mod_Speed[0] == 0) {
        SetAllVentola(FanSpeed[0]);
      }


      if (ModLED_Fan > 0) {  //and (StatoFan_Mod_All == 1)
        if (Fan_Mod_Speed[1] == 0) {
          analogWrite(PWM_Fan_1, FanSpeed[1]);
        }
        if (Fan_Mod_Speed[2] == 0) {
          analogWrite(PWM_Fan_2, FanSpeed[2]);
        }
        if (Fan_Mod_Speed[3] == 0) {
          analogWrite(PWM_Fan_3, FanSpeed[3]);
        }
        if (Fan_Mod_Speed[4] == 0) {
          analogWrite(PWM_Fan_4, FanSpeed[4]);
        }
      }
    }
  }
}


void SetAllVentola(byte PWM) {
  analogWrite(PWM_Fan_1, PWM);
  analogWrite(PWM_Fan_2, PWM);
  analogWrite(PWM_Fan_3, PWM);
  analogWrite(PWM_Fan_4, PWM);
}