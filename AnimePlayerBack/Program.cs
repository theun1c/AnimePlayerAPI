using AnimePlayerBack.Contracts;
using AnimePlayerBack.Models;
using Microsoft.EntityFrameworkCore;
using Supabase;

namespace AnimePlayerBack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // connecting to a supabase 
            builder.Services.AddScoped<Supabase.Client>(_ =>
            new Supabase.Client(
                builder.Configuration["Supabase:Url"],
                builder.Configuration["Supabase:Key"],
                new SupabaseOptions
                {
                    AutoRefreshToken = true,
                    AutoConnectRealtime = true,
                }));
            
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
                


            app.UseHttpsRedirection();

            app.Run();
        }
    }
}
