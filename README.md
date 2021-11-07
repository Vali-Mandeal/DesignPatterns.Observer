# DesignPatterns.Observer
This is a demonstration from my DesignPattern series.

Observer is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.

In this app, we have a Microsoft Store which makes fictional sales for Microsoft Products every 4 seconds.
There is an Enum containing 7 Products (ex Surface Pro, Surface Laptop) in ./MicrosoftStore/Product.

We also have 4 Concrete Subscribers. Three of them looking for a sale for something specific (ex. SurfacePro) and one of them is interested in every change. 
Last example is just 4 fun (MicrosoftNerd) xD.

Subscribers can also join or leave the Subscription at runtime in any moment.
