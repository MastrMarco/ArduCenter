//*****************************************************************************************************************************//
//                                           Ver: X.04 Firmware data 10/05/23                                                  //
//*****************************************************************************************************************************//

void Void_Fan_Mod() {
  //----------------------------Controllo Speed Fan-----------------------

  if (S_Pro_12V == true) {
    analogWrite(PWM_Fan_1, 0);
    analogWrite(PWM_Fan_2, 0);
    analogWrite(PWM_Fan_3, 0);
    analogWrite(PWM_Fan_4, 0);
  }

  if (S_Pro_12V == false) {

    if ((millis() < (StartFanPower + DelayFanPower)) and (ControlloFan == true)) {
      analogWrite(PWM_Fan_1, 255);
      analogWrite(PWM_Fan_2, 255);
      analogWrite(PWM_Fan_3, 255);
      analogWrite(PWM_Fan_4, 255);
    } else {



      if (ModLED_Fan == 0 and Fan_Mod_Speed[0] == 0) {
        analogWrite(PWM_Fan_1, FanSpeed[0]);
        analogWrite(PWM_Fan_2, FanSpeed[0]);
        analogWrite(PWM_Fan_3, FanSpeed[0]);
        analogWrite(PWM_Fan_4, FanSpeed[0]);
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