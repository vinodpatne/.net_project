var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
}




var app = builder.Build();
{
    var name ="";
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();

}

