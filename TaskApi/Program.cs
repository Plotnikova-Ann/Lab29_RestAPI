var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors (options => {
options.AddPolicy("AllowAll", policy => {
policy.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader();
});
});
if (app. Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
app.UseHttpsRedirection();
app.UseCors("AllowAll");
app. UseAuthorization();
