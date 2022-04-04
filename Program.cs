// See https://aka.ms/new-console-template for more information
using BuilderDesignPattern;

Console.WriteLine("Hello, World!");
Director  directory = new Director ();
Builder builder1 = new ConcreteBuilder1();
Builder builder2 = new ConcreteBuilder2();  



directory.Build (builder1); 
Products p1 = builder1.GetProducts();
p1.show();




directory.Build (builder2); 
Products p2 = builder2.GetProducts();
p2.show();


// Wait for user
Console.ReadKey();

