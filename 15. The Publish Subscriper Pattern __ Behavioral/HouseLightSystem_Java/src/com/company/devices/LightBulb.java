package com.company.devices;

public class LightBulb {
    public int index_;
    public LightBulb(int index){
        index_= index;
    }
    public Boolean open_ = false;
    public void setLit(boolean open){
        open_= open;
        if (open){
            System.out.println("\n The Bulb "+ index_ + " is Opened");
            System.out.println("======================================== \n");

        }
    }
}
