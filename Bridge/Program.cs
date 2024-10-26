using Bridge;

MessageSenderBase smsSender = new SmsSender();
CustomerManager customerManager = new() { MessageSenderBase = smsSender};
customerManager.UpdateCustomer();