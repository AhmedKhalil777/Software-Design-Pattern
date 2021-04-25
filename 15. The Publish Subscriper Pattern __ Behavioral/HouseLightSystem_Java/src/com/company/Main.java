package com.company;

import com.company.devices.*;

public class Main {

    public static void main(String[] args) {
	// write your code here

        // Configurations
        KeyStorage.UpdateStorage();
        var checker = new  Checker();
        var sensor = new PhotoSObs();
        var bulb1 =  new LightBulb(1);
        var bulb2 =  new LightBulb(2);

        var device1 =  new DeviceCtrl(checker, sensor, bulb1);
        var device2 =  new DeviceCtrl(checker, sensor, bulb2);

        checker.checkKey("Ahmed", "123");
        checker.checkKey("Ahmed", "123");
        checker.checkKey("Ahmed", "123");
        checker.checkKey("Ahmed", "123");
        checker.checkKey("Ahmed", "123");

        


    }
}
