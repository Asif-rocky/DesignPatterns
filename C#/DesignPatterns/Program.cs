using DesignPatterns.src.OopPrinciples.Coupling;

Order orderWithEmail = new Order(new EmailSender());
orderWithEmail.PlaceOrder("Order #1234");

Order orderWithSms = new Order(new SmsSender());
orderWithSms.PlaceOrder("Order #5678");