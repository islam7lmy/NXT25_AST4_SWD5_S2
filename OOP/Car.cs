namespace OOP
{
    class Car
    {
        /// Attributes or Fields
        //public int Id;
        //public string Model;
        //public int Speed;

        #region Full property [not recomended if no logic will do in get or set]
        //private int id;
        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        //private string model;
        //public string Model
        //{
        //    get { return model; }
        //    set { model = value; }
        //}

        //private int speed;

        //public int Speed
        //{
        //    get { return speed; }
        //    set { speed = value; }
        //}
        #endregion

        ///automatic property [recomended if no logic will do in get or set]
        public int Id { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        ///clr will alwyas create a default constructor 
        ///if no user defined constructor exist
        ///public Car(){ } //=>Do Nothing 

        ///user defined constructor
        ///clr will no longer create a default constructor 
        ///if any user defined constructor exist
        public Car(int id , string model , int speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
            Console.Write("ctor 04");
        }

        public Car(int id, string model) : this (id, model, 200)
        {
            //Id = id;
            //Model = model;
            //Speed = 200;
            Console.Write("ctor 03");
        }

        public Car(int id) : this(id, "BMW")
        {
            //Id = id;
            //Model = "BMW";
            //Speed = 200;
            Console.Write("ctor 02");
        }

        /// constrructor chaning 
        public Car() : this(10)
        {
            //Id = 10;
            //Model = "BMW";
            //Speed = 200;
            Console.Write("ctor 01");
        }
    }
}
