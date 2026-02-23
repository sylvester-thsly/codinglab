var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
// 1. THE DATA (Put the menu on the "Wall" so all waiters see it)
var menu =  new List<Coffee>

{
    new Coffee("Cappuccino", 5),
    new Coffee("latte", 4),
    new Coffee("Expresso", 2)
};


// 2. THE WAITERS
// Waiter 1: Just hands over the whole menu  
app.MapGet("/Coffee", () => menu); 

// 2. THE WAITERS
// Waiter 1: Just hands over the whole menu 
app.MapGet("/coffee/{name}", (string name) => menu.FirstOrDefault(c => c.Name.ToLower() == name.ToLower()));



    
app.Run(); 

record Coffee(string Name, int Price);
