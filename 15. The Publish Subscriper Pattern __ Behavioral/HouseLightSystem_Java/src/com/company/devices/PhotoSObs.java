package com.company.devices;

import java.util.Random;

public class PhotoSObs {
    public boolean isDayLight(){
       var isOpen =  new Random().nextInt() %2 == 0;
       System.out.print("\n the Day is " +  ((isOpen)? "Light" : "Dark"));
       return  isOpen;
    }
}
