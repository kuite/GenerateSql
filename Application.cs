    
    namespace GenerateSql
    {
        public class Application
        {
            public Application(string arg)
            {
                //sparsuj text z pliku arg (YouPlay context) do jakiegos obiektu
            }

            public string Run()
            {
                var response = "INSERT INTO TABELA VALUES (1, 'a', 99, true)";
                //tutaj zawracasz gotowy skrypt sql (odpalenie tego skryptu na bazie ma seedowac randomowe dane)

                return response;
            }
        }
    }
  