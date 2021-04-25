package com.company.devices;

import java.util.HashMap;
import java.util.Map;

public class KeyStorage {
    public static Map<String,String> storage_ =new HashMap();
    public static  void UpdateStorage(){
        storage_.put("Ahmed", "123");
        storage_.put("Mohammad", "456");
    }


}
