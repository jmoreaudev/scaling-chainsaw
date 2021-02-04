using Sample.Data.Stores.Mock;

namespace Sample.Data.Stores
{
    // this class centralizes how the stores are made, which lets you 
    // change from mock stores to real ones in a single spot in code

    public static class StoreFactory
    {
        public static IStudentStore BuildStudentStore()
        {
            return new MockStudentStore();
        }
    }
}