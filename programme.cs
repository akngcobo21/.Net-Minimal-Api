
var builder=WebApplication.CreateBuilder(args);
var app=builder.Build();

var items=new List<Item>
{
    new Item(
        Id:1,
        Name:"item1",
        Price:10.0
    ),
};

app.MapGet("/items/{id:int}", (int id) =>
{
  var item=items.FirstOrDefault(i=>i.Id==id);
  return item is null ? Results.NotFound() : Results.Ok(item);
});


app.Run();
record Item(int Id,string Name,double Price);