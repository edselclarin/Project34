namespace Project34CLI.Factories
{
    public static class WebServiceModelFactory
    {
#if DEBUG
        public static Project34WebServiceDev.User CreateUser()
        {
            return new Project34WebServiceDev.User();
        }
#else
        public static Project34WebServiceProd.User CreateUser()
        {
            return new Project34WebServiceProd.User();
        }
#endif
    }
}
