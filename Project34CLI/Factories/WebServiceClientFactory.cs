namespace Project34CLI.Factories
{
    public static class WebServiceClientFactory
    {
#if DEBUG
        public static Project34WebServiceDev.Project34WebServiceSoapClient CreateClient()
        {
            return new Project34WebServiceDev.Project34WebServiceSoapClient();
        }
#else
        public static Project34WebServiceProd.Project34WebServiceSoapClient CreateClient()
        {
            return new Project34WebServiceProd.Project34WebServiceSoapClient();
        }
#endif
    }
}
