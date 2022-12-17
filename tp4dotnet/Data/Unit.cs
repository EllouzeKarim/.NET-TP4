namespace tp4dotnet.Data
{
    public class Unit : IUnit
    {
        private readonly UniversityContext _Context;
        public IRepositoryStudent student { get; private set; }

        public Unit()
        {
            this._Context = UniversityContext.Instantiate_UniversityContext();
            student = new StudentRepository();
        }
        public bool complete()
        {

            try
            {
                int result = _Context.SaveChanges();
                if (result > 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}