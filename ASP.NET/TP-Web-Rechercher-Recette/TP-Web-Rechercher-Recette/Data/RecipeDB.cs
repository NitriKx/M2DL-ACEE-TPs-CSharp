using System;

namespace Data
{
    public class RecipeDB : IDisposable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}