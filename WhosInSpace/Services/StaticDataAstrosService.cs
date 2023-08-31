using WhosInSpace.Models;

namespace WhosInSpace.Services
{
    public class StaticDataAstrosService : IAstrosService
    {
        public Task<AstrosData?> GetAstrosAsync()
        {
            return Task.FromResult<AstrosData?>(new AstrosData
            {
                Message = "success",
                Number = 4,
                People = new List<Astronaut>
                {
                    new Astronaut { Craft = "Red Dwarf", Name = "Dave Lister" },
                    new Astronaut { Craft = "Red Dwarf", Name = "Arnold Rimmer" },
                    new Astronaut { Craft = "Red Dwarf", Name = "Kryten" },
                    new Astronaut { Craft = "Red Dwarf", Name = "Cat" }
                }
            });
        }
    }
}
