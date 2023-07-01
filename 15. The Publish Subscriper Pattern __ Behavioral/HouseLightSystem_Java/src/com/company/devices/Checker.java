package com.company.devices;

import com.company.template.Content;
import com.company.template.IPublisher;
import com.company.template.ISubscriber;

import java.security.Key;
import java.security.KeyStore;
import java.util.ArrayList;
import java.util.Iterator;

public class Checker implements IPublisher {

    public String name_;
    public ArrayList subscribers_ = new ArrayList();

    public Checker()
    {
    }

    @Override
    public void subscribe(ISubscriber subscriber) {
        subscribers_.add(subscriber);
    }

    @Override
    public void unSubscribe(ISubscriber subscriber) {
        int id = subscribers_.indexOf(subscriber);
        if(id != -1) { subscribers_.remove(id); }
    }

    public void checkKey(String user_name,String user_password){
        boolean isValid =  false;
        if (KeyStorage.storage_.containsKey(user_name) && KeyStorage.storage_.get(user_name) == user_password ){
            isValid = true;
        }
        Content cnt = new Content(this , new ArrayList());
        if (isValid){
            cnt.data_.add("Valid");
        }
        else{
            cnt.data_.add("Invalid");
        }
        for (Iterator e = subscribers_.iterator(); e.hasNext();){
            ((ISubscriber)e.next()).receive(cnt);
        }
    }
}
