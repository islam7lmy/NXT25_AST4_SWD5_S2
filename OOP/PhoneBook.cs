using System.Text;
namespace OOP
{
    struct PhoneBook
    {
        string[] numbers;
        string[] names;

        int count; //number of contacts in the phone book
        public int Count { get { return count; } }

        int size; //Capacity of the phone book
                  //[max number of elements can be saved in phonebook]

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                sb.Append($"{names[i]} : {numbers[i]}");
                sb.AppendLine();
            }
            return sb.ToString();
        }

        ///clr will generate a default constructor 
        ///that will initialize the attributes with their default values
        ///Constructor Chaining : 
        ///calling one constructor from another constructor in the same Struct or Class
        public PhoneBook() : this(0)
        {
            //size = 10; //0 for value types
            //numbers = new string[10]; //default; //null for reference types
            //names = new string[10]; //default; //null for reference types
        }

        public PhoneBook(int _Size)
        {
            size = _Size < 3 ? 3 : _Size;
            numbers = new string[size];
            names = new string[size];
        }

        public void AddContact(string name, string number/*, int _postion*/)
        {
            //if (_postion >= 0 && _postion < size)
            //{
            //    names[_postion] = name;
            //    numbers[_postion] = number;
            //}

            //int _postion = Array.IndexOf(names, null); //find the first empty position in names array
            //if (_postion >= 0)
            //{
            //    names[_postion] = name;
            //    numbers[_postion] = number;
            //}

            if (count == size) //phone book is full
                Resize(size + 1);

            names[count] = name;
            numbers[count] = number;
            count++;

        }

        public void RemoveContact(string _Name)
        {
            int index = Array.IndexOf(names, _Name);
            if (index >= 0)
            {
                for (int i = index; i < count - 1; i++)
                {
                    names[i] = names[i + 1];
                    numbers[i] = numbers[i + 1];
                }
                count--;
                Resize(size - 1);
            }
            else
            {
                Console.WriteLine("Contact not found");
            }
        }

        #region Get And Set By Name
        /// getter for number by name
        public string GetNumber(string _Name)
        {
            int index = Array.IndexOf(names, _Name);
            if (index >= 0)
            {
                return numbers[index];
            }
            else
            {
                return "Contact not found";
            }
        }

        /// setter for number by name
        public void SetNumber(string _Name, string _NewNumber)
        {
            int index = Array.IndexOf(names, _Name);
            if (index >= 0)
            {
                numbers[index] = _NewNumber;
            }
            else
            {
                Console.WriteLine("Contact not found");
            }
        }

        // indexer for number by name
        /// indexer is a special type of property 
        /// that allows you to access elements in a collection 
        /// using array-like syntax 
        public string this[string _Name]
        {
            get
            {
                int index = Array.IndexOf(names, _Name);
                if (index >= 0)
                {
                    return numbers[index];
                }
                else
                {
                    return "Contact not found";
                }
            }
            set
            {
                int index = Array.IndexOf(names, _Name);
                if (index >= 0)
                {
                    numbers[index] = value;
                }
                else
                {
                    Console.WriteLine("Contact not found");
                }
            }
        }
        #endregion

        #region Get And Set By Index
        public string GetContact(int index)
        {
            if (index >= 0 && index < size)
            {
                return $"{names[index]} : {numbers[index]}";
            }
            else
            {
                return $"index is out of range";
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < size)
                {
                    return $"{names[index]} : {numbers[index]}";
                }
                else
                {
                    return $"index is out of range";
                }
            }
        }
        #endregion

        void Resize(int newSize)
        {
            if (newSize > size)
            {
                string[] newnumbers = new string[newSize];
                string[] newnames = new string[newSize];

                numbers.CopyTo(newnumbers, 0);
                names.CopyTo(newnames, 0);

                numbers = newnumbers;
                names = newnames;

                size = newSize;
            }
            else if (newSize < size)
            {
                if (newSize >= 3 && newSize >= count)
                {
                    string[] newnumbers = new string[newSize];
                    string[] newnames = new string[newSize];

                    for (int i = 0; i < newSize; i++)
                    {
                        newnumbers[i] = numbers[i];
                        newnames[i] = names[i];
                    }

                    numbers = newnumbers;
                    names = newnames;

                    size = newSize;
                }
                else
                {
                    Console.WriteLine("Invalid new size for phone book");
                }

            }
        }
    }
}
