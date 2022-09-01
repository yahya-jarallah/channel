using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_CHANNEL

{
     class TV_CHANNEL
    {
    public static void employeeinfo()
        {
           
            char b;
            
            employee e1 = new employee();
            string name;
            int Id;
            int phone;
            long salary;
            Console.WriteLine("\n\n\n\t\t\t\t**************************************************\n\t\t\t\t");
            Console.Write("\t\t\t\t\t  Enter employee name : ");
            name = Console.ReadLine();
            e1.Name = name;
            Console.Write("\t\t\t\t\t  Enter employee id : ");
            Id = int.Parse(Console.ReadLine());
            e1.Id = Id;
            Console.Write(" \t\t\t\t\t  Enter employee phone number: ");
            phone = int.Parse(Console.ReadLine());
            e1.Ph_number = phone;
            Console.Write("\t\t\t\t\t  Enter the salary of the employee : ");
            salary = long.Parse(Console.ReadLine());
            e1.Salary = salary;
            employee[] employee = { e1 };
            for (int i = 0; i < employee.Length; i++)
                employee[i].print_data();
            Console.WriteLine("\n\n\n\t\t\t\t********************************************************\n\t\t\t\t");
            Console.WriteLine("\n\t\t\t\tEnter letter b to exit the program or any letter to continue " + " : ");
            b = char.Parse(Console.ReadLine());
            if (b == 'b')
                return;

        }

       public static void advertisersinfo()
        {
            char b;
            advertisers adv1 = new advertisers();
            string name;
            int employee_number = 0;
            int phone = 0;
            string company_name;
            string product;
            double amount;
            Console.WriteLine("\n\n\n\t\t\t\t**************************************************\n\t\t\t\t");
            Console.Write("\t\t\t\t\t Enter the name of the advertisers : ");
            name = Console.ReadLine();
            adv1.Name = name;
            Console.Write("\t\t\t\t\t Enter the advertisers Id number : ");
            employee_number = int.Parse(Console.ReadLine());
            adv1.Id = employee_number;
            Console.Write("\t\t\t\t\t Enter advertisers phone number :");
            phone = int.Parse(Console.ReadLine());
            adv1.Ph_number = phone;
            Console.Write("\t\t\t\t\t Enter advertisers company name : ");
            company_name = Console.ReadLine();
            adv1.company_name = company_name;
            Console.Write("\t\t\t\t\t Enter the of product to advertise about : ");
            product = Console.ReadLine();
            adv1.product = product;
            Console.Write("\t\t\t\t\t Enter the amount of the advertisments : ");
            amount = double.Parse(Console.ReadLine());
            adv1.amount = amount;
            advertisers[] advertisers = { adv1 };
            for (int i = 0; i < advertisers.Length; i++)
                advertisers[i].print_data();
            Console.WriteLine("\n\t\t\t\t Enter letter b to exit the program or any letter to continue " + " : ");
            b = char.Parse(Console.ReadLine());
            if (b == 'b')
                return;


        }
      public static  void programinfo()
        {
           

            char b;


            program pro1 = new program();
            string prog_name;
            string type;
            int time;
            float duration;
            int number;
            Console.WriteLine("\n\n\n\t\t\t\t**************************************************\n\t\t\t\t");
            Console.Write("\t\t\t\t\t Enter the name of the program : ");
            prog_name = Console.ReadLine();
            pro1.prog_name = prog_name;
            Console.Write("\t\t\t\t\t Enter the type of program : ");
            type = Console.ReadLine();
            pro1.Type = type;
            Console.Write("\t\t\t\t\t Enter the time of program : ");
            time = int.Parse(Console.ReadLine());
            pro1.prog_time = time;
            Console.Write("Enter the duration of program : ");
            duration = float.Parse(Console.ReadLine());
            pro1 = new program();
            pro1.prog_duration = duration;
            Console.Write("\t\t\t\t\t Enter the number of program : ");
            number = int.Parse(Console.ReadLine());
            program[] program = { pro1 };
            for (int i = 0; i < program.Length; i++)
                program[i].print_program_data();
            Console.WriteLine("\n\t\t\t\t Enter letter b to exit the program or any letter to continue " + " : ");
            b = char.Parse(Console.ReadLine());
            if (b == 'b')
                return;


        }

      public static  void advertismentsinfo()
        {
           

            char b;
            advertisments ad1 = new advertisments();
            string prog_name;
            string company_name;
            int time;
            float duration;
            int number;
            int repetiton;
            float price;
            Console.WriteLine("\n\n\n\t\t\t\t**************************************************\n\t\t\t\t");
            Console.Write("\t\t\t\t\t Enter the name of the program : ");
            prog_name = Console.ReadLine();
            ad1.prog_name = prog_name;
            Console.Write("\t\t\t\t\t Enter the name of the company : ");
            company_name = Console.ReadLine();
            ad1.Company_name = company_name;
            Console.Write("\t\t\t\t\t Enter the time of the advertisments : ");
            time = int.Parse(Console.ReadLine());
            ad1.prog_time = time;
            Console.Write("\t\t\t\t\t Enter the duration of the advertisments : ");
            duration = float.Parse(Console.ReadLine());
            ad1.prog_duration = duration;
            Console.Write("\t\t\t\t\t Enter the number of the advertisments : ");
            number = int.Parse(Console.ReadLine());
            Console.Write("\t\t\t\t\t Enter the conut of repetition : ");
            repetiton = int.Parse(Console.ReadLine());
            ad1.Repetition = repetiton;
            Console.Write("\t\t\t\t\t Enter the price of the advertisments : ");
            price = float.Parse(Console.ReadLine());
            ad1.Price = price;
            advertisments[] advertisments = { ad1 };
            for (int i = 0; i < advertisments.Length; i++)
                advertisments[i].print_program_data();
            Console.WriteLine("\n\t\t\t\t Enter letter b to exit the program or any letter to continue " + " : ");
            b = char.Parse(Console.ReadLine());
            if (b == 'b')
                return;

        }

        static void Main(string[] args)

           { 
          
                int choice;
                Console.Clear();
                do
                {

                    Console.WriteLine("\n\n\n\n\t\t\t\t\t\t\t TV CHANNAL\n\n\t\t\t\t");
                    Console.WriteLine("\t\t\t\t\t***********************************************\n\n\n\t\t\t\t");
                    Console.WriteLine("\t\t\t\t\t    1.press 1 to go to employee record.\n\n\t\t\t\t");
                    Console.WriteLine("\t\t\t\t\t    2.press 2 to go to advertisers record.\n\n\t\t\t\t");
                    Console.WriteLine("\t\t\t\t\t    3.press 3 to go to advertisment record.\n\n\t\t\t\t");
                    Console.WriteLine("\t\t\t\t\t    4.press 4 to go to program record.\n\n\t\t\t\t");
                    Console.WriteLine("\t\t\t\t\t    5.press -1  to exit the program.\n\n\t\t\t\t");
                    Console.WriteLine("\t\t\t\t\t ***********************************************\n\n\t\t\t\t");
                    Console.Write(" \t\t\n\t\t\t\t\t\t\tyour choice : ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                    Console.Clear();
                                    TV_CHANNEL.employeeinfo();
                              
                               
                            }
                            break;
                        case 2:
                            {
                                Console.Clear();
                                TV_CHANNEL. advertisersinfo();
                            }
                            break;
                        case 3:
                            {
                                Console.Clear();
                                TV_CHANNEL.programinfo();
                            }
                            break;

                        case 4:
                            { 
                                Console.Clear();
                                TV_CHANNEL. advertismentsinfo();
                            }
                            break;
                        case -1:
                            {
                                return;
                                
                            }
                            
                        default:
                            break;
                    }
                } while (choice != 0);
            

          

        }

    }

    }








