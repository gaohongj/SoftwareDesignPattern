namespace NvwaCreatePerson
{
    public class Nvwa
    {
        
        public static IPerson GetPerson(string type)
        {
            IPerson person = null;
            switch (type)
            {
                case "M":
                    person = new Man();
                    person.Person();
                    break;
                case "W":
                    person = new Waman();
                    person.Person();
                    break;
                case "R":
                    person = new Robot();
                    person.Person();
                    break;
            }
            return person;
        }
    }
}
