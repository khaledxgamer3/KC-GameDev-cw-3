using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw_3 : MonoBehaviour
{
   
   string Hero_name = "Ben 10";
   int Hero_power = 70;

   string Villain_name = "Ghost_Freak";
   int Villain_power = 40;
   
   float playerspeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (Villain_power > Hero_power)
        {
            print(Villain_name + " is more powerful");
        }
        else if(Hero_power > Villain_power)
        {
            print(Hero_name+" is more powerful");
        }
        else
        {
            print("their power is equal");
        }

        setspeed();

    
    }
  
  
    void setspeed(float speed = (2.5f))
    {
        print(playerspeed);
       playerspeed = speed;
        print(playerspeed);
    }

    

}
