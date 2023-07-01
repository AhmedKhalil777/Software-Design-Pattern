package com.company.template;

import java.util.ArrayList;

public class Content {
    public IPublisher source_;
    public ArrayList<Object> data_;

    public Content(IPublisher publisher, ArrayList<Object> data){
        source_= publisher;
        data_ = (ArrayList<Object>) data.clone() ;
    }

}

