using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_CHANNEL
{
     class advertisers : person
    {
        string _company_name;
        string _product;
        double _amount;
       public advertisers()
        {
            _company_name = company_name;
            _product = product;
            _amount = amount;
        }
        public string company_name
        {
            get { return this. _company_name; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    this._company_name = "NO NAME";
                else
                this. _company_name = value; }
        }
        public string product
        {
            get { return this. _product; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    this._product = "NO NAME";
                else
                _product = value; }
        }
        public double amount
        {
            get { return this._amount; }
            set
            {
                double amo;
                do
                {
                    amo = double.Parse(Console.ReadLine());
                    if (amo >= 100000)
                        this._amount = amo;
                    else
                        Console.WriteLine(" \n\n\t\t\t\t\t invalid entry! enter the corect amount ( not less than 100000 ) :");
                } while (amo < 100000);
            }
        }
            public  override void print_data()
        {
            Console.WriteLine("\t\t\t\t\t***********************************************\n\n\n\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t person name is : " + Name);
            Console.WriteLine("\t\t\t\t\t person number is : " + Id);
            Console.WriteLine("\t\t\t\t\t person phone number is : " + Ph_number);
            Console.WriteLine("\t\t\t\t\t company_name is : " + company_name);
            Console.WriteLine("\t\t\t\t\t company_product is : " + product);
            Console.WriteLine("\t\t\t\t\t company_amount is : " + amount);
            Console.WriteLine("\t\t\t\t\t***********************************************\n\n\n\t\t\t\t");
        }
        }
    }

