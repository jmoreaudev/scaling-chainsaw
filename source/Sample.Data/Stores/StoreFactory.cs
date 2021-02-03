using Sample.Data.Stores.Mock;

namespace Sample.Data.Stores
{
    public static class StoreFactory
    {
        public static IStudentStore BuildStudentStore()
        {
            return new MockStudentStore();
        }
    }
}