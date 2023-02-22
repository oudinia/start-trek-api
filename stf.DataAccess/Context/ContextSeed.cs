using Microsoft.EntityFrameworkCore;
using stf.Domain;

namespace stf.DataAccess.Context;

public static class ContextSeed
{

    public static void Seed(this ModelBuilder builder) => builder.SeedPlanets();
    private static void SeedPlanets(this ModelBuilder builder)
    {
        builder.Entity<Planet>().HasData(new[]{
            new Planet() { PlanetId = 100, Name = "Vulcan", Description = "A hot, arid planet with a harsh, rocky terrain. Home to the logical and stoic Vulcan species." },
            new Planet() { PlanetId = 200, Name = "Betazed", Description = "A beautiful planet covered in greenery and waterfalls. Home to the empathic Betazoid species." },
            new Planet() { PlanetId = 300, Name = "Qo'noS", Description = "A harsh, volcanic planet with a toxic atmosphere. Home to the warrior Klingon species." },
            new Planet() { PlanetId = 400, Name = "Bajor", Description = "A planet with a complex spiritual history and a strong connection to the Bajoran species' religion." },
            new Planet() { PlanetId = 500, Name = "Andoria", Description = "A frozen planet with icy terrain and harsh weather conditions. Home to the blue-skinned Andorian species." },
            new Planet() { PlanetId = 600, Name = "Risa", Description = "A tropical paradise planet known for its beaches, resorts, and hedonistic culture." },
            new Planet() { PlanetId = 700, Name = "Cardassia Prime", Description = "A planet with a militaristic society and a complicated political landscape. Home to the Cardassian species." },
            new Planet() { PlanetId = 800, Name = "Ferenginar", Description = "A planet known for its vast wealth and a culture centered around the accumulation of wealth. Home to the Ferengi species." },
            new Planet() { PlanetId = 900, Name = "Romulus", Description = "A planet with a secretive and militaristic society. Home to the Romulan species." },
            new Planet() { PlanetId = 1000, Name = "Tellar Prime", Description = "A planet with a highly-developed infrastructure and a strong focus on scientific exploration. Home to the Tellarite species." },
            new Planet() { PlanetId = 1100, Name = "Trill", Description = "A planet with a unique symbiotic species that coexists with humanoid hosts. Home to the Trill species." },
            new Planet() { PlanetId = 1200, Name = "Vorta Vor", Description = "A planet with a hierarchical and highly-structured society. Home to the genetically-engineered Vorta species." },
            new Planet() { PlanetId = 1300, Name = "Breen", Description = "A planet with an enigmatic and mysterious species. Little is known about the Breen and their home world." },
            new Planet() { PlanetId = 1400, Name = "Talax", Description = "A planet with a highly-developed and technologically-advanced society. Home to the Talaxian species." },
            new Planet() { PlanetId = 1500, Name = "Gornar", Description = "A planet with a warlike and territorial species. Home to the lizard-like Gorn species." }
        });
    }
}