using CervezasColombia_CS_API_PostgreSQL_Dapper.DbContexts;


var builder = WebApplication.CreateBuilder(args);

//Aqui agregamos los servicios requeridos

//El DBContext a utilizar
builder.Services.AddSingleton<PgsqlDbContext>();

//Los repositorios

app.Run();