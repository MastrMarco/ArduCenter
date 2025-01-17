//*****************************************************************************************************************************//
//                                           Ver: X.08 Firmware data 01/06/24                                                  //
//*****************************************************************************************************************************//

void Void_Fan_Mod() {
  //--------------------------Controllo Speed RPM Fan----------------------
  //A Fan1
  if (!PinA_pre && PinA) {
    Count_RPM_1++;
    PinA_pre = PinA;
  }
  if (PinA_pre && !PinA) {
    PinA_pre = PinA;
  }
  //B Fan2
  if (!PinB_pre && PinB) {
    Count_RPM_2++;
    PinB_pre = PinB;
  }
  if (PinB_pre && !PinB) {
    PinB_pre = PinB;
  }
  //C Fan3
  if (!PinC_pre && PinC) {
    Count_RPM_3++;
    PinC_pre = PinC;
  }
  if (PinC_pre && !PinC) {
    PinC_pre = PinC;
  }
  //D Fan4
  if (!PinD_pre && PinD) {
    Count_RPM_4++;
    PinD_pre = PinD;
  }
  if (PinD_pre && !PinD) {
    PinD_pre = PinD;
  }
  //--
  if (millis() >= (ResetTimerVirtuale[11] + DelayVirtuale[11])) {
    ResetTimerVirtuale[11] = millis();
    RPM_Fan1 = Count_RPM_1;  // * 60;
    Count_RPM_1 = 0;
    RPM_Fan2 = Count_RPM_2;  // * 60;
    Count_RPM_2 = 0;
    RPM_Fan3 = Count_RPM_3;  // * 60;
    Count_RPM_3 = 0;
    RPM_Fan4 = Count_RPM_4;  // * 60;
    Count_RPM_4 = 0;
  }
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