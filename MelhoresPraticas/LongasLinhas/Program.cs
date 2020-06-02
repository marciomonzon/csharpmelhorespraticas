using System;

namespace LongasLinhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // não use longas linhas
        public int DoOperation()
        {
            BusinessManager businessManager = new BusinessManager();

            // ruim
            //return businessManager.ClientState.Value + businessManager.ClientState.Value + businessManager.ClientState.Value + businessManager.ClientState.Value;

            // melhor
            //return businessManager.clientState.Value1 
            //    + businessManager.clientState.Value2 
            //    + businessManager.clientState.Value1 
            //    + businessManager.clientState.Value2;

            // bem melhor
            ClientState cs = businessManager.clientState;
            return cs.Value1
                + cs.Value2
                + cs.Value1
                + cs.Value2;
        }

        class BusinessManager
        {
            public ClientState clientState { get; set; }
        }

        class ClientState
        {
            public int Value1 { get; set; }
            public int Value2 { get; set; }
        }
    }
}
