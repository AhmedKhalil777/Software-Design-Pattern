package com.company.template;

public interface IPublisher {
    public void subscribe(ISubscriber subscriber);
    public void unSubscribe(ISubscriber subscriber);
}
