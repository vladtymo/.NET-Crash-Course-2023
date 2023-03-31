namespace Exam
{
    internal class Program
    {
        public interface IEditor
        {
            void Add();
             void Remove();
            void Edit();
        }

    
        public abstract class Service : IEditor
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public abstract void Add();
            public abstract void Remove();
            public abstract void Edit();
        }



        class Haircut : Service
        {
            public override void Add()
            {
                throw new NotImplementedException();
            }

            public override void Edit()
            {
                throw new NotImplementedException();
            }

            public override void Remove()
            {
                throw new NotImplementedException();
            }
        }
        class Dyeing : Service
        {
            public override void Add()
            {
                throw new NotImplementedException();
            }

            public override void Edit()
            {
                throw new NotImplementedException();
            }

            public override void Remove()
            {
                throw new NotImplementedException();
            }
        }
        class Manicure : Service
        {
            public override void Add()
            {
                throw new NotImplementedException();
            }

            public override void Edit()
            {
                throw new NotImplementedException();
            }

            public override void Remove()
            {
                throw new NotImplementedException();
            }
        }
        class Cosmetic_procedure : Service
        {
            public override void Add()
            {
                throw new NotImplementedException();
            }

            public override void Edit()
            {
                throw new NotImplementedException();
            }

            public override void Remove()
            {
                throw new NotImplementedException();
            }
        }


        public abstract class Person : IEditor
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }

            public abstract void Add();
            public abstract void Remove();
            public abstract void Edit();
        }

        class Client : Person
        {
            public override void Add()
            {
                throw new NotImplementedException();
            }

            public override void Edit()
            {
                throw new NotImplementedException();
            }

            public override void Remove()
            {
                throw new NotImplementedException();
            }
        }
        class Master : Person
        {
            public override void Add()
            {
                throw new NotImplementedException();
            }

            public override void Edit()
            {
                throw new NotImplementedException();
            }

            public override void Remove()
            {
                throw new NotImplementedException();
            }
        }

        public abstract class Product : IEditor
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public abstract void Add();
            public abstract void Remove();
            public abstract void Edit();
        }





        static void Main(string[] args)
        {
            
        }
    }
}