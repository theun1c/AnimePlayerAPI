using AnimePlayerBack.Contracts;
using AnimePlayerBack.Data;
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

            app.MapPost("/anime", async (
                CreateAnimeRequest request,
                Supabase.Client client) =>
            {
                var anime = new AnimeModel
                {
                    Name = request.Name,
                    Episodes = request.Episodes,
                    Seasons = request.Seasons,
                };

                var response = await client.From<AnimeModel>().Insert(anime);
                var newAnime = response.Models.First();

                return Results.Ok(newAnime.Id);   
            });

            app.MapGet("/anime/{id}", async (Guid id, Supabase.Client client) =>
            {
                var response = await client
                .From<AnimeModel>()
                .Where(n => n.Id == id)
                .Get();

                var anime = response.Models.FirstOrDefault();
                if(anime == null)
                {
                    return Results.NotFound();
                }

                var animeResponse = new AnimeResponse
                {
                    Id = anime.Id,
                    Name = anime.Name,
                    Episodes = anime.Episodes,
                    Seasons = anime.Seasons,
                };

                return Results.Ok(animeResponse);    
            });

            app.MapDelete("/anime/{id}", async (Guid id, Supabase.Client client) =>
            {
                await client 
                .From<AnimeModel>()
                .Where (n => n.Id == id)
                .Delete(); 

                return Results.NoContent();
            });

            app.UseHttpsRedirection();

            app.Run();
        }
    }
}
